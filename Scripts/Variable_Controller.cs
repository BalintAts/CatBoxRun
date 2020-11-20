using UnityEngine;
using System.Collections;

public class Variable_Controller : MonoBehaviour 
{

	private float mSpeed;
	private float mJump;
	private float mGravity;
	private float mRandomDeskTime;
	private int mRandomDeskPosibility;
	private float mRandomMouseTime;
	private int mRandomMousePosibility;
	private float gameTime;
	private float mSpeedStep;
	private float mDeskStep;
	public bool GameRunning;

	void Start()
	{
		GameRunning = true;
		mGravity = 4; //PlayerPrefs.GetFloat("mGravity");
		mSpeed = 4; //PlayerPrefs.GetFloat("mSpeed"); max 8
		mJump = 14; //PlayerPrefs.GetFloat("mJump");
		mRandomDeskTime = 1.5f; //PlayerPrefs.GetFloat("mRandomDeskTime");
		mRandomDeskPosibility = 2;//PlayerPrefs.GetInt("mRandomDeskPosibility");
		mRandomMouseTime = 1; //PlayerPrefs.GetFloat("mRandomMouseTime");
		mRandomMousePosibility = 2; //PlayerPrefs.GetInt("mRandomMousePosibility");
		gameTime = 1f;
		mSpeedStep = 0.15f;
		mDeskStep = -0.06f;
	
	}
	public float getgameTime()
	{
		return gameTime;
	}
	public void incgameTime()
	{
		gameTime += 0.1f;
	}
	public void decgameTime()
	{
		gameTime -= 0.1f;
	}
	public float getGravity()
	{
		return mGravity;
	}
	public void incGravity()
	{
		mGravity += 0.1f;
	}
	public void decGravity()
	{
		mGravity -= 0.1f;
	}
	public float getJump()
	{
		return mJump;
	}
	public void setSpeed(float speed)
	{
		mSpeed = speed;
	}
	public float getSpeed()
	{
		return mSpeed;
	}
	public float getDeskTime()
	{
		return mRandomDeskTime;
	}
	public int getRandomDesk()
	{
		return mRandomDeskPosibility;
	}
	public float getMouseTime()
	{
		return mRandomMouseTime;
	}
	public int getMousePos()
	{
		return mRandomMousePosibility;
	}
	public void incSpeed()
	{
		mSpeed += mSpeedStep;
	}
	public void decSpeed()
	{
		mSpeed -= 0.1f;
	}
	public void incJump()
	{
		mJump += 0.1f;
	}
	public void decJump()
	{
		mJump -= 0.1f;
	}
	public void incTableRandomTime()
	{
		mRandomDeskTime += mDeskStep;
	}
	public void decTableRandomTime()
	{
		mRandomDeskTime -= 0.1f;
	}
	public float getTableRandomTime()
	{
		return mRandomDeskTime;
	}
	public void incTableRandom()
	{
		mRandomDeskPosibility += 1;
	}
	public void decTableRandom()
	{
		mRandomDeskPosibility -= 1;
	}
	public int getTableRandomPos()
	{
		return mRandomDeskPosibility;
	}
	public void incMouseRandomTime()
	{
		mRandomMouseTime += 0.1f;
	}
	public void decMouseRandomTime()
	{
		mRandomMouseTime -= 0.1f;
		PlayerPrefs.SetFloat("mRandomMouseTime",mRandomMouseTime);
	}
	public void incMouseRandom()
	{
		mRandomMousePosibility += 1;
	}
	public void decMouseRandom()
	{
		mRandomMousePosibility -= 1;
	}
	public int getMouseRandomPos()
	{
		return mRandomMousePosibility;
	}
	/*
	highScore = PlayerPrefs.GetInt("HighScore");
	PlayerPrefs.SetInt("HighScore",score);
	*/

}
