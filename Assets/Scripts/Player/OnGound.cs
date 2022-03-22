using UnityEngine;

public class OnGround : LocomotionState
{
    public void Jump(LocomotionContext context)
    {
        context.SetState(new OnAir());
        Debug.Log("transitioned Jump");
    }
    public void Land(LocomotionContext context){}
}
