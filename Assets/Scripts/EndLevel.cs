using UnityEngine;

public class EndLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnlockEnd.completedLevels++;
        StartScene.start("ChooseDifficulty");
    }
}
