using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsAnObjectInRange : MonoBehaviour
{
    [SerializeField] private GameObject obj, tgtObj;
    [SerializeField] private float range, speed;
    [SerializeField] private Animator objAn;
    void Start()
    {
        objAn.GetComponent<Animator>();
    }
    void Update()
    {
        float distance = Vector2.Distance(obj.transform.position, tgtObj.transform.position);
        if (distance <= range)
        {
            if (tgtObj.transform.position.x < obj.transform.position.x)
            {
                objAn.SetBool("IsRunning", true);
                obj.transform.Translate(new Vector2((speed*Time.deltaTime)*-1, 0));
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else if (tgtObj.transform.position.x > obj.transform.position.x)
            {
                objAn.SetBool("IsRunning", true);
                obj.transform.Translate(new Vector2((speed*Time.deltaTime), 0));
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
        else
		{
            objAn.SetBool("IsRunning", false);
        }
    }
}
