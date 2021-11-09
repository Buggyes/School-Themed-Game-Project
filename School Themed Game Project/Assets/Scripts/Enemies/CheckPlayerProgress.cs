using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerProgress : MonoBehaviour
{
    GameManager gm;
    void Update()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(gm.won)
		{
            Destroy(gameObject);
		}
    }
}
