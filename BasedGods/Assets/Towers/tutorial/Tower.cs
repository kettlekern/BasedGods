using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	public GameObject bulletPrefab;
	public float rotationSpeed = 35;
	public float cooldown = 1.0f;
	private float timer = 0.0f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
	}

	void OnTriggerStay(Collider co) {
		if(co.GetComponent<Monster>()) {
			timer -= Time.deltaTime;
			if(timer <= 0.0f) {
				timer = cooldown;
				GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
				g.GetComponent<Bullet>().target = co.transform;
			}
		}
	}
}