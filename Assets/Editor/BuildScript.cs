using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void BuildIOS()
    {
        string outputPath = "build/iOS";

        BuildPlayerOptions opts = new BuildPlayerOptions
        {
            scenes = GetScenes(),
            locationPathName = outputPath,
            target = BuildTarget.iOS,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(opts);
    }

    static string[] GetScenes()
    {
        var scenes = new System.Collections.Generic.List<string>();
        foreach (var scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
                scenes.Add(scene.path);
        }
        return scenes.ToArray();
    }
}
