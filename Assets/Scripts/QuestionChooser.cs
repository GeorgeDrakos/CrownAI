using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuestionChooser : MonoBehaviour
{
    Text questionText;
    Text score;
    QuestionGen newQ;
    QuestionGen exampleQ;
    int opChoice;

    void Start() {
        newQ = generateQuestion();
        Debug.Log(newQ.toString());
        questionDisplay(newQ);
    }
    public void questionDisplay(QuestionGen generatedQ) {
        questionText = GameObject.Find("Question").GetComponent<Text>();
        questionText.text = generatedQ.toString();
    }


    public void answerTrue() {
        if (newQ.answer == true) {
            Debug.Log("This is correct, you win!");

        } else {
            Debug.Log("This is wrong :(");

        }
        endOfFight();
    }
    public void answerFalse() {
        if (newQ.answer == false) {
            Debug.Log("This is correct, you win!");
            
        } else {
            Debug.Log("This is wrong :(");
        }
        endOfFight();
    }

    public QuestionGen generateQuestion() {

         int LHS = Random.Range(0, 100);
         int RHS = Random.Range(0, 100);
         opChoice = Random.Range(0, 100);

        if (opChoice >= 50) {
            if (LHS > RHS) {
                exampleQ = new QuestionGen(LHS, RHS, '<', false);
            } else if (LHS < RHS) {
                exampleQ = new QuestionGen(LHS, RHS, '<', true);
            }
        } else if (opChoice <= 100) {

            if (LHS > RHS) {
                exampleQ = new QuestionGen(LHS, RHS, '>', true);
            } else if (LHS < RHS) {
                exampleQ = new QuestionGen(LHS, RHS, '>', false);
            }
        }
        return exampleQ;
        }

    public void endOfFight() {
        SceneManager.LoadScene(0);
    }
}