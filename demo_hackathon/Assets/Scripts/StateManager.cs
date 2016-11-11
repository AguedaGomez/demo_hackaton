﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.States;
using Assets.Scripts.Interfaces;

public class StateManager : MonoBehaviour {

	private IStateBase activeState;

	// Use this for initialization
	void Start () {
		activeState = new BeginState(this);
		Debug.Log("El estado activo es: " + activeState);
	}
	
	// Update is called once per frame
	void Update () {
		if (activeState != null) {
			activeState.StateUpdate ();
		}
	}

	public void SwitchState(IStateBase newState){
		activeState = newState;
	}
}
