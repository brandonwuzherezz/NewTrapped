using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {
	public static bool ShedDoor = false;
    public static bool FoyerCloset = false;
    public static bool DiningRoom = false;
    public static bool HallWay = false;
    public static bool Pantry = false;
    public static bool RestroomA = false;
    public static bool Kitchen = false;
    public static bool Ballroom = false;
    public static bool BallHall = false;
    public static bool BallroomB = false;
    public static bool KitchenB = false;
    public static bool BallroomC = false;
    public static bool BallroomD = false;
    public static bool SFH = false;
    public static bool Patio = false;

    void Start() {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (ShedDoor == true)
        {
            SpawnShed();
        }
        if (FoyerCloset == true)
        {
            SpawnOutSideCloset();
        }
        if (DiningRoom == true)
        {
            if (sceneName == "3Foyer")
            {
                SpawnOutsideDH();
            }
        }
        if (HallWay == true)
        {
            if (sceneName == "5Dining Room")
            {
                SpawnOutsideHall1();
            }
        }
        if(Pantry == true)
        {
            if (sceneName == "6HallWay1")
            {
                SpawnOutsidePantry();
            }
           
        }
        if (RestroomA == true)
        {
            if (sceneName == "6HallWay1")
            {
                SpawnOutsideRestroomA();
            }
        }
        if (Kitchen == true)
        {
            if (sceneName == "6HallWay1")
            {
                SpawnOutsideKitchen();
            }
        }
        if (Ballroom == true)
        {
            if (sceneName == "Kitchen")
            {
                SpawnOutsideBallroom();
            }
        }
        if (BallHall == true)
        {
            if (sceneName == "Ballroom")
            {
                SpawnOutsideBallHall();
            }
        }
        if (BallroomB == true)
        {
            if (sceneName == "Ballroom_hallway")
            {
                SpawnOutsideBallroomB();
            }
        }
        if (KitchenB == true)
        {
            if (sceneName == "Ballroom")
            {
                SpawnOutsideKitchenB();
            }
        }
    }

    void SpawnShed()
    {//spawn in courtyard
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.920011f, -0.04718876f, -0.5662009f);
         ShedDoor = false;
	}
    void SpawnOutSideCloset()
    {//spawn in foyer from closet
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.5112f, -0.2557331f, -18.14018f);
        FoyerCloset = false;
    }
    void SpawnOutsideDH()
    {//spawn in foyer from DH
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.03327464f, -0.2557331f, -7.017335f);
        DiningRoom = false;
    }
    void SpawnOutsideHall1()
    {//spawn in DH from Hallway
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-50.05046f, -0.1651622f, 12.76999f);
        HallWay = false;
    }
    void SpawnOutsidePantry()
    {//spawn in Hallway from Pantry
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.7269199f, -0.1306694f, 4.180002f);
        Pantry = false;
    }
    void SpawnOutsideRestroomA()
    {//spawn in Hallway from Restroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.7812766f, -0.1306694f, -2.124695f);
        RestroomA = false;
    }
    void SpawnOutsideKitchen()
    {//spawn in Hallway from Kitchen
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-0.3930801f, -0.1306694f, 9.920001f);
        Kitchen = false;
    }
    void SpawnOutsideBallroom()
    {//spawn in Kitchen from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(13.29302f, -0.09485483f, 3.660009f);
        Ballroom = false;
    }
    void SpawnOutsideBallHall()
    {//spawn in Ballroom from BallHall
		GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.07f, -0.1842351f, -23.96999f);
        BallHall = false;
    }
    void SpawnOutsideBallroomB()
    {//spawn in BallHall from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-10.21f, -0.09485483f, 12.76002f);
        BallroomB = false;
    }
    void SpawnOutsideKitchenB()
    {//spawn in Ballroom from Kitchen
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-14.44f, -0.095f, -7.79f);
        KitchenB = false;
    }
    void SpawnOutsideBallroomC()
    {//spawn in Second Floor Hallway from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-10.21f, -0.09485483f, 12.76002f);
        BallroomC = false;
    }
    void SpawnOutsideBallroomD()
    {//spawn in Patio from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-10.21f, -0.09485483f, 12.76002f);
        BallroomD = false;
    }
}
//-13.81001f, -0.1842351f, -7.590008f
