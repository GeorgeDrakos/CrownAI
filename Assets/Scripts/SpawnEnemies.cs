using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject enemyPrefab;
    public int enemyDifficulty;
    // Start is called before the first frame update
    void Start() {
        for (int x = 0; x == enemyDifficulty; x++) {
            Vector2 position = new Vector2(Random.Range(-10.0f, 10.0f), 0);
            Instantiate(enemyPrefab, position, Quaternion.identity);
            Debug.Log("enemy number" + x);
            //detecting all enemies for debug purposes
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
