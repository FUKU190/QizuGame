using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSVreader : MonoBehaviour
{
    public TextAsset CSVfile;
    public List<string[]> csvDatas = new List<string[]>();
    public Text Quiz,Select1, Select2, Select3, Select4,Count;
    string Answer;
    public int count2 = 0;
    public Text CorrectText, IncorrectanswerText;
    private AudioSource[] sources;
    public CanvasGroup Select1off, Select2off, Select3off, Select4off,AnsCount;

    // Use this for initialization
    void Start(){
       // sources = gameObject.GetComponents<AudioSource>();
        Select1off.alpha = 1;
        Select2off.alpha = 1;
        Select3off.alpha = 1;
        Select4off.alpha = 1;
        AnsCount.alpha = 1;
        QuizLoad2();
    }

    //CSVfileを読み込み、リストにカンマ区切りで格納
    public void QuizLoad2(){
        string[] lines = CSVfile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (string line in lines){
            if (line == "") { continue; }
            csvDatas.Add(line.Split(','));
        }
        //ランダムな数をRandomNumに入れて、csvDataから呼び出す
        int RandomNum = Random.Range(0, 32);
        Quiz.text = csvDatas[RandomNum][0];
        Answer = csvDatas[RandomNum][1];
        Select1.text = csvDatas[RandomNum][2];
        Select2.text = csvDatas[RandomNum][3];
        Select3.text = csvDatas[RandomNum][4];
        Select4.text = csvDatas[RandomNum][5];
    }
    
    public void Display1(){             //選択肢1の判定
        if (Answer == Select1.text){
            CorrectText.text = "正解";
           // sources[0].Play();
            count2++;
            Count.text = "正解数:" + count2;
            StartCoroutine("NextQuestion2");


        }
        else if (Answer != Select1.text){
            IncorrectanswerText.text = "不正解";
            //sources[1].Play();
            StartCoroutine("NextQuestion2");

        }
    }
    public void Display2(){               //選択肢2の判定
        if (Answer == Select2.text){
            CorrectText.text = "正解";
            //sources[0].Play();
            count2++;
            Count.text = "正解数:" + count2;
            StartCoroutine("NextQuestion2");
        }
        else if (Answer != Select2.text){
            IncorrectanswerText.text = "不正解";
            //sources[1].Play();
            StartCoroutine("NextQuestion2");
        }
    }
    public void Display3(){               //選択肢3の判定
        if (Answer == Select3.text){
            CorrectText.text = "正解";
            //sources[0].Play();
            count2++;
            Count.text = "正解数:" + count2;
            StartCoroutine("NextQuestion2");
        }
        else if (Answer != Select3.text){
            IncorrectanswerText.text = "不正解";
            //sources[1].Play();
            StartCoroutine("NextQuestion2");
        }
    }
    public void Display4(){                //選択肢4の判定
        if (Answer == Select4.text){
            CorrectText.text = "正解";
            //sources[0].Play();
            count2++;
            Count.text = "正解数:" + count2;
            StartCoroutine("NextQuestion2");
        }
        else if (Answer != Select4.text)
        {
            IncorrectanswerText.text = "不正解";
            //sources[1].Play();
            StartCoroutine("NextQuestion2");

        }
    }
    
    public void ButtonOff(){
        Select1off.alpha = 0;
        Select2off.alpha = 0;
        Select3off.alpha = 0;
        Select4off.alpha = 0;
    }
      IEnumerator NextQuestion2(){
        yield return new WaitForSeconds(0.5f);
        yield return null;
        CorrectText.text = "";
        IncorrectanswerText.text = "";
        QuizLoad2();//次の問題を表示
    }

}


