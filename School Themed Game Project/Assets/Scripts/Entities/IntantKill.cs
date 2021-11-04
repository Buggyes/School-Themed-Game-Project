using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntantKill : MonoBehaviour
{
	[SerializeField] private int[] layerMask;
	[SerializeField] private GameObject target;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		for (int i = 0; i < layerMask.Length; i++)
		{
			if (collision.gameObject.layer.Equals(layerMask[i]))
			{
				target.gameObject.SetActive(false);
				break;
			}
		}
	}
}
