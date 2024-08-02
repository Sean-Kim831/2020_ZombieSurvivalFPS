using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaccine_Spawn : MonoBehaviour
{
    public GameObject Vaccine;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Vaccine, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
