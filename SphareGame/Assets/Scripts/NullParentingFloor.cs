using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullParentingFloor : MonoBehaviour
{


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        other.transform.parent = null;

    }
}
