using UnityEngine;
using System.Collections;

public class Posing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Animator anim = GetComponent<Animator> ();

		if ( Input.GetKey ( KeyCode.A )) {
			anim.SetBool( "Posing", true );
		}

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Locomotion.wired_pose")) {
			anim.SetBool( "Posing", false );
		}

	
	}
}
