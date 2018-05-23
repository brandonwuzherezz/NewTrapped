using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour {
    public Color col;
    // Use this for initialization
    void Start () {
        col = this.GetComponent<MeshRenderer>().material.color;
        col.a = 1f; 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
