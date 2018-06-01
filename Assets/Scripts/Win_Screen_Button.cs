using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win_Screen_Button: MonoBehaviour
{
    public void Load_Level ()
    {
        Flashlight.creation = false;
        Flashlight.totalBatteries = 0;
        Battery.DeletedBatteries.Clear();
        Shadows.DeletedShadows.Clear();
        Timer.Deletedimages.Clear();
        LoadLevel.ShedDoor = false;
        LoadLevel.FoyerCloset = false;
        LoadLevel.DiningRoom = false;
        LoadLevel.HallWay = false;
        LoadLevel.Pantry = false;
        LoadLevel.RestroomA = false;
        LoadLevel.Kitchen = false;
        LoadLevel.Ballroom = false;
        LoadLevel.BallHall = false;
        LoadLevel.BallroomB = false;
        LoadLevel.KitchenB = false;
        //Manuel
        LoadLevel.Bedroom1A = false;
        LoadLevel.Bedroom1B = false;
        LoadLevel.Bedroom2 = false;
        LoadLevel.BathroomA = false;
        LoadLevel.BathroomB = false;
        LoadLevel.MasterBedroomA = false;
        LoadLevel.MasterBedroomB = false;
        LoadLevel.MasterBedroomC = false;
        LoadLevel.MasterBedroomD = false;
        LoadLevel.MasterBedroomE = false;
        LoadLevel.MasterBathroom = false;
        LoadLevel.MasterCloset = false;
        LoadLevel.Library = false;
        LoadLevel.Vault = false;
        //Jay
        LoadLevel.BallroomC = false;
        LoadLevel.BallroomD = false;
        LoadLevel.BSH = false;
        LoadLevel.Patio = false;
        LoadLevel.SFH = false;
        LoadLevel.BSHB = false;
        LoadLevel.SFHB = false;
        LoadLevel.SFHC = false;
        ActivateFlashlight.hasFlashlight = false;
        ActivateFlashlight.isFlashlightDestroyed = false;
        BatteryManager.battery = 0;
        SceneManager.LoadScene("1AIntro");
    }


}