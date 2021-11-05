using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField] private GameObject startButton, proceedButton;
    [SerializeField] private Transform camTrans;
    [SerializeField] private float advanceQtt;
    [SerializeField] private int sceneQtt;
    void Start()
    {
        startButton.SetActive(false);
        sceneQtt--;
    }
    void Update()
    {
        if(sceneQtt == 0)
		{
            startButton.SetActive(true);
            proceedButton.SetActive(false);
		}
    }
    public void MoveCamera()
	{
        if (sceneQtt != 0)
        {
            camTrans.transform.position = new Vector3(camTrans.position.x + advanceQtt, camTrans.position.y, camTrans.position.z);
            sceneQtt--;
        }
	}
}
