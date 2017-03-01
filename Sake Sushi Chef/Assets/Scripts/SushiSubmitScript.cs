using UnityEngine;
using System.Collections;

public class SushiSubmitScript : MonoBehaviour {


	private string sushi;
	// Use this for initialization
	void Start () {
		sushi = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void addIngredient(string s)
	{
		sushi += s;
	}

	void resetSushi()
	{
		sushi = "";
	}
}
