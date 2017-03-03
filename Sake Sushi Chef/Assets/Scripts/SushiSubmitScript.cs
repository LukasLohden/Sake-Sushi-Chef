using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SushiSubmitScript : MonoBehaviour {

	public SushiMenu sushiMenu;
	public Text customerText;
	public GameObject trashcan;
	public Button startResetButton;

	private string sushi;
	private string order;
	// Use this for initialization
	void Start () {
		sushi = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddIngredient(string s)
	{
		sushi += s;
	}

	void ResetSushi()
	{
		sushi = "";
	}

	void CheckSushi(){
		if (sushi.Equals(order)) {
			customerText.text = "Thank You";
			startResetButton.gameObject.SetActive (true);
		}
		else{
			customerText.text = "Incorrect, I would like a " + order;
		}
		trashcan.SendMessage ("Reset");
	}

	void ChooseRandomSushi(){
		int index = Random.Range(0,sushiMenu.sushiMenu.Length);
		order = sushiMenu.sushiMenu [index];
		customerText.text = "I would like a \n" + order;
	}
}
