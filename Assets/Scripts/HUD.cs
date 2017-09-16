using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    static int _gameScore;

    public Text scoreText;

	void Start ()
    {
        GameScore = 0;
        SetScore();
    }

	void Update ()
    {
        SetScore();
    }

    void SetScore()
    {
        scoreText.text = goalArea.score.ToString();
    }

    public int GameScore
    {
        get { return _gameScore; }
        set { _gameScore = value;  }
    }
}
