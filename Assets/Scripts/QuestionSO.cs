using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField]string question = "Enter new quesiton here";
    [SerializeField]string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;
    
    public string GetQuestion()
    {
        return question;
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
    public string GetAnswer(int index)
    {//this is passing int index and returns string answer
        return answers[index];
    }
}
