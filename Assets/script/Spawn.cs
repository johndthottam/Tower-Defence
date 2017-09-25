using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject MonsterPrefab;
	public float SpawnInterval = 4;

	void Start () {
		InvokeRepeating ("MonsterSpawn", SpawnInterval, SpawnInterval);
	}

	void MonsterSpawn()
	{
		Instantiate (MonsterPrefab, transform.position, Quaternion.identity);
	}

}
