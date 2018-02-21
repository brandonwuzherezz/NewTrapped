using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadLevel : MonoBehaviour {
	public static bool ShedDoor = false;
	public static bool hasFlashlight = false;
	void Start () {
		SpawnShed ();
		if (hasFlashlight == true) {
			GameObject flash = GameObject.Find ("Flashlight1");
			flash.SetActive(true);
			GameObject flash1 = GameObject.Find ("Flashlight");
			flash1.SetActive(true);
			GameObject Canvas = GameObject.Find ("Canvas") ;
			Canvas.SetActive(true); 
		}
	}
	void SpawnShed(){
		
		if(ShedDoor == true){
			GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(15.49f,-0.08f,-3.18f);
		}	
	
	}
	public void setFlashlightTrue(){
		hasFlashlight = true;
	}
	public void SetShedTrue(){
		ShedDoor = true;
	}
}
