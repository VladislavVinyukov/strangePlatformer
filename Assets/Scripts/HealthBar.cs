using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private SpriteRenderer healthBarSprite;

    public void ChangeUIHealth(float maxHealth, float currentHealth)
    {
        healthBarSprite.size = new Vector2(currentHealth/maxHealth, healthBarSprite.size.y);
    }
}
