﻿using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	protected bool playerDetected;
	


	// Use this for initialization
	public virtual void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}

	public void playerDetectedOn(){
		playerDetected = true;
	}
	public void playerDetectedOff(){
		playerDetected = false;
	}

}
