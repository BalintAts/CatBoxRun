using UnityEngine;
using System.Collections;

public class Cloud_Logic_Controller : MonoBehaviour 
{
	[System.Serializable]
	public struct arrayElement
	{
		public GameObject Cloud;
		public bool active;
	}
	public arrayElement[] CloudArray;
	public int next;
	void Start () 
	{
		elementRespawnCall();
		next = 0;
	}
	
	void setFirstCloudActive()
	{
		CloudArray[next].active = true;
		CloudArray[next].Cloud.SetActive(true);
	}
	
	public void elementRespawnCall()
	{
		setFirstCloudActive();
	}
	public void elementFinishCall(int id)
	{
		CloudArray[id].active = false;
		if (id == 2) 
		{
			next = 0;
		} else 
		{
			next = next+1;
		}
	}
}
