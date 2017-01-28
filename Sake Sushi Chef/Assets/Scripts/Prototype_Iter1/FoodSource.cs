using UnityEngine;
using System.Collections;

public class FoodSource: MonoBehaviour {

	public Transform bottomBunObj;
	public Transform topBunObj;
	public Transform burgerObj;

	public Transform backRollObj;
	public Transform frontRollObj;
	public Transform hotdogObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (gameObject.name == "bun bin") {
			if (GamePlay.boardSlot1 == "empty") {
				Instantiate (bottomBunObj, new Vector2 (-1, -0.5f), bottomBunObj.rotation);
				Instantiate (topBunObj, new Vector2 (-1, -0.3f), topBunObj.rotation);
				GamePlay.boardSlot1 = "bun";
				GamePlay.selectedSlot = 1;
			} else if (GamePlay.boardSlot2 == "empty") {
				Instantiate (bottomBunObj, new Vector2 (-0, -0.5f), bottomBunObj.rotation);
				Instantiate (topBunObj, new Vector2 (-0, -0.3f), topBunObj.rotation);
				GamePlay.boardSlot2 = "bun";
				GamePlay.selectedSlot = 2;
			} else if (GamePlay.boardSlot3 == "empty") {
				Instantiate (bottomBunObj, new Vector2 (1, -0.5f), bottomBunObj.rotation);
				Instantiate (topBunObj, new Vector2 (1, -0.3f), topBunObj.rotation);
				GamePlay.boardSlot3 = "bun";
				GamePlay.selectedSlot = 3;
			}
		} 
		else if (gameObject.name == "roll bin") {
			if (GamePlay.boardSlot1 == "empty") {
				Instantiate (backRollObj, new Vector2 (-1, -0.5f), backRollObj.rotation);
				Instantiate (frontRollObj, new Vector2 (-1, -0.5f), frontRollObj.rotation);
				GamePlay.boardSlot1 = "roll";
				GamePlay.selectedSlot = 1;
			} else if (GamePlay.boardSlot2 == "empty") {
				Instantiate (backRollObj, new Vector2 (-0, -0.5f), backRollObj.rotation);
				Instantiate (frontRollObj, new Vector2 (-0, -0.5f), frontRollObj.rotation);
				GamePlay.boardSlot2 = "roll";
				GamePlay.selectedSlot = 2;
			} else if (GamePlay.boardSlot3 == "empty") {
				Instantiate (backRollObj, new Vector2 (1, -0.5f), backRollObj.rotation);
				Instantiate (frontRollObj, new Vector2 (1, -0.5f), frontRollObj.rotation);
				GamePlay.boardSlot3 = "roll";
				GamePlay.selectedSlot = 3;
			}
		} 
		else if (gameObject.name == "hamburger bin")  {
			if (GamePlay.grillSlot1 == "empty") {
				Instantiate (burgerObj, new Vector2 (5, -0.5f), burgerObj.rotation);
				GamePlay.grillSlot1 = "filled";
			}
			else if (GamePlay.grillSlot2 == "empty") {
				Instantiate (burgerObj, new Vector2 (6, -0.5f), burgerObj.rotation);
				GamePlay.grillSlot2 = "filled";
			}
			else if (GamePlay.grillSlot3 == "empty") {
				Instantiate (burgerObj, new Vector2 (7, -0.5f), burgerObj.rotation);
				GamePlay.grillSlot3 = "filled";
			}
		}
		else if (gameObject.name == "hotdog bin")  {
			if (GamePlay.grillSlot1 == "empty") {
				Instantiate (hotdogObj, new Vector2 (5, -0.5f), hotdogObj.rotation);
				GamePlay.grillSlot1 = "filled";
			}
			else if (GamePlay.grillSlot2 == "empty") {
				Instantiate (hotdogObj, new Vector2 (6, -0.5f), hotdogObj.rotation);
				GamePlay.grillSlot2 = "filled";
			}
			else if (GamePlay.grillSlot3 == "empty") {
				Instantiate (hotdogObj, new Vector2 (7, -0.5f), hotdogObj.rotation);
				GamePlay.grillSlot3 = "filled";
			}
		}


	}

}
