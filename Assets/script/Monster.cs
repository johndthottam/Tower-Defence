using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject castle = GameObject.Find ("Castle");
		if (castle) 
		{
			GetComponent<NavMeshAgent>().destination = castle.transform.position; //assign destination to enemy
		}
	}

	void OnTriggerEnter(Collider co)
	{
		if(co.name == "Castle")
		{
			co.GetComponentInChildren<Health> ().decreased ();  //reduce health of castle
			Destroy(gameObject);
		}
	}

}
