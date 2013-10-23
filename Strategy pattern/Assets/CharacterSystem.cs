using UnityEngine;
using System.Collections;

public class CharacterSystem : MonoBehaviour {
	public GameObject axe; 
	public GameObject queenOutfit; 
	public GameObject kingOutfit; 
	public GameObject knife; 
    
	Character currentCharacter; 
	King myKing; 
	Queen myQueen; 

	
	// Use this for initialization
	void Start () {
		myQueen = new Queen(); 
		myKing = new King(); 
		currentCharacter = myQueen; 
		currentCharacter.outfit = queenOutfit; 
		currentCharacter.weapon.setWeapon(knife, "knife");
		
	}
	
	// Update is called once per frame
	void Update () {
	 

		//currentCharacter.mover(); 
		if(Input.GetKeyDown("space") && currentCharacter.outfit != null){
			string fight = currentCharacter.fight(); 
			Debug.Log("I am a " + currentCharacter.name + " and I am fighting with a " + currentCharacter.weapon.getName()); 
		}			
		
		if(Input.GetKeyDown(KeyCode.W)) {
			switchCharacters(); 
		}
        if (Input.GetKeyDown(KeyCode.A)) {
            var temp = currentCharacter.weapon.getName(); 
            Debug.Log("key a fired");
            if ( temp == axe.name){
                currentCharacter.weapon.setWeapon(knife, "knife");
            }
            else {currentCharacter.weapon.setWeapon(axe, "axe"); }
        }
	}
	void switchCharacters(){
	if(currentCharacter.name == "queen") 
			{
				Destroy(currentCharacter.outfit); 
				currentCharacter = myKing;
				Debug.Log("the current character is " + currentCharacter.name); 
				currentCharacter.weapon.setWeapon(axe, "axe");  
				currentCharacter.outfit = Instantiate(kingOutfit, transform.position, transform.rotation) as GameObject; 
			} 
			else if(currentCharacter.name == "king")
			{
				Destroy(currentCharacter.outfit);
				currentCharacter = myQueen;
				Debug.Log("the current character is " + currentCharacter.name);
				currentCharacter.weapon.setWeapon(knife, "knife");  
				currentCharacter.outfit = Instantiate(queenOutfit, transform.position, transform.rotation) as GameObject;  
			}
	}

}
