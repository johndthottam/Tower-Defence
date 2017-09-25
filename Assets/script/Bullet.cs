using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 12;
	public Transform target;

	void FixedUpdate()
	{
		if(target)  //is target valid
		{
			Vector3 dir = target.position - transform.position; //direction of enemy
			GetComponent<Rigidbody> ().velocity = dir.normalized * speed; //speed
		}
		else
		{
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider co)
	{
		Health health = co.GetComponentInChildren<Health> ();
		if (health) 
		{
			health.decreased ();
			Destroy (gameObject);
		}
	}
}
