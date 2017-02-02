using UnityEngine;
using System.Collections;

public class ServeTopping: MonoBehaviour {

	public int occupiedSlot = 99;
	public bool mouseControlled = false;

	// Use this for initialization
	void Start () {
		occupiedSlot = GamePlay.selectedSlot;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (occupiedSlot == GamePlay.selectedFood) {
			mouseControlled = true;
			Vector2 mouseposition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 objPosition = Camera.main.ScreenToWorldPoint (mouseposition);
			transform.position = new Vector2(objPosition.x, objPosition.y - 0.2f);
		}
		if (GamePlay.deleteFood && mouseControlled) {
			Destroy (gameObject);
		}

	}
}
