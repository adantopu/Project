using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if player press mouse button down
        if (Input.GetMouseButtonDown(0))
        {
            //then set animation speed 1 or enable
            animator.speed = 1;
        }

        //if player press mouse button up
        if (Input.GetMouseButtonUp(0))
        {
            //then set animation speed 0 or disable
            animator.speed = 0;
        }
    }
}
