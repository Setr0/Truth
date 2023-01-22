using UnityEngine;

public class EnableSoundtrack : MonoBehaviour
{
    public AudioSource soundtrack;

    private void Start()
    {
        if (GameObject.FindGameObjectsWithTag("soundtrack").Length == 0)
        {
            soundtrack.Play();
        }
    }
}
