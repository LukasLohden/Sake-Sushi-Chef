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
    public GameObject onBoardIng;
    public GameObject ingObj;

    private GameObject[] ingredients;
    private const int NUM_INGREDIENTS = 9;
    private int ingredient_count;
	// Use this for initialization
	void Start () {
        ingredients = new GameObject[NUM_INGREDIENTS];
        ingredient_count = 0;
        for (int i = 0; i < NUM_INGREDIENTS; i++){
            ingredients[i] = null;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void showIngredient (GameObject g) {
        int num_child = ingObj.transform.childCount;
        for(int i=0; i < num_child; i++)
        {
            //print(ingObj.transform.GetChild(i));
            print("i= " + i);
            print("g=" + g);
            if(ingObj.transform.GetChild(i).gameObject == g)
            {
                print("    in first if");
                print("    IngCount=" + ingredient_count);
                if (ingredient_count < NUM_INGREDIENTS)
                {
                    print("        in second if");
                    ingredients[ingredient_count] = (GameObject)Instantiate(g, gameObject.transform);
                    ingredients[ingredient_count].GetComponent<SpriteRenderer>().sortingOrder = ingredient_count + 2;
                    ingredients[ingredient_count].transform.position = gameObject.transform.position;
                    ingredient_count++;
                    print("        " + ingredients);
                }
                break;
            }
        }


    }

    public void clearBoard()
    {
        foreach(GameObject item in ingredients)
        {
            Destroy(item);
        }
        for(int i=0; i < NUM_INGREDIENTS; i++)
        {
            ingredients[i] = null;
        }
    }
}
