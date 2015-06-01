using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bullet : MonoBehaviour {

	public float speed = 10;
	public Transform target;
	public Text resource;

	void FixedUpdate () {
		if (target) {
			Vector3 dir = target.position - transform.position;
			GetComponent<Rigidbody>().velocity = dir.normalized * speed;
		} else {
			Destroy(gameObject);

		}
	}

	void OnTriggerEnter(Collider co) {
		Health health = co.GetComponentInChildren<Health>();
		if (health) {
			health.decrease();
			if (health.current() <= 1) {
				God.gold += Monster.worth;
				resource.text = "Gold: " + God.gold.ToString();
				Debug.Log ("+" + Monster.worth + ", Total: " + God.gold.ToString());
			}
			Destroy(gameObject);
		}
	}
}
