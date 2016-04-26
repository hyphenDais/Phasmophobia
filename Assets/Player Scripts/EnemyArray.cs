using UnityEngine;
using System.Collections;

public class EnemyArray : EnemyMovement
{
	public GameObject[] enemies;

	// Use this for initialization

	void Start () 
	{
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");

		for (int i = 0; i < enemies.Length; i++) 
		{
			Debug.Log ("There are " + i + " enemies " + enemies [i].name);
		}
	}


}// end Attack class