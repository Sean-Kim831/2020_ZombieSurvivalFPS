using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp_point : MonoBehaviour
{
    public float timer = 0;
    public int zombie_count = 0;
    public int zombie_limit_count = 40;
    public GameObject zombie_prefabs;
    public static int sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<sp_point>().zombie_count;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("sp : " + sp);

        timer += 1 * Time.deltaTime;

        if (timer > 2)
        {
            if (sp < zombie_limit_count)
            {
                Instantiate(zombie_prefabs, this.transform.position, this.transform.rotation);
                sp++;
                timer = 0;
            }
            else if (sp == zombie_limit_count)
            {
                timer = 0;
            }
        }

        
    }
}
