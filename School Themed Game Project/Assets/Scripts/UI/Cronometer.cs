using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometer : MonoBehaviour
{
    [SerializeField] private Text timerTxt;
    [SerializeField] private float timer;
    private GameManager gm;
    private float timerDisplay;
    void Start()
    {
        timerTxt = GetComponent<Text>();
    }
    void Update()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gm.startCronometer)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerDisplay = Mathf.Round(timer);
                timerTxt.text = "Time: " + timerDisplay;
            }
            else
            {
                timerDisplay = 0;
                timerTxt.text = "Time: " + timerDisplay;
                gm.WinGame();
            }
        }
    }
}
