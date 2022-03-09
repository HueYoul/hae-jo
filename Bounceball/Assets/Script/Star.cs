using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {     
        if (collision.tag == "Player")
        {
            //collision.gameObject.GetComponent<GameManager>().star++;
            GameObject.Find("GameManager").GetComponent<GameManager>().star++;
            gameObject.SetActive(false);
        }
    }
}
