using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/PatrolAction")]
public class PatrolAction : Action {

	public Transform[] waypoints;

	public override void Act(StateController controller) {
	}
}
