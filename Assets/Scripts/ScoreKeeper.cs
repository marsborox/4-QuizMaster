using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;
    public int GetCorrectAnswer()
    {
        return correctAnswers;
    }
    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }
    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }
    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }
    public int CalculateScore()
    {//if it would be kept all as int
        //it would round down to 0
        //this is how we can divide int by float
        //and get reasonable result
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen*100);
    }
}
