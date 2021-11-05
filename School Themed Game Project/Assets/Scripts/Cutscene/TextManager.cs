using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] private Text[] csText;
    private int arrayPos;
	private void Start()
	{
		arrayPos = 0;
		for (int i = 0; i < csText.Length; i++)
		{
			csText[i].gameObject.SetActive(false);
		}
		csText[arrayPos].gameObject.SetActive(true);
	}
	public void ChangeText()
    {
		if (arrayPos < csText.Length-1)
		{
			csText[arrayPos].gameObject.SetActive(false);
			arrayPos++;
			csText[arrayPos].gameObject.SetActive(true);
		}
	}
}
