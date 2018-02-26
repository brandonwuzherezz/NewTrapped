using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMenu : MonoBehaviour {

	public GUIText referencetotext;

	void OnTriggerEnter(Collider hit){
		referencetotext.text ="Necesito mas comida";
	}

	void OnTriggerExit(Collider hit){
		referencetotext.text ="";
	}

}
