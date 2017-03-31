using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Character
{
	public class DefaultLocomotionState : BaseState 
	{
		protected DriverController driver = null;

		public DefaultLocomotionState (
			BaseStateObject controlledObject, 
			BaseInputCache inputCache, 
			BaseAnimationHandlingCache animationHandlingCache) 
			: base (controlledObject, inputCache, animationHandlingCache)
		{
			if (controlledObject is DriverController) 
			{
				driver = ControlledObject as DriverController;
			}
		}
		
		public override void Enter ()
		{
		}

		public override void Exit ()
		{
		}

		public override void Sleep ()
		{
		}

		public override void Awake ()
		{
		}

		public override void OnUpdate ()
		{
			Vector2 leftTrack = driver.InputCollector.CurrentInputSourceInstance.MovementVector;
			Vector2 rightTrack = driver.InputCollector.CurrentInputSourceInstance.LookVector;
			Vector2 triggers = driver.InputCollector.CurrentInputSourceInstance.TriggersVector;

			driver.Tank.Ride (leftTrack.y, rightTrack.y, triggers.y, triggers.x);
		}

		public override void OnLateUpdate ()
		{
		}

		public override void OnFixedUpdate ()
		{
		}
	}
}