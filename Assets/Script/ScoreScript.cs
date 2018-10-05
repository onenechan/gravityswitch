﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text highScoreText; //ハイスコアを表示するText
	private int highScore; //ハイスコア用変数
	private string key = "HIGH SCORE"; //ハイスコアの保存先キー

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt(key, 0);
		//保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
		highScoreText.text = "HighScore: " + highScore.ToString();
		//ハイスコアを表示
	}
	
	// Update is called once per frame
	void Update () {
		//ハイスコアより現在スコアが高い時
		if (PlayerScript.score > highScore) {

			highScore = PlayerScript.score;
			//ハイスコア更新

			PlayerPrefs.SetInt(key, highScore);
			//ハイスコアを保存

			highScoreText.text = "HighScore: " + highScore.ToString();
			//ハイスコアを表示
		}

	}
}
