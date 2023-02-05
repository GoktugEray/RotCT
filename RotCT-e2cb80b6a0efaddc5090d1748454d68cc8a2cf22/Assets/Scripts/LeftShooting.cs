using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LeftShooting : MonoBehaviour
{
    public Slider cSlider;
    private float waitTime;
    private bool isAvailable = true, isReload = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && waitTime<=0 && isAvailable)
        {
            Instantiate(Resources.Load("Bullet"), transform.position, 
                Quaternion.Euler(Camera.main.transform.eulerAngles + new Vector3(0, 2.5f, 0)));
            cSlider.value += 0.2f;
        }
        if (cSlider.value <= 3.75f) isAvailable = true;
        if (cSlider.value > 4.95f && isReload)
        {
            isReload = false;
            isAvailable = false;
            StartCoroutine(SetBool());
        }
    }
    IEnumerator SetBool()
    {
        cSlider.value = 4.94f;
        yield return new WaitForSeconds (3f);
        isReload = true;
    }
}
