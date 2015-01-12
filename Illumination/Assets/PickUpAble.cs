using UnityEngine;
using System.Collections;

public class PickUpAble : MonoBehaviour {

	public bool canBePickedUp = false;
	public bool isPickedUp = false;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Camera")
			canBePickedUp = true;
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "Camera")
			canBePickedUp = false;
	}

}
