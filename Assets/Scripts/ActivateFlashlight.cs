using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlashlight : MonoBehaviour {

	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			GameObject flash = GameObject.Find ("Flashlight1");
			flash.SetActive(true);
			GameObject flash1 = GameObject.Find ("Flashlight");
			flash1.SetActive(true);
			GameObject Canvas = GameObject.Find ("Canvas") ;
			Canvas.SetActive(true); 
			GameObject.FindGameObjectWithTag ("Load").GetComponent<LoadLevel> ().setFlashlightTrue();
			Destroy(gameObject);
		}

	}
}
