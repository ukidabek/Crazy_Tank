using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class TankObject : BaseStateObject
	{
		[SerializeField]
		private TankControlValues _controlValues = new TankControlValues ();
		public TankControlValues ControlValues 
		{
			get { return this._controlValues; }
		}

		[SerializeField]
		private TrackObject _leftTrack = null;
		public TrackObject LeftTrack 
		{
			get { return this._leftTrack; }
			set { _leftTrack = value; }
		}

		[SerializeField]
		private TrackObject _rightTrack = null;
		public TrackObject RightTrack 
		{
			get { return this._rightTrack; }
			set { _rightTrack = value; }
		}

		public void Ride(float leftTrackRpm, float rightTrackRpm)
		{
			_controlValues.LeftTrackPower = leftTrackRpm;
			_controlValues.RightTrackPower = rightTrackRpm;
		}
	}
}