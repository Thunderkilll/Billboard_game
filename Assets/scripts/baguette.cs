using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baguette : MonoBehaviour
{
    public Transform boule0; //les coordonnée du boule blanche
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Transform>(); //get current object transform values
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(boule0);
    }
}
