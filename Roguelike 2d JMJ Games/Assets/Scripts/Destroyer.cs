﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("SpawnPoint")||other.gameObject.CompareTag("ClosedWall"))
		{
			Destroy(other.gameObject);
		}
	}
}
