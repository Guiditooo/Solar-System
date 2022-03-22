using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject planets;
    private CelestialBody[] planetArray;

    private void Awake()
    {
        planetArray = planets.GetComponentsInChildren<CelestialBody>();
    }

    private void Start()
    {
        planets.SetActive(true);
    }

}
