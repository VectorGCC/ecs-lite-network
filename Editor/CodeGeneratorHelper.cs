using System;
using System.IO;
using System.Linq;
using UnityEditor;

public static class CodeGeneratorHelper
{
    public static string GetCodeGenFolderPath(Type generatorScript)
    {
        var script = AssetDatabase.FindAssets($"t: Script {generatorScript.Name}");
        var scriptPath = AssetDatabase.GUIDToAssetPath(script.First());
        var directory = Path.GetDirectoryName(scriptPath);

        var parent = Directory.GetParent(directory);
        var rootPath = parent.FullName;

        var path = Path.Combine(rootPath, "Generated");
        return path;
    }
}