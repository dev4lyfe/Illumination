using UnityEngine;
using System.Collections;

public class Desk : MonoBehaviour {

	public Animator thisAnimator;

	void Start () {
		thisAnimator = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Animator> ();
	}

	void OnMouseDown () {
		thisAnimator.SetTrigger ("desk");
	}
}
