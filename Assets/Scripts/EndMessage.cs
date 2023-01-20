using UnityEngine;

public class EndMessage : MonoBehaviour
{
    public GameObject endPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        endPanel.SetActive(true);
    }
}
