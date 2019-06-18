using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class endlessController : MonoBehaviour
{
    
    public TextMeshProUGUI FirstNumber;
    public TextMeshProUGUI Sign;
    public TextMeshProUGUI SecondNumber;
    public TextMeshProUGUI Score;
    public Text Answer;
    public TextMeshProUGUI FinalScore;
    public GameObject LosePanel;
    public bool genNumber =  true;
    public int num1, num2, sign, anw;
    int counter = 1;
    int score = 0;
    public InputField inputfieldname;
    public AudioClip CorrectAnswer;
    public AudioClip WrongAnswer;
    public AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (genNumber == true)
        {
            genNumber = false;
            sign = GetRandomNumber(1,3);
            num1 = GetRandomNumber(1, 100);
            num2 = GetRandomNumber(1, 100);
        }
        FirstNumber.text = num1.ToString();
        if (sign == 1)
            Sign.text = "+";
        else
            Sign.text = "x";
        SecondNumber.text = num2.ToString();
    
    }

    public void Submit()
    { if (Answer.text != "") { 
       anw = int.Parse(Answer.text);

        if (((sign == 1) && (num1 + num2 == anw)) || ((sign == 2) && (num1 * num2 == anw)))
        {
            Debug.Log("correct");
            musicSource.clip = CorrectAnswer;
            musicSource.Play(0);
            inputfieldname.Select();
            inputfieldname.text = "";
            score = score + counter * 10;
            Score.text = score.ToString();
            counter++;
            genNumber = true;
        }
        else
        {
            Debug.Log("wrong");
            musicSource.clip = WrongAnswer;
            musicSource.Play(0); 
            LosePanel.SetActive(true);
            FinalScore.text = score.ToString();
            counter = 1;
            score = 0;
        }
      }
    }

    public void ClosePanel()
    {
        LosePanel.SetActive(false);
        genNumber = true;
        inputfieldname.Select();
        inputfieldname.text = "";


    }





    private static readonly System.Random getrandom = new System.Random();

    public static int GetRandomNumber(int min, int max)
    {
        lock (getrandom) // synchronize
        {
            return getrandom.Next(min, max);
        }
    }
}
