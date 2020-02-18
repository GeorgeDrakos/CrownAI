using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionChooser : MonoBehaviour
{
    Text questionText;
    Text score;
    QuestionGen newQ;
    QuestionGen exampleQ;

    void Start() {
        newQ = generateQuestion();
        //newQ = new QuestionGen(1,2,'<',true);
        Debug.Log(newQ.toString());
        questionDisplay(newQ);
    }
    public void questionDisplay(QuestionGen generatedQ) {
        questionText = GameObject.Find("Question").GetComponent<Text>();
        questionText.text = generatedQ.toString();
        score = GameObject.Find("Score").GetComponent<Text>();

    }
    public void answerTrue() {
        if (newQ.answer == true) {
            Debug.Log("This is correct, you win!");

        } else {
            Debug.Log("This is wrong :(");

        }
    }
    public void answerFalse() {
        if (newQ.answer == false) {
            Debug.Log("This is correct, you win!");

        } else {
            Debug.Log("This is wrong :(");
        }
    }

    public QuestionGen generateQuestion() {

         int LHS = Random.Range(1, 100);
         int RHS = Random.Range(2, 100);

        if (LHS > RHS) {
            LHS = Random.Range(1, 100);
            RHS = Random.Range(2, 100);
        }
        else {
           exampleQ = new QuestionGen(LHS, RHS, '<', true);
        }
        return exampleQ;
    }
}