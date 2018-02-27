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


    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("S_SoundFX").GetComponent<AudioSource>();
        myLight = GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flashlight"))
        {
            if (GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().isActive == true)
            {
                audioSource.Play();
                Destroy(gameObject);
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
