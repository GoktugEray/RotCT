using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPoint : MonoBehaviour
{
    private int randomNumber;
    private GameObject player;
    private bool isSpawn;
    private int rangeNumber;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SpawnMonster());
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 145) isSpawn = true;
        else isSpawn = false;
    }

    IEnumerator SpawnMonster()
    {
        rangeNumber = (int) (7 - LevelTime.Instance.minutes);
        if (LevelTime.Instance.minutes == 0)
        {
            rangeNumber = 6;
        }
        if (isSpawn)
        {
            randomNumber = Random.Range(1, rangeNumber);
            Instantiate(Resources.Load($"Enemy {randomNumber}"), transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(13f);
        StartCoroutine(SpawnMonster());
    }
}
