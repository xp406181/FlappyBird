using UnityEngine;
using System.Collections;

public class BirdSimple : MonoBehaviour {
	public float timer;
	public float factor = 0.2f;
	public float speed = 2f;
	public int frameNumber = 10;//frame per second
	public int frameCount = 0;//frame counter
	public int picNum = 3;
	public Renderer rend;
	Vector3 defaultPos;

	// Use this for initialization
	void Start () {
		this.rend = this.GetComponent<Renderer>();
		defaultPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.PlayAnim();
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

		transform.position = new Vector3(defaultPos.x,defaultPos.y + Mathf.Sin(Time.time * speed) * factor, defaultPos.z);
	}
}
