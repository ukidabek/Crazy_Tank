using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.Character;

using CrazyTank.Tank;

namespace CrazyTank.Character
{
	public class DriverController : BasePlayerCharacterController
	{
		[SerializeField]
		private TankObject _tank = null;
		public TankObject Tank 
		{
			get { return this._tank; }
			set { _tank = value; }
		}
	}
}