using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        // Change the cube color to green.
        if(other.tag == "boule") {
        Debug.Log(other.name + "hole");
        Destroy(other.gameObject);
        }
    }
}
