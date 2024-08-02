using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaccine_N : MonoBehaviour
{
    public static int Vaccine_Count = 0;
    public GameObject Vaccine;
    // Start is called before the first frame update
    void Start()
    {
        Vaccine_Count = 0;
        this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)){
            this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
        }
        else
        {
            this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
        Debug.Log(Vaccine_Count);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "emptyobject")
        {
            Destroy(Vaccine);
            Vaccine_Count++;
        }
    }
}
