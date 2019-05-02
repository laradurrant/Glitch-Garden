using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Health health;
    private float damage = 50f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
  
        if (collision.CompareTag("Projectile"))
        {
          //  Debug.Log("Projectile Detected");
            Destroy(collision.gameObject);
            damage = collision.gameObject.GetComponent<ProjectileDamage>().GetDamage();
            health = this.gameObject.GetComponent<Health>();
            health.DealDamage(damage);
        }
    }
}
