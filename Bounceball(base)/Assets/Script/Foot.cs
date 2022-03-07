using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //circle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
        circle.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150));
    }
}
