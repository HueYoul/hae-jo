using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    public float LimitTime;
    public int Star = 0;
    public Text text_Timer;
    public Button btn;

    void Update()
    {
        text_Timer.text = "Time : " + string.Format("{0:0.#}", LimitTime);
        if (Star >= 1 && Star < 11)
        {
            LimitTime += Time.deltaTime;
            text_Timer.text = "Time : " + string.Format("{0:0.#}", LimitTime);
        }
        if (Star >= 11)
        {
            text_Timer.text = "Time : " + string.Format("{0:0.#}", LimitTime);
        }
    }
}
