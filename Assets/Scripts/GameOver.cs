using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Flashlight.creation = false;
            Flashlight.totalBatteries = 0;
            Battery.isDestroyed = false;
            Battery.DeletedBatteries.Clear();
            Timer.Deletedimages.Clear();
            LoadLevel.ShedDoor = false;
            ActivateFlashlight.hasFlashlight = false;
            ActivateFlashlight.isFlashlightDestroyed = false;
            BatteryManager.battery = 0;
           SceneManager.LoadScene("1Courtyard");
        }
    }
}
