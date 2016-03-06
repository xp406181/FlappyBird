using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	public int frameNumber = 10;//frame per second
	public int frameCount = 0;//frame counter
	public int picNum = 3;
	public float timer;
	public float horizonV = 5.0f;
	public float verticalV = 5.0f;

	public Renderer rend;
	public Rigidbody rigid;

	
	// Use this for initialization
	void Start () {
		rend = this.GetComponent<Renderer>();
		rigid = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager._instance.gameState == GameManager.GAMESTATE_PLATYING){
			this.PlayAnim();
		}

		if(GameManager._instance.gameState == GameManager.GAMESTATE_PLATYING){
			this.Control();
		}

	}

	void PlayAnim(){
		timer += Time.deltaTime;
		
		if(timer >= 1.0f/frameNumber ){
			frameCount ++;
			timer -= 1.0f/frameNumber;
			int frameIndex = frameCount % picNum;
			float offsetX = 1.0f/picNum * frameIndex;
			if(rend != null){
				rend.material.SetTextureOffset("_MainTex",new Vector2(offsetX,0));
			}
		}
	}

	void Control(){
		if(Input.GetMouseButton(0)){
			this.rigid.velocity = new Vector3(horizonV,verticalV,0);
		}
	}

	public void GetLife(){
		this.rigid.useGravity = true;
		this.rigid.velocity = new Vector3(horizonV,verticalV,0);
	}
}
