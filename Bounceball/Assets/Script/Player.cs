using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canDoubleJump = false;
    public bool noGravity = false;
   

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (noGravity && Input.anyKeyDown)
        {
            noGravity = false;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(0.002f, 0, 0));
        }

        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(-0.002f, 0, 0));
        }

        if(Input.GetKey(KeyCode.UpArrow) && canDoubleJump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150));
            canDoubleJump = false;
        }
    }
}
