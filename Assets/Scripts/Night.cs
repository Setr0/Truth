using UnityEngine;

public class Night : MonoBehaviour
{
    public new Camera camera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera.backgroundColor = Color.black;
    }
}
