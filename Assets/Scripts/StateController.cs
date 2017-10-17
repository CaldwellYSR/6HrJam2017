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
    public AudioClip suprise;

    [HideInInspector] public int nextWaypoint;
    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector] public GameObject chaseTarget;
    [HideInInspector] public AudioSource supriseSource;
    [HideInInspector] public bool beingAttacked, beingConsumed;

    private bool soundsHavePlayed;

    void Awake() {
        nextWaypoint = 0;
        navMeshAgent = GetComponent<NavMeshAgent>();
        supriseSource = GetComponent<AudioSource>();
    }

    void Update() {
        currentState.UpdateState(this);
    }
}
