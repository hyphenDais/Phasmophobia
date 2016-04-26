using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private MovePlayer player; //name of the class
	public float moveSpeed; // calculates the speed at which player moves 
	public float backUp;
	public float jumpSpeed; // calculates how high player can jump
	//public float runSpeed = 10f;

	// Use this for initialization
	void Start () 
	{

	}


	// Update is called once per frame
	void Update () 
	{
		Moving ();
	}

	void Moving()
	{
		//deltaTime calcualtes how fast Lidia moves every second instead of every frame.
		if (Input.GetKey (KeyCode.W)) // this allows Lidia to move forward
			transform.Translate (Vector3.up * jumpSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.S)) // this allows Lidia to move backwards 
			transform.Translate (new Vector3 (0,0, -backUp) * Time.deltaTime);

		if (Input.GetKey (KeyCode.A)) // this allows Lidia to turn Left
			transform.Translate (new Vector3 (0,0, -backUp) * Time.deltaTime);

		if (Input.GetKey (KeyCode.D)) // this allows Lidia to turn right
			transform.Translate (new Vector3 (0,0, backUp) * Time.deltaTime);

		if (Input.GetKey (KeyCode.Space)) //this allows Lidia to jump
			transform.Translate (Vector3.up * jumpSpeed * Time.deltaTime);
	}
}
