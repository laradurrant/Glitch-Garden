using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    
    [Range (0f, 5f)]
    public float movementSpeed;

	// Use this for initialization
	void Start () {
        movementSpeed = 0f;
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);

	}

    public void SetMovementSpeed(float speed)
    {
        movementSpeed = speed;
    }

}
