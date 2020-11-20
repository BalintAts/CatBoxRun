using UnityEngine;
using System.Collections;

public class Bench_Controller : MonoBehaviour 
{
	
	public Transform spawnPosition;
	public int type;
	public int id;
	public GameObject BenchLogic;
	private Bench_Logic_Controller logic;
	void Start()
	{
		logic = BenchLogic.GetComponent<Bench_Logic_Controller>();
		this.gameObject.transform.position = new Vector3(spawnPosition.position.x,spawnPosition.position.y,spawnPosition.position.z);
	}
	
	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.gameObject.tag == "Respawn")
		{
			logic.elementRespawnCall();
		}
		if (coll.gameObject.tag == "Finish")
		{
			logic.elementFinishCall(type,id);
			this.gameObject.transform.position = new Vector3(spawnPosition.position.x,spawnPosition.position.y,spawnPosition.position.z);
			this.gameObject.SetActive(false);
		}
    }
	
}
