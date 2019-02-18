using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boule : MonoBehaviour
{
     Transform transform;
     Rigidbody rigidbody;
    public float forceMagnitude = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>(); //get current object transform values
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void UpdateOld()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
                Debug.DrawLine(ray.origin, hit.point);
            Debug.Log(hit.collider.gameObject.tag); ;
            if (hit.collider.gameObject.tag == "boule")
            {
                Vector3 f = (hit.collider.gameObject.transform.position - transform.position).normalized * forceMagnitude;
                rigidbody.AddForce(f, ForceMode.VelocityChange);
            }
        }


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
                Debug.DrawLine(ray.origin, hit.point);
            Debug.Log(hit.collider.gameObject.tag); ;
            if (hit.collider.gameObject.tag == "boule" || hit.collider.gameObject.tag == "table")
            {

                Vector3 cible = hit.point;
                cible.y = transform.position.y;
               Vector3 f = (hit.collider.gameObject.transform.position - transform.position).normalized * forceMagnitude;



                rigidbody.AddForce(f, ForceMode.VelocityChange);
            }
        }


    }
}
