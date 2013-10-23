using System; 
using System.Collections;
using UnityEngine; 
public class Axe : IWeaponBehavior{
	public GameObject axe;
    public string name = "axe"; 
	public Axe(){
	
	}


	public string usingWeapon(){
		
		//saxe.GetComponent<Transform>().Translate(1.0f, 0.0f,0.0f);
		return "I will chop thy head off";
	}
	public void setWeapon(GameObject axe_, string name){
		axe = axe_;
        axe.name = name; 
	}

    public GameObject getWeapon() {
        return axe; 
    }
    public string getName()
    {
        return name;
    } 
}	
