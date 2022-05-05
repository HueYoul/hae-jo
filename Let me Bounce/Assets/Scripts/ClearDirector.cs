using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    public int clearstar = 0;
    void Update()
    {
        if(clearstar == 2)
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
