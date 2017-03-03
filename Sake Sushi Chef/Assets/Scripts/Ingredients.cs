using UnityEngine;
using System.Collections;

public class Ingredients : MonoBehaviour {

    private int cost_to_purchase = 0;
    private int cost_to_sell = 0;
    //private bool active = false;
    public GameObject cutting_board;
	public GameObject sushiSubmitButton;

	private bool hasCloned;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnMouseDown()
	{
		if (!hasCloned) {
			cutting_board.SendMessage ("showIngredient", gameObject);
			sushiSubmitButton.SendMessage ("addIngredient", gameObject.name);
			hasCloned = true;
		}
	}

	void ResetSushi()
	{
		hasCloned = false;
	}
}
