using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard ");
		print("Pick a number in your head ! but don't tell me ");
		int max = 2000;
		int min = 1;
		print("The highest no can be " + max);
		print("The lowest no can be " + min);


	}

	
	// Update is called once  per frame
		
	void Update () {
		if( Input.GetKeyDown(KeyCode.UpArrow)){
			print("Up arow pressed");

		}
		
	}
}