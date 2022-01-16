using UnityEngine;

public class FinishSpotScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<BonusCollector>().showFinishPanel();
            collision.gameObject.GetComponent<PlayerMovement>().allreadyFinished = true;
        }
    }
}
