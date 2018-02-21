using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShedEntrance : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("Shed");
			GameObject.FindGameObjectWithTag("Load").GetComponent<LoadLevel>().SetTrue();
		}
	}
}
