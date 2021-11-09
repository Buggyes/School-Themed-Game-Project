using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rig;
    public bool isGoingRight;
    void Update()
    {
        if(isGoingRight)
		{
            rig.velocity = new Vector2(speed, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(!isGoingRight)
		{
            rig.velocity = new Vector2(speed*-1, 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
