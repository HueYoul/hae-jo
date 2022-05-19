using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public int star = 0;
    public GameObject ending;
    public PhotonView PV;

    private void Update()
    {
        if (star == 5)
        {
            //Time.timeScale = 0;
            ending.SetActive(true);
        }
    }
}
