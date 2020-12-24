using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    private Transform startLocation;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = GameObject.Find("StartLocation").transform;
        transform.position = startLocation.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Debug.Log("Level Complete");
        }
    }
}
