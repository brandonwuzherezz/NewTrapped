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

    public static bool Bedroom1A = false;
    public static bool Bedroom1B = false;
    public static bool Bedroom2 = false;
    public static bool BathroomA = false;
    public static bool BathroomB = false;
    public static bool MasterBedroomA = false;
    public static bool MasterBedroomB = false;
    public static bool MasterBedroomC = false;
    public static bool MasterBedroomD = false;
    public static bool MasterBedroomE = false;
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

        if (Bedroom1A == true)
        {
            if (sceneName == "Bathroom")
            {
                SpawnOutsideBedroom1A();
            }
        }

/*        if(Bedroom1B == true)
        {
            if (sceneName == "Hallway1")
            {
                SpawnOutsideBedroom1B();
            }
        }
*/
        if (Bedroom2 == true)
        {
            if (sceneName == "Bathroom") 
            {
                SpawnOutsideBedroom2();
            }
        }
        if (BathroomA == true)
        {
            if (sceneName == "Bedroom1")
            {
                SpawnOutsideBathroomA();
            }
        }

        if (BathroomB == true)
        {
            if (sceneName == "Bedroom2")
            {
                SpawnOutsideBathroomB();
            }
        }

        if (MasterBedroomA == true)
        {
            if (sceneName == "MasterBathroom")
            {
                SpawnOutsideMasterBedroomA();
            }
        }

        if (MasterBedroomB == true)
        {
            if (sceneName == "MasterCloset")
            {
                SpawnOutsideMasterBedroomB();
            }
        }

        /*        if (MasterBedroomC == true)
                {
                    if (sceneName == "Hallway2")
                    {
                        SpawnOutsideMasterBedroomC();
                    }
                }
                */
        if (MasterBedroomD == true)
        {
            if (sceneName == "Library")
            {
                SpawnOutsideMasterBedroomD();
            }
        }

        if(MasterBedroomE == true)
        {
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
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-19.76f, -0.1651627f, -9.26f);
            Hallway1 = false;
        }

    */

    void SpawnOutsideBedroom1A()
    {//Spawn in Bathroom from Bedroom1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.17f, -0.1651627f, 19.39999f);
        Bedroom1A = false;
    }
/* 
    
    void SpawnOutsideBedroom1B()
    {//Spawn in Hallway1 from Bedroom1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3();
        Bedroom1B = false;
    }

*/

    void SpawnOutsideBedroom2()
    {//Spawn in Bathroom from Bedroom2
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.83f, -0.1651627f, 22.5f);
        Bedroom2 = false;
    }

    void SpawnOutsideBathroomA()
    {//Spawn in Bedroom 1 from Bathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-29.14f, -0.1651627f, -8.4f);
        BathroomA = false;
    }

    void SpawnOutsideBathroomB()
    {//Spawn in Bedroom2 from Bathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-2.99f, -0.1651627f, 17.32f);
        BathroomB = false;
    }

    void SpawnOutsideMasterBedroomA()
    {//Spawn in MasterBathroom from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.46f, -0.1651627f, 11.68f);
        MasterBedroomA = false;
    }

    void SpawnOutsideMasterBedroomB()
    {//Spawn in MasterCloset from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.46f, -0.1651627f, 16.48f);
        MasterBedroomB = false;
    }

 /* 
   
    void SpawnOutsideMasterBedroomC()
    {//Spawn in Hallway2 from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3();
        MasterBedroomC = false;
    }

*/

    void SpawnOutsideMasterBedroomD()
    {//Spawn in Library from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-45.37f, -0.1651627f, 12f);
        MasterBedroomD = false;
    }

    void SpawnOutsideMasterBedroomE()
    {//Spawn in Vault from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.07f, -0.1651627f, 25.96f);
        MasterBedroomE = false;
    }

    void SpawnOutsideMasterBathroom()
    {//Spawn in MasterBedroom from MasterBathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(38.26f, -0.1651627f, -13.89f);
        MasterBathroom = false;
    }

    void SpawnOutsideMasterCloset()
    {//Spawn in MasterBedroom from MasterCloset
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(38.26f, -0.1651627f, 19.65f);
        MasterCloset = false;
    }

    void SpawnOutsideLibrary()
    {//Spawn in MasterBedroom from Library
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(11.67f, -0.1651627f, 29.86f);
        Library = false;
    }

    void SpawnOutsideVault()
    {//Spawn in MasterBedroom from Vault
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(31.86f, -0.1651627f, -28.36f);
        Vault = false;
    }

    /*
        void SpawnOutsideHallway2()
        {//Spawn in MasterBedroom from Hallway
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.07f, -0.1651627f, 25.96f);
            Hallway2 = false;
        }
    */

}
