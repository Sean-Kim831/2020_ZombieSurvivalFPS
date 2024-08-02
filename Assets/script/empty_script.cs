using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class empty_script : MonoBehaviour
{
    public bool is_knifed = true;
    public float knife_timer = 0;


    public int Vaccine_Count = 0;
    public GameObject Vaccine;
    public Text Vaccine_CountText;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
        Vaccine_CountText.text = "Vaccine: " + Vaccine_Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_knifed)
        {
            if (Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.G))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = true;
                is_knifed = false;
            }
            else
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
        else
        {
            knife_timer += 1 * Time.deltaTime;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            if (knife_timer >= 1.5)
            {
                is_knifed = true;
                knife_timer = 0;
            }
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Vaccine")
        {
            Destroy(Vaccine);
            Vaccine_Count++;
            Vaccine_CountText.text = "Vaccine: " + Vaccine_Count;
        }
    }

}