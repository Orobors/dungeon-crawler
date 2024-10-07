using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        gameObject.transform.Translate(hAxis * speed * Time.deltaTime, 0, vAxis * speed * Time.deltaTime);
    }
}
