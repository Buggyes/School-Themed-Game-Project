using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTextManager : MonoBehaviour
{
	private TextManager tm;
	public void Call()
	{
		tm = GameObject.Find("TextManager").GetComponent<TextManager>();
		tm.ChangeText();
	}
}
