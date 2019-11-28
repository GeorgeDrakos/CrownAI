using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour {
    [SerializeField] private int hp = 5;
    [SerializeField] private bool alive = true;
    [SerializeField] private int lvl = 1;

    public int Hp { get => hp; set => hp = value; }
    public bool Alive { get => alive; set => alive = value; }
    public int Lvl { get => lvl; set => lvl = value; }

    GameObject me;
    // Constructor for enemies / will assist in randomizing position of the enemies
    public EnemyParent(int x,int y, int hp, bool alive, int lvl) {
        //x = x position of enemy
        // y = y position of enemy
        hp = this.hp;
        alive = this.alive;
        lvl = this.lvl;
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
