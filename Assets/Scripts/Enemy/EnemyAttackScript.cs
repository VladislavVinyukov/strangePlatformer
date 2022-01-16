using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Vector2 direction = collision.gameObject.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(direction.normalized * 3, ForceMode2D.Impulse);
        }
    }
}
