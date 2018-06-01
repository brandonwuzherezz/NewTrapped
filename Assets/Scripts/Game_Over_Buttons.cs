using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over_Buttons : MonoBehaviour
{

    public static string PreviousScene;
    public static bool ResetGame = false;

    public void Restart_Level()
    {
        ResetGame = true;
        SceneManager.LoadScene(PreviousScene);
    }


    public void Quit_Game()
    {

        Application.Quit();


    }



}
