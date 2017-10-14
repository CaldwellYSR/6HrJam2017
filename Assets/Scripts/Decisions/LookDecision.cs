using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Look")]
public class LookDecision : Decision {
	public override bool Decide(StateController controller) {
		return LookForTarget(controller);
	}
	public bool LookForTarget(StateController controller) {
		RaycastHit hit;

		Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.lookRange, Color.red, 0);
		
		if (
			Physics.SphereCast(controller.eyes.position, controller.lookRadius, controller.eyes.forward, out hit, controller.lookRange)
			&& hit.collider.CompareTag("Player")
		) {
			controller.chaseTarget = hit.collider.gameObject;
			return true;
		} else {
			return false;
		}
	}
}
