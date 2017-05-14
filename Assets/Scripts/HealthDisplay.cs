using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthDisplay : MonoBehaviour {

    public PlayerInformation playerOne;
    public PlayerInformation playerTwo;

    public Text player1Health;
    public Text player2Health;


	
	// Update is called once per frame
	void FixedUpdate () {
        player1Health.text = playerOne.getCurrentHealth().ToString();
        player2Health.text = playerTwo.getCurrentHealth().ToString();             
    }

}
