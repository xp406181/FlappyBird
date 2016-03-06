using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static int GAMESTATE_MENU = 0;//游戏菜单
	public static int GAMESTATE_PLATYING = 1;//游戏中
	public static int GAMESTATE_END = 2;//游戏结束


	public Transform firstBg;
	public int score = 0;
	public int gameState = GAMESTATE_MENU;
	public static GameManager _instance;
	private GameObject bird;

	void Awake(){
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		bird = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameState == GAMESTATE_MENU){
			if(Input.GetMouseButton(0)){
				gameState = GAMESTATE_PLATYING;

				bird.SendMessage("GetLife");
			}
		}

		if(this.gameState == GameManager.GAMESTATE_END){
			GameMenu._instance.gameObject.SetActive(true);
			GameMenu._instance.UpdateScore(this.score);
			bird.SendMessage("Freeze");
		}
	}
}
