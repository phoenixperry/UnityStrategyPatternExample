using UnityEngine;
using System.Collections;

public class Knife : IWeaponBehavior {
	public GameObject knife;
    string name = "knife";
	// Use this for initialization
	public Knife () {
	
	}
	
	public string usingWeapon(){
		
		//saxe.GetComponent<Transform>().Translate(1.0f, 0.0f,0.0f);
		return "I will stab!"; 
	}
	public void setWeapon(GameObject knife_, string name){
		knife = knife_;
        knife.name = name; 
	}
    public GameObject getWeapon()
    {
        return knife; 
    }
    public string getName() {
        return name; 
    } 
  }