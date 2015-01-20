using UnityEngine;
using System.Collections;

public class Response : MonoBehaviour {

	public delegate void ClickAction();
	public static event ClickAction s_OnClicked;

	void Start () {
	
	}
	

	void Update () {
	
	}

	void OnMouseDown() 
	{
		s_OnClicked();
		Debug.Log ("You clicked on me");
	}
}
