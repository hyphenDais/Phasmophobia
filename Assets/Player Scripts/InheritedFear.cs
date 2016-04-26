using UnityEngine;
using System.Collections;

// InheritedFear class is inherting the Nyctophobia script with all its variables and functions
public class InheritedFear : Nyctophobia {

	public delegate void AlarmingPain(); 
	
	//Event example
	public static event AlarmingPain OnDeath;
	int randomNum;

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Terror") 
		{
			Destroy (other.gameObject);
			randomNum = Random.Range (0, 6);
			FearDamage ();
			playerHealth = playerHealth - randomNum;
			print (randomNum);
			if (playerHealth <= 0)
				Dead ();
		}
	}

	void FearDamage()
	{
		// Switch statment example
		// When the player touches a purple capsule, a random damage amount is subtracted from the player's health
		// Based upon the number rolled, the following switch statement will apply the proper damage and message.
		switch(randomNum)
		{
		case 5:
			// If the player is dealt 5 damage, a Coroutine will be called
			print ("You took 5 damage. You are frozen with fear!");
			StartCoroutine (FreezeCharacter ());
			break;

		case 4:
			print ("You took 4 damage. You are terrified!");
			break;

		case 3:
			print ("You took 3 damage. You're really scared");
			break;

		case 2:
			print ("You took 2 damage. You feel anxious");
			break;

		case 1:
			print ("You took 1 damage. You feel unaeasy");
			break;

		default:
			print ("You feel fine");
			break;
		}//end switch statement
	}// end Fear Damage 
	
	// Coroutine example. When the player is dealt 5 damage, the FreezeCharacter coroutine will be called.
	// It will disable the character's movement for 5 seconds and change the player's color to cyan. 
	// After 5 seconds, the character's color will revert to green, and their movement will return.
	IEnumerator FreezeCharacter()
	{
		Debug.Log ("Coroutine started");
		ChangeColor ();
		yield return new WaitForSeconds (5f);
		Debug.Log ("Coroutine Finished");
		movement.enabled = true;
		GetComponent<Renderer>().material.color = Color.green;
	}

	void Dead ()
	{
		print ("You're health has been depleted");
		movement.enabled = !movement.enabled;
		//Event is being broadcast to the GameOverManager script.
		if(OnDeath != null)
			OnDeath();
	}
}
