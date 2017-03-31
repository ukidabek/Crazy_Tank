using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class DefaultTankState : BaseState 
	{
		private TankObject _tank = null;

		public DefaultTankState (
			BaseStateObject controlledObject, 
			BaseInputCache inputCache, 
			BaseAnimationHandlingCache animationHandlingCache) 
			: base (controlledObject, inputCache, animationHandlingCache)
		{
			if (controlledObject is TankObject) 
			{
				_tank = controlledObject as TankObject;
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
		}

		public override void OnLateUpdate ()
		{
		}

		public override void OnFixedUpdate ()
		{
			_tank.LeftTrack.Rotate (1000 * _tank.ControlValues.LeftTrackPower);
			_tank.RightTrack.Rotate (1000 * _tank.ControlValues.RightTrackPower);

			_tank.LeftTrack.Brake (1000 * _tank.ControlValues.LeftTrackBrakePower);
			_tank.RightTrack.Brake (1000 * _tank.ControlValues.RightTrackBrakePower);

		}
	}
}