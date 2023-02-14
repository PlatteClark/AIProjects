using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : State
{
    public DeathState(StateAgent owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        owner.animator.SetBool("IsDead", true);
        owner.movement.Stop();
    }

    public override void OnExit()
    {
    }

    public override void OnUpdate()
    {
        if (owner.animationDone)
        {
            owner.GetComponent<Collider>().enabled = false;
            GameObject.Destroy(owner.gameObject, 5);
        }
    }

}
