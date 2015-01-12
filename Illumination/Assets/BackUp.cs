using UnityEngine;
using System.Collections;

public class BackUp : MonoBehaviour {

	Animator thisAnimator;
	// Use this for initialization
	void Start () {
		thisAnimator = GetComponent<Animator> ();
	}
	
	void OnMouseDown () {
		thisAnimator.SetTrigger ("back");
	}
}
