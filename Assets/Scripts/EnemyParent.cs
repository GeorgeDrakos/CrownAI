using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour {
    [SerializeField] private int hp = 5;
    [SerializeField] private int dmg = 1;
    [SerializeField] private float spd = 0.1f;
    [SerializeField] private bool alive = true;
    [SerializeField] private int lvl = 1;

    public int Hp { get => hp; set => hp = value; }
    public int Dmg { get => dmg; set => dmg = value; }
    public float Spd { get => spd; set => spd = value; }
    public bool Alive { get => alive; set => alive = value; }
    public int Lvl { get => lvl; set => lvl = value; }

    GameObject me;
    // Start is called before the first frame update
    void Start() {
        me = new GameObject();
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
