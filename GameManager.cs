using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int score;
	public static GameManager inst;

	public Text scoreText;
    public Text highScore;

	public void IncrementScore() {
		score++;
		scoreText.text = "Score: " + score;

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScore.text = "Highscore: " + score.ToString();
        }
	}

	private void Awake () {
		inst = this;
	}

	// Use this for initialization
	void Start () {
        highScore.text = "Highscore: " + PlayerPrefs.GetInt("Highscore",0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
