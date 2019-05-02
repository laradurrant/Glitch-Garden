using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    GameObject projectile;
    public GameObject prefab;
    public float movementSpeed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void FireProjectile()
    {
        projectile = Instantiate(prefab, this.gameObject.transform.position, Quaternion.identity);
       
    }
}
