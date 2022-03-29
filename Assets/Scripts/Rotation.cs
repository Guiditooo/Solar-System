using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private void RotationMovement()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        RotationMovement();   
    }
}
