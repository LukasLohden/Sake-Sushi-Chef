using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {
    public GameObject tuna;
    public GameObject yellow_tail;
    public GameObject avacado;
    public GameObject shrimp;
    public GameObject crab;
    public GameObject rice;
    public GameObject nori;
    public GameObject teriyaki;
    public GameObject chilli_oil;

    public GameObject board_tuna;
    public GameObject board_yellow_tail;
    public GameObject board_avacado;
    public GameObject board_shrimp;
    public GameObject board_crab;
    public GameObject board_rice;
    public GameObject board_nori;
    public GameObject board_teriyaki;
    public GameObject board_chilli_oil;

    public GameObject cutting_board;
    private GameObject[] ingredients;
    private const int NUM_INGREDIENTS = 9;
    private int ingredient_count;
	// Use this for initialization
	void Start () {
        ingredients = new GameObject[NUM_INGREDIENTS];
        ingredient_count = 2;
        for (int i = 0; i < NUM_INGREDIENTS; i++){
            ingredients[i] = null;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void showIngredient (GameObject g) {
        if (g==tuna)
        {
            board_tuna.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if(g == yellow_tail)
        {
            board_yellow_tail.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == nori)
        {
            board_nori.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == rice)
        {
            board_rice.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == avacado)
        {
            board_avacado.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == shrimp)
        {
            board_shrimp.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == crab)
        {
            board_crab.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == chilli_oil)
        {
            board_chilli_oil.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
        else if (g == teriyaki)
        {
            board_teriyaki.GetComponent<SpriteRenderer>().sortingOrder = ingredient_count++;
        }
    }
}
