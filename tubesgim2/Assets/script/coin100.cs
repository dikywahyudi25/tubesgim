﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin100 : MonoBehaviour
{
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag.Equals ("player1")){
			print("coin diambil");
			Destroy (gameObject);
			DolarScore.hitungDolar += 100;
			
		}
	}

}