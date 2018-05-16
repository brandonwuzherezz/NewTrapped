using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour
{
    string currentScene;
    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}