using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int jumpHigh = 10;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpHigh;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
