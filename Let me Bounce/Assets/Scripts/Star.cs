using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int a=0;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().star++;           
            GameObject.Find("timer").GetComponent<Timer_>().Star++;
            GameObject.FindWithTag("ClearStar").GetComponent<ClearStar>().clear++;
            GameObject.FindWithTag("ClearStar2").GetComponent<ClearStar2>().clear2++;
            gameObject.SetActive(false);
            
        }
    }
}
