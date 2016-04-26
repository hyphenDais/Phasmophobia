using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthForAll : MonoBehaviour {
	public int playerHealth;
	public float startingHealth;
	public float currentHealth;
	public GameObject healthBar; //reference to green health bar
	//public Slider healthSlider;
	//public Image damageImage;
	//public AudioClip deathClip;
	//public float flashSpeed = 5f;
	//public Color flashColor = new Color (1f, 0f, 0f, 0.1f);

	//Animator anim;
	//AudioSource playerAudio;
	MovePlayer playerMovement;
	bool isDead;
	//bool damaged;

	//bool dead;



	void Awake ()
	{
		//anim = GetComponent <Animator> ();
		//playerAudio = GetComponent <AudioSource> ();
		playerMovement = GetComponent <MovePlayer> ();

	}

	void Start () 
	{
	currentHealth = startingHealth;
	
	}

	// Update is called once per frame
	void Update () 
	{
		/* If the player has just been damaged...
		if(damaged)
		{
			// ... set the colour of the damageImage to the flash colour.
			damageImage.color = flashColor;
		}
		// Otherwise...
		/*
		else
		{
			// ... transition the colour back to clear.
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}


		// Reset the damaged flag.
		damaged = false;
		*/
	}
	//public void SetHealthBar (float myHealth)
	//{
		//healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	//	healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth,0f ,1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	//}

	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash.
	//	damaged = true;

		// Reduce the current health by the damage amount.
		//currentHealth -= 2f;
		//float calc_Health = currentHealth / playerHealth; // will control the scale of the health bar
		//SetHealthBar (calc_Health);

		// Set the health bar's value to the current health.
		//healthSlider.value = currentHealth;

		// Play the hurt sound effect.
		//playerAudio.Play ();

		// If the player has lost all it's health and the death flag hasn't been set yet...
		if(currentHealth <= 0 && !isDead)
		{
			// ... it should die.
			Death ();
		}
	}


	void Death ()
	{
		// Set the death flag so this function won't be called again.
		isDead = true;

		// Tell the animator that the player is dead.
		//anim.SetTrigger ("Die");

		// Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
		//playerAudio.clip = deathClip;
		//playerAudio.Play ();

		// Turn off the movement and shooting scripts.
		playerMovement.enabled = false;
	}       




}
