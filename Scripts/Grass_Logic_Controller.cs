using UnityEngine;
using System.Collections;

public class Grass_Logic_Controller : MonoBehaviour 
{
	[System.Serializable]
	public struct arrayElement
	{
		public GameObject Grass;
		public bool active;
	}
	public arrayElement[] GrassArray;
	void Start () 
	{
		
	}
	
	void setFirstCloudActive()
	{
		for(int i = 0; i<3; i++)
		{
			if(GrassArray[i].active == false)
			{
				GrassArray[i].active = true;
				GrassArray[i].Grass.SetActive(true);
				break;
			}
		}
	}
	
	public void elementRespawnCall()
	{
		setFirstCloudActive();
	}
	public void elementFinishCall(int id)
	{
		GrassArray[id].active = false;
	}
}
