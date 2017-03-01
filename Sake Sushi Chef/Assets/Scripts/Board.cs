using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {

	public int baseSushiLayer;
	private int layerCount;
	// Use this for initialization
	void Start () {

		layerCount = baseSushiLayer;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void showIngredient (GameObject g) {

		GameObject ingredient = (GameObject)Instantiate(g, gameObject.transform.position, new Quaternion());
		ingredient.GetComponent<SpriteRenderer> ().sortingOrder = layerCount;
		ingredient.tag = "clone";
		++layerCount;
    }

    public void clearBoard()
    {

		foreach (GameObject clone in GameObject.FindGameObjectsWithTag("clone")) {
			Destroy (clone);
		}
		layerCount = baseSushiLayer;
    }
}
