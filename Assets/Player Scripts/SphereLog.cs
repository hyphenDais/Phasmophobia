using UnityEngine;
using System.Collections;

public class SphereLog : MonoBehaviour {

	public GameObject[] sphereList;

	// Use this for initialization
	void Start () {
		sphereList = GameObject.FindGameObjectsWithTag ("Sphere");
		for (int j = 0; j < sphereList.Length; j++)
			Debug.Log ("There are " + j + " on the board" + sphereList [j].name);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
