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
		private BrakeObject _brake = null;
		public BrakeObject Brake 
		{
			get { return this._brake; }
			set { _brake = value;}
		}

		[SerializeField]
		private EngineObject _engine = null;
		public EngineObject Engine 
		{
			get { return this._engine; }
			set { _engine = value; }
		}

		[SerializeField]
		private GearboxObject _gearbox = null;
		public GearboxObject Gearbox 
		{
			get { return this._gearbox; }
			set { _gearbox = value; }
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

		public void Ride(float leftTrackRpm, float rightTrackRpm, float gas, float brake)
		{
			_controlValues.LeftTrackPower = leftTrackRpm;
			_controlValues.RightTrackPower = rightTrackRpm;
			_controlValues.Gas = gas;
			_controlValues.TrackBrakePower = brake;
		}
	}
}