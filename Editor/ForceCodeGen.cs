using UnityCodeGen;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEditor.Callbacks;

public class ForceCodeGen
{
    [DidReloadScripts]
    public static void ForceCodeGenerate()
    {
        UnityCodeGenUtility.Generate();
    }
}