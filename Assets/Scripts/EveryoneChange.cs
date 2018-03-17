using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EveryoneChange : MonoBehaviour {
    public MeshRenderer mycurrentRenderer;
    public MeshRenderer BasecurrentRenderer;
    public Texture MynormalTexture;
    public Texture normalTexture;
    // Use this for initialization
    void Start () {
        mycurrentRenderer = this.GetComponent<MeshRenderer>();
        BasecurrentRenderer = GameObject.Find("BaseShadowLibrary").GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		if(BasecurrentRenderer.material.mainTexture == normalTexture)
        {
            mycurrentRenderer.material.mainTexture = MynormalTexture;
        }
	}
}
