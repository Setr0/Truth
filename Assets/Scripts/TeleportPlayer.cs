using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.transform.position = new Vector2(66.18f, -29.4f);
    }
}
