using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoreEyes : MonoBehaviour
{
    public MeshRenderer BasecurrentRenderer;
    public Material normalTexture;
    public string NormalTexture_name;
    // Use this for initialization
    void Start()
    {
        NormalTexture_name = normalTexture.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (BasecurrentRenderer.material.name.Contains(NormalTexture_name))
        {
            Destroy(this.gameObject);
        }
    }
}
