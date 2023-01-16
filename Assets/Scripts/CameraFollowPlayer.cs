using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        float playerX = player.transform.position.x;
        float playerY = player.transform.position.y;

        if (player.transform.position.x <= -0.6712771f)
        {
            transform.position = new Vector3(-0.6557271f, playerY += 3.7f, -1f);
        }
        else if(player.transform.position.x >= 59.87917f)
        {
            transform.position = new Vector3(59.87917f, playerY += 3.7f, -1f);
        }
        else
        {
            transform.position = new Vector3(playerX, playerY += 3.7f, -1f);
        }
    }
}
