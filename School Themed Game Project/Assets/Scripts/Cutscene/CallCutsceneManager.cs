using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallCutsceneManager : MonoBehaviour
{
	private CutsceneManager cm;
	public void Call()
	{
		cm = GameObject.Find("CutsceneManager").GetComponent<CutsceneManager>();
		cm.MoveCamera();
	}
}
