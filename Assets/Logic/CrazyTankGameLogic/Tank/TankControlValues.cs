using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

namespace CrazyTank.Tank
{
	[Serializable]
	public class TankControlValues 
	{
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
		private float leftTrackBrakePower = 0f;
		public float LeftTrackBrakePower 
		{
			get { return this.leftTrackBrakePower; } 
			set { leftTrackBrakePower = value; }
		}

		[SerializeField, Range(0f, 1f)]
		private float rightTrackBrakePower = 0f;
		public float RightTrackBrakePower 
		{
			get { return this.rightTrackBrakePower; }
			set { rightTrackBrakePower = value; }
		}

	}
}