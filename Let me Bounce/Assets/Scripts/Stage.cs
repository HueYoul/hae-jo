using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    public int b = 0;
    public int c = 0;
    public Text text;
    void Update()
    {
        if(b==1)
        {
            text.text = "Stage2";
        }

        if (c == 1)
        {
            text.text = "Stage3";
        }
    }
}
