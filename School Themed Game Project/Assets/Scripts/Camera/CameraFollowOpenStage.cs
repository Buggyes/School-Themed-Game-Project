using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowOpenStage : MonoBehaviour
{
    public Transform follow;
    [SerializeField] private float maxNegY;
    [SerializeField] private Rigidbody2D playerRig;
    void Update()
    {
        if (playerRig.transform.position.y > maxNegY)
        {
            this.transform.position = new Vector3(follow.position.x, follow.position.y, this.transform.position.z);
        }
        else if (playerRig.transform.position.y <= maxNegY)
        {
            this.transform.position = new Vector3(follow.position.x, maxNegY, this.transform.position.z);
        }
        else
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
    }
}
