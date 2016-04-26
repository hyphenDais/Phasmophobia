using UnityEngine;
using System.Collections;

public class InheritedFear : Nyctophobia {

	public delegate void AlarmingPain(); 
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
		switch(randomNum)
		{
		case 5:
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
		if(OnDeath != null)
			OnDeath();
	}
}
