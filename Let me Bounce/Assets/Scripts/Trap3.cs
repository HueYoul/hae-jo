using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap3 : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector3(Random.Range(103f, 105f), 0, 0);
        }
    }
}

