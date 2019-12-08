using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecisionManager : MonoBehaviour {


    public void True() {
        Debug.Log("Nope, the answer is false");

    }

    public void False() {
        Debug.Log("Correct!");
    }
}
