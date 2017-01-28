using UnityEngine;
using System.Collections;

public class ServeHamburger : MonoBehaviour {

	public int occupiedSlot = 0;
	public bool mouseControlled = false;

	// Use this for initialization
	void Start () {
		occupiedSlot = GamePlay.selectedSlot;
	}
	
	// Update is called once per frame
	void Update () {
		if (mouseControlled) {
			Vector2 mouseposition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 objPosition = Camera.main.ScreenToWorldPoint (mouseposition);
			transform.position = objPosition;
		}
		if (GamePlay.deleteFood && mouseControlled) {
			Destroy (gameObject);
		}
	}

	void OnMouseDown(){
		mouseControlled = true;
		GamePlay.deleteFood = false;
		GamePlay.selectedFood = occupiedSlot;
		Debug.Log (mouseControlled);
	}
}
