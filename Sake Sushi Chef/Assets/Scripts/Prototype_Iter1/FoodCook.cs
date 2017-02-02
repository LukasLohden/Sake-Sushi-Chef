using UnityEngine;
using System.Collections;

public class FoodCook : MonoBehaviour {

	public float cookTime = 0;
	public bool onGrill = true;
	public int occupiedSlot = 100;


	public bool mouseControlled = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (onGrill) {
			cookTime += Time.deltaTime;
			if (cookTime > 5 && cookTime < 10) {
				GetComponent<SpriteRenderer> ().color = new Color (1, 1, 0);
			} else if (cookTime > 10) {
				GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
			}
		}
		if (occupiedSlot == GamePlay.selectedFood) {
			mouseControlled = true;
			Vector2 mouseposition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 objPosition = Camera.main.ScreenToWorldPoint (mouseposition);
			transform.position = new Vector2(objPosition.x, objPosition.y - 0.2f);
			if (gameObject.name == "burger patty(Clone)") {
				GamePlay.currentMeal = "hamburger";
			}
			else if (gameObject.name == "hotdog(Clone)") {
				GamePlay.currentMeal = "hotdog";
			}
		}
		if (GamePlay.deleteFood && mouseControlled) {
			Destroy (gameObject);
		}
	}

	void OnMouseDown() {
		onGrill = false;

		// 6, 7, and 8 are the x-position of the 3 slots on the grill.
		if (transform.position.x == 6) {
			GamePlay.grillSlot1 = "empty";
		}
		else if (transform.position.x == 7) {
			GamePlay.grillSlot2 = "empty";
		}
		else if (transform.position.x == 8) {
			GamePlay.grillSlot3 = "empty";
		}

		// Only moves to the board if a bun is ready for it.
		if (GamePlay.boardSlot1 == "bun") {
			GetComponent<Transform> ().position = new Vector2 (-1, -0.5f);
			GamePlay.boardSlot1 = "filled";
			occupiedSlot = 1;
		}
		else if (GamePlay.boardSlot2 == "bun") {
			GetComponent<Transform> ().position = new Vector2 (0, -0.5f);
			GamePlay.boardSlot2 = "filled";
			occupiedSlot = 2;
		}
		else if (GamePlay.boardSlot3 == "bun") {
			GetComponent<Transform> ().position = new Vector2 (1, -0.5f);
			GamePlay.boardSlot3 = "filled";
			occupiedSlot = 3;
		}
	}
}
