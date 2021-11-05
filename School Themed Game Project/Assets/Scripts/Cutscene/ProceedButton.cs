using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceedButton : MonoBehaviour
{
    private CutsceneManager cm;
    public void Proceed()
	{
		cm = GameObject.Find("CutsceneManager").GetComponent<CutsceneManager>();
		cm.MoveCamera();
	}
}
