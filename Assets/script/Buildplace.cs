using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour {

	public GameObject towerPrefab;	//tower prefab reference

	void OnMouseUpAsButton()
	{
		GameObject g = (GameObject)Instantiate (towerPrefab);
		g.transform.position = transform.position + Vector3.up;
	}
}
