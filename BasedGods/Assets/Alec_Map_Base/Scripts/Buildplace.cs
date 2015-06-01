using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Buildplace : MonoBehaviour {
	//Tower should be built
	public GameObject towerPrefab;
	public bool created = false;
	public Text resource;

	void OnMouseUpAsButton() {
		if (!created && God.gold >= 5) {
			GameObject g = (GameObject)Instantiate (towerPrefab);
			g.transform.position = transform.position + Vector3.up;
			created = true;
			God.gold -= 5;
			Debug.Log ("Built tower: -5, total: " + God.gold.ToString());
			resource.text = "Gold: " + God.gold.ToString();
		}
	}
}
