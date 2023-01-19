using UnityEngine;

public class RockController : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y <= -29.4f)
        {
            Destroy(gameObject);
        }
    }
}
