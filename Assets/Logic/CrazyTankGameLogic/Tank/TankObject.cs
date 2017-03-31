using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class TankObject : BaseStateObject
	{
		[SerializeField]
		private TrackObject _leftTrack = new TrackObject();

		[SerializeField]
		private TrackObject _rightTrack = new TrackObject();

		public void Ride(float leftTrackRpm, float rightTrackRpm)
		{
			_leftTrack.Rotate (leftTrackRpm);
			_rightTrack.Rotate (rightTrackRpm);
		}
	}
}