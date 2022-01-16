using UnityEngine;

public class BonusValueScript : MonoBehaviour
{
    public int bonusValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BonusCollector bonusCollector = collision.gameObject.GetComponent<BonusCollector>();
        if (bonusCollector != null)
        {
            bonusCollector.countBonus += bonusValue;
            Destroy(gameObject);
        }
        
    }
}
