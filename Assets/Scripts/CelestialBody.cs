using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    [SerializeField] private float diameter;
    [SerializeField] private GameObject referencePoint;
    [SerializeField] private float distanceFromReferencePoint;

    private void Awake()
    {
        transform.localScale = new Vector3(diameter, diameter, diameter);
     }
    private void Start()
    {
        if (gameObject.layer != 6)
        {
            transform.position = new Vector3(referencePoint.transform.lossyScale.x * (1 + distanceFromReferencePoint), 0, 0);
        }
    }
}
