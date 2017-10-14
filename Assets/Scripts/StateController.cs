using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

    public State currentState;
	public Transform[] waypoints;
    public Transform eyes;
    public float lookRadius = 2f;
    public float lookRange = 20.0f;

    [HideInInspector] public int nextWaypoint;
    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector] public GameObject chaseTarget;

    void Awake() {
        nextWaypoint = 0;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        currentState.UpdateState(this);
    }
}
