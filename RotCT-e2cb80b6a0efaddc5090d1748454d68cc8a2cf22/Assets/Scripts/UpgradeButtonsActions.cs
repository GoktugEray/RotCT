using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class UpgradeButtonsActions : MonoBehaviour
{
    public GameObject player, baseInGame;

    public void SpeedChosed()
    {
        player.GetComponent<FirstPersonController>().MoveSpeed += 5;
        LevelTime.Instance.StartGame();
        transform.parent.gameObject.SetActive(false);
    }
    public void HealthChosed()
    {
        LevelTime.Instance.StartGame();
        transform.parent.gameObject.SetActive(false);
    }
}
