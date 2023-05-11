using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetoneiraAnimation : MonoBehaviour
{
    public Animator animator;
    void PlayAnimation()
    {
        animator.SetBool("StartTeleport", true);
    }
    void StopAnimation()
    {
        animator.SetBool("StartTeleport", false);
    }
}
