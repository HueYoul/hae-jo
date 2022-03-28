using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightShift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().noGravity = true;
            collision.gameObject.transform.position = gameObject.transform.position + new Vector3(0.4f, 0, 0);
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 0);
        }
    }
}
