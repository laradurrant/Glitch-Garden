using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveProjectile : MonoBehaviour {

    public float movementSpeed = 1f;


    // Use this for initialization
    void Start () {
  
    }

    // Update is called once per frame
    void Update () {

   

       // transform.Rotate(Vector2.up, 10 * movementSpeed * Time.deltaTime);

        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
    }
}
