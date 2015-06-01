using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {
	//Tower should be built
	public GameObject towerPrefab;
	public bool created = false;

	void OnMouseUpAsButton() {
		if (!created) {
			GameObject g = (GameObject)Instantiate (towerPrefab);
			g.transform.position = transform.position + Vector3.up;
			created = true;
		}
	}
}
