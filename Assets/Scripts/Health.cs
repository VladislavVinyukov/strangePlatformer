using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private HealthBar healthBar;
    private float currentHealth;
    [HideInInspector] public bool isAlive;
    private Animator animator;

    private void Awake()
    {
        healthBar = GetComponent<HealthBar>();
        animator = GetComponent<Animator>();
        
        currentHealth = maxHealth;
        isAlive = true;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        if (healthBar != null)
        {
            healthBar.ChangeUIHealth(maxHealth, currentHealth);
        }
        CheckAlive();
    }

    private void CheckAlive()
    {
        if (currentHealth > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false;
            animator.Play("death");
        }
    }
    public void Destroy()
    {
        if (gameObject.CompareTag("Player"))
            GetComponent<MainElements>().uIScript.ShowDeathPanel();
        Destroy(gameObject);
    }
}
