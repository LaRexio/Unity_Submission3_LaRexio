using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class MC_Controlls : MonoBehaviour
{
    private float direction = 0f; // the position where the player starts

    [SerializeField] private float speed = 2f; // how much speed the MC got
    [SerializeField] private float jumpForce = 10f;

    private Rigidbody rb;

    #region GroundCheck

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform transformgroundCheck;

    #endregion

    [SerializeField] private UI_Manager ManagerUI; // to use the ui manager in this script
    [SerializeField] private Coin_Manager ManagerCoin;
    private bool playerCanMove = true; // Player can move the MC

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCanMove = true;
    }

    void Update()
    {
        #region movement

        Debug.Log(rb.linearVelocity);

        direction = 0;


        if (Keyboard.current.aKey.isPressed)
        {
            direction = -1;
        }


        if (Keyboard.current.dKey.isPressed)
        {
            direction = 1;
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame) 
        { Jump();}

        
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        
        #endregion
    }

    void Jump()
    {
        if (Physics2D.OverlapCircle(transformgroundCheck.position, 0.2f, groundLayer))
    }
}






/*
            private void OnTriggerEnter2D(Collider2D other)
            {
            
                Debug.Log("We entered a Trigger" + other.name);

                if (other.CompareTag("coin"))
                {
                    Coin_Manager.AddCoin();
                    Destroy(other.gameObject);
                }

                else if (other.CompareTag("obstacle"))
                {
                    //Stop Movement && Show Lost panel

                    UI_Manager.Showlose();
                    playerCanMove = false;

                
                }
            }
*/
