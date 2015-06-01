using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	TextMesh tm;
	public Text resource;
	// Use this for initialization
	void Start () {
		tm = GetComponent<TextMesh> ();

	}
	
	// Update is called once per frame
	void Update () {
		transform.forward = Camera.main.transform.forward;
	}

	// Return the current Health by counting the '-'
	public int current() {
		return tm.text.Length;
	}
	
	// Decrease the current Health by removing one '-'
	public void decrease() {
		if (current () > 1)
			tm.text = tm.text.Remove (tm.text.Length - 1);
		else if (transform.parent.gameObject != null) {
			Destroy (transform.parent.gameObject);
			if (transform.parent.gameObject != null) {
				God.gold += Monster.worth;
				Debug.Log ("+" + Monster.worth + ", Total: " + God.gold.ToString());
				GameObject.Find("Gold").GetComponent<Text>().text = "Gold: " + God.gold.ToString();
			}
		}
	}
}