using UnityEditor;
using UnityEngine;

namespace Editor.Actions
{
    public class EditorScreenCapture : UnityEditor.Editor
    {
        [MenuItem("Edit/ScreenCapture")]
        private static void CaptureScreenshot()
        {
            var path = EditorUtility.SaveFilePanel("Save Screenshot",
                $"{Application.dataPath}/../Documents/ScreenShots",
                System.DateTime.Now.ToString("yyyyMMdd-HHmmss"), "png");
            if (string.IsNullOrEmpty(path)) return;

            ScreenCapture.CaptureScreenshot(path);
            var assembly = typeof(EditorWindow).Assembly;
            var type = assembly.GetType("UnityEditor.GameView");
            var window = EditorWindow.GetWindow(type);
            window.Repaint();
            Debug.Log("ScreenCapture: " + path);
        }
    }
}
