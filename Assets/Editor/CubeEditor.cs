using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.AnimatedValues;

[CanEditMultipleObjects]
[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    
    Cube cube;
    public void OnEnable()
    {
        cube = target as Cube;
    }


    /*
     * CH1. GUILayoutOption

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        cube.value = EditorGUILayout.IntField("��", cube.value, GUILayout.Width(300), GUILayout.Height(30), GUILayout.ExpandWidth(true));
    }
    */

    /*
     * CH2. Button
    enum ObjectEnum
    {
        boat_moss, box, lantern
    };
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();
        
        if (GUILayout.Button(Resources.Load<Texture2D>("obstacle_river_lantern"), GUILayout.Width(100), GUILayout.Height(100)))
        {
            Debug.Log("��ֹ� ��ư ����");
        }

        if (GUILayout.RepeatButton("���� ��ư")) // Ŭ���� ���·� ���콺�� �����̸� ����
        {
            Debug.Log("���� ��ư ����");
        }

        if (EditorGUILayout.DropdownButton(new GUIContent("��Ӵٿ� ��ư 1"), FocusType.Keyboard))
        {
            Debug.Log("��Ӵٿ� ��ư ����");
        }

        var enumValues = Enum.GetValues(typeof(ObjectEnum));
        GenericMenu menu = new GenericMenu();
        int themeLength = enumValues.Length;
        for (int i = 0; i < themeLength; i++)
        {
            menu.AddItem(new GUIContent($"{enumValues.GetValue(i)}"), false, handleItemClicked, enumValues.GetValue(i));
        }
        
        if (EditorGUILayout.DropdownButton(new GUIContent("Add New..."), FocusType.Keyboard))
        {
            menu.ShowAsContext();
        }
        EditorGUI.EndChangeCheck();
        
    }

    void handleItemClicked(object parmaeter)
    {
        Debug.Log(parmaeter);
    }
    */

    /*
     * Ch3_1. Toggle(single) 
    bool toggle;
    Cube cube;

    public override void OnInspectorGUI()
    {
        toggle = cube.toggleValue;
        toggle = GUILayout.Toggle(toggle, "���");
        toggle = EditorGUILayout.ToggleLeft("���", toggle);
        toggle = EditorGUILayout.Toggle("���", toggle);
        cube.toggleValue = toggle;
    }
    */

    /*
     * CH3_2. Toggle Group
    bool posGroupEnabled = true;
    bool[] pos = new bool[]{true,true,true};
    string[] toggleLabels = new string[] { "x", "y", "z" };

    public override void OnInspectorGUI()
    {
        posGroupEnabled = EditorGUILayout.BeginToggleGroup("Align position", posGroupEnabled);
        for (int i = 0; i < 3; i++)
        {
            pos[i] = EditorGUILayout.Toggle(toggleLabels[i], pos[i]);
        }
        EditorGUILayout.EndToggleGroup();
    }
    */

    /*
     * CH4.LabelField
    int intField;
    public override void OnInspectorGUI()
    {
        //EditorGUILayout.LabelField("�Ϲ� ��");
        //EditorGUILayout.SelectableLabel("���� ���� ��");

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("�� ��");
        intField = EditorGUILayout.IntField(intField);
        intField = EditorGUILayout.IntField(intField);
        EditorGUILayout.EndHorizontal();
    }
    */


    /* CH_5. Text  
    // CH5_1. TextField
    public override void OnInspectorGUI()
    {
        cube.text = GUILayout.TextField(cube.text);
        cube.text = EditorGUILayout.TextField("�ؽ�Ʈ", cube.text);
        cube.text = EditorGUILayout.PasswordField("��й�ȣ", cube.text);
        cube.text = EditorGUILayout.DelayedTextField("������ �ؽ�Ʈ", cube.text);
    }
    
    // CH5_2. TextArea
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        cube.text = GUILayout.TextArea(cube.text, GUILayout.Height(50));
        cube.text = EditorGUILayout.TextArea(cube.text);
    }
    */

    /*
     * CH6. Slider
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        cube.floatValue = GUILayout.HorizontalSlider(cube.floatValue, 0f, 10f, GUILayout.Height(20));
        cube.floatValue = GUILayout.VerticalSlider(cube.floatValue, 10f, 0f, GUILayout.Height(100));

        cube.floatValue = EditorGUILayout.Slider("Slider", cube.floatValue, 0f, 10f);
    }
    */

    /*
     * CH7. Scrollbar
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        cube.floatValue = GUILayout.HorizontalScrollbar(cube.floatValue, 2f, 0f, 10f);
        cube.floatValue = GUILayout.VerticalScrollbar(cube.floatValue, 2f, 10f, 0f);
    }
    */

    /*
     * CH8. ScrollView
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        cube.scroll = EditorGUILayout.BeginScrollView(cube.scroll, GUILayout.Width(500), GUILayout.Height(150));
        GUILayout.Button("��ư 1", GUILayout.Width(850), GUILayout.Height(100));
        GUILayout.Button("��ư 2", GUILayout.Height(100));
        EditorGUILayout.EndScrollView();
    }
    */


    /*
     * CH9. SerializedProperty
    SerializedProperty tr;

    private void OnEnable()
    {
        tr = serializedObject.FindProperty("tr");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.PropertyField(tr, new GUIContent("Transform"));
        serializedObject.ApplyModifiedProperties();
    }

    */

    /*
     * CH11. Begin/End Horizontal
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.BeginHorizontal("box");
        GUILayout.Button("��ư 1", GUILayout.Width(150), GUILayout.Height(100));
        //GUILayout.Space(20);
        //GUILayout.FlexibleSpace();
        EditorGUILayout.Separator();
        GUILayout.Button("��ư 2", GUILayout.Width(150), GUILayout.Height(100));
        GUILayout.EndHorizontal();
    }
    */

    /*
     * CH12. Begin/End Vertical
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.BeginVertical("box");
        GUILayout.Button("��ư 1", GUILayout.Width(150), GUILayout.Height(100));
        GUILayout.Button("��ư 2", GUILayout.Height(100));
        GUILayout.EndVertical();
    }
    */

    /*
     * CH13. Begin/End FadeGroup
    AnimBool showFade;

    private void OnEnable()
    {
        showFade = new AnimBool(false);
        showFade.valueChanged.AddListener(Repaint);
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        showFade.target = EditorGUILayout.ToggleLeft("Fade", showFade.target);
        if (EditorGUILayout.BeginFadeGroup(showFade.faded))
        {
            EditorGUI.indentLevel++; //�ڽ�ó�� ��!
            EditorGUILayout.LabelField("Color");
            EditorGUILayout.LabelField("Text");
            EditorGUILayout.LabelField("Number");
            EditorGUI.indentLevel--;
        }

        EditorGUILayout.EndFadeGroup();

    }
    */

    /*
     * CH14. Begin/End FoldoutHeaderGroup
    bool showPosition = false;

    public override void OnInspectorGUI()
    {
        showPosition = EditorGUILayout.BeginFoldoutHeaderGroup(showPosition, "Fold");

        if (showPosition)
        {
            for (int i = 0; i < Selection.transforms.Length; i++)
            {
                Selection.transforms[i].position
                    = EditorGUILayout.Vector3Field("Position", Selection.transforms[i].position);
            }
        }

        EditorGUILayout.EndFoldoutHeaderGroup();
    }
    */

    /* CH15. GUILayout.SelectionGrid
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Button(Resources.Load<Texture2D>("obstacle_river_lantern"), GUILayout.Width(30), GUILayout.Height(30));

        EditorGUI.BeginChangeCheck();
        cube.selGridInt = GUILayout.SelectionGrid(cube.selGridInt, cube.selTextures, 2, GUILayout.Width(200), GUILayout.Height(200));
        if (EditorGUI.EndChangeCheck()) Debug.Log("���� ������");

        GUILayout.Button(Resources.Load<Texture2D>("obstacle_river_oak"), GUILayout.Width(30), GUILayout.Height(30));
    }
    */

    /*
     * CH16. BuildTargetGroup
    public override void OnInspectorGUI()
    {
        BuildTargetGroup selectionBuildTargetGroup = EditorGUILayout.BeginBuildTargetSelectionGrouping();

        if (selectionBuildTargetGroup == BuildTargetGroup.Android)
        {
            EditorGUILayout.LabelField("�ȵ���̵� ����");
        }

        if (selectionBuildTargetGroup == BuildTargetGroup.Standalone)
        {
            EditorGUILayout.LabelField("PC ����");
        }

        EditorGUILayout.EndBuildTargetSelectionGrouping();
    }
    */

    /*
     * CH17. ToolBar
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();
        cube.selIndex = GUILayout.Toolbar(cube.selIndex, new string[] { "0", "1" });
        if (EditorGUI.EndChangeCheck()) GUI.FocusControl(null);

        switch (cube.selIndex)
        {
            case 0: cube.text0 = EditorGUILayout.TextField("0", cube.text0); break;
            case 1: cube.text1 = EditorGUILayout.TextField("1", cube.text1); break;
        }
    }
    */

    /* CH18. Popup
    public override void OnInspectorGUI()
    {
        cube.currCharacter = (Cube.Character)EditorGUILayout.EnumPopup(cube.currCharacter);

        switch (cube.currCharacter)
        {
            case Cube.Character.Dog:
                cube.text0 = EditorGUILayout.TextField(cube.text0);
                break;
            case Cube.Character.Hamster:
                cube.text1 = EditorGUILayout.TextField(cube.text1);
                break;
            case Cube.Character.Cat:
                cube.text2 = EditorGUILayout.TextField(cube.text2);
                break;
        }
    }
    */

    /*
     * CH19. Play/Stop Button
    public override void OnInspectorGUI()
    {
        string label = EditorApplication.isPlaying ? "��" : "��";
        if (GUILayout.Button(label))
        {
            EditorApplication.ExecuteMenuItem("Edit/Play");
        }
    }
    */

    /*
     * CH20. background color
    public override void OnInspectorGUI()
    {
        GUILayout.Button("���");

        GUI.backgroundColor = Color.yellow;
        GUILayout.Button("���");
        GUILayout.Button("���");
        GUILayout.Button("���");
        GUILayout.Button("���");
        
        GUI.backgroundColor = Color.white;
        GUILayout.Button("���");
    }
    */

    /*
     * CH21. Cell state ����
    Cube cube;
    void OnEnable()
    {
        cube = target as Cube;
        if (cube.Cell[0] == null)
        {
            //for (int i = 0; i < cube.Cell.Length; i++) cube.Cell[i] = Resources.Load<Texture2D>("Resources/unity_builtin_extra/UISprite");
        }
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        int index = 0;
        for (int i = 0; i < cube.size; i++)
        {
            GUILayout.BeginHorizontal();
            for (int j = 0; j < cube.size; j++)
            {
                if (GUILayout.Button(cube.Cell[index], GUILayout.Width(50), GUILayout.Height(50)))
                {
                    if (cube.Cell[index] == cube.CellState[0])
                        cube.Cell[index] = cube.CellState[1];
                    else if (cube.Cell[index] == cube.CellState[1])
                        cube.Cell[index] = cube.CellState[0];
                }
                index++;
            }
            GUILayout.EndHorizontal();
        }
    }
    */

    /*
     * CH22. Text Asset ����
    string text;
    TextAsset txtAsset;
    Vector2 scroll;

    public override void OnInspectorGUI()
    {
        txtAsset = (TextAsset)EditorGUILayout.ObjectField(txtAsset, typeof(TextAsset), true);

        if (txtAsset != null)
        {
            text = txtAsset.text;

            scroll = EditorGUILayout.BeginScrollView(scroll);
            text = EditorGUILayout.TextArea(text, GUILayout.Height(600));
            EditorGUILayout.EndScrollView();
        }
    }
    */

    /*
     * CH23. Animation Curve ����
    public override void OnInspectorGUI()
    {
        cube.curveX = EditorGUILayout.CurveField("Animation on X", cube.curveX);
        cube.SetCurves(cube.curveX);
    }
    */
}
