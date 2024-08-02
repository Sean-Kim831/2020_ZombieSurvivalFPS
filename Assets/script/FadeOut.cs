using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FadeOut : MonoBehaviour
{
    public Image failFade;
    float fades = 0.1f;
    float time = 0;
    void Update()
    {
        if (p_dmg.end)
        {
            GameOver();
            if (Input.GetKey(KeyCode.F5))
            {
                Restart();
            }
        }
        if(Vaccine_N.Vaccine_Count == 4)
        {
            Clear();
            if (Input.GetKey(KeyCode.F5))
            {
                Restart();
            }
        }
        
    }
    void GameOver()
    {
        time += 1 * Time.deltaTime;
        Time.timeScale = 0.3f;
            if (fades > 0.0f && time >= 0.05f)
            {
                fades += 20.0f * Time.deltaTime;
                failFade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 254.0f)
            {
                time = 0;
                
            }
    }
    void Restart()
    {
        p_dmg.end = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("test_version_1");

    }
    void Clear()
    {
        time += 1 * Time.deltaTime;
        Time.timeScale = 0.3f;
            if (fades > 0.0f && time >= 0.05f)
            {
                fades += 3.0f * Time.deltaTime;
                failFade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 255.0f)
            {
                time = 0;
                if (Input.GetKeyDown(KeyCode.F5))
                {
                    Restart();
                }
            }
    }
   

}
