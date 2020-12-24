using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour
{
    private Transform marble;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(90f, 90f, 0f);
        marble = GameObject.Find("Marble").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(marble.localPosition.x, marble.localPosition.y + 15f, marble.localPosition.z);
    }
}
