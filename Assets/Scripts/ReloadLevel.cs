using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] LocalBatteries;
        GameObject[] LocalShadows;
        List<string> ShadowsNames = new List<string>(); ;
        List<string> BatteryNames = new List<string>(); ;
        LocalBatteries = GameObject.FindGameObjectsWithTag("Battery");
        LocalShadows = GameObject.FindGameObjectsWithTag("Shadow");
        
		foreach(GameObject bat in LocalBatteries)
        {
            BatteryNames.Add(bat.name);
            
        }

        foreach (GameObject Shad in LocalShadows)
        {
            ShadowsNames.Add(Shad.name);

        }

        if (GameOver.ResetGame == true)
        {
     
            foreach (string battery in BatteryNames)
            {
				if(Battery.DeletedBatteries.Contains(battery)){
					Battery.DeletedBatteries.Remove(battery);
               	    BatteryManager.battery -= 1;
                }
			}
           
            foreach (string Shadow in ShadowsNames)
            {
				if(Shadows.DeletedShadows.Contains(Shadow)){
				    Shadows.DeletedShadows.Remove(Shadow);
				}
            }
            Flashlight.batteryLife = 150;
            GameOver.ResetGame = false;
        }
	}

}
