using UnityEngine;
using System.Collections;

public class ClickForwardCollider : MonoBehaviour {

	public Animator thisAnimator;

	void OnMouseDown () {
		thisAnimator.SetTrigger ("forward");
		print ("FICK");
	}
}
