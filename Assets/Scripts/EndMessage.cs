using UnityEngine;

public class EndMessage : MonoBehaviour
{
    public GameObject endMessage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        endMessage.SetActive(true);
    }
}
