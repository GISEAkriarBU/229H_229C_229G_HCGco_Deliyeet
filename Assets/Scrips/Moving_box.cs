using UnityEngine;

public class Moving_box : MonoBehaviour
{
    public Vector2 minBounds, maxBounds;
    private Vector2 targetPosition;

    void Start() => PickNewTarget();

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5f);

        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
            PickNewTarget();
    }

    void PickNewTarget()
    {
        targetPosition = new Vector2(Random.Range(minBounds.x, maxBounds.x), Random.Range(minBounds.y, maxBounds.y));
    }
}
