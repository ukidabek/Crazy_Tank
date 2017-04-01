using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class GearboxObject : BaseStateObject 
	{
		[SerializeField]
		private int _currentGear = 0;

		[SerializeField]
		private List<Gear> _gears = new List<Gear>();

		[SerializeField]
		private float _inRpm = 0f;
		public float InRpm 
		{
			get { return this._inRpm; }
			set 
			{ 
				_inRpm = value;

				_outRpm = _inRpm / _gears [_currentGear].GearRatio;
			}
		}

		[SerializeField]
		private float _outRpm = 0f;
		public float OutRpm 
		{
			get { return this._outRpm; }
			set { _outRpm = value; }
		}
	}

	[Serializable]
	public class Gear
	{
		[SerializeField]
		public float GearRatio = 1f;
	}
}