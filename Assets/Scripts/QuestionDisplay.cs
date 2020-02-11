using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour {
    public Text question;
    public string n;
    void Awake() {
        //TODO: implement a way to select a different question everytime combat happens
        //Populating the array with questions
        string[,] Questions = new string[2,2] { { "5 < 5", "False" }, { "8 < 23", "True" } } ;
        string n = (Random.Range(0, 2).ToString());
        Debug.Log(Questions(n,0));
        //question.setText = Questions[n, 0];
    }
}
