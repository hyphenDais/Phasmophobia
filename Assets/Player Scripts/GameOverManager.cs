using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour 
{
	public float hurryBack = 5f;

	Animator anim;
	float restartTimer;
	public AudioClip laugh;
	AudioSource playerAudio;

	void Awake ()
	{
		// Set up the reference.
		anim = GetComponent <Animator> ();
		playerAudio = GetComponent <AudioSource> ();
	}

	// Use this for initialization
	void Start () 
	{
	
	}

	void OnEnable()
	{
		InheritedFear.OnDeath += GameOverScreen;
	}

	void OnDisable()
	{
		InheritedFear.OnDeath -= GameOverScreen;
	}

	void GameOverScreen()
	{
		// If the player has run out of health...

			// ... tell the animator the game is over.
			anim.SetTrigger ("GameOver");

			// ... play the audio cue.
			playerAudio.Play ();

			// .. increment a timer to count up to restarting.
			restartTimer += Time.deltaTime;

			// .. if it reaches the restart delay...
			if (restartTimer >= hurryBack) 
			{
				// .. then reload the currently loaded level.
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
