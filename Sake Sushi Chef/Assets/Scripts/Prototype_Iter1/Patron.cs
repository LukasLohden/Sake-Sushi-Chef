using UnityEngine;
using System.Collections;

public class Patron : MonoBehaviour {

	public string orderedMeal = "hamburger";


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		if (GamePlay.deleteFood && GamePlay.currentMeal == orderedMeal) {
			Destroy(gameObject);
			Application.LoadLevel ("Main Menu");
		}
	}

}
