using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");

		var min = 1;
		var max = 1000;

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than 500?");
		print ("Up arrow for higher, down for lower, return for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("Up arrow key was pressed");
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			print ("Down arrow key was pressed");
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!!!");
		}
	}
}
