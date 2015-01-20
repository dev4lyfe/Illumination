using UnityEngine;
using System.Collections;

public class ViewControl : MonoBehaviour {

	public float turnSpeed = 4.0f;
	public float panSpeed = 4.0f;

	private Vector3 mouseOrigin; 
	private bool isPanning;
	private bool isRotating;

//	void OnEnable()
//	{
//		Response.s_OnClicked += MoveToPosition;
//	}
//	
//	
//	void OnDisable()
//	{
//		Response.s_OnClicked -= MoveToPosition;	
//	}
//
//	void Start () 
//	{
//
//	}
	

	void Update () 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			mouseOrigin = Input.mousePosition;
			isRotating = true;
		}

		if (isRotating) 
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint (Input.mousePosition - mouseOrigin);

			transform.RotateAround (transform.position, transform.right, -pos.y * turnSpeed);
			transform.RotateAround (transform.position, Vector3.up, pos.x * turnSpeed);
		}
	}


//	void MoveToPosition(){
//
//	}
	

}
