using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DeathCounter))]
public class DeathCounterInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DeathCounter deathCounter = (DeathCounter) target;
        if(GUILayout.Button("Reset")){
            deathCounter.Reset();
        }
    }

}
