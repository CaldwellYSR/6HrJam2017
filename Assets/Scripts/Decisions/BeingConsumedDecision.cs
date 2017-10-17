using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Being Consumed")]
public class BeingConsumedDecision : Decision {

  public override bool Decide(StateController controller) {
    return IsAgentBeingConsumed(controller);
  }

  private bool IsAgentBeingConsumed(StateController controller) {
    return controller.beingConsumed;
  }
}
