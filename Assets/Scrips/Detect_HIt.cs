using UnityEngine;

public class Detect_HIt : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Box"))
        {

            // Add score
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(50);
            }

            // Destroy projectile
            Destroy(gameObject);
        }
       
    }
}
