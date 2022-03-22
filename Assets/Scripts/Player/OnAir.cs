using UnityEngine;

public class OnAir : LocomotionState
{
    public void Jump(LocomotionContext context){}
    public void Land(LocomotionContext context)
    {
        context.SetState(new OnGround());
        Debug.Log("Transisioned Ground");
    }
}
