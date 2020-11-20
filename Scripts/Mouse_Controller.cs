using UnityEngine;
using System.Collections;

public class Mouse_Controller : MonoBehaviour 
{
	public Transform spawnPosition;
	public int id;
	public int type;
	public GameObject MouseLogic;
	private Mouse_Logic_Controller logic;
	void Start()
	{
		logic = MouseLogic.GetComponent<Mouse_Logic_Controller>();
		this.gameObject.transform.position = new Vector3(spawnPosition.position.x,spawnPosition.position.y,spawnPosition.position.z);
	}
	
	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.gameObject.tag == "Respawn")
		{
			logic.elementRespawnCall();
		}
		if (coll.gameObject.tag == "Finish" | coll.gameObject.tag == "Player")
		{
			logic.elementFinishCall(type,id);
			this.gameObject.transform.position = new Vector3(spawnPosition.position.x,spawnPosition.position.y,spawnPosition.position.z);
			this.gameObject.SetActive(false);
		}
    }
}
