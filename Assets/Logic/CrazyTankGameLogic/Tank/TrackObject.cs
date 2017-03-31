using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

namespace CrazyTank.Tank
{
	[Serializable]
	public class TrackObject 
	{
		[SerializeField]
		private List<WheelCollider> _trackWheelsList = new List<WheelCollider>();

		public void Rotate(float rpm)
		{
			for (int i = 0; i < _trackWheelsList.Count; i++) 
			{
				WheelCollider wheel = _trackWheelsList [i];
				wheel.motorTorque = rpm; 
			}
		}
	}
}