using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State
{
    public PatrolState(StateAgent owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        owner.movement.Resume();
        owner.navigation.targetNode = owner.navigation.GetNearestNode();
        owner.timer.value = Random.Range(5, 10);
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        //handled by state agent
    }

}
