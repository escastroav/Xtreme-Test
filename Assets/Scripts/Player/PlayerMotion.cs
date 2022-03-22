using UnityEngine;

public class PlayerMotion : MonoBehaviour, IMovable
{
    float horizontalMotion = 0;
    [SerializeField] float speed = 0.2f;
    [SerializeField] float jumpSpeed = 1.0f;

    PlayerState playerStates = null;
    Rigidbody2D rb = null;

    void Start()
    {
        playerStates = GetComponent<PlayerState>();

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {        
        if(playerStates.GetCurrentState() is OnGround)
            MovePattern();
        Debug.Log(playerStates.GetCurrentState());
        if(playerStates.GetCurrentState() is OnGround && Input.GetKeyDown(KeyCode.Space))
        {
            JumpPattern();
        }
    }

    public void MovePattern()
    {
        horizontalMotion = Input.GetAxisRaw("Horizontal") * speed; 
        Vector2 motion = new Vector2(horizontalMotion,rb.velocity.y);
        rb.velocity = motion;
    }

    public void JumpPattern()
    {        
        playerStates.JumpTransition();
        float upForce = jumpSpeed * 60f;
        Vector3 vectorJumpForce = new Vector3(0f,upForce,0f);
        rb.AddForce(vectorJumpForce, ForceMode2D.Impulse);

    }
}
