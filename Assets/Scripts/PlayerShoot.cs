using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public ParticleSystem shootParticles;
	public float shootDistance;
	public float shootRadius;

	void Update() {
		shootParticles.Stop();

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
			// shootParticles.shape.scale.x
			Debug.Log("Hit EM!");
		}

		shootParticles.Play();
	}
}
