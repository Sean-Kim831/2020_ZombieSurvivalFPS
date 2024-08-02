using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut_text : MonoBehaviour
{
    public UnityEngine.UI.Text fade;
    public UnityEngine.UI.Text sucfade;

    public bool is_successed = false;

    float fades = 0.1f;
    float time = 0;
    void Update()
    {
        if (Vaccine_N.Vaccine_Count == 4)
        {
            is_successed = true;
        }

        time += 1 * Time.deltaTime;
        if (p_dmg.end)
        {
            if (fades > 0.0f && time >= 0.05f)
            {
                fades += 1.0f * Time.deltaTime;
                fade.color = new Color(255, 255, 255, fades);
                time = 0;
            }
            else if (fades >= 255.0f)
            {
                time = 0;
                //다음신으로 넘기거나 다음 활동할 것에 대해 작성 ㅇㅇ
            }
        }

        if (is_successed)// 성공할 때의 부울 변수는 일단 esc누르면 작동되게 해놓음, 백신 다 모으면 true반환하게 할 것
        {
            if (fades > 0.0f && time >= 0.05f)
            {
                fades += 4.0f * Time.deltaTime;
                sucfade.color = new Color(255, 255, 255, fades);
                time = 0;
            }
            else if (fades >= 255.0f)
            {
                time = 0;
            }
        }


    }

}