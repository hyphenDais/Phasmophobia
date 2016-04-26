using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectOrbs : MonoBehaviour {

	public delegate void OrbsCollected();
	public static event OrbsCollected OnCollect;
	
	//List example
	public List <string> orbList;
	int i;
	
	void OnTriggerEnter(Collider other)
	{
		//If statement example
		if (other.gameObject.tag == "Sphere") 
		Destroy (other.gameObject);
		//When the player touches a yellow sphere, it gets destroyed and added to the orbList.
		orbList.Add (other.gameObject.name);
		i++;   // every time an integer gets added to the list, i goes up by 1.
		if (i == 7)
		{
		print ("All orbs collected");
		}
		if (OnCollect != null)
			OnCollect();
	}
	
	// Use this for initialization
	void Start () 
	{
		print ("Collect all orbs");
	}

}
