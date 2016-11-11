using System;
using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.States
{
	public class EndGameState : IStateBase
	{
		private StateManager manager;

		public EndGameState (StateManager managerRef)
		{
			manager = managerRef;
			Debug.Log ("Endgame state");
		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState (new BeginState (manager));
			}
		}

		public void ShowIt(){
		}

		public void StateFixedUpdate(){
		}
	}
}

