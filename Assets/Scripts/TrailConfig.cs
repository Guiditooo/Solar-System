using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailConfig : MonoBehaviour
{
    [SerializeField] private Color32 trailColor = new Color32(255,255,255,255);
    
    private TrailRenderer trail;

    private float timer = 0.7f;

    // Start is called before the first frame update
    private void Awake()
    {
        trail = GetComponent<TrailRenderer>();
    }

    private void Start()
    {
        StartCoroutine(StartTrail());
    }

    IEnumerator StartTrail()
    {
        yield return new WaitForSeconds(timer);
        trail.enabled = true;
        trail.startColor = trailColor;
        trail.endColor = trailColor;
        SetTrailWidth(3.0f);
        //trail.time = 5;
    }

    public void SetTrailWidth(float trailWidth)
    {
        trail.startWidth = trailWidth;
        trail.endWidth = trailWidth;
    }
}
