using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/State")]
public class State : ScriptableObject {

	public Action[] actions;
	public Transition[] transitions;

	public void UpdateState(StateController controller) {
		DoActions(controller);
		CheckTransitions(controller);
	}

	public void DoActions(StateController controller) {
		foreach(var action in actions) {
			action.Act(controller);
		}
	}

	public void CheckTransitions(StateController controller) {
		foreach(var transition in transitions) {
			if (transition.decision.Decide(controller)) {
				controller.currentState = transition.trueState;
			} else {
				controller.currentState = transition.falseState;
			}
		}
	}

}
