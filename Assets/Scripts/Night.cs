using UnityEngine;

public class Night : MonoBehaviour
{
    public new Camera camera;
    public GameObject starsGroup;
    public Color color;

    void setNight()
    {
        camera.backgroundColor = color;
        starsGroup.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        setNight();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        setNight();
    }
}
