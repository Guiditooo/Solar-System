using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    [SerializeField] private General.BodyNames planetName;
    [SerializeField] private float diameter;
    [SerializeField] private GameObject referencePoint;
    [SerializeField] private float distanceFromReferencePoint;

    private string bodyName;

    private void Awake()
    {
        bodyName = gameObject.name;
    }

    private void Start()
    {
        transform.localScale = new Vector3(diameter, diameter, diameter);
        if (planetName != General.BodyNames.Sun)
        {
            transform.position = new Vector3(referencePoint.transform.lossyScale.x * (1 + distanceFromReferencePoint), 0, 0);
        }
    }

    public string GetName() => bodyName;
    public int GetID() => (int)planetName;
    public void SetID(int newID) => planetName = (General.BodyNames)newID;

}
