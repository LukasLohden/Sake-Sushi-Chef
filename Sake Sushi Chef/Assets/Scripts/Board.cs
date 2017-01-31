using UnityEngine;
using System.Collections;

public class board : MonoBehaviour {
    GameObject cutting_board;
    private GameObject[] ingredients;
    private const int NUM_INGREDIENTS = 9;
	// Use this for initialization
	void Start () {
        ingredients = new GameObject[NUM_INGREDIENTS];
        for (int i = 0; i < NUM_INGREDIENTS; i++){
            ingredients[i] = null;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
