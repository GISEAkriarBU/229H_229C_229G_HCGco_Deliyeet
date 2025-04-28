using UnityEngine;

public class Detect_HIt : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            GameManager.Instance.AddScore(50);
            Destroy(gameObject);
        }
    }
}
