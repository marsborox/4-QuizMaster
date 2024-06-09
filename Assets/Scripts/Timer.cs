using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuesiton = 30f; //time to solve quesiton
    [SerializeField] float timeToShowCorrectAnswer = 4f; //time ot resolve the answer

    //nowe variable to pick whichever itmer
    public bool loadNextQuestion;
    public bool isAnsweringQuesiton = false;
    public float fillFraction;

    float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }
    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        //if im answering quesiton
        if (isAnsweringQuesiton)
        {
            if (timerValue > 0)//and timer is running
            {//how much time remaisnt in fraciton
                fillFraction = timerValue / timeToCompleteQuesiton;
            }
            else
            {//so timer is 0 swap timer and set question answering
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuesiton = false;
            }
        }
        else
        {//if im not answering question
            if (timerValue > 0)
            {//timer is running how much time remains fraction
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {   //timer 0 set timer and set quesiton answering
                timerValue = timeToCompleteQuesiton;
                isAnsweringQuesiton = true;
                //also load next question
                loadNextQuestion = true;
            }
        }
        //Debug.Log(isAnsweringQuesiton + ": " +timerValue + " = "+fillFraction);
    }    


}
