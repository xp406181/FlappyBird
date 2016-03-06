using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour {
	public Transform currentBg;
	public float offsetX = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
//		Debug.Log("-------------------");
		if(other.tag == "Player"){
//			Debug.Log("+++++++++++++++++++++++++");
			Transform firstBg = GameManager._instance.firstBg;
			float x = firstBg.position.x;
			float y = firstBg.position.y;
			float z = firstBg.position.z;
			currentBg.position = new Vector3(x + offsetX,y,z);

			GameManager._instance.firstBg = currentBg;
		}
	}
}
