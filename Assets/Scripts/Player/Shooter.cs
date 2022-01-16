using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D rg = bullet.GetComponent<Rigidbody2D>();
        
        rg.velocity = new Vector2(speed * transform.localScale.x, rg.velocity.y);
    }

}
