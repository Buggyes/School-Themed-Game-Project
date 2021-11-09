using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowClosedStage : MonoBehaviour
{
    public Transform follow;
    void Update()
    {
        this.transform.position = new Vector3(follow.position.x, 0, this.transform.position.z);

    }
}
