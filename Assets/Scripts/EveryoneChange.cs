using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EveryoneChange : MonoBehaviour {
    public MeshRenderer mycurrentRenderer;
    public MeshRenderer BasecurrentRenderer;
    //Texture of nonshadow
    public Material MynormalTexture;
    //Texture of Parent nonshadow
    public Material normalTexture;
    // Use this for initialization
    public string NormalTexture_name;
    public string MyNormalTexture_name;
    void Start () {
        //render of child objects
        mycurrentRenderer = this.GetComponent<MeshRenderer>();
        NormalTexture_name = normalTexture.name;
    }
	
	// Update is called once per frame
	void Update () {
		if(BasecurrentRenderer.material.name.Contains(NormalTexture_name))
        {
            mycurrentRenderer.material= MynormalTexture;
            print("true");
        }
        else
        {
            print(BasecurrentRenderer.material);
            print(normalTexture);
        }
	}
}
