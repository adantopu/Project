using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    int isFishCastingHash;
 


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isFishCastingHash = Animator.StringToHash("isFishCasting");// add perfomance with using simpler data type
    }

    // Update is called once per frame
    void Update()
    {
        //if player press mouse button down
        if (Input.GetMouseButtonDown(0))
        {
            //then set the isFishCasting boolean to be true
            animator.SetBool(isFishCastingHash, true);
        }

        //if player press mouse button up
        if (Input.GetMouseButtonUp(0))
        {
            //then set the isFishCasting boolean to be false
            animator.SetBool(isFishCastingHash, false);
        }
    }
}
