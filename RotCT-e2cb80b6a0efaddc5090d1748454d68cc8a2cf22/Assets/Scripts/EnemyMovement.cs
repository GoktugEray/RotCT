using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _agent => GetComponent<NavMeshAgent>();
    public GameObject player;
    public EnemyScriptable enemyData;
    public int shotCount;
    private bool isActive = true, iscounted = true;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        shotCount = enemyData.shotCount;
    }

    private void Update()
    {
        if(isActive) _agent.SetDestination(player.transform.position+new Vector3 (2.1f,0,2.1f));
        if (shotCount <= 0)
        {
            isActive = false;
            _agent.SetDestination(transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            shotCount -= 1;
            Destroy(other.gameObject);
        }

        if (shotCount == 0 && iscounted)
        {
            LevelTime.Instance.killedEnemy += 1;
            iscounted = false;
        }
    }
}
