using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour {
    public Text question;
    public bool answer;

    void Start() {
        //TODO: implement a way to select a different question everytime combat happens
        question.text = "5 < 5";
        answer = 5 < 5;
    }
}
