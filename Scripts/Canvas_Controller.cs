using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using System;
public class Canvas_Controller : MonoBehaviour 
{
	public GameObject Pause;
	public GameObject Dead;
	public GameObject Interface;
	public GameObject Cat;
	public GameObject Score;
	private Cat_Controller cat_Controller;
	private Score_Controller score_controller;
	private GameObject Variable;
	private Variable_Controller variable;
	public bool isPaused = false;
	void Start()
	{
		cat_Controller = Cat.GetComponent<Cat_Controller>();
		score_controller = Score.GetComponent<Score_Controller>();
		Variable = GameObject.Find("Variable_Controller");
		variable = Variable.GetComponent<Variable_Controller>();
	}
	void Update() 
	{
		if (cat_Controller.getDead())
		{
			Dead.SetActive(true);
			Pause.SetActive(false);
			Interface.SetActive(true);
			//Time.timeScale = 0f;
			variable.setSpeed(0);
			score_controller.saveHighScore();
		}
		else 
		{
			Interface.SetActive(true);
			Dead.SetActive(false);
			Pause.SetActive(false);
			Time.timeScale = variable.getgameTime();
		}
		if (isPaused)
		{
			Pause.SetActive(true);
			Dead.SetActive(false);
			Interface.SetActive(false);
			Time.timeScale = 0f;
		}
	}
	public void setPausedTrue()
	{
		isPaused = true;
	}
	public void setPausedFalse()
	{
		isPaused = false;
	}
	public void restartLevel()
	{
		  Application.LoadLevel("Main_Level");
	}
	public void exitLevel()
	{
		  Application.LoadLevel("Main_Menu");
	}
	public void submitScore()
	{
		Social.ReportScore(score_controller.getHighScore(), "CgkI2LvbwckBEAIQAA", (bool success) => {
        // handle success or failure
    });
	}

}
