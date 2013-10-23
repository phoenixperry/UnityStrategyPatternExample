
using System;
using UnityEngine; 

public abstract class Character{
	public IWeaponBehavior weapon;
	public GameObject outfit; 
	float myMover  = 0.0f; 
	Vector3 myVect; 

	public string name; 
	
	public Character(){

	} 
	public void mover(){

		float myz = 0.0f; 
		float myx = Input.GetAxis("Horizontal"); 
		float myy = Input.GetAxis("Vertical");
		myVect = new Vector3(myx, 0, myz); 
		outfit.GetComponent<Transform>().Translate(myVect);
	} 
	public string fight(){
	
		return weapon.usingWeapon(); 
	} 


}
