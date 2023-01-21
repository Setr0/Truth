using UnityEngine;

public class DogController : MonoBehaviour
{
    public GameObject player;
    SpriteRenderer spriteRender;
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(player.transform.position.x > transform.position.x)
        {
            spriteRender.flipX = false;
        }
        else
        {
            spriteRender.flipX = true;
        }
    }
}
