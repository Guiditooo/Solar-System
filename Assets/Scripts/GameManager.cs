using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject planets;

    private CelestialBody[] bodies;
    private TrailConfig[] trails;

    [SerializeField] private General.BodyNames actualBody;

    private Vector3 defaultCameraPos;
    private Quaternion defaultCameraRot;

    private bool isActualDefault = true;

    private void Awake()
    {
        bodies = planets.GetComponentsInChildren<CelestialBody>();
        trails = planets.GetComponentsInChildren<TrailConfig>();
        defaultCameraPos = Camera.main.transform.position;
        defaultCameraRot = Camera.main.transform.rotation;
    }

    private void Start()
    {
        actualBody = General.BodyNames.Sun;
        planets.SetActive(true);
    }

    private void Update()
    {
        if (actualBody == General.BodyNames.Sun)
        {
            Camera.main.transform.position = defaultCameraPos;
            Camera.main.transform.rotation = defaultCameraRot;
            ChangeTrailWidth(true);
            return;
        }

        ChangeTrailWidth(false);
        Camera.main.transform.rotation = Quaternion.identity;
        Vector3 auxPos = bodies[((int)actualBody)].transform.position;
        auxPos.z -= bodies[((int)actualBody)].transform.lossyScale.z*2;
        Camera.main.transform.position = auxPos;
        //foreach (CelestialBody body in planetPositionList)
        //{
        //    Debug.Log("Posicion del planeta " + body.GetName() + ": " + body.transform.position);
        //}
    }

    

    private void ChangeTrailWidth(bool isDefault)
    {
        if (isActualDefault == isDefault) return;
        if(isDefault)
        {
            for (int i = 0; i < trails.Length; i++)
            {
                trails[i].SetTrailWidth(3.0f);
            }
        }
        else
        {
            for (int i = 0; i < trails.Length; i++)
            {
                trails[i].SetTrailWidth(0.01f);
            }
        }
        isActualDefault = isDefault;
    }


    /*
    private void SortBodies()
    {
        CelestialBody[] aux = bodies;

        for (int x = 0; x < bodies.Length; x++)
        {
            for (int indiceActual = 0; indiceActual < bodies.Length - 1; indiceActual++)
            {
                int indiceSiguienteElemento = indiceActual + 1;
                if (bodies[indiceActual].GetID() > bodies[indiceSiguienteElemento].GetID())
                {
                    int temporal = bodies[indiceActual].GetID();
                    bodies[indiceActual] = bodies[indiceSiguienteElemento];
                    bodies[indiceSiguienteElemento].SetID(temporal);
                }
            }
        }
    }
    */
}
