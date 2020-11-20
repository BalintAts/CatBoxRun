using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bench_Logic_Controller : MonoBehaviour 
{
	[System.Serializable]
	public struct arrayElement
	{
		public GameObject Bench;
		public bool active;
	}
	public arrayElement[] BenchArray;
	public arrayElement[] EmptyBenchArray;
	
	void Start () 
	{
		elementRespawnCall();
	}
	
	void FixedUpdate()
	{
		bool spawn = false;
		for (int i = 0; i < 10; i++)
		{
			if (BenchArray[i].active == true) {spawn  = true; break;}
		}
		if (!spawn) 
		{
			setFirstBenchActive();
		}
	}
	
	void setFirstBenchActive()
	{
		for (int i = 0; i < 10; i++)
		{
			if (BenchArray[i].active == false)
			{
				BenchArray[i].active = true;
				BenchArray[i].Bench.SetActive(true);
				return;
			}	
		}
	}
	void setFirstEmptyBenchActive()
	{
		for (int i = 0; i < 10; i++)
		{
			if (EmptyBenchArray[i].active == false)
			{
				EmptyBenchArray[i].active = true;
				EmptyBenchArray[i].Bench.SetActive(true);
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
				setFirstBenchActive();
				break;
			}
			case 1:
			{
				setFirstEmptyBenchActive();
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
				EmptyBenchArray[id].active = false;
				break;
			}
			case 1:
			{
				BenchArray[id].active = false;
				break;
			}
		}
	}
}
