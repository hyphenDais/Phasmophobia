using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {

	Animator anim;
	AudioSource playerAudio;
	public AudioClip hurryBack;

	void Awake ()
	{
		// Set up the reference.
		anim = GetComponent <Animator> ();
		playerAudio = GetComponent <AudioSource> ();
	}

	void OnEnable ()
	{
		CollectOrbs.OnCollect += VictoryScreen;
	}

	void OnDisable ()
	{
		CollectOrbs.OnCollect -= VictoryScreen;
	}

	void VictoryScreen()
	{
		// If the player has run out of health...

		// ... tell the animator the game is over.
		anim.SetTrigger ("Winning");

		// ... play the audio cue.
		playerAudio.Play ();

	}
}
