using UnityEngine;

public class EndLevel : MonoBehaviour
{
    AudioSource endLevelSound;
    bool completed = false;

    void Start()
    {
        completed = false;
        endLevelSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (completed)
        {
            if(!endLevelSound.isPlaying)
            {
                UnlockEnd.completedLevels++;
                StartScene.start("ChooseDifficulty");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!completed)
        {
            endLevelSound.Play();
            completed = true;
        }
    }
}
