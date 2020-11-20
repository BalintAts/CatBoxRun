using UnityEngine;
using System.Collections;

public class Mouse_Logic_Controller : MonoBehaviour 
{
[System.Serializable]
	public struct arrayElement
	{
		public GameObject Mouse;
		public bool active;
	}
	public arrayElement[] MouseArray;
	public arrayElement[] EmptyMouseArray;
	
	void Start () 
	{
		elementRespawnCall();
	}
	
	void FixedUpdate()
	{
		bool spawn = false;
		for (int i = 0; i < 5; i++)
		{
			if (MouseArray[i].active == true) {spawn  = true; break;}
		}
		if (!spawn) 
		{
			setFirstMouseActive();
		}
	}
	
	void setFirstMouseActive()
	{
		for (int i = 0; i < 5; i++)
		{
			if (MouseArray[i].active == false)
			{
				MouseArray[i].active = true;
				MouseArray[i].Mouse.SetActive(true);
				return;
			}	
		}
	}
	void setFirstEmptyMouseActive()
	{
		for (int i = 0; i < 5; i++)
		{
			if (EmptyMouseArray[i].active == false)
			{
				EmptyMouseArray[i].active = true;
				EmptyMouseArray[i].Mouse.SetActive(true);
				return;
			}	
		}
	}
	public void elementRespawnCall()
	{
		int random = Random.Range(0,2);
		switch (random)
		{
			case 0:
			{
				setFirstMouseActive();
				break;
			}
			case 1:
			{
				setFirstEmptyMouseActive();
				break;
			}
		}
	}
	public void elementFinishCall(int type, int id)
	{
		switch (type)
		{
			case 0:
			{
				EmptyMouseArray[id].active = false;
				break;
			}
			case 1:
			{
				MouseArray[id].active = false;
				break;
			}
		}
	}
	
}
