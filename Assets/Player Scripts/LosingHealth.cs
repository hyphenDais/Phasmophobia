using UnityEngine;
using System.Collections;

public class LosingHealth : Nyctophobia {

	public GameObject[] threatList;

	// Use this for initialization
	void Start () {
		threatList = GameObject.FindGameObjectsWithTag ("Enemy");

		for (int i = 0; i < threatList.Length; i++) {
			Debug.Log ("Enemy Number " + i + " is logged" + threatList [i].name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
