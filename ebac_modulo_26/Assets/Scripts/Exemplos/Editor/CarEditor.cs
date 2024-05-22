using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;
        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);
        myTarget.speed = EditorGUILayout.IntField("My Speed", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("My Gear", myTarget.gear);

        EditorGUILayout.LabelField("Total Speed", myTarget.TotalSpeed.ToString());

        EditorGUILayout.HelpBox("Calculate Total Speed", MessageType.Info);

        if (myTarget.TotalSpeed >= 200 || myTarget.TotalSpeed <= 0)
        {
            EditorGUILayout.HelpBox("Invalid Speed", MessageType.Error);
        }

        GUI.color = Color.yellow;

        if (GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }
    }
}
