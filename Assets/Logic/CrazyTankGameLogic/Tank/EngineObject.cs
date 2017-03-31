using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class EngineObject : BaseStateObject
	{
		[SerializeField]
		private AnimationCurve _acceleration = new AnimationCurve();

		[SerializeField]
		private AnimationCurve _losses = new AnimationCurve();

		[SerializeField]
		private float _rpm = 0f;
		public float Rpm 
		{
			get { return this._rpm; }
		}

		[SerializeField]
		private float _maxRpm = 4000f;

		[SerializeField, Range(0,1f)]
		private float _gertShiftRpmLoss = 0.25f;

		public void ApplayGas(float gas)
		{
			float accelerationValue = _acceleration.Evaluate (gas);
			accelerationValue -= _losses.Evaluate (_rpm);
			_rpm += accelerationValue;

			_rpm = Mathf.Clamp (_rpm, 0f, _maxRpm);
		}

		public void ShiftGear()
		{
			_rpm *= 1f - _gertShiftRpmLoss;
		}
	}
}