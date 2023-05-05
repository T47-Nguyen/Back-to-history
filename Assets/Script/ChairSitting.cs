using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSitting : MonoBehaviour
{
    public GameObject playerStanding, playerSitting, inText, standText;
    public bool interactable, Sitting;
    void OnTriggerStay(Collider other)
    {
        if ( other.CompareTag("MainCamera"))
        {
            inText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inText.SetActive(false);
            interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inText.SetActive(false);
                standText.SetActive(true);
                playerSitting.SetActive(true);
                Sitting = true;
                playerStanding.SetActive(false); ;
                interactable = false;
            }
        }
        if ( playerSitting == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                playerSitting.SetActive(false);
                standText.SetActive(false);
                playerStanding.SetActive(true);
                inText.SetActive(false);
                Sitting = false;
            }
        }
    }
}
