using System;
using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.States
{
	public class PlayState : IStateBase
	{
		private StateManager manager;

		public PlayState (StateManager managerRef)
		{
			manager = managerRef;
			Debug.Log ("Play state");
		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState (new EndGameState (manager));
					}
		}

		public void ShowIt(){
		}

		public void StateFixedUpdate(){
		}
	}
}

