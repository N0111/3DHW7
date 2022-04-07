using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject doar;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Play"))
        {
            Destroy(doar);
        }

    }
}
