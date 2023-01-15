using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if(player.transform.position.x <= -0.6712771f)
        {
            transform.position = new Vector3(-0.6557271f, 0f, -1f);
        }
        else if(player.transform.position.x >= 59.87917f)
        {
            transform.position = new Vector3(59.87917f, 0f, -1f);
        }
        else
        {
            transform.position = new Vector3(player.transform.position.x, 0f, -1f);
        }
    }
}
