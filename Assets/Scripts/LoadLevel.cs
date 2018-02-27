using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadLevel : MonoBehaviour {
	public static bool ShedDoor = false;
	void Start () {
		SpawnShed ();
	}

    void SpawnShed(){
		
		if(ShedDoor == true){
			GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.920011f, -0.04718876f, -0.5662009f);
		}	
	
	}
	public void SetShedTrue(){
		ShedDoor = true;
	}
}
