using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(0.1f, 70f)]
    public float rotatinoSpeed = 5f;
    [Range(0.1f, 70f)]
    public float movementSpeed = 12f;

    public Transform center;

    // Start is called before the first frame update


    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.up * rotatinoSpeed * Time.deltaTime, Space.Self);
        transform.RotateAround(center.position, Vector3.up, movementSpeed * Time.deltaTime);

    }
}
