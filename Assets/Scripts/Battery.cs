using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    AudioSource audioSource;
    public int collected = 1;
    public static List<string> DeletedBatteries = new List<string>();
    Animator anim;
    public GameObject chosenEffect;
    //bool pickup;

    void Start()
    {        
        audioSource = GameObject.FindGameObjectWithTag("B_SoundFX").GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (DeletedBatteries.Contains(gameObject.name) && GameOver.ResetGame == false)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpotlightManager.noBatteries = false;
            GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().Collected(collected);
            audioSource.Play();
            DeletedBatteries.Add(gameObject.name);
            Destroy(gameObject);
            anim.SetTrigger("batteryPickup");
            GameObject effectPlayer = (GameObject)Instantiate(chosenEffect, transform.position, transform.rotation);
            //Destroy(effectPlayer);
            Debug.Log(effectPlayer);
        }
         
    }
}