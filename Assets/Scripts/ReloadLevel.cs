using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadLevel : MonoBehaviour {

    // Use this for initialization
    
    void Awake () {
        GameObject[] LocalBatteries;
        GameObject[] LocalShadows;
        GameObject[] LocalKeys;
        List<string> ShadowsNames = new List<string>(); 
        List<string> BatteryNames = new List<string>();
        List<string> keyNames = new List<string>(); ;
        LocalBatteries = GameObject.FindGameObjectsWithTag("Battery");
        LocalShadows = GameObject.FindGameObjectsWithTag("Shadow");
        LocalKeys = GameObject.FindGameObjectsWithTag("Key");
        
        foreach (GameObject bat in LocalBatteries)
        {
            BatteryNames.Add(bat.name);
            
        }

        foreach (GameObject Shad in LocalShadows)
        {
            ShadowsNames.Add(Shad.name);

        }
        foreach (GameObject K in LocalKeys)
        {
            keyNames.Add(K.name);

        }
        if (Game_Over_Buttons.ResetGame == true)
        {
            foreach (string kys in keyNames)
            {
                if (Key.DeleteKeys.Contains(kys))
                {
                    if(kys == "DHkey")
                    {
                        EnterBarricadeDH.dhKey = false;
                    }
                    Key.DeleteKeys.Remove(kys);
                    KeyManager.isImgOn = false;
                    print("here");
                }
            }
            foreach (string battery in BatteryNames)
            {
                if (Battery.DeletedBatteries.Contains(battery)){
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
            Game_Over_Buttons.ResetGame = false;
        }
	}

}
