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
			_tank.Engine.ApplayGas (_tank.ControlValues.Gas);

			_tank.Gearbox.InRpm = _tank.Engine.Rpm;

			_tank.LeftTrack.Rotate (_tank.Gearbox.OutRpm * _tank.ControlValues.LeftTrackPower);
			_tank.RightTrack.Rotate (_tank.Gearbox.OutRpm * _tank.ControlValues.RightTrackPower);

			float brakePower = _tank.Brake.Brake (_tank.ControlValues.TrackBrakePower);
			_tank.LeftTrack.Brake (brakePower);
			_tank.RightTrack.Brake (brakePower);

		}
	}
}