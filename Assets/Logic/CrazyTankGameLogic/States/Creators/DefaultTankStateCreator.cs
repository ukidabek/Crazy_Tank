using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Tank
{
	[CreateAssetMenu(
		fileName = "DefaultTankStateCreator.asset", 
		menuName = "StateCreator/DefaultTankStateCreator")]
	public class DefaultTankStateCreator : BaseStateCreator 
	{
		public override BaseState CreateProduct (
			BaseStateObject controlledObject, 
			BaseInputCache inputCache, 
			BaseAnimationHandlingCache animationHandlingCache)
		{
			DefaultTankState newState = new DefaultTankState (
				                            controlledObject,
				                            inputCache,
				                            animationHandlingCache);

			return newState;
		}
	}
}
