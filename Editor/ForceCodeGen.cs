using UnityCodeGen;
using UnityEditor.Callbacks;

public class ForceCodeGen
{
    [DidReloadScripts]
    public static void ForceCodeGenerate()
    {
        UnityCodeGenUtility.Generate();
    }
}