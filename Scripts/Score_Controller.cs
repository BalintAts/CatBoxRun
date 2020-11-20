using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_Controller : MonoBehaviour {
	public int score = 0;
	private int highScore;
	//public Text text;
	//public Text gameOverText;
	public GameObject Variable;
	private Variable_Controller variable;
	private bool increase;
	void Start () 
	{
		highScore = PlayerPrefs.GetInt("HighScore");
		variable = Variable.GetComponent<Variable_Controller>();
		score = 0;
		increase = false;
	}
	
	public void scoreIncrease()
	{
		score += 1;
		variable.incSpeed();
		variable.incTableRandomTime();
	}
	public string getScore()
	{
		return score.ToString();
	}
	void FixedUpdate()
	{
		//text.text = getScore();
		//gameOverText.text = getHighScore().ToString();
	}
	public int getHighScore()
	{
		if (score > highScore)
		{
			highScore = score;
		}
		saveHighScore();
		return highScore;
	}
	public void saveHighScore()
	{
		if (score >= highScore)
		{
			PlayerPrefs.SetInt("HighScore",score);
		}
	}
}
