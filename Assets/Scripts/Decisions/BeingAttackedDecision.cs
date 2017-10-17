using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Being Attacked")]
public class BeingAttackedDecision : Decision {

  public override bool Decide(StateController controller) {
    return IsAgentBeingAttacked(controller);
  }

  private bool IsAgentBeingAttacked(StateController controller) {
    return controller.beingAttacked;
  }
}
