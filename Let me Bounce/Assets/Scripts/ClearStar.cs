using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStar : MonoBehaviour
{
    public int trans = 0;
    public int clear = 0;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(clear == 3)
        {
            gameObject.SetActive(true);
            if (collision.tag == "Player")
            {
                GameObject.Find("Stage").GetComponent<Stage>().b++;
                trans++;
                if (trans == 1)
                {
                    collision.gameObject.transform.position = new Vector3(Random.Range(1.0f, 1.5f), -20, 0);
                }
            }

        }
        
    }
}
