using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour {
    [SerializeField] private int hp = 5;
    [SerializeField] private int dmg = 1;
    [SerializeField] private float spd = 0.1f;
    [SerializeField] private bool alive = true;
    [SerializeField] private int lvl = 1;
    GameObject me;
    // Start is called before the first frame update
    void Start() {
        me = new GameObject();
    }

    // Update is called once per frame
    void Update() {
    }

    void die() {
        if (hp == 0) {
            Destroy(me);
        }
    }
}
