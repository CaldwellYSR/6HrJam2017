using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/State")]
public class State : ScriptableObject {

	public Action[] actions;

	public void UpdateState(StateController controller) {
		DoActions(controller);
	}

	public void DoActions(StateController controller) {
		foreach(var action in actions) {
			action.Act(controller);
		}
	}

}
