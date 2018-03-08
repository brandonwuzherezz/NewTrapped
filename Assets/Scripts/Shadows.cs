using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadows : MonoBehaviour
{
    AudioSource audioSource;
    public Transform Player;
    public float EnemyDistance;

    public Light myLight;

    public float duration = .025f;

    public Color ccolor = Color.clear;
    public Color wcolor = Color.white;

    public Texture normalTexture;
    public float Xpos;
    public float Ypos;
    public float Zpos;

    public BoxCollider MyBox;
    public Shadow_Movement myShadowM;
    public MeshRenderer currentRenderer;
    public Shadows myShadow;
    public Rigidbody myRigid;
    public MeshCollider myMeshC;
    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("S_SoundFX").GetComponent<AudioSource>();
        myLight = GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();
        myLight.intensity = 12f;
        currentRenderer = this.GetComponent<MeshRenderer>();
        myShadowM = this.GetComponent<Shadow_Movement>();
        MyBox = this.GetComponent<BoxCollider>();
        myShadow = this.GetComponent<Shadows>();
        myRigid = this.GetComponent<Rigidbody>();
        myMeshC = this.GetComponent<MeshCollider>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flashlight"))
        {
            if (GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().isActive == true)
            {
                //Change Texture
                currentRenderer.material.mainTexture = normalTexture;
                //Turn off trigger of Box Collider
                Destroy(MyBox);
                //Activate MeshCollider
                myMeshC.enabled = true;
                //Turn off Shadow Movement
                Destroy(myShadowM);
                //Turn off the Rigid Body
                Destroy(myRigid);
                transform.position = new Vector3(Xpos, Ypos, Zpos);
                audioSource.Play();
                //Change Tag
                transform.tag = "Untagged";
                // Turn off Shadow Script 
                Destroy(myShadow);
            }
        }
    }

    void Update()
    {

        float distance = Vector3.Distance(transform.position, Player.transform.position);
        print(distance);
        if (distance < EnemyDistance)
        {

            myLight.enabled = true;
            float t = Mathf.PingPong(Time.time, duration);
            myLight.color = Color.Lerp(ccolor, wcolor, t);


        }

        else
        {
            myLight.color = wcolor;
        }

            
        

    }
}
