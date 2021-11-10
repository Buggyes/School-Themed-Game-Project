using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGrip : MonoBehaviour
{
	[SerializeField] private GameObject player;
	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject == player)
		{
			player.transform.parent = transform;
		}
	}
	private void OnCollisionExit2D(Collision2D col)
	{
		player.transform.parent = null;
	}
}
