using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class ATypeEnemySMBReturn : SceneLinkedSMB<ATypeEnemyBehavior>
{
    public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _monoBehaviour.ChangeDebugText("RETURN");

        _monoBehaviour.Controller.SetFollowNavmeshAgent(true);
        _monoBehaviour.Controller.SetTarget(_monoBehaviour.BasePosition);
    }

    public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnSLStateNoTransitionUpdate(animator, stateInfo, layerIndex);

        _monoBehaviour.FindTarget();

        // Ÿ�� �߰� ��
        GameObject currentTarget = _monoBehaviour.CurrentTarget;
        if (currentTarget != null)
        {
            // ���� ���·� ����
            _monoBehaviour.StartPursuit();
        }
        else
        {
            // ������ ���� �� Idle ���� ����
            Vector3 toBase = _monoBehaviour.BasePosition - _monoBehaviour.transform.position;
            toBase.y = 0;
            if (_monoBehaviour.IsNearBase() == true)
            { 
                _monoBehaviour.TriggerIdle();
            }
        }
    }
    public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _monoBehaviour.Controller.SetFollowNavmeshAgent(false);
    }
}