using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlashlight : MonoBehaviour {

    public static bool hasFlashlight = false;
    public static bool isFlashlightDestroyed = false;
    public AudioSource Flashnoise;
    Animator anim;
    //bool Pickup;

    void Start()
    {
        anim = GetComponent<Animator>();
        if (isFlashlightDestroyed)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
            hasFlashlight = true;
            isFlashlightDestroyed = true;
            Flashnoise.Play();
            Destroy(gameObject);
            anim.SetTrigger("FlashlightPickup");            
        }

	}
}
