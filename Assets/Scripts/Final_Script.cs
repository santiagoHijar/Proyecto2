using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("has terminado el nivel");
        }
    }
}
