using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionHandler : MonoBehaviour
{
    public GameObject correctPanel;

    public GameObject wrongPanel;

    public GameObject close;

    public GameObject Answered_Warn;

    public Text ScoreText;

    public GameObject CloseRightWrongBtn;

    public GameObject btnA;

    public GameObject btnB;

    public GameObject btnC;

    public GameObject btnD;

    public GameObject DetailAnsButton;

    public GameObject DetailAnsPanel;

    public Sprite[] detailAnsImages;

    public int Ans;

    int nowQuestion;

    int score = 0;

    public bool[] haveAnswered;

    public bool[] haveAnsweredAndRight;

    // public GameObject[] badges;
    public GameObject badgeTW;

    public GameObject badgeChild;

    public GameObject badgeRainForest;

    public GameObject badgeAustralia;

    public GameObject badgeDesert;

    public GameObject badgeAfica;

    public GameObject badgeBird;

    public GameObject badgeClimbBug;

    public GameObject badgeWarm;

    public int[] Answers;

    public void getStudentAns(int studentAns)
    {
        if (haveAnswered[nowQuestion - 1] == true)
        {
            // now question have been answered
            Answered_Warn.SetActive(true);
			DetailAnsButton.SetActive(true);
            return;
        }
        CloseRightWrongBtn.SetActive(true);
        if (studentAns == Ans)
        {
            correct();
        }
        else
        {
            wrong();
        }
        haveAnswered[nowQuestion - 1] = true;
    }

    public void initQuestion(int questionID)
    {
        hideAll();
        nowQuestion = questionID;
        Ans = Answers[questionID - 1];
        correctPanel.SetActive(false);
        wrongPanel.SetActive(false);
        showBtns();
    }

    public void correct()
    {
        score++;
        ScoreText.text = "" + score;
		haveAnsweredAndRight[nowQuestion-1]=true;
        correctPanel.SetActive(true);
        wrongPanel.SetActive(false);
        DetailAnsButton.SetActive(true);
        if (
            haveAnsweredAndRight[0] &&
            haveAnsweredAndRight[1] &&
            haveAnsweredAndRight[2]
        ) badgeTW.SetActive(true);
        if (
            haveAnsweredAndRight[3] &&
            haveAnsweredAndRight[4] &&
            haveAnsweredAndRight[5]
        ) badgeChild.SetActive(true);
        if (
            haveAnsweredAndRight[6] &&
            haveAnsweredAndRight[7] &&
            haveAnsweredAndRight[8]
        ) badgeRainForest.SetActive(true);
        if (haveAnsweredAndRight[9] && haveAnsweredAndRight[11])
            badgeAustralia.SetActive(true);
        if (haveAnsweredAndRight[10]) badgeDesert.SetActive(true);
        if (
            haveAnsweredAndRight[12] &&
            haveAnsweredAndRight[13] &&
            haveAnsweredAndRight[14]
        ) badgeAfica.SetActive(true);
        if (
            haveAnsweredAndRight[15] &&
            haveAnsweredAndRight[16] &&
            haveAnsweredAndRight[17]
        ) badgeBird.SetActive(true);
        if (
            haveAnsweredAndRight[18] &&
            haveAnsweredAndRight[19] &&
            haveAnsweredAndRight[20]
        ) badgeClimbBug.SetActive(true);
        if (
            haveAnsweredAndRight[21] &&
            haveAnsweredAndRight[22] &&
            haveAnsweredAndRight[23]
        ) badgeWarm.SetActive(true);
    }

    public void wrong()
    {
        wrongPanel.SetActive(true);
        correctPanel.SetActive(false);
        DetailAnsButton.SetActive(true);
    }

    public void showBtns()
    {
        btnA.SetActive(true);
        btnB.SetActive(true);
        btnC.SetActive(true);
        btnD.SetActive(true);
    }

    public void hideAll()
    {
        btnA.SetActive(false);
        btnB.SetActive(false);
        btnC.SetActive(false);
        btnD.SetActive(false);
        correctPanel.SetActive(false);
        wrongPanel.SetActive(false);
        Answered_Warn.SetActive(false);
        CloseRightWrongBtn.SetActive(false);
        DetailAnsButton.SetActive(false);
        DetailAnsPanel.SetActive(false);
    }

    public void showDetailAnsPanel()
    {
        hideAll();
        DetailAnsPanel.SetActive(true);
        Image image = DetailAnsPanel.GetComponent<Image>();
        image.sprite = detailAnsImages[nowQuestion - 1];
    }

    // Start is called before the first frame update
    void Start()
    {
        hideAll();
        haveAnswered = new bool[24];
        haveAnsweredAndRight = new bool[24];
        for (int i = 0; i < 24; i++)
        {
            haveAnswered[i] = false;
            haveAnsweredAndRight[i] = false;
        }
        ScoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
    }
}
