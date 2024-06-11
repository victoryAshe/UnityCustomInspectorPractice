using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CubeWindow : EditorWindow
{
    [MenuItem("Examples/MyWindow")]
    static void Init()
    {
        CubeWindow window = GetWindow<CubeWindow>(typeof(Cube));
        window.Show();
    }

    /*
     * CH10. Area & GUI Style
    public void OnGUI()
    {
        //GUILayout.BeginArea(new Rect(10, 10, 100, 100));
        GUILayout.BeginArea(new Rect(10, 10, 100, 100), new GUIStyle("Box"));
        GUILayout.Button("버튼 1");
        GUILayout.Button("버튼 2");
        GUILayout.EndArea();
    }
    */

}
