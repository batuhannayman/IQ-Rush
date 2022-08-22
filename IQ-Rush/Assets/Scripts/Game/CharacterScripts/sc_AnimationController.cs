using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_AnimationController : MonoBehaviour
{
    [SerializeField] Animator anim;
    public static sc_AnimationController instance;

    [SerializeField] public bool isCarrying;

    void Start()
    {
        anim = GetComponent<Animator>();
        instance = this;
        isCarrying = false;
    }

    void FixedUpdate()
    {
        AnimationControl();
    }

    public void Running()
    {
        anim.SetBool("isRunning", true);
        anim.SetBool("isCarrying", false);
        isCarrying = false;
    }

    public void Carrying()
    {
        anim.SetBool("isRunning", false);
        anim.SetBool("isCarrying", true);
        isCarrying = true;
    }

    void AnimationControl()
    {
        if (isCarrying == false)
        {
            if (sc_MoveController.instance.movement.x == 0 && sc_MoveController.instance.movement.z == 0)
            {
                anim.SetBool("isRunning", false);

            }
            else
            {
                anim.SetBool("isRunning", true);

            }
        }

        else
        {
            if (sc_MoveController.instance.movement.x == 0 && sc_MoveController.instance.movement.z == 0)
            {
                anim.SetBool("isCarryMoving", false);

            }
            else
            {
                anim.SetBool("isCarryMoving", true);

            }
        }
    }


}
