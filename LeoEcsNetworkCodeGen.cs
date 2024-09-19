using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "LeoECS/NetworkCodeGen")]
public class LeoEcsNetworkCodeGen : ScriptableObject
{
    public string UnityCodeGenPath;

    public static string GetCodeGenPath()
    {
        var asset = AssetDatabase.FindAssets("t: LeoEcsNetworkCodeGen").FirstOrDefault();
        if (string.IsNullOrEmpty(asset))
            return string.Empty;
        var path = AssetDatabase.GUIDToAssetPath(asset);
        var codeGen = AssetDatabase.LoadAssetAtPath<LeoEcsNetworkCodeGen>(path);
        return codeGen.UnityCodeGenPath;
    }
}