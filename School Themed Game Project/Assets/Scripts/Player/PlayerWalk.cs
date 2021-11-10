using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator plAn;
    public Rigidbody2D plRig;
    private PlayerJump pj;
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
        pj = GameObject.Find("Player").GetComponent<PlayerJump>();
        if (pj.ableToMove)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                plAn.SetBool("isRunning", true);
                plRig.transform.Translate(Vector2.right * (Time.deltaTime * moveSpeed));
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                plAn.SetBool("isRunning", true);
                plRig.transform.Translate(Vector2.left * (Time.deltaTime * moveSpeed));
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                plAn.SetBool("isRunning", false);
            }
        }
        else
		{
            plAn.SetBool("isRunning", false);
        }
    }
}
