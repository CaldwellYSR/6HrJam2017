using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

    public State currentState;

	public Transform[] waypoints;

    [HideInInspector] public int nextWaypoint;
    [HideInInspector] public NavMeshAgent navMeshAgent;

    void Awake() {
        nextWaypoint = 0;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        currentState.UpdateState(this);
    }
}
