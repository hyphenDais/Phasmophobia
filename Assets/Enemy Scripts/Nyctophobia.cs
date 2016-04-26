using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Nyctophobia : MonoBehaviour 
{
	public int playerHealth;
	public float startingHealth;
	public float currentHealth;

	public MovePlayer movement;

	void Awake ()
	{
		movement = GetComponent <MovePlayer> ();
	}

	void Start ()
	{
		currentHealth = playerHealth;
	}
		
	public void ChangeColor ()
	{
		GetComponent<Renderer>().material.color = Color.cyan;	
		movement.enabled = false;
	}



}//end Class
