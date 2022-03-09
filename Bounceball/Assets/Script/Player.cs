using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canDoubleJump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(0.005f, 0, 0));
        }

        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(-0.005f, 0, 0));
        }

        if(Input.GetKey(KeyCode.UpArrow) && canDoubleJump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150));
            canDoubleJump = false;
        }
    }
}
