using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	TextMesh textmesh;

	void Start()
	{
		textmesh = GetComponent<TextMesh> ();  //creating reference to Textmesh component
	}

	void Update()
	{
		transform.forward = Camera.main.transform.forward;  //make element face camera

	}

	//get current health by geting number of "-"
	public int current()
	{
		return textmesh.text.Length;
	}

	//Decrease health "-" when taking damage
	public void decreased()
	{
		if (current () > 1) {
			textmesh.text = textmesh.text.Remove (textmesh.text.Length - 1);
		}
		else
		{
			Destroy (transform.parent.gameObject);//destory the gameobject
		}
	}
}
