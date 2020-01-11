using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject enemyPrefab;
    public int enemyDifficulty;
    // Start is called before the first frame update
    void Start() {
        //for (int x = 0; x == enemyDifficulty; x++) {
        //Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0 ,0);
        //Instantiate(enemyPrefab, position, Quaternion.identity);
        //Debug.Log("Enemy instantiated");
        //Debug.Log("enemy number" + x);
        //detecting all enemies for debug purposes
        //}

        for (int i = 0; i < enemyDifficulty; i++) {
            Instantiate(enemyPrefab, new Vector3(Random.Range(1f, 750f), Random.Range(1f, 340f), 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
