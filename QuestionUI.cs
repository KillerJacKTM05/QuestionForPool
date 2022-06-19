using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUI : MonoBehaviour
{
    [SerializeField] private GameObject timer;
    [SerializeField] private List<GameObject> choices;
    [SerializeField] private GameObject questionText;
    [SerializeField] private InputField playerInputField;
    private string input;
    //UI setter class;
    public GameObject getQuestionText()
    {
        return questionText;
    }
    public List<GameObject> getChoices()
    {
        return choices;
    }
    public GameObject getTimer()
    {
        return timer;
    }
    public string getFieldText()
    {
        return input;
    }

    public void setInput()              //call on end edit
    {
        input = playerInputField.text;
        //Debug.Log("player input:" + input);
        MenuManager.instance.Answer(0);
    }
    public void setTimer(int Time)
    {
        Text timeText = timer.GetComponentInChildren<Text>();
        timeText.text = Time.ToString();
        //MenuManager.instance.QuestionTimer(Time, getTimer());
    }
    public void setQuestionText(string Text)
    {
        Text qText = questionText.GetComponent<Text>();
        qText.text = Text;
        qText.alignment = TextAnchor.MiddleLeft;
    }
    public void setChoices(List<string> list)
    {
        for(int i = 0; i < choices.Count; i++)
        {
            Text tex = choices[i].GetComponentInChildren<Text>();
            tex.text = list[i];
        }

    }
}
