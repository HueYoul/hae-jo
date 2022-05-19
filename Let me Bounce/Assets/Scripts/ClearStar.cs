using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStar : MonoBehaviour
{
    public int a = 0;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("Stage").GetComponent<Stage>().b++;
            a++;
            if (a == 1)
            {
                collision.gameObject.transform.position = new Vector3(Random.Range(-3f, -2f), -27, 0);
                //collision.gameObject.transform.translate(new Vector3(0,0,0));
                //collision.gameObject.transform.position = new Vector3(Random.Range(103f, 105f), 0, 0);
            }
        }
    }
}
