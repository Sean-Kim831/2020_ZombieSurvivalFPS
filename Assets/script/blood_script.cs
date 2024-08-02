using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood_script : MonoBehaviour
{
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 0.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
