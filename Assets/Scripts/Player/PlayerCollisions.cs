using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    PlayerState state;

    private void Start() {
        state = GetComponent<PlayerState>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "PlayableSurface")
        {
            state.LandTransition();
        }    
        
    }
    
}