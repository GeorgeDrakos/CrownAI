using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject enemyPrefab;
    void Start() {

        for (int i = 0; i < 3; i++) {
            Instantiate(enemyPrefab, new Vector3(Random.Range(200f, 700f), Random.Range(70f, 300f), 0), Quaternion.identity);
            Debug.Log("Enemy instantiated");
            Debug.Log("enemy number: " + i);
            //detecting all enemies for debug purposes
        }
    }
}
