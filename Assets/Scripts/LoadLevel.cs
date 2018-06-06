using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadLevel : MonoBehaviour
{
 
    //Brandon
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
    //Manuel
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
    //Jay
    public static bool BallroomC = false;
    public static bool BallroomD = false;
    public static bool BSH = false;
    public static bool Patio = false;
    public static bool SFH = false;
    public static bool BSHB = false;
    public static bool SFHB = false;
    public static bool SFHC = false;
    public static bool BSHC = false;


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


        if (Bedroom1B == true)
        {
            if(sceneName == "secondFloorHallway")
            {
                SpawnOutsideBedroom1B();
            }
        }



        if (Bedroom1A == true)
        {
            print("here");
            if (sceneName == "Bedroom1")
            {
                
                SpawnOutsideBedroom1A();
            }
        }
        //Spawn in Bathroom after enter bedroom2
        if (Bedroom2 == true)
        {
            if (sceneName == "Bathroom")
            {
                SpawnOutsideBedroom2();
            }
        }
        //Spawn in MB after entering the Libarary
        if (Library == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideLibrary();
            }
        }
        //Spawn in MB after entering the MC
        if (MasterCloset == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideMasterCloset();
            }

        }
        //Spawn in MB after entering the MasterBathroom
        if (MasterBathroom == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideMasterBathroom();
            }
        }
        //Spawn in MB after entering the Vault
        if (Vault == true)
        {
            if (sceneName == "MasterBedroom")
            {
                SpawnOutsideVault();
            }
        }
        /*        if(Bedroom1B == true)
                {
                    if (sceneName == "Hallway1")
                    {
                        SpawnOutsideBedroom1B();
                    }
                }


                if (BathroomA == true)
                {
                    if (sceneName == "Bedroom1")
                    {
                        SpawnOutsideBathroomA();
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

                       if (MasterBedroomC == true)
                        {
                            if (sceneName == "Hallway2")
                            {
                                SpawnOutsideMasterBedroomC();
                            }
                        }

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

                
               
               
              
                */
            if (BSHC == true)
            {
                if (sceneName == "Ballroom_secondHallway")
                {
                SpawnOutsideMasterBedroomC();
                }
            }

        

        if (BallroomC == true)
        {
            if (sceneName == "Ballroom_secondHallway")
            {
                SpawnOutsideBallroomC();
            }
        }
        if (BallroomD == true)
        {
            if (sceneName == "Patio")
            {
                SpawnOutsideBallroomD();
            }
        }
        if (Patio == true)
        {
            if (sceneName == "Ballroom")
            {
                SpawnOutsidePatio();
            }
        }
        if (BSH == true)
        {
            if (sceneName == "Ballroom")
            {
                SpawnOutsideBSH();
            }
        }
        if (BSHB == true)
        {
            if (sceneName == "secondFloorHallway")
            {
                SpawnOutsideBSHB();
            }
        }
        if (SFH == true)
        {
            if (sceneName == "Ballroom_secondHallway")
            {
                SpawnOutsideSFH();
            }
        }
        if (SFHB == true)
        {
            if (sceneName == "secondFloorHallway")
            {
                SpawnOutsideCloset1();
            }
        }
        if (SFHC == true)
        {
            if (sceneName == "secondFloorHallway")
            {
                SpawnOutsideCloset2();
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
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(14.41302f, -0.09485483f, -1.519992f);
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

    /*

        void SpawnOutsideHallway1()
        {//Spawn in Bedroom1 from Hallway1
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-19.76f, -0.1651627f, -9.26f);
            Hallway1 = false;
        }

    */
    /*Manuels Code */
    void SpawnOutsideBedroom1A()
    {//Spawn in Bathroom from Bedroom1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-14.14999f, -0.1651627f, -2.777015f);
        Bedroom1A = false;
    }

    
    void SpawnOutsideBedroom1B()
    {//Spawn in SFH from Bedroom1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-13.4881f, -0.09485483f, 0.86f);
        Bedroom1B = false;
    }



    void SpawnOutsideBedroom2()
    {//Spawn in Bathroom from Bedroom2
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(5.07716f, -0.01597869f, 18.60066f);
        Bedroom2 = false;
    }

    void SpawnOutsideBathroomA()
    {//Spawn in Bedroom 1 from Bathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-14.75026f, -0.1651627f, -12.91045f);
        BathroomA = false;
    }

    void SpawnOutsideBathroomB()
    {//Spawn in Bedroom2 from Bathroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-2.99f, -0.1651627f, 17.32f);
        BathroomB = false;
    }

    void SpawnOutsideMasterBedroomA()
    {//Spawn in MasterBathroom from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-3.450881f, -0.1651627f, 11.68f);
        MasterBedroomA = false;
    }

    void SpawnOutsideMasterBedroomB()
    {//Spawn in MasterCloset from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.790001f, -0.1651627f, 16.42f);
        MasterBedroomB = false;
    }

 
   
    void SpawnOutsideMasterBedroomC()
    {//Spawn in SFH from MasterBedroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-9.679993f, -0.09485483f, 14.82394f);
        MasterBedroomC = false;
    }



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
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-3.66948f, -0.1651627f, -21.16181f);
        MasterBathroom = false;
    }

    void SpawnOutsideMasterCloset()
    {//Spawn in MasterBedroom from MasterCloset
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(30.10771f, -0.1651627f, -24.03656f);
        MasterCloset = false;
    }

    void SpawnOutsideLibrary()
    {//Spawn in MasterBedroom from Library
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(42.74224f, -0.1651627f, 2.122032f);
        Library = false;
    }

    void SpawnOutsideVault()
    {//Spawn in MasterBedroom from Vault
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-18.54109f, -0.1651627f, -13.1209f);
        Vault = false;
    }

    /*
        void SpawnOutsideHallway2()
        {//Spawn in MasterBedroom from Hallway
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.07f, -0.1651627f, 25.96f);
            Hallway2 = false;
        }
    */
       
    void SpawnOutsideBallroomC()
    {//spawn in Second Floor Hallway from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-12.48f, -0.09485483f, 30.47f);
        BallroomC = false;
    }
    void SpawnOutsideBallroomD()
    {//spawn in Patio from Ballroom
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-13.29001f, -0.09485483f, -0.120002f);
        BallroomD = false;
    }
    void SpawnOutsidePatio()
    {//spawn in Ballroom from Patio
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(7.761491f, -0.1842351f, -13.41427f);
        Patio = false;
    }
    void SpawnOutsideBSH()
    {//spawn in Ballroom from BSH
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(10.76002f, -0.1842351f, -4.150003f);
        BSH = false;
    }
    void SpawnOutsideBSHB()
    {//spawn in SFH from BSH
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(23.25f, -0.095f, 0.86f);//23.25f, -0.095f, 0.86f
        BSHB = false;
    }
    void SpawnOutsideSFH()
    {//spawn in BSH from SFH
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-12.9f, -0.09485483f, 16.33006f);//-13.6f, -0.09485483f, -1.729955f
        SFH = false;
    }
    void SpawnOutsideCloset1()
    {//spawn in SFH from Closet1
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(16.95003f, -0.09485483f, 2.99427f);//16.95003f
        SFHB = false;
    }
    void SpawnOutsideCloset2()
    {//spawn in SFH from Closet2
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-7.269984f, -0.09485483f, 2.99427f);//-7.269984f
        SFHC = false;
    }
}
