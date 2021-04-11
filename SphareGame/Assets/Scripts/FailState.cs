using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailState : MonoBehaviour
{
         private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("YOU LOSE");

            other.transform.position = new Vector3( 0, 0, 0);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero; //(0,0,0)
            other.transform.parent = null;
        }

    }
}