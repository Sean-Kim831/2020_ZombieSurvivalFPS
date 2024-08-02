using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p_dmg : MonoBehaviour
{
    public float z_attackTime = 0.0f;
    public int health_count = 10;
    public static bool end = false;
    public Text playerHP;
    AudioSource audioSource;
    public AudioClip pain_sound;

    public Transform blood_effect;

    // Start is called before the first frame update
    void Start()
    {
        end = false;
        z_move zmove = gameObject.GetComponent<z_move>();
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = pain_sound;
        audioSource.loop = false;
        playerHP.text = "HP | " + health_count * 10;
    }



    // Update is called once per frame
    void Update()
    {
        if(health_count <= 0)
        {
            end = true;
            health_count = 0;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.transform.name == "Zombie1 1(Clone)")
        {
            z_attackTime += 1 * Time.deltaTime;
            
            if (z_attackTime >= 0.5f)
            {
                health_count--;
                Instantiate(blood_effect, this.transform.position, this.transform.rotation);
                audioSource.PlayOneShot(pain_sound);
                z_attackTime = 0.0f;
                
            }
            playerHP.text = "HP | " + health_count * 10;

        }
    }
}
