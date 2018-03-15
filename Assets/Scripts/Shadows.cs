using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadows : MonoBehaviour
{
    AudioSource audioSource;
    public Transform Player;
    public float EnemyDistance;

    //public Light myLight;
    //public Light mySpotLight;

    public float duration = .025f;

    public Color ccolor = Color.clear;
    public Color wcolor = Color.white;

    public Texture normalTexture;
    public float Xpos;
    public float Ypos;
    public float Zpos;
    public static float Xp;
    public static float Yp;
    public static float Zp;
    public bool StopAtPosition = false;
    public BoxCollider MyBox;
    public Shadow_Movement myShadowM;
    public MeshRenderer currentRenderer;
    public Shadows myShadow;
    public Rigidbody myRigid;
    public MeshCollider myMeshC;
    public AudioSource myAudio;
    public static bool ShadowDestroyed = false;
    public static List<string> DeletedShadows = new List<string>();
    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("S_SoundFX").GetComponent<AudioSource>();
        //myLight = GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();
        //mySpotLight = GameObject.FindGameObjectWithTag("Spotlight").GetComponent<Light>();
        currentRenderer = this.GetComponent<MeshRenderer>();
        print(currentRenderer);
        myShadowM = this.GetComponent<Shadow_Movement>();
        MyBox = this.GetComponent<BoxCollider>();
        myShadow = this.GetComponent<Shadows>();
        myRigid = this.GetComponent<Rigidbody>();
        myMeshC = this.GetComponent<MeshCollider>();
        myAudio = this.GetComponent<AudioSource>();
        if (DeletedShadows.Contains(gameObject.name)){
            myMeshC.enabled = false;
            //Change Texture
            currentRenderer.material.mainTexture = normalTexture;
            //Turn off trigger of Box Collider
            MyBox.isTrigger = false;
            //Activate MeshCollider
            //myMeshC.enabled = true;
            //Turn off Shadow Movement
            Destroy(myShadowM);
            //Turn off the Rigid Body
            Destroy(myRigid);
            //move positon
            
            transform.position = new Vector3(Xp, Yp, Zp);
            //Turn off shadow audio
            myAudio.mute = true;
            myAudio.enabled = false;
            //Change Tag
            transform.tag = "Untagged";
            // Turn off Shadow Script 
            Destroy(myShadow);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flashlight"))
        {
            if (GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().isActive == true)
            {
                //Adds Shadow name to DeletedShadows
                DeletedShadows.Add(gameObject.name);
                //Change Texture
                currentRenderer.material.mainTexture = normalTexture;
                //Turn off trigger of Box Collider
                MyBox.isTrigger = false;
                //Activate MeshCollider
                //SmyMeshC.enabled = true;
                //Turn off Shadow Movement
                Destroy(myShadowM);
                //Turn off the Rigid Body
                Destroy(myRigid);

                if (StopAtPosition == true)
                {
                    transform.position = new Vector3(Xpos, Ypos, Zpos);
                    Xp = Xpos;
                    Yp = Ypos;
                    Zp = Zpos;
                }
                else
                {
                    Xp = transform.position.x;
                    Yp = transform.position.y;
                    Zp = transform.position.z;
                }
                audioSource.Play();
                //Change Tag
                transform.tag = "Untagged";
                //turn off audio tag
                myAudio.mute = true;
                myAudio.enabled = false;
                // Turn off Shadow Script 
                Destroy(myShadow);
                Flashlight.myLight.color = wcolor;
                SpotlightManager.mySpotLight.color = wcolor;
            }
        }
    }

    void Update()
    {

        float distance = Vector3.Distance(transform.position, Player.transform.position);
        print(distance);
        if (distance < EnemyDistance)
        {

            Flashlight.myLight.enabled = true;
            SpotlightManager.mySpotLight.enabled = true;
            float t = Mathf.PingPong(Time.time, duration);
            Flashlight.myLight.color = Color.Lerp(ccolor, wcolor, t);
            SpotlightManager.mySpotLight.color = Color.Lerp(ccolor, wcolor, t);


        }

        else
        {
            Flashlight.myLight.color = wcolor;
            SpotlightManager.mySpotLight.color = wcolor;
        }

            
        

    }
}
