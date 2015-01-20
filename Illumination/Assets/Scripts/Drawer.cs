using UnityEngine;
using System.Collections;

public class Drawer : MonoBehaviour {

	public bool canOpen = true;
	public Animator thisAnimator;

	void Start () {
		thisAnimator = GetComponent<Animator> ();
	}

	void OnMouseDown () {
 		thisAnimator.SetTrigger ("drawer");

	}

//	void OnTriggerEnter (Collider other) {
//		if (other.tag == "MainCamera") {
//			print ("openable");
//			canOpen = true;
//		}
//	}
//	
//	void OnTriggerExit (Collider other) {
//		if (other.tag == "MainCamera")
//			canOpen = false;
//	}

}
