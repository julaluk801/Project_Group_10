﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour {
	public Text timerText;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;  
		
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ("D2");
		string seconds = ((int)(t % 60)).ToString ("D2");
		timerText.text = minutes + " : " + seconds;

		
	}
}
