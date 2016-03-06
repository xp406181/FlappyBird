using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
	public static GameMenu _instance;
	public GUIText newScore;
	public GUIText highScore;
	public GUITexture startTexture;

	void Awake(){
		_instance = this;
		this.gameObject.SetActive(false);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateScore(int newScore){
		int highScore =  PlayerPrefs.GetInt("score",0);

		this.newScore.text = newScore.ToString();
		this.highScore.text = highScore.ToString();

		if(newScore > highScore){
			highScore = newScore;
			PlayerPrefs.SetInt("score",highScore);
		}

		if(Utils.CheckClickStartBtn(this.startTexture)){
			Application.LoadLevel(1);
		}

	}


}
