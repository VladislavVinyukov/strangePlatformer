using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float speed;
    [SerializeField] private float shootInterval=2;
    private float currentShootTime;
    [SerializeField] private GameObject bulletPrefab;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D rg = bullet.GetComponent<Rigidbody2D>();

        rg.velocity = new Vector2(speed * transform.localScale.x, rg.velocity.y);
    }

    private void Awake()
    {
        currentShootTime = shootInterval;
    }

    private void Update()
    {
        if (currentShootTime < 0)
        {
            Shoot();
            currentShootTime = shootInterval;
        }
        else
        {
            currentShootTime -= Time.deltaTime;
        }
    }
}
