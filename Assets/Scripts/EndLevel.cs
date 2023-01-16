using UnityEngine;

public class EndLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartScene.start("ChooseDifficulty");
    }
}
