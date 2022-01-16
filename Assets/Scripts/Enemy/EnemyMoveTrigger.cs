using UnityEngine;

public class EnemyMoveTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {

            collision.gameObject.transform.localScale = new Vector3(collision.gameObject.transform.localScale.x * -1, 1, 1);
            collision.gameObject.GetComponent<EnemyRunnerScript>().speed *= -1;
        }
    }
}
