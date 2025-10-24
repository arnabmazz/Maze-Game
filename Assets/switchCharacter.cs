using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject avatar1, avatar2;

	// variable contains which avatar is on and active
	int whichAvatarIsOn = 1;


	// Use this for initialization
	void Start () {

		// anable first avatar and disable another one
		avatar1.gameObject.SetActive (true);
		avatar2.gameObject.SetActive (false);
		
	}

	// public method to switch avatars by pressing UI button
	public void SwitchAvatar()
	{

		// processing whichAvatarIsOn variable
		switch (whichAvatarIsOn) {

		// if the first avatar and third is on
		case 1:

			// then the second avatar is on now
			whichAvatarIsOn = 2;

			
			avatar2.gameObject.SetActive (true);
			avatar1.gameObject.SetActive (false);
			break;

		
	}
}
}