using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text TimeText,Over,Quiz,Count;
    [SerializeField]
    float MaxTime,CurrentTime;
    float NowTime;
    public GameObject obj;
    public CanvasGroup canvasGroup,bt1,bt2,bt3,bt4;
  
    // Use this for initialization
    public void Start(){
        canvasGroup.alpha = 0;
    }

    // Update is called once per frame
    public void Update(){
        NowTime += Time.deltaTime;
        CurrentTime = MaxTime - NowTime;   //現在時間の計測（現在時間＝最大時間ー経過時間）

        if (CurrentTime < 0)  //カウントが0になったら計測終了
        {
            canvasGroup.alpha = 1;
            Over.text = "タイムアップ";
            CurrentTime = 0;
            StartCoroutine("Result");
        }
        TimeText.text = CurrentTime.ToString("F2");
    }
    public void CountAgain()
    {
        NowTime = 0;
        Time.timeScale = 1;
    }
    IEnumerator Result()
    {
        yield return new WaitForSeconds(2.0f);
        yield return null;
        bt1.alpha = 0;
        bt2.alpha = 0;
        bt3.alpha = 0;
        bt4.alpha = 0;
        bt1.interactable = false;
        bt2.interactable = false;
        bt3.interactable = false;
        bt4.interactable = false;
        Over.text = "";
        Quiz.text = "";
        Count.text = "";
        obj.SetActive(false);
        TimeText.text = "";
        //GetComponent<WallDestroy>().enabled = true;
        //result.text = GameObject.Find("QuizObject").GetComponent<CSVreader>().
    }
}

