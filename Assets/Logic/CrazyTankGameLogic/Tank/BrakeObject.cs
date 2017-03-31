using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class BrakeObject : BaseStateObject 
	{
		[SerializeField]
		private AnimationCurve _brakingCharacteristic = new AnimationCurve();

		public float Brake(float power)
		{
			return _brakingCharacteristic.Evaluate (power);
		}
	}
}