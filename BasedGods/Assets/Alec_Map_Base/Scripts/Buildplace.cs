using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {
	//Tower should be built
	public GameObject towerPrefab;

	void OnMouseUpAsButton() {
		GameObject g = (GameObject)Instantiate(towerPrefab);
		g.transform.position = transform.position + Vector3.up;
	}
}
