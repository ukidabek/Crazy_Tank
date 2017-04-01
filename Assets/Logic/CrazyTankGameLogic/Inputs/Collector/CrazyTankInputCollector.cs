using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.Inputs;

namespace CrazyTank.Input
{
	public class CrazyTankInputCollector : InputCollector 
	{
		private BaseCrazyTankInputSource _currentCrazyTankInputSource = null;
		public BaseCrazyTankInputSource CurrentCrazyTankInputSource 
		{
			get { return this._currentCrazyTankInputSource; }
			protected set { _currentCrazyTankInputSource = value; }
		}

		protected override bool SelectCurrentInputSourceInstance (BaseInputSource source)
		{
			bool baseSelectCurrentInputSource = base.SelectCurrentInputSourceInstance (source);
			if (baseSelectCurrentInputSource && 
				source is BaseCrazyTankInputSource) 
			{
				CurrentCrazyTankInputSource = source as BaseCrazyTankInputSource;
			}

			return baseSelectCurrentInputSource;
		}
	}
}