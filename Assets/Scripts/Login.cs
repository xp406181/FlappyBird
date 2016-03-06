using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
	public GUITexture startTexture;
	public GUITexture rankTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Utils.CheckClickStartBtn(this.startTexture)){
			Application.LoadLevel(1);
		}
	}
}
