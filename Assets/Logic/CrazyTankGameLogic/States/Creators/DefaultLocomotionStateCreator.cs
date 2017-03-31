using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.States;

namespace CrazyTank.Character
{
	[CreateAssetMenu(
		fileName = "DefaultLocomotionStateCreator.asset", 
		menuName = "StateCreator/DefaultLocomotionStateCreator")]
	public class DefaultLocomotionStateCreator : BaseStateCreator
	{
		public override BaseState CreateProduct (
			BaseStateObject controlledObject, 
			BaseInputCache inputCache, 
			BaseAnimationHandlingCache animationHandlingCache)
		{
			DefaultLocomotionState newState = new DefaultLocomotionState (
				                                  controlledObject,
				                                  inputCache,
				                                  animationHandlingCache);

			return newState;
		}
	}
}