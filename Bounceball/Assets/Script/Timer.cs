using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the fir
    // st frame update
    public float LimitTime;
    public int Star = 0;
    public Text text_Timer;

    // Update is called once per frame
    void Update()
    {
        if (Star < 3)
        {
            LimitTime += Time.deltaTime;
            text_Timer.text = "시간 : " + string.Format("{0:0.#}", LimitTime);

        }
        if (Star >= 3)
        {
            text_Timer.text = "시간 : " + string.Format("{0:0.#}", LimitTime);
        }
           
    

    }
}
