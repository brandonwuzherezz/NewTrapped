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
			GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(15.49f,-0.08f,-3.18f);
		}	
	
	}
	public void SetShedTrue(){
		ShedDoor = true;
	}
}
