using UnityEngine;
using System.Collections;

public class GamePlay : MonoBehaviour {

	public static string boardSlot1 = "empty";
	public static string boardSlot2 = "empty";
	public static string boardSlot3 = "empty";

	public static string grillSlot1 = "empty";
	public static string grillSlot2 = "empty";
	public static string grillSlot3 = "empty";

	public static int selectedSlot = 0;
	public static int selectedFood = 0;

	public KeyCode giveFood;
	public static bool deleteFood = false;
	public static string currentMeal = "none";

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (giveFood)) {
			deleteFood = true;
		}

	}
}
