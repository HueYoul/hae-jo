using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().canDoubleJump = true;
            gameObject.SetActive(false);
        }
    }
}
