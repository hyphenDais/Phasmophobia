using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	public NavMeshAgent enemy;

	// Use this for initialization
	void Start () {
		enemy = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
