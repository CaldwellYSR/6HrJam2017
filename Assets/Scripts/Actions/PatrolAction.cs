using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Patrol")]
public class PatrolAction : Action {

	public override void Act(StateController controller) {
		Patrol(controller);
	}

	private void Patrol(StateController controller) {
		controller.navMeshAgent.speed = 5;
		controller.navMeshAgent.destination = controller.waypoints[controller.nextWaypoint].position;
		controller.navMeshAgent.Resume();
		if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance) {
			controller.nextWaypoint = (controller.nextWaypoint + 1) % controller.waypoints.Length;
		}
	}
}
