﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int scoreValue;
	Text score;

	// Use this for initialization
	void Start () {
		scoreValue = 0;
		score = GetComponent<Text> ();
	}
	

	// Update is called once per frame
	void Update () {
		score.text = " Score : " + scoreValue;

	}
}