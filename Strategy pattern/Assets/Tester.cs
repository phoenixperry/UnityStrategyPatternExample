using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {
	public Texture2D normalTex;
	public Texture2D hoverTex; 

 
	void OnMouseEnter () {
	 guiTexture.texture = hoverTex;
	}
	 
	void OnMouseExit(){
	 guiTexture.texture = normalTex;
	}
	 
	void OnMouseDown(){
	 Debug.Log("clicked");
	}
		
public int Counter = 0;
 
void Update () {
 Counter++;
 guiText.text = "Counter is: "+Counter;
}
}
