using UnityEngine;
using UnityEngine.InputSystem;


public class MC_Controlls : MonoBehaviour
{
    private float direction = 0f; // the position where the player starts

    [SerializeField] private float speed = 2f; // how much speed the MC got
    [SerializeField] private float jumpForce = 10f;

    public Rigidbody2D rb;

    [Header("The Groundcheck")] [SerializeField]
    private LayerMask groundLayer;

    [SerializeField] private Transform transformgroundCheck;


    [Header("The Manager")] [SerializeField]
    private UI_Manager managerUI; // to use the ui manager in this script

    [SerializeField] private CoinManager managerCoin;

    public bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        canMove = true;
    }

    void Update()
    {
        #region movement

        //if (canMove) {

        Debug.Log(rb.linearVelocity);

        direction = 0;


        if (Keyboard.current.aKey.isPressed && canMove == true)
        {
            direction = -1;
        }


        if (Keyboard.current.dKey.isPressed && canMove == true)
        {
            direction = 1;
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame && canMove == true)
        {
            Jump();
        }



        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
        //}


        #endregion
    }

    public void Jump()
    {

        if (canMove = true)
        {
            if (Physics2D.OverlapCircle(transformgroundCheck.position, 0.2f, groundLayer))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            }
        }

    }






    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("We entered a Trigger" + other.name);

        if (other.CompareTag("Coin"))
        {
            managerCoin.AddCoin();
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Obstacle"))
        {
            //Stop Movement && Show Lost panel

            managerUI.Showlose(); //show lost panel
            canMove = false;


        }

        if (other.CompareTag("win"))
        {
            Debug.Log("You win");
            if (managerCoin.coinCounter >= 15)
            {
                managerUI.winningMenu(); // show win panel

                canMove = false; // cannot move
            }
        }
    }
}
