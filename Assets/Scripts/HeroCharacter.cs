using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCharacter : MonoBehaviour {
    // Start is called before the first frame update

    // initiating variables
    [SerializeField] private int hp = 5;
    [SerializeField] private int dmg = 1;
    [SerializeField] private float spd = 32;
    [SerializeField] private bool alive = true;
    [SerializeField] private int lvl = 1;
    [SerializeField] private int exp = 0;

    void Start() {
    }

    // Update is called once per frame
    void Update() {
        checkMovement();

    }

    void checkMovement() {
        // Character movement
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.position = new Vector3(transform.position.x + spd, transform.position.y, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.position = new Vector3(transform.position.x - spd, transform.position.y, 0.0f);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.position = new Vector3(transform.position.x, transform.position.y + spd, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            transform.position = new Vector3(transform.position.x, transform.position.y - spd, 0.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.tag.Equals("Enemy")) { // checks the tag of the colliding objects
            Debug.Log("I hit an enemy");
        } else {
            Debug.Log("I didn't hit an enemy");
        }
     //TODO fix it
    }
}
