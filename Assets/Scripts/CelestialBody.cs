﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CelestialBodies { Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune }
public class CelestialBody : MonoBehaviour
{
    [SerializeField] private float diameter;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float traslationSpeed;

    public GameObject referencePoint;
    [SerializeField] private float distanceFromReferencePoint;

    private TrailRenderer trail;

    private void Awake()
    {
        transform.localScale = new Vector3(diameter, diameter, diameter);
        trail = GetComponent<TrailRenderer>();
    }
    private void Start()
    {
        if (gameObject.layer != 6)
        {
            transform.position = new Vector3(referencePoint.transform.lossyScale.x * (1 + distanceFromReferencePoint), 0, 0);
            trail.enabled = true;
        }
    }

    private void Rotation()
    {
        Quaternion aux = transform.rotation;
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void Traslation()
    {
        transform.RotateAround(referencePoint.transform.position, Vector3.up, traslationSpeed * Time.deltaTime);
    }

    void Update()
    {
        Rotation();
        Traslation();
    }
}
