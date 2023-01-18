using UnityEngine;

public class UnlockEnd : MonoBehaviour
{
    public static int completedLevels;
    public GameObject endButton;

    void Update()
    {
        if(completedLevels >= 3)
        {
            endButton.SetActive(true);
        }
    }
}
