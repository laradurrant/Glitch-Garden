using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Health : MonoBehaviour {

    public GameObject ps;
    private float health;
    private float damage = 50f;
    GameObject deathVFXObject;


    private void Start()
    {
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);

            deathVFXObject = Instantiate(ps, this.transform.position, Quaternion.identity   );
            deathVFXObject.GetComponentInChildren<ParticleSystem>().Play();
            Destroy(deathVFXObject, 2f);
      
            
        }
    }


}
