using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class HeroCharacter : MonoBehaviour {

    // initiating variables
    public float spd;
    public int dmg;
    public float Spd { get => spd; set => spd = value; }
    public int Dmg { get => dmg; set => dmg = value; }

    float X, Y; // direction received from buttons in order to move the main character



    void Update() {
        checkMovement();
    }

    void checkMovement() {
                // Character movement with keyboard ONLY FOR USSER STUDY PURPOSES
                if (Input.GetKeyDown(KeyCode.RightArrow)) {
                    moveRight();
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                    moveLeft();
                }
                if (Input.GetKeyDown(KeyCode.UpArrow)) {
                    moveUp();
                }
                if (Input.GetKeyDown(KeyCode.DownArrow)) {
                    moveDown();
                } 


        // Character movement with buttons
        X = CrossPlatformInputManager.GetAxis("Horizontal") * Spd;
        Y = CrossPlatformInputManager.GetAxis("Vertical") * Spd;

        // Changing position of hero character
        transform.position = new Vector2(transform.position.x + X, transform.position.y + Y);
    }

    public void moveLeft() {
        transform.position = new Vector3(transform.position.x - spd, transform.position.y, 0.0f);
    }
    public void moveRight() {
        transform.position = new Vector3(transform.position.x + spd, transform.position.y, 0.0f);
    }
    public void moveUp() {
        transform.position = new Vector3(transform.position.x, transform.position.y + spd, 0.0f);
    }
    public void moveDown() {
        transform.position = new Vector3(transform.position.x, transform.position.y - spd, 0.0f);
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
