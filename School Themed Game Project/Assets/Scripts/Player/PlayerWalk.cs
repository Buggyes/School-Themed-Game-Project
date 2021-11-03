using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    public Rigidbody2D plRig;
    void Start()
    {
        
    }
    void Update()
    {
        CheckMovement();
    }
    private void CheckMovement()
	{
        if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.velocity = new Vector2(moveSpeed, plRig.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            plRig.velocity = new Vector2(moveSpeed*-1, plRig.velocity.y);
        }
        else
		{
            plRig.velocity = new Vector2(0, plRig.velocity.y);
        }
    }
}
