using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    

    public string playerOneAttack;
    public string playerTwoAttack;

    public PlayerInformation playerOne;
    public PlayerInformation playerTwo;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(playerOneAttack))
        {
            Combat combat = new Combat(playerOne, playerTwo);
            combat.Attack();
        }

        if (Input.GetKeyDown(playerTwoAttack))
        {
            Combat combat = new Combat(playerTwo, playerOne);
            combat.Attack();
        }
    }
}
