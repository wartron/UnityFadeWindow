using UnityEngine;
using UnityEditor;
using System.Collections;

public class FadeWindow : EditorWindow
{

    float fadeVal = 0.5f;

    string tintPrefKey = "Playmode tint";

    [MenuItem("Fade Window/Fade Slider")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(FadeWindow));
    }

    void OnGUI()
    {
        fadeVal = EditorGUILayout.Slider("Fade Amount", fadeVal, 0, 1);

        //Debug.Log(EditorPrefs.GetString(tintPrefKey));

        string oldTint = EditorPrefs.GetString(tintPrefKey);
        string newTint = string.Format("Playmode tint;{0};{0};{0};1", fadeVal);

        Debug.Log("old: " + oldTint);
        Debug.Log("new: " + newTint);

        EditorPrefs.SetString(tintPrefKey, newTint);

    }
}
