using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    AudioSource audioSource;
    public int collected = 1;
    public static bool isDestroyed = false;
    public static List<string> DeletedBatteries = new List<string>();
    void Start()
    {
        
        audioSource = GameObject.FindGameObjectWithTag("B_SoundFX").GetComponent<AudioSource>();
        if (isDestroyed)
        {
            if (DeletedBatteries.Contains(gameObject.name)) { 
            Destroy(gameObject);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpotlightManager.noBatteries = false;
            GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight>().Collected(collected);
            audioSource.Play();
            isDestroyed = true;
            DeletedBatteries.Add(gameObject.name);
            Destroy(gameObject);
        }
         
    }
}