using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(go.transform.position, new Vector3(0, 1, 0), speed);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        //Gizmos.DrawSphere(go.transform.position,0.08f);
        Gizmos.DrawLine(
            new Vector3(go.transform.position.x,9999f,go.transform.position.z),
            new Vector3(go.transform.position.x,-9999f,go.transform.position.z)
            );
        Vector3 temp = new Vector3(go.transform.position.x, transform.position.y, go.transform.position.z);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(
            temp,
            Vector3.Distance(temp,transform.position)
            );
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(temp,transform.position);
    }
}