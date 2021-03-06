using System;
using System.Collections;
using System.Collections.Generic;

public class FSMState
{
	protected Dictionary<PlayerActions, PlayerStates> transitions = new Dictionary<PlayerActions, PlayerStates>();
	protected PlayerStates ID;
	
	public PlayerStates getID()
	{
		return ID;
	}
	
	public FSMState (PlayerStates newID)
	{
		ID=newID;
	}
	
	public void addTransition(PlayerActions newAction,PlayerStates newState)
	{//we want to check validity of the item to add
		transitions.Add(newAction,newState);
	}
	
	public PlayerStates validateNewAction(PlayerActions newAction)
	{
		
		if(transitions.ContainsKey(newAction))
		{
			return transitions[newAction];
		}
		
		return PlayerStates.NULL;
	}
	public void animateState(AnimationSprite animator)
	{
		int[] variables = AnimationVars.variables[ID];
		animator.animateSprite(variables[0],variables[1],variables[2],variables[3],variables[4],variables[5]);
	}
}

