using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.Play("Disappearing");
        }
    }

    public void DestroyPlatform()
    {
        Destroy(gameObject, 0.5f);
    }
}
