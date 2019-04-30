using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab;
    public bool spawn = true;
    [Range (0.1f, 3f)]
    public float minWaitTime = 0.4f;

    [Range(1f, 10f)]
    public float maxWaitTime = 3.0f;

    private float waitTime;
    private int lane_number;
    private float y_position;
    private Vector2 new_vector;
    private GameObject enemy;

    // Use this for initialization
    void Start () {

        enemy = this.gameObject;

        if (spawn)
        {
            StartCoroutine("SpawnEnemies");
        }

    }

    IEnumerator SpawnEnemies()
    {
        while (spawn)
        {
            SpawnAttacker();
            yield return new WaitForSeconds(waitTime);
        }
    }

    void SpawnAttacker()
    {
        lane_number = Random.Range(0, 5);
        waitTime = Random.Range(minWaitTime, maxWaitTime);
        y_position = transform.position.y - 1f * lane_number;
        new_vector = new Vector2(transform.position.x, y_position);
        enemy = Instantiate(enemyPrefab, new_vector, Quaternion.identity) as GameObject;
       
    }
	
	// Update is called once per frame
	void Update () {

        if(!spawn)
        {
            StopCoroutine("spawnEnemies");
        }
	}


}
