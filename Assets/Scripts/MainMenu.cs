using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public bool isStart;
    public bool isQuit;
    AudioSource audioSource;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnMouseUp()
    {
        audioSource.Play();
        if (isStart)
        {
            SceneManager.LoadScene("1Courtyard");
        }

        if (isQuit)
        {
            Application.Quit();
        }
    }
}
