using UnityEngine;
using System.Collections;

public class Main_Menu_Controller : MonoBehaviour {


	public void newGame()
	{
		Application.LoadLevel("Main_Level");
	}
	public void Exit()
	{
		Application.Quit();	
	}
}
