using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Night : MonoBehaviour
{
    public Camera camera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera.backgroundColor = Color.black;
    }
}
