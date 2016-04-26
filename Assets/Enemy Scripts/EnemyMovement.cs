using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private float smoothSailing = 1f;
	public Transform target;

	void Start () 
	{
		// On Startup, have the Coroutine begin closing the gap between the enemy and the target
		StartCoroutine (EnemyCoroutine (target));
	}

	IEnumerator EnemyCoroutine (Transform target)
	{
		// While the enemy is too fay away from the target, it needs to continue to
		// shorten the distance between itself and the target. Therefore, it must
		// keep closing in on the target until it reaches it.
		// Create a while loop to tell the enemy what needs to be done if outside
		// the target's range.
		while (Vector3.Distance (transform.position, target.position) > 5f) 
		{
			//While this loop is being run, it means the enemy is too far away and needs to close the gap.
			// This loop will continue to run until the gap has been closed.
			transform.position = Vector3.Lerp (transform.position, target.position, smoothSailing * Time.deltaTime);
			yield return null;
		}

		// When the target is reached, a message needs to be displayed saying so
		if (Vector3.Distance (transform.position, target.position) <= 5f) 
		{
			//print ("Target acquired");

			// Wait X seconds for the Coroutine to determine if the enemy has kept the gap closed for X seconds.
			yield return new WaitForSeconds (3f);

			// If the enemy has kept the gap closed for at least X seconds, display a message saying the coroutine 
			// has completed.
			print ("Coroutine Finished");
			OnCoroutineEnd ();

		}

	}

	void OnCoroutineEnd()
	{
		DestroyObject (gameObject);
	}

}
