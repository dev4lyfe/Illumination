using UnityEngine;
using System.Collections;

public class PickUpAble : MonoBehaviour {

	public bool canBePickedUp = false;
	public bool isPickedUp = false;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "MainCamera") {
			canBePickedUp = true;
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "MainCamera")
			canBePickedUp = false;
	}

	void OnMouseDown () {
		if (canBePickedUp) {
			gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("MainCamera").transform, false);
			gameObject.transform.localPosition.Set(GameObject.FindGameObjectWithTag("MainCamera").transform.position.x,GameObject.FindGameObjectWithTag("MainCamera").transform.position.y,GameObject.FindGameObjectWithTag("MainCamera").transform.position.z);
			gameObject.transform.rotation = Quaternion.identity;
		}
	}

}
