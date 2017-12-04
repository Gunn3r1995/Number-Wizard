﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int min = 1;
	int max = 1000;
	int guess = 500;

	// Use this for initialization
	void Start () {
		max++;
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Up arrow key was pressed");
			min = guess;
			guess = (max + min)/2;
			print ("Higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("Down arrow key was pressed");
			max = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!!!");
		}
	}
}