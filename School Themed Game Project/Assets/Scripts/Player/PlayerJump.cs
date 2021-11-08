using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    [SerializeField] private Animator an;
    [SerializeField] private float jumpStr, speedLimit;
    [SerializeField] private bool hasAnimator;
    private bool ableToJump;
    private int divideForce;
    public bool ableToMove;
    private void Start()
    {
        divideForce = 1;
        if (hasAnimator == true)
        {
            an.GetComponent<Animator>();
        }
    }
    void Update()
    {
        if (ableToMove == true)
        {
            if(Input.GetKey(KeyCode.UpArrow) && ableToJump == true)
			{
                plRig.AddForce(new Vector2(plRig.velocity.x, jumpStr/divideForce));
                divideForce++;
                if (hasAnimator == true)
                {
                    an.SetBool("isJumping", true);
                }
            }
            else if(Input.GetKeyUp(KeyCode.UpArrow) && ableToJump == true && plRig.velocity.y > 0)
			{
                ableToJump = false;
			}
            if (plRig.velocity.y >= speedLimit)
            {
                ableToJump = false;
            }
            CheckSpeed();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D hitContact in collision.contacts)
        {
            if (hitContact.normal.y > 0)
            {
                ableToJump = true;
                divideForce = 1;
                plRig.velocity.y.Equals(0);
                if (hasAnimator == true)
                {
                    an.SetBool("isJumping", false);
                }
            }
        }
    }
    private void CheckSpeed()
	{
        if(plRig.velocity.y > 0)
		{
            an.SetBool("isGoingUp", true);
            an.SetBool("isGoingDown", false);
        }
        else if(plRig.velocity.y < 0)
		{
            if(ableToJump == true)
			{
                ableToJump = false;
			}
            an.SetBool("isGoingUp", false);
            an.SetBool("isGoingDown", true);
        }
	}
}
