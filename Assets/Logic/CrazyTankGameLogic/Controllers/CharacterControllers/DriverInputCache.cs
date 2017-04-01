using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;
using BaseGameLogic.Inputs;
using BaseGameLogic.Character;

using CrazyTank.Tank;

namespace CrazyTank.Character
{
	public class DriverInputCache : BaseInputCache 
	{
		public ButtonInput GearUp { get; set; }
		public ButtonInput GearDown { get; set; }
	}
}