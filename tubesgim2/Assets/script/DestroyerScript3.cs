﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript3 : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D other){
 	if (other.tag == "Player") {
 		Application.LoadLevel(8);
 		return;
 	}
 	if(other.gameObject.transform.parent){
 		Destroy (other.gameObject.transform.parent.gameObject);

 	}else{
 		Destroy (other.gameObject);
 	}
 }
}
