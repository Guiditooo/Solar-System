using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslation : MonoBehaviour
{

    [SerializeField] private float traslationSpeed;
    [SerializeField] private GameObject referencePoint;

    private void TraslationMovement()
    {
        transform.RotateAround(referencePoint.transform.position, Vector3.up, traslationSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        TraslationMovement();
    }
}
