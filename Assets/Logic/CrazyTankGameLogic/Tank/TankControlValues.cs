using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

namespace CrazyTank.Tank
{
	[Serializable]
	public class TankControlValues 
	{
		[SerializeField, Range(0f, 1f)]
		private float _gas= 0f;
		public float Gas 
		{
			get { return this._gas; } 
			set { _gas = value; }
		}

		[SerializeField, Range(-1f, 1f)]
		private float leftTrackPower = 0f;
		public float LeftTrackPower 
		{
			get { return this.leftTrackPower; } 
			set { leftTrackPower = value; }
		}

		[SerializeField, Range(-1f, 1f)]
		private float rightTrackPower = 0f;
		public float RightTrackPower 
		{
			get { return this.rightTrackPower; }
			set { rightTrackPower = value; }
		}

		[SerializeField, Range(0f, 1f)]
		private float trackBrakePower = 0f;
		public float TrackBrakePower 
		{
			get { return this.trackBrakePower; } 
			set { trackBrakePower = value; }
		}
	}
}