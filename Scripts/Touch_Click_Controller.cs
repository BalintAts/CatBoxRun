using UnityEngine;
using System.Collections;

public class Touch_Click_Controller : MonoBehaviour {

	private GameObject Cat;
	private Cat_Controller cat_controller;
	void Start () 
	{
		Cat = GameObject.Find("Cat");
		cat_controller = Cat.GetComponent<Cat_Controller>();
	}
	
	void Update() 
	{
		   if (Input.GetMouseButtonDown(1))
		   {
			   cat_controller.Jump();
		   }
		   if (Input.touchCount > 0)
		   {
			Touch t = Input.GetTouch(0);
			if (t.phase == TouchPhase.Began)
			{
				cat_controller.Jump();
			}
		   }
		   for (int i = 0; i < Input.touchCount; ++i)
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) 
			{
                cat_controller.Jump();
            }
    }
	//}
	
}
