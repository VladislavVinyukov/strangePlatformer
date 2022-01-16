using UnityEngine;

public class EnemyRunnerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Health health;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Health>();
    }

    void Update()
    {
        if (!health.isAlive) return;

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
