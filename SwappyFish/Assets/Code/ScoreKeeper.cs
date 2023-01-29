using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class ScoreKeeper : MonoBehaviour
{
    
	private int _currentScore = 0;
	
	public void IncrementScore()
	{
		_currentScore++;
		TMP_Text scoreText = GetComponent<TMP_Text>();
		scoreText.text = "Score : " + _currentScore.ToString();
	}

  
}
