using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;

namespace Editor.Utility
{
    [InitializeOnLoad]
    public class DefineSymbols
    {
        private const string ManifestJsonPath = "Packages/manifest.json";

        private static readonly Dictionary<string, string> Map = new()
        {
            { "com.unity.nuget.newtonsoft-json", "PACKAGE_NEWTONSOFT_JSON" },
            { "com.neuecc.unirx", "PACKAGE_NEUECC_UNIRX" },
        };

        static DefineSymbols()
        {
            var defines = GetDefineNames();
            foreach (var def in defines) AddLibraryDefineIfNeeded(def);
        }

        private static void AddLibraryDefineIfNeeded(string define)
        {
            var buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
            var defines = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
            if (defines.Contains(define)) return;

            PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, defines + ";" + define);
        }

        private static IEnumerable<string> GetDefineNames()
        {
            var manifest = File.ReadAllText(ManifestJsonPath);
            return Map
                .Where(x => manifest.Contains(x.Key))
                .Select(x => x.Value)
                .ToList();
        }
    }
}
