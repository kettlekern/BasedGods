using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Navigate to Castle
		GameObject castle = GameObject.Find("Base 1");
		if (castle)
			GetComponent<NavMeshAgent>().destination = castle.transform.position;
	}

	void OnTriggerEnter(Collider co) {
		// If castle then deal Damage, destroy self
		if (co.name == "Base 1") {
			co.GetComponentInChildren<Health>().decrease();
			Destroy(gameObject);
		}
	}

}
