using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ClearDirector : MonoBehaviour
{
    public int clearstar = 0;
    float coolDown = 2.0f;
    float updateTime = 0.0f;
    void Update()
    {
        /*if(clearstar == 2)
        {
            if(updateTime > coolDown)
            {
                if (SceneManager.GetActiveScene().name == "Stage1")
                {
                    SceneManager.LoadScene("Stage2");
                    PhotonNetwork.Instantiate("Player", new Vector3(Random.Range(0f, 1f), 0, 0), Quaternion.identity);
                }
                else if (SceneManager.GetActiveScene().name == "Stage2")
                {
                    SceneManager.LoadScene("Stage3");
                }

            }
            else
            {
                updateTime += Time.deltaTime;
            }
            
        }*/
    }
}
