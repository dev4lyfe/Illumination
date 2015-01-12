using UnityEngine;
using System.Collections;

public class PickUpAble : MonoBehaviour {

	public bool canBePickedUp = false;
	public bool isPickedUp = false;
	public Light light2, d;
	public Transform newPosition;

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
		gameObject.transform.SetParent(newPosition, false);
		gameObject.transform.position = newPosition.position;
		gameObject.transform.rotation = newPosition.transform.rotation;
		gameObject.transform.localScale = new Vector3 (1f, 1f, 1f);
		light2.enabled = true;
		d.enabled = true;

	}

}
