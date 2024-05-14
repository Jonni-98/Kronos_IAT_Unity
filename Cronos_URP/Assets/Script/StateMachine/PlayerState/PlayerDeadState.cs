using UnityEngine;

public class PlayerDeadState : PlayerBaseState
{
	public PlayerDeadState(PlayerStateMachine stateMachine) : base(stateMachine) { }
	public override void Enter()
	{
		stateMachine.Animator.Rebind();
	}
	public override void Tick()
	{
		
	}

	public override void Exit()
	{
	}

}