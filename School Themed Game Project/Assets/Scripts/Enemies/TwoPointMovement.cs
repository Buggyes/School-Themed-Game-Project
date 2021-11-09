using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPointMovement : MonoBehaviour
{
    [SerializeField] private float speed, limitLeft, limitRight;
    [SerializeField] private Rigidbody2D rig;
    public bool isGoingRight;
    void Update()
    {
        if(rig.position.x < limitLeft)
		{
            isGoingRight = true;
		}
        else if (rig.position.x > limitRight)
        {
            isGoingRight = false;
        }
        switch(isGoingRight)
		{
            case true:
                rig.velocity = new Vector2(speed, 0);
                GetComponent<SpriteRenderer>().flipX = true;
                break;
            case false:
                rig.velocity = new Vector2(speed * -1, 0);
                GetComponent<SpriteRenderer>().flipX = false;
                break;
		}
    }
}
