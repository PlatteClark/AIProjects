using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{

    public IdleState(StateAgent owner) : base(owner){}

    public override void OnEnter()
    {
        owner.timer.value = 2;
    }

    public override void OnExit()
    {
    }

    public override void OnUpdate()
    {
        // handled by state agent now.
    }
}
