using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Attack")]
public class AttackDecision : Decision {

	public override bool Decide(StateController controller) {
		return AttackTarget(controller);
	}
	public bool AttackTarget(StateController controller) {
		return controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance;
	}

}
