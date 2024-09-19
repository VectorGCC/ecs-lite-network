using System.Text;
using SevenBoldPencil.EasyEvents;
using UnityCodeGen;
using UnityEditor;

[Generator]
public class NetworkSyncViewsVarsGenerator : ICodeGenerator
{
    public void Execute(GeneratorContext context)
    {
        var sb = new StringBuilder();

        sb.AppendLine("// <auto-generated/>");
        sb.AppendLine("using Mirror;");
        sb.AppendLine("public abstract partial class EntityView : EntityViewBase");
        sb.AppendLine("{");

        var types = TypeCache.GetTypesWithAttribute<NetworkSyncAttribute>();
        foreach (var type in types)
        {
            sb.AppendLine($"[SyncVar(hook = nameof({type.Name}Hook))] public {type.FullName} {type.Name};");

            // Apply state hook
            sb.AppendLine($"public void {type.Name}Hook({type.FullName} oldComponent, {type.FullName} newComponent)");
            sb.AppendLine("{");
            sb.AppendLine("ApplyState();");
            sb.AppendLine("}");
        }

        // Read method
        sb.AppendLine("protected override T Read<T>() where T : struct");
        sb.AppendLine("{");

        for (var i = 0; i < types.Count; i++)
        {
            var type = types[i];
            sb.AppendLine($" if ({type.Name} is T component{i})");
            sb.AppendLine($"return component{i};");
        }

        sb.AppendLine($"return default;");
        sb.AppendLine("}");

        // Update method
        sb.AppendLine("private void Update()");
        sb.AppendLine("{");
        sb.AppendLine("if (!NetworkServer.active)");
        sb.AppendLine("return;");
        sb.AppendLine("if (_entity.Version != _lastVersion)");
        sb.AppendLine("{");
        sb.AppendLine("_lastVersion = _entity.Version;");

        foreach (var type in types)
        {
            sb.AppendLine($"{type.Name} = _entity.Read<{type.FullName}>();");
        }

        sb.AppendLine("}");

        sb.AppendLine("}");

        sb.AppendLine("}");

        context.OverrideFolderPath(LeoEcsNetworkCodeGen.GetCodeGenPath());
        context.AddCode("EntityView.SyncVarComponents.Generated.cs", sb.ToString());
    }
}