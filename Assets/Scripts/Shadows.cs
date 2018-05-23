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

    public Material normalTexture;
    public float Xpos;
    public float Ypos;
    public float Zpos;
    public List<float> Coordinates = new List<float>();
    public static Dictionary<string, List<float>> myDictionary = new Dictionary<string, List<float>>();
    public bool StopAtPosition = false;
    public BoxCollider MyBox;
    public Shadow_Movement myShadowM;
    public MeshRenderer currentRenderer;
    public Shadows myShadow;
    public Rigidbody myRigid;
    public MeshCollider myMeshC;
    public AudioSource myAudio;
    public GameObject myParticles;

    public static bool ShadowDestroyed = false;
    public static List<string> DeletedShadows = new List<string>();
    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("S_SoundFX").GetComponent<AudioSource>();
        //myLight = GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();
        //mySpotLight = GameObject.FindGameObjectWithTag("Spotlight").GetComponent<Light>();
        currentRenderer = this.GetComponent<MeshRenderer>();
        //print(currentRenderer);
        myShadowM = this.GetComponent<Shadow_Movement>();
        MyBox = this.GetComponent<BoxCollider>();
        myShadow = this.GetComponent<Shadows>();
        myRigid = this.GetComponent<Rigidbody>();
        myMeshC = this.GetComponent<MeshCollider>();
        myAudio = this.GetComponent<AudioSource>();
        //myParticles = this.GetComponent<ParticleSystem>();
        
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
                currentRenderer.material = normalTexture;
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
                }
                else
                {
                    Xpos = transform.position.x;
                    Ypos = transform.position.y;
                    Zpos = transform.position.z;
                }
                Coordinates.Add(Xpos);
                Coordinates.Add(Ypos);
                Coordinates.Add(Zpos);
                if (!myDictionary.ContainsKey(gameObject.name))
                {
                    myDictionary.Add(gameObject.name, Coordinates);
                }
                audioSource.Play();
                //Change Tag
                transform.tag = "Untagged";
                //turn off audio tag
                myAudio.mute = true;
                myAudio.enabled = false;
                // Turn off Shadow Script 
                Destroy(myShadow);
                Destroy(myParticles);
                Flashlight.batteryLife -= 150f / 10f;
                Flashlight.myLight.color = wcolor;
                SpotlightManager.mySpotLight.color = wcolor;
            }
        }
    }

    void Update()
    {
        if (DeletedShadows.Contains(gameObject.name) && GameOver.ResetGame == false)
        {
            myMeshC.enabled = false;
            //Change Texture
            currentRenderer.material = normalTexture;
            //Turn off trigger of Box Collider
            MyBox.isTrigger = false;
            //Activate MeshCollider
            //myMeshC.enabled = true;
            //Turn off Shadow Movement
            Destroy(myShadowM);
            //Turn off the Rigid Body
            Destroy(myRigid);
            //move positon
            Xpos = myDictionary[gameObject.name][0];
            Ypos = myDictionary[gameObject.name][1];
            Zpos = myDictionary[gameObject.name][2];
            transform.position = new Vector3(Xpos, Ypos, Zpos);
            //Turn off shadow audio
            myAudio.mute = true;
            myAudio.enabled = false;
            //Change Tag
            transform.tag = "Untagged";
            // Turn off Shadow Script 
            Destroy(myShadow);
            Destroy(myParticles);
        }
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        //print(distance);
        if (distance < EnemyDistance)
        {

            //Flashlight.myLight.enabled = true;
            //sSpotlightManager.mySpotLight.enabled = true;
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
