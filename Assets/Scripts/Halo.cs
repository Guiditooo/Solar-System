using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halo : MonoBehaviour
{
    // Start is called before the first frame update
    private Light lightComponent;
    private void Awake()
    {
        lightComponent = GetComponent<Light>();
    }

    void Start()
    {
        lightComponent.range = 200;
        lightComponent.enabled = true;
    }

    // Update is called once per frame

}
