using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStar2 : MonoBehaviour
{

    public int trans2 = 0;
    public int clear2 = 0;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (clear2 == 6)
        {
            gameObject.SetActive(true);
            if (collision.tag == "Player")
            {
                GameObject.Find("Stage").GetComponent<Stage>().c++;
                trans2++;
                if (trans2 == 1)
                {
                    collision.gameObject.transform.position = new Vector3(Random.Range(0.0f, 0.5f), -43, 0);
                }
            }

        }

    }
}
