using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;

        if(GameObject.FindGameObjectsWithTag("soundtrack").Length > 0)
        {
            Destroy(GameObject.FindGameObjectsWithTag("soundtrack")[0]);
        }
    }
}
