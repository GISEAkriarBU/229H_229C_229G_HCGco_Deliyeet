using UnityEngine;

public class Spinplatform : MonoBehaviour
{
    [SerializeField] private float torqueForce = 10f; // Adjust this to spin faster/slower

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic; // Must be Dynamic to use torque
        rb.gravityScale = 0f; // Make sure gravity doesn't affect it
    }

    void FixedUpdate()
    {
        rb.AddTorque(torqueForce);
    }
}
