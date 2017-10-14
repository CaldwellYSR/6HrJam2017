using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public float shootDistance;
	public float shootRadius;

	void Update() {
		if (Input.GetButton("Shoot"))
			Shoot();
	}
	
	public void Shoot() {
		RaycastHit hit;

		Debug.DrawRay(transform.position, transform.forward.normalized * shootDistance, Color.red, 0);
		
		if (
			Physics.SphereCast(transform.position, shootRadius, transform.forward, out hit, shootDistance)
			&& hit.collider.CompareTag("Enemy")
		) {
			Debug.Log("Hit EM!");
		}
	}
}
