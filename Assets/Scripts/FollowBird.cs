using UnityEngine;
using System.Collections;

public class FollowBird : MonoBehaviour {
	private GameObject bird;
	private Transform birdTrans;

	public Vector3 defaultPosDiff = new Vector3(-5.06f,-2.33f,-9.5f);
	public float minY = -2.4f;
	public float maxY = 2.4f;
	// Use this for initialization
	void Start () {
		bird = GameObject.FindGameObjectWithTag("Player");
		birdTrans = bird.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 birdPos = birdTrans.position;
		float x = birdPos.x + defaultPosDiff.x;
		float y = birdPos.y + defaultPosDiff.y;
		float z = birdPos.z + defaultPosDiff.z;

		if(y < minY){
			y = minY;
		}
		if(y > maxY){
			y = maxY;
		}
		this.transform.position = new Vector3(x,y,z);
	}
}
