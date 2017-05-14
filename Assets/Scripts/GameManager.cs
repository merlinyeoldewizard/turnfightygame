using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerInformation playerOne;
    public PlayerInformation playerTwo;


	// Use this for initialization
	void Start () {
        
        playerOne.setCurrentHealth(playerOne.maxHealth);
        playerTwo.setCurrentHealth(playerTwo.maxHealth);

    }
	
}
