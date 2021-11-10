using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject platform;
    public float min, max, speed;
    public int axisDirection;
    //1 = x, 2 = y
    public bool isGoingPositive;

    void Start()
    {
        isGoingPositive = true;
    }
    void Update()
    {
        switch(axisDirection)
		{
            case 1:
                if (isGoingPositive)
                {
                    platform.transform.Translate(new Vector2(speed / 100, 0));
                }
                else
                {
                    platform.transform.Translate(new Vector2(-speed / 100, 0));
                }
                if (min > platform.transform.position.x)
                {
                    isGoingPositive = true;
                }
                else if (max < platform.transform.position.x)
                {
                    isGoingPositive = false;
                }
                break;
            case 2:
                if (isGoingPositive)
                {
                    platform.transform.Translate(new Vector2(0, speed / 100));
                }
                else
                {
                    platform.transform.Translate(new Vector2(0, -speed / 100));
                }
                if (min > platform.transform.position.x)
                {
                    isGoingPositive = true;
                }
                else if (max < platform.transform.position.x)
                {
                    isGoingPositive = false;
                }
                break;
            default:
                break;
		}
    }
}