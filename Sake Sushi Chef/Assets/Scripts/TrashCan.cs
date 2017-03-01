using UnityEngine;
using System.Collections;

public class TrashCan : MonoBehaviour {

    public GameObject cutting_board;
	public GameObject sushi;
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
		sushi.SendMessage ("resetSushi");
    }
}
