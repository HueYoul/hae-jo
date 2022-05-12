using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    public int clearstar = 0;
    float coolDown = 2.0f;
    float updateTime = 0.0f;
    void Update()
    {
        if(clearstar == 2)
        {
            if(updateTime > coolDown)
            {
                if (SceneManager.GetActiveScene().name == "Stage1")
                {
                    SceneManager.LoadScene("Stage2");
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
            
        }
    }
}
