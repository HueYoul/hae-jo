using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int star = 0;
    public GameObject ending;

    private void Update()
    {
        if (star == 11)
        {
            //Time.timeScale = 0;
            ending.SetActive(true);
        }
    }
}
