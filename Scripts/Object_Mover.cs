using UnityEngine;
using System.Collections;

public class Object_Mover : MonoBehaviour 
{
	public float speedreduce;
	public GameObject Variable;
	private Variable_Controller variable;
	void Start()
	{
		variable = Variable.GetComponent<Variable_Controller>();
	}
	void Update() 
	{
		if (variable.GameRunning)
			transform.position += Vector3.left * Time.deltaTime * (variable.getSpeed()*speedreduce);
	}
}
