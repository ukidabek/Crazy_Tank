using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	public class TrackObject : BaseStateObject
	{
		[SerializeField]
		private List<WheelCollider> _trackWheelsList = new List<WheelCollider>();

		public void Rotate(float power)
		{
			for (int i = 0; i < _trackWheelsList.Count; i++) 
			{
				WheelCollider wheel = _trackWheelsList [i];
				wheel.motorTorque = power; 
			}
		}

		public void Brake(float power)
		{
			for (int i = 0; i < _trackWheelsList.Count; i++) 
			{
				WheelCollider wheel = _trackWheelsList [i];
				wheel.brakeTorque = power; 
			}
		}
	}
}