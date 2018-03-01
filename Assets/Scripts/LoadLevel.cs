using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadLevel : MonoBehaviour {
	public static bool ShedDoor = false;
    public static bool FoyerCloset = false;
    public static bool DiningRoom = false;
    public static bool HallWay = false;
    void Start() {
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
            SpawnOutsideDH();
        }
        if (HallWay == true)
        {
            SpawnOutsideHall1();
        }
    }

    void SpawnShed(){
	     GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.920011f, -0.04718876f, -0.5662009f);
         ShedDoor = false;
	}
    void SpawnOutSideCloset()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1.5112f, -0.2557331f, -18.14018f);
        FoyerCloset = false;
    }
    void SpawnOutsideDH()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.03327464f, -0.2557331f, -7.017335f);
        DiningRoom = false;
    }
    void SpawnOutsideHall1()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-50.05046f, -0.1651622f, 12.76999f);
        HallWay = false;
    }
}
