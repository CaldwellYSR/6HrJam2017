using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Chase")]
public class ChaseAction : Action {

	public override void Act(StateController controller) {
		ChaseTarget(controller);
	}

	private void ChaseTarget(StateController controller) {
		controller.navMeshAgent.speed = 8;
		controller.navMeshAgent.destination = controller.chaseTarget.transform.position;
		controller.navMeshAgent.Resume();
	}

}
