using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {
	private bool homeBase;
	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
		homeBase = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

	/*void onMouseUpAsButton(){
		if (homeBase) {
			mainCamera.transform.localPosition = new Vector3(82.8f, 18.0f, -23.0f);
		} else {
			mainCamera.transform.localPosition = new Vector3(0.0f, 18.0f, -23.0f);
		}
	}*/

	void ToggleCamera(){
		if (homeBase) {
			mainCamera.transform.localPosition = new Vector3(82.8f, 18.0f, -23.0f);
		} else {
			mainCamera.transform.localPosition = new Vector3(0.0f, 18.0f, -23.0f);
		}
		homeBase = !homeBase;
	}
}
