using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public GameObject explosionPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().SetTrigger("isPressed");
    }

    public void ExplosionFunc()
    {
        explosionPoint.SetActive(true);
        Destroy(explosionPoint, 0.1f);
    }
}
