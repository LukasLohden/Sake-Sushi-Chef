using UnityEngine;
using System.Collections;

public class LoadGame: MonoBehaviour {

	public void loadScene(string scene)
	{
		Application.LoadLevel (scene);
	}
}
