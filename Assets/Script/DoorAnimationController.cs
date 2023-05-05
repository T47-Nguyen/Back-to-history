using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationController : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Dooropen", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
              {
            animator.SetBool("Dooropen", false);
        }
    }
}