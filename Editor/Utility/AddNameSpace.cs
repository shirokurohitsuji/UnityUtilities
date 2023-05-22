using UnityEditor;

namespace Editor.Utility
{
    public class AddNameSpace : AssetModificationProcessor
    {
        private const string AssetsDir = "Assets";
        private const string CsExtension = ".cs";
        private const string MetaExtension = ".meta";
        private const string NameSpacePlaceHolder = "#NAMESPACE#";
        private const char Slash = '/';
        private const char SlashWin = '\\';
        private const char Dot = '.';

        public static void OnWillCreateAsset(string path)
        {
            if (!path.Contains(MetaExtension)) return;
            var filePath = path.Replace(MetaExtension, string.Empty);
            if (System.IO.Path.GetExtension(filePath) != CsExtension) return;

            var directoryPath = System.IO.Path.GetDirectoryName(filePath)?.Replace(SlashWin, Slash);
            var nameSpacePath = directoryPath?[(AssetsDir.Length + 1)..];
            var nameSpace = nameSpacePath?.Replace(Slash, Dot);

            var content = System.IO.File.ReadAllText(filePath);
            var replaced = content.Replace(NameSpacePlaceHolder, nameSpace);

            System.IO.File.WriteAllText(filePath, replaced);
            AssetDatabase.Refresh();
        }
    }
}
