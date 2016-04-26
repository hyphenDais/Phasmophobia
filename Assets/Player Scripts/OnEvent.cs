using UnityEngine;
using System.Collections;

public class OnEvent : MonoBehaviour {

	delegate void MyDelegate(int num);
	MyDelegate myDelegate;

	void Start ()
	{
		myDelegate = PrintNum;
		myDelegate(5);

		myDelegate = DoubleNum;
		myDelegate(5);
	}
	void PrintNum(int num)
	{
		print ("There were " + num + " reasons to be afraid...");
	}

	void DoubleNum(int num)
	{
		print ("But now, there are " + num * 2 + " reasons!");
	}

	void NoThreat ()
	{
		print ("Ignore the enemies. They're not the threat"); 
	}
}
