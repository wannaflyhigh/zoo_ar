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

	public int Ans;
	int nowQuestion;
	int score=0;

	public bool[] haveAnswered;

	public void getStudentAns(int studentAns){
		if(haveAnswered[nowQuestion-1]==true){
			// now question have been answered
			Answered_Warn.SetActive(true);
			return;
		}
		CloseRightWrongBtn.SetActive(true);
		if(studentAns==Ans){
			correct();
		}else{
			wrong();
		}
		haveAnswered[nowQuestion-1]=true;
	}

	public void setAns(int ans){
		Ans=ans;
		correctPanel.SetActive(false);
		wrongPanel.SetActive(false);
	}

	public void setNowQuestion(int questionID){
		nowQuestion=questionID;
	}

	public void correct(){
		score++;
		ScoreText.text=""+score;
		correctPanel.SetActive(true);
		wrongPanel.SetActive(false);
	}

	public void wrong(){
		wrongPanel.SetActive(true);
		correctPanel.SetActive(false);
	}

	public void showBtns(){
		btnA.SetActive(true);
		btnB.SetActive(true);
		btnC.SetActive(true);
		btnD.SetActive(true);
	}

	public void hideAll(){
		btnA.SetActive(false);
		btnB.SetActive(false);
		btnC.SetActive(false);
		btnD.SetActive(false);
		correctPanel.SetActive(false);
		wrongPanel.SetActive(false);
		Answered_Warn.SetActive(false);
		CloseRightWrongBtn.SetActive(false);
	}

	// Start is called before the first frame update
	void Start()
	{
		hideAll();
		haveAnswered=new bool[24];
		for(int i=0;i<24;i++){
			haveAnswered[i]=false;
		}
		ScoreText.text="0";
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	
}
