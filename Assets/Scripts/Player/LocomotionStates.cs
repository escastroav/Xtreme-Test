using UnityEngine;

public interface LocomotionContext
{
    void SetState(LocomotionState state);
    LocomotionState GetCurrentState();
}

public interface LocomotionState
{
    void Jump(LocomotionContext context);
    void Land(LocomotionContext context);
}


