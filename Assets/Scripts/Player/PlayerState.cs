using UnityEngine;

public class PlayerState : MonoBehaviour, LocomotionContext
{
    [SerializeField] LocomotionState currentState = new OnGround();

    public void JumpTransition() => currentState.Jump(this);

    public void LandTransition() => currentState.Land(this);

    public void SetState(LocomotionState state)
    {
        currentState = state;
    }
    public LocomotionState GetCurrentState()
    {
        return currentState;
    }
}