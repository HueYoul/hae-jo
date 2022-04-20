using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int star = 0;
    public GameObject ending;
    //public GameObject player;

    private void Update()
    {
        if (star == 1)
        {
            Time.timeScale = 0;
            ending.SetActive(true);
            //Destroy(player);
        }
    }
}
