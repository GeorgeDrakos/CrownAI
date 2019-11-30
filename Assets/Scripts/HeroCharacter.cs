using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroCharacter : MonoBehaviour {

    // initiating variables
    [SerializeField] private int hp = 5;
    [SerializeField] private int dmg = 1;
    [SerializeField] private float spd = 32;
    [SerializeField] private bool alive = true;
    [SerializeField] private int lvl = 1;
    [SerializeField] private int exp = 0;

    public int Hp { get => hp; set => hp = value; }
    public int Dmg { get => dmg; set => dmg = value; }
    public float Spd { get => spd; set => spd = value; }
    public bool Alive { get => alive; set => alive = value; }
    public int Lvl { get => lvl; set => lvl = value; }
    public int Exp { get => exp; set => exp = value; }

    void Start() {

    }

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

            EnemyParent enemy = col.GetComponent<EnemyParent>();
            enemy.takeDmg(Dmg);
            SceneManager.LoadScene(1);
            Debug.Log("Enemy Hp: " + enemy.Hp + " Damage dealt: " + Dmg);
        } else {
            Debug.Log("If you see this there is a bug with collision detection :)");
        }
    }
}
