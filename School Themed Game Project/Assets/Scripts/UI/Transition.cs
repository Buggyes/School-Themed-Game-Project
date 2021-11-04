using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transition : MonoBehaviour
{
	public string sceneName;
	public void Transitate()
	{
		SceneManager.LoadScene(sceneName);
	}
}
