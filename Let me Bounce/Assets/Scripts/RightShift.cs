using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightShift : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerScript>().noGravity = true;
            collision.gameObject.transform.position = gameObject.transform.position + new Vector3(1f, 0, 0);
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0);
        }
    }
}
