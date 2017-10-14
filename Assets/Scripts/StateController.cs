using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour {

    public State currentState;
	public Transform[] waypoints;

    void Update() {
        currentState.UpdateState(this);
    }
}
