using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.Inputs;

namespace CrazyTank.Input
{
	public class BaseCrazyTankInputSource : BaseInputSource 
	{
		[SerializeField]
		protected ButtonInput _gearDown = new ButtonInput ();
		public ButtonInput GearDown 
		{
			get { return this._gearDown; }
		}

		[SerializeField]
		protected ButtonInput _gearUp = new ButtonInput ();
		public ButtonInput GearUp 
		{
			get { return this._gearUp; }
		}

		protected override void Awake ()
		{
			physicalInputs.Add (_gearUp);
			physicalInputs.Add (_gearDown);

			base.Awake ();
		}
	}
}