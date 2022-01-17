using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeMove : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(5.0f * Time.deltaTime * Mathf.Sin(Time.time * 2), -Time.deltaTime * Mathf.Sin(Time.time), 0);
    }
}
