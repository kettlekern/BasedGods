using UnityEngine;
using System.Collections;

public class MenuFunctionality : MonoBehaviour {
	public string newGameScene;
	// Use this for initialization
	void Start () {
		newGameScene = "AllBlocks";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeToScene(){
		Application.LoadLevel(newGameScene);
	}
}
