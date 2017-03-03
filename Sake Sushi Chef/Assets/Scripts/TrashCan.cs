using UnityEngine;
using System.Collections;

public class TrashCan : MonoBehaviour {

    public GameObject cutting_board;
	public GameObject sushiSubmitButton;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        cutting_board.SendMessage("clearBoard");
		sushiSubmitButton.SendMessage ("resetSushi");
		foreach( GameObject ingredient in GameObject.FindGameObjectsWithTag("ingredient"))
		{
			ingredient.SendMessage ("ResetSushi");
		}
    }
}
