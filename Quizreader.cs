using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizreader : MonoBehaviour
{
    public TextAsset CSVfile;
    public List<string[]> csvData = new List<string[]>();
    public Text Quiz, Select1, Select2, Select3, Select4, Count;
    string Answer;
    public int count = 0;
    public Text CorrectText, IncorrectanswerText;
    //private AudioSource[] source;
    public CanvasGroup Select1off, Select2off, Select3off, Select4off, AnsCount;

    // Use this for initialization
    void Start()
    {
        //source = gameObject.GetComponents<AudioSource>();
        Select1off.alpha = 1;
        Select2off.alpha = 1;
        Select3off.alpha = 1;
        Select4off.alpha = 1;
        AnsCount.alpha = 1;
        QuizLoad();
    }

    //CSVfileを読み込み、リストにカンマ区切りで格納
    public void QuizLoad()
    {
        string[] lines = CSVfile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (string line in lines)
        {
            if (line == "") { continue; }
            csvData.Add(line.Split(','));
        }
        //ランダムな数をRandomNumに入れて、csvDataから呼び出す
        int RandomNum = Random.Range(0, 32);
        Quiz.text = csvData[RandomNum][0];
        Answer = csvData[RandomNum][1];
        Select1.text = csvData[RandomNum][2];
        Select2.text = csvData[RandomNum][3];
        Select3.text = csvData[RandomNum][4];
        Select4.text = csvData[RandomNum][5];
    }

    public void Display1()
    {             //選択肢1の判定
        if (Answer == Select1.text)
        {
            CorrectText.text = "正解";
           // source[0].Play();
            count++;
            Count.text = "正解数:" + count;
            StartCoroutine("NextQuestion");


        }
        else if (Answer != Select1.text)
        {
            IncorrectanswerText.text = "不正解";
            //source[1].Play();
            StartCoroutine("NextQuestion");

        }
    }
    public void Display2()
    {              
        //選択肢2の判定
        if (Answer == Select2.text)
        {
            CorrectText.text = "正解";
            //source[0].Play();
            count++;
            Count.text = "正解数:" + count;
            StartCoroutine("NextQuestion");
        }
        else if (Answer != Select2.text)
        {
            IncorrectanswerText.text = "不正解";
           // source[1].Play();
            StartCoroutine("NextQuestion");
        }
    }
    public void Display3()
    {               
        //選択肢3の判定
        if (Answer == Select3.text)
        {
            CorrectText.text = "正解";
           // source[0].Play();
            count++;
            Count.text = "正解数:" + count;
            StartCoroutine("NextQuestion");
        }
        else if (Answer != Select3.text)
        {
            IncorrectanswerText.text = "不正解";
            //source[1].Play();
            StartCoroutine("NextQuestion");
        }
    }
    public void Display4()
    {               
        //選択肢4の判定
        if (Answer == Select4.text)
        {
            CorrectText.text = "正解";
            //source[0].Play();
            count++;
            Count.text = "正解数:" + count;
            StartCoroutine("NextQuestion");
        }
        else if (Answer != Select4.text)
        {
            IncorrectanswerText.text = "不正解";
            //source[1].Play();
            StartCoroutine("NextQuestion");

        }
    }

    public void ButtonOff()
    {
        Select1off.alpha = 0;
        Select2off.alpha = 0;
        Select3off.alpha = 0;
        Select4off.alpha = 0;
    }
    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(0.5f);
        yield return null;
        CorrectText.text = "";
        IncorrectanswerText.text = "";
        QuizLoad();//次の問題を表示
    }

}