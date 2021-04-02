using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CardObject))]
[CanEditMultipleObjects]
[ExecuteInEditMode]
public class ActionLevelEditor : Editor
{
    SerializedProperty actionLevel;
    
    void OnEnable()
    {
        actionLevel = serializedObject.FindProperty("actionLevel");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(actionLevel);
        serializedObject.ApplyModifiedProperties();
    }
}
