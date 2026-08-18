using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entra al Trigger");

            Renderer carRenderer = other.GetComponent<Renderer>();

            if (carRenderer != null )
            {
                carRenderer.material.color = Random.ColorHSV();
            }
              
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Sale del Trigger");
        }
    }
}
