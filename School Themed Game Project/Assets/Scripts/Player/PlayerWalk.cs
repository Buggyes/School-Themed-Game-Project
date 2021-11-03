using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator plAn;
    public Rigidbody2D plRig;
    void Start()
    {
        plAn.GetComponent<Animator>();
    }
    void Update()
    {
        CheckMovement();
    }
    private void CheckMovement()
	{
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            plAn.SetBool("isRunning", true);
            plRig.velocity = new Vector2(moveSpeed * 2f, plRig.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            plAn.SetBool("isRunning", true);
            plRig.velocity = new Vector2(moveSpeed * -2f, plRig.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plAn.SetBool("isRunning", true);
            plRig.velocity = new Vector2(moveSpeed, plRig.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            plAn.SetBool("isRunning", true);
            plRig.velocity = new Vector2(moveSpeed*-1, plRig.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
		{
            plAn.SetBool("isRunning", false);
            plRig.velocity = new Vector2(0, plRig.velocity.y);
        }
    }
}
