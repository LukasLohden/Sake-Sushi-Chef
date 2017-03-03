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
		Reset ();
    }

	void Reset()
	{
		cutting_board.SendMessage("ClearBoard");
		sushiSubmitButton.SendMessage ("ResetSushi");
		foreach( GameObject ingredient in GameObject.FindGameObjectsWithTag("ingredient"))
		{
			ingredient.SendMessage ("ResetSushi");
		}
	}
}
