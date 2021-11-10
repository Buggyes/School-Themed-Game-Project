using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject firstBossFightWall, secondBossFightWall, player, flyingEnRight, flyingEnLeft, cronometer;
    [SerializeField] private Canvas restartScreen, victoryScreen;
    [SerializeField] private float bossFightWallSpawnTrigger, flyingEnFirstSpawnPos, flyingEnSecondSpawnPos, enSpawnCd, desactivateSpawnEnPosition;
    [SerializeField] private int stage;
    private PlayerJump pj;
    private float spawnRate, timer;
    public bool startCronometer, isFighting, won;
    void Start()
    {
        switch(stage)
		{
            case 1:
                startCronometer = false;
                spawnRate = 0;
                isFighting = false;
                won = false;
                cronometer.SetActive(false);
                secondBossFightWall.SetActive(false);
                firstBossFightWall.SetActive(false);
                restartScreen.gameObject.SetActive(false);
                victoryScreen.gameObject.SetActive(false);
                break;
            case 2:
                isFighting = false;
                won = false;
                restartScreen.gameObject.SetActive(false);
                victoryScreen.gameObject.SetActive(false);
                break;
            case 3:
                isFighting = false;
                won = false;
                restartScreen.gameObject.SetActive(false);
                victoryScreen.gameObject.SetActive(false);
                break;
            default:
                break;
		}
    }
    void Update()
    {
        switch(stage)
		{
            case 1:
                if(player.transform.position.x > bossFightWallSpawnTrigger && !isFighting)
				{
                    firstBossFightWall.SetActive(true);
                    secondBossFightWall.SetActive(true);
                    cronometer.SetActive(true);
                    startCronometer = true;
                    isFighting = true;
                }
                if(isFighting && !won)
				{
                    RandomlySpawnFlyingEnemy();
				}
                checkPlayerIsAlive();
                break;
            case 2:
                //Reaproveito a variavel de spawner da parede para triggar o spawn de inimigos voadores da segunda fase
                if(player.transform.position.x >= bossFightWallSpawnTrigger && !won)
				{
                    SpawnFlyingEnemy();
				}
                if(player.transform.position.x >= desactivateSpawnEnPosition && !won)
				{
                    pj = GameObject.Find("Player").GetComponent<PlayerJump>();
                    pj.ableToMove = false;
                    WinGame();
				}
                checkPlayerIsAlive();
                break;
            case 3:
                if (player.transform.position.x >= desactivateSpawnEnPosition && !won)
                {
                    pj = GameObject.Find("Player").GetComponent<PlayerJump>();
                    pj.ableToMove = false;
                    WinGame();
                }
                checkPlayerIsAlive();
                break;
            default:
                break;
		}
    }
    public void WinGame()
	{
        won = true;
        victoryScreen.gameObject.SetActive(true);
	}
    private void checkPlayerIsAlive()
	{
        if(player.activeInHierarchy == false)
		{
            restartScreen.gameObject.SetActive(true);
		}
	}
    private void SpawnFlyingEnemy()
    {
        timer = Time.time;
        if (timer > spawnRate)
        {
            spawnRate = (timer + enSpawnCd);
            float flyingEnSpawnPosY = Random.Range(-3, 5);
            Vector2 spawnPos = new Vector2(flyingEnFirstSpawnPos, flyingEnSpawnPosY);
            Instantiate(flyingEnRight, spawnPos, new Quaternion());
        }
    }
    private void RandomlySpawnFlyingEnemy()
	{
        timer = Time.time;
        if (timer > spawnRate)
        {
            spawnRate = (timer + enSpawnCd);
            float randomizedSpawnLoc = Random.Range(0, 100);
            if (randomizedSpawnLoc > 0 && randomizedSpawnLoc <= 49)
            {
                float flyingEnSpawnPosY = Random.Range(8, 15);
                Vector2 spawnPos = new Vector2(flyingEnFirstSpawnPos, flyingEnSpawnPosY);
                Instantiate(flyingEnRight, spawnPos, new Quaternion());
            }
            else if (randomizedSpawnLoc >= 50)
            {
                float flyingEnSpawnPosY = Random.Range(8, 15);
                Vector2 spawnPos = new Vector2(flyingEnSecondSpawnPos, flyingEnSpawnPosY);
                Instantiate(flyingEnLeft, spawnPos, new Quaternion());
            }
        }
    }
}
