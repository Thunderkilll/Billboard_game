using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform cible;
    public float speedRotation = 100f;
    public float vitessezoom = 20f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


        float verticalRotation = Input.GetAxis("Vertical") * speedRotation * Time.deltaTime;

        float horizontalRotation = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;

        transform.RotateAround(cible.position,Vector3.up,horizontalRotation);

        transform.LookAt(cible.position);

        Vector3 axe = transform.TransformVector(transform.right);

        transform.RotateAround(cible.position, axe , -verticalRotation);

        float zoom = vitessezoom * Time.deltaTime;

        if (Input.GetKey(KeyCode.O))
             {
            transform.Translate(zoom * Vector3.forward);
       }
        if (Input.GetKey(KeyCode.P))
        {
            transform.Translate(zoom * -(Vector3.forward));
        }
    }
}
