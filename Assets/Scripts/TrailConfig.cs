using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailConfig : MonoBehaviour
{
    [SerializeField] private Color32 trailColor = new Color32(255,255,255,255);
    
    private TrailRenderer trail;

    // Start is called before the first frame update
    private void Awake()
    {
        trail = GetComponent<TrailRenderer>();
    }
    void Start()
    {
        trail.enabled = true;
        trail.startColor = trailColor;
        trail.endColor = trailColor;
    }

}
