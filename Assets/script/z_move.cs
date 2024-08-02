using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z_move : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject target;

    Animator animator;
    AudioSource audioSource;
    public AudioClip hitting_sound;
   

    public Transform blood_effect1;

    public static int random_hp;
    public Vector3 random_blood_position;

    public bool is_dead = false;
    public float dead_timer = 0;

    public float hitting_timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        random_hp = Random.Range(4,6);
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = hitting_sound;
        audioSource.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");

        random_blood_position.y = Random.Range(0.4f, 1.2f);

        RaycastHit hit;
        Vector3 fwd = Vector3.forward;

        if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, 1f))
        {
            if (hit.collider.tag == "Player")
            {
                animator.SetBool("attackStart", true);
            }
        }
        else
        {
            animator.SetBool("attackStart", false);
            animator.SetBool("runStart", true);

        }

        agent.SetDestination(target.transform.position);
        animator.SetBool("runStart", true);

        if (is_dead)
        {
            dead_timer += 1 * Time.deltaTime;
        }

        if (dead_timer > 5)
        {
            Destroy(this.gameObject);
            is_dead = false;
            dead_timer = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Bullet_Prefab(Clone)")
        {
            Instantiate(blood_effect1, this.transform.position+random_blood_position, this.transform.rotation);
            audioSource.Play();
            random_hp--;

            //animator.SetTrigger("hit");
            //agent.SetDestination(target.transform.position);
            //animator.SetBool("runStart", true);

            if (random_hp <1)
            {
                animator.SetTrigger("dead");
                sp_point.sp--;
                is_dead = true;
                this.agent.speed = 0f;
                gameObject.GetComponent<CapsuleCollider>().enabled = false;
            }
        }

        if (collision.transform.tag == "kni")
        {
            if (Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.Q))
            {
                Instantiate(blood_effect1, this.transform.position + new Vector3(0, 0.6f, 0), this.transform.rotation);
                audioSource.Play();
                random_hp -= 10;
                if (random_hp < 1)
                {
                    animator.SetTrigger("dead");
                    sp_point.sp--;
                    is_dead = true;
                    this.agent.speed = 0f;
                    gameObject.GetComponent<CapsuleCollider>().enabled = false;

                }
            }
        }

    }

}
