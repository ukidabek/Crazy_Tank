using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.Inputs;

namespace CrazyTank.Inputs
{
	public class GamePadInputSource : BaseInputSource 
	{
		public override InputSourceEnum InputSourceType 
		{
			get { return InputSourceEnum.GamePadInput; }
		}

		[SerializeField]
		private AnalogInput _leftAnalog = new AnalogInput();

		[SerializeField]
		private AnalogInput _rightAnalog = new AnalogInput();

		public override Vector3 MovementVector 
		{
			get { return _leftAnalog.Axis; }
		}

		public override Vector3 LookVector 
		{
			get 
			{ 
				Vector2 reading = _rightAnalog.Axis;
				reading.x *= xLookAxisSensitivity;
				reading.y *= yLookAxisSensitivity;

				return reading; 
			}
		}

		protected override void Awake ()
		{
			physicalInputs.Add (_leftAnalog);
			physicalInputs.Add (_rightAnalog);

			base.Awake ();
		}
	}
}