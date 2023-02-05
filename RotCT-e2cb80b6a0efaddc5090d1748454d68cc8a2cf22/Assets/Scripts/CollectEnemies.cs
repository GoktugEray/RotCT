using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEnemies : MonoBehaviour
{
    public int capacity = 3, collected = 0;
    private int bonusTime, additionalTime = 3;

    private void OnTriggerStay(Collider other)
    {  
        if (other.CompareTag("Enemy") && Input.GetKeyDown(KeyCode.E) && collected < capacity && other.GetComponent<EnemyMovement>().shotCount <= 0)
        {
            Destroy(other.gameObject);
            collected += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shop"))
        {
            print(collected);
            bonusTime = additionalTime * collected;
        }
    }

}
