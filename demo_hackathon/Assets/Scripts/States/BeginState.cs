using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.States
{
	public class BeginState : IStateBase
	{
		private StateManager manager;

		public BeginState (StateManager managerRef)
		{
			manager = managerRef;
			Debug.Log ("Begin state");
		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState (new PlayState (manager));
			}
		}

		public void ShowIt(){
		}

		public void StateFixedUpdate(){
		}
	}
}

