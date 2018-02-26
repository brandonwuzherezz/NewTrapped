using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width - 125, 10, 100, 100));
        if (GUILayout.Button("Restart"))
        {
           
            SceneManager.LoadScene("LevelTest");
        }
        GUILayout.EndArea();
    }    
}