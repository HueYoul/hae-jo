using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public GameObject circle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        circle.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 700));
    }
}
