using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour {

    public int hp;
    private bool alive = true;
    private int lvl = 1;

    public int Hp { get => hp; set => hp = value; }
    public bool Alive { get => alive; set => alive = value; }
    public int Lvl { get => lvl; set => lvl = value; }

    void Start() {

    }
    // Update is called once per frame
    void Update() {
            if (hp <= 0) {
                die();
            }
        }

    void OnTriggerEnter2D(Collider2D col) {
            Debug.Log(Hp);
        }

    public void takeDmg(int amount) {
        hp -= amount;
    }

    void die() {
            Alive = false;
    }
}
