using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{

    public float maxSpeed = 4.0f;
    bool facingRight = false;
    public int State = 0;
    public AudioSource audioSource;

    Flashlight flashLight;
    public Animator anim;
    Rigidbody RB;
    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("W_soundFX").GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody>();

        GameObject flash = GameObject.Find("Flashlight1");
        flashLight = flash.GetComponent<Flashlight>();
    }
    void FixedUpdate()
    {
        float move = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey("a"))
        {
            if (!audioSource.isPlaying) {
                audioSource.Play();
           }
            State = 1;
            //anim.SetInteger("State", State);
            transform.position += transform.right * Time.deltaTime * maxSpeed;
            RB.velocity = new Vector3(0, RB.velocity.y, 0);
            
        }
        else if (Input.GetKey("d"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            State = 1;
            //anim.SetInteger("State", State);
            transform.position -= transform.right * Time.deltaTime * maxSpeed;
            RB.velocity = new Vector3(0, RB.velocity.y, 0);
        }       
        else if (Input.GetKey("w"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            State = 1;
            anim.SetInteger("State", State);
            transform.position -= transform.forward * Time.deltaTime * maxSpeed;

            RB.velocity = new Vector2(0, RB.velocity.y);
            //State = 0;

        }
        else if (Input.GetKey("s"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            State = 1;
            anim.SetInteger("State", State);
            transform.position += transform.forward * Time.deltaTime * maxSpeed;

            RB.velocity = new Vector2(0, RB.velocity.y);
            //State = 1;
        }
        if(Input.anyKey == false && anim != null)
        {
            audioSource.Stop();
            State = 0;
            anim.SetInteger("State", State);
        }
        //if(Input.anyKey == true && anim != null)
        if (anim != null)
        {
            anim.SetInteger("State", State);
        }
        else
        {
            //State = 0;
        }

        if (move > 0 && !facingRight ){
            Flip();
            
        }else if(move < 0 && facingRight)
        {
            Flip();
            
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    void OnTriggerEnter(Collider col)
    {
        //Battery drain on contact(In progress)
        /* if (col.gameObject.tag == "Shadow" && flashLight.isActive != true && flashLight.totalBatteries > 0)
         {
             flashLight.totalBatteries -= 1;
         }
         else if (col.gameObject.tag == "Shadow" && flashLight.isActive != true && flashLight.totalBatteries == 0)
         {
             Destroy(GameObject.FindWithTag("Player"));
         }*/

         //Shadow contact kills player
        if (col.gameObject.tag == "Shadow")
        {
            Scene currentScene = SceneManager.GetActiveScene();
            GameOver.PreviousScene = currentScene.name;
            SceneManager.LoadScene("Scene_GameOver");
            //Destroy(GameObject.FindWithTag("Player"));
            //flashLight.isActive = true;
            //flashLight.batteryLife = 0;
            //flashLight.myLight.intensity = 0;
            Debug.Log("Trigger!");
        }

    }
}
