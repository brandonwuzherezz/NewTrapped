using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{

    public KeyCode flashlightToggleKey = KeyCode.F;
    public float maxBatteryLife;
    public int totalBatteries = 1;
    public float batteryLife;
    public bool isActive;
    public static Light myLight;
    public Slider flashlightbar;
    public Text text;
    public float speed = 5.0f;

    //flicker values
    public static float maxFlickerSpeed = 1f;
    public static float minFlickerSpeed = 0.1f;

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        myLight = GetComponent<Light>();
        batteryLife = maxBatteryLife;

        flashlightbar.value = maxBatteryLife;
        text = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(flashlightToggleKey))
        {
            isActive = !isActive;

            if (batteryLife > 0)
            {
                audioSource.Play();
            }

        }
        if (isActive)
        {

           myLight.enabled = true;

            batteryLife -= 0.1f;

            SetBoxColliders(true);
           


            flashlightbar.value = batteryLife / maxBatteryLife;

            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.y); //mouse position
            //Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos); // convert to position in the world
            //lookPos = lookPos - transform.position; // offset by the position of flashlight 
            float angle = Mathf.Atan2(mousePos.x - (Screen.width / 2), mousePos.z - (Screen.height / 2)) * Mathf.Rad2Deg; // arctan b/w x and y            
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up); //rotate based on angle and axis(forward = z and up = y)      
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
            //Debug.Log("lookPos: " + mousePos);

            if (batteryLife <= 0)
            {
                myLight.enabled = false;
                SetBoxColliders(false);
                AddBatteryLife();
            }

        }

        else
        {
            myLight.enabled = false;
            SetBoxColliders(false);
        }
        

    }

    public void Collected(int _collected)
    {
        totalBatteries += _collected;
        BatteryManager.battery += _collected;

    }

    public void AddBatteryLife()
    {
        if (totalBatteries > 0)
        {
            totalBatteries -= 1;
            BatteryManager.battery -= 1;
            batteryLife = maxBatteryLife;
            flashlightbar.value = maxBatteryLife;
            isActive = !isActive;

        }

        else
        {
            SpotlightManager.noBatteries = true;
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shadow"))
        {
            if (isActive)
            {

                batteryLife -= maxBatteryLife / 12.5f;

            }
        }
    }
    public void SetBoxColliders(bool active)
    {
        foreach (BoxCollider b in GetComponents<BoxCollider>())
        {
            b.enabled = active;
      }
    }

    public static IEnumerator FlashlightFlicker()
    {
        myLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));

        myLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));


    }
}