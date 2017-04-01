using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.Character;

using CrazyTank.Tank;
using CrazyTank.Input;

namespace CrazyTank.Character
{
	public class DriverController : BasePlayerCharacterController
	{
		protected CrazyTankInputCollector crazyTankInputCollector = null;
		public CrazyTankInputCollector CrazyTankInputCollector {
			get 
			{
				if (crazyTankInputCollector == null &&
				   inputCollector is CrazyTankInputCollector) 
				{
					crazyTankInputCollector = inputCollector as CrazyTankInputCollector;
				}

				return this.crazyTankInputCollector;
			}
		}

		[SerializeField]
		private TankObject _tank = null;
		public TankObject Tank 
		{
			get { return this._tank; }
			set { _tank = value; }
		}
	}
}