using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public static void start(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
