using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
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

    public static bool Bedroom1 = false;
    public static bool Bedroom2 = false;
    public static bool Bathroom = false;
    public static bool MasterBedroom = false;
    public static bool MasterBathroom = false;
    public static bool MasterCloset = false;
    public static bool Library = false;
    public static bool Vault = false;

    void Start()
    {
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
        if (Pantry == true)
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

        //Connections from Manuel's levels

/*
        if (Hallway1 == true)
        {
            if(sceneName == "Bedroom1")
            {
                SpawnOutsideHallway1();
            }
        }

*/

        if (Bedroom1 == true)
        {
            if (sceneName == "Bathroom")
            {
                SpawnOutsideBedroom1A();
            }

            /*if (sceneName == "Hallway1")
            {
                SpawnOutsideBedroom1B();
            }*/
        }
        if (Bedroom2 == true)
        {
            if (sceneName == "Bathroom") 
            {
                SpawnOutsideBedroom2();
            }
        }
        if (Bathroom == true)
        {
            if (sceneName == "Bedroom1")
            {
                SpawnOutsideBathroomA();
            }
            if (sceneName == "Bedroom2")
            {
                SpawnOutsideBathroomB();
            }

        }
        if (MasterBedroom == true)
        {
            if (sceneName == "MasterBathroom")
            {
                SpawnOutsideMasterBedroomA();
            }
            if (sceneName == "MasterCloset")
            {
                SpawnOutsideMasterBedroomB();
            }
            /*if (sceneName == "Hallway2")
            {
                SpawnOutsideMasterBedroomC();
            }*/
            if (sceneName == "Library")
            {
                SpawnOutsideMasterBedroomD();
            }
            if (sceneName == "Vault")
            {
                SpawnOutsideMasterBedroomE();
            }
        }
        if (MasterBathroom == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideMasterBathroom();
            }
        }
        if (MasterCloset == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideMasterCloset();
            }
        }
        if (Library == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideLibrary();
            }
        }
        if (Vault == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideVault();
            }
        }

    /*    if (Hallway2 == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideHallway2();
            }
        }

    */

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
    {//spawn in Hallway from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.07f, -0.1842351f, -23.96999f);
        BallHall = false;
    }
    void SpawnOutsideBallroomB()
    {//spawn in Ballroom from Ball
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-10.21f, -0.09485483f, 12.76002f);
        BallroomB = false;
    }
    void SpawnOutsideKitchenB()
    {//spawn in Ballroom from Kitchen
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-13.81001f, -0.1842351f, -7.590008f);
        KitchenB = false;
    }

/*

    void SpawnOutsideHallway1()
    {//Spawn in Bedroom1 from Hallway1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-19.4f, -0.081f, -10.04f);
        Hallway1 = false;
    }

*/

    void SpawnOutsideBedroom1A()
    {//Spawn in Bathroom from Bedroom1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(8.57f, -2.95f, -2.57f);
        Bedroom1 = false;
    }
/* 
    
    void SpawnOutsideBedroom1B()
    {//Spawn in Hallway1 from Bedroom1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3();
        Bedroom1 = false;
    }

*/

    void SpawnOutsideBedroom2()
    {//Spawn in Bathroom from Bedroom2
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(19.89f, -2.994f, 23.97f);
        Bedroom2 = false;
    }

    void SpawnOutsideBathroomA()
    {//Spawn in Bedroom 1 from Bathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-28.113f, -0.081f, -8.977f);
        Bathroom = false;
    }

    void SpawnOutsideBathroomB()
    {//Spawn in Bedroom2 from Bathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(20.03f, -0.09f, 10.42f);
        Bathroom = false;
    }

    void SpawnOutsideMasterBedroomA()
    {//Spawn in MasterBathroom from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(8.667f, -2.992f, 33.78f);
        MasterBedroom = false;
    }

    void SpawnOutsideMasterBedroomB()
    {//Spawn in MasterCloset from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(18.296f, 11.39f, 27.14f);
        MasterBedroom = false;
    }

 /* 
   
    void SpawnOutsideMasterBedroomC()
    {//Spawn in Hallway2 from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3();
        MasterBedroom = false;
    }

*/

    void SpawnOutsideMasterBedroomD()
    {//Spawn in Library from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(48.79f, -0.071f, -42.92f);
        MasterBedroom = false;
    }

    void SpawnOutsideMasterBedroomE()
    {//Spawn in Vault from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(25.04f, -0.089f, 9.62f);
        MasterBedroom = false;
    }

    void SpawnOutsideMasterBathroom()
    {//Spawn in MasterBedroom from MasterBathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-33.02f, 0.909f, -49.088f);
        MasterBathroom = false;
    }

    void SpawnOutsideMasterCloset()
    {//Spawn in MasterBedroom from MasterCloset
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(35.99f, 0.909f, -49.088f);
        MasterCloset = false;
    }

    void SpawnOutsideLibrary()
    {//Spawn in MasterBedroom from Library
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(40.321f, 0.909f, 5.3f);
        Library = false;
    }

    void SpawnOutsideVault()
    {//Spawn in MasterBedroom from Vault
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-40.28f, 0.909f, -38.59f);
        Vault = false;
    }

/*
    void SpawnOutsideHallway2()
    {//Spawn in MasterBedroom from Hallway
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(35.77f, 0.909f, 26.999f);
        Hallway2 = false;
    }
*/

}
