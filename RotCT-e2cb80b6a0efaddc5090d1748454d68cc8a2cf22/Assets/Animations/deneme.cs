using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class deneme : MonoBehaviour
{
    

    public Animator animator;

    void LateUpdate()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isLeftShooting", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isLeftShooting", false);
        }
        
        if(Input.GetMouseButtonDown(1))
        {
            animator.SetBool("isRightShooting", true);
        }
        if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("isRightShooting", false);
        }
        
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("isReloading", true);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool("isReloading", false);
        }
        


    }
}
