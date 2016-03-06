using UnityEngine;
using System.Collections;

public class Utils{

	public static bool CheckClickStartBtn(GUITexture startTexture){
		if(Input.GetMouseButtonDown(0)){
			Rect rect = startTexture.GetScreenRect();
			Vector3 mousePos = Input.mousePosition;
			if(mousePos.x > rect.x &&
			   mousePos.x < rect.x + rect.width &&
			   mousePos.y > rect.y &&
			   mousePos.y < rect.y + rect.height){
				return true;
			}
		}
		return false;
	}
}
