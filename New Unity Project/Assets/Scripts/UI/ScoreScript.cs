﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int ScoreValue1 = 0;
     Text Score;

	void Start ()
    {

        Score = GetComponent<Text>();
    }
	
	
	void Update ()
    {

        Score.text = "Player 1 Score: " + ScoreValue1;
    }
}