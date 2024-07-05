using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardBehavior : StateMachineBehaviour
{
	PlayerStateMachine stateMachine;
	private readonly int fallHash = Animator.StringToHash("isFalling");
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		stateMachine = PlayerStateMachine.GetInstance();
		stateMachine.SwitchState(new PlayerDefenceState(stateMachine));
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.7f)
		{
			//animator.speed = 0f;
		}

// 		if (Input.GetKey(KeyCode.Mouse1))
// 		{
// 			isDefencing();
// 		}
// 		if (Input.GetKeyUp(KeyCode.Mouse1))
// 		{
// 			isNotDefencing();
// 		}

	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	//    
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove()
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	//    // Implement code that processes and affects root motion
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK()
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	//    // Implement code that sets up animation IK (inverse kinematics)
	//}
}