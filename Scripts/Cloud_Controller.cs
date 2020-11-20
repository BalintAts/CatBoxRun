using UnityEngine;
using System.Collections;

public class Cloud_Controller : MonoBehaviour 
{
	public Transform spawnPosition;
	public GameObject CloudLogic;
	private Cloud_Logic_Controller logic;
	public int id;
	void Start()
	{
		logic = CloudLogic.GetComponent<Cloud_Logic_Controller>();
		this.gameObject.transform.position = new Vector3(spawnPosition.position.x,spawnPosition.position.y,spawnPosition.position.z);
	}
	
	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.gameObject.tag == "Finish")
		{
			logic.elementFinishCall(id);
			this.gameObject.transform.position = new Vector3(spawnPosition.position.x,spawnPosition.position.y,spawnPosition.position.z);
			this.gameObject.SetActive(false);
			logic.elementRespawnCall();
		}
    }
}
