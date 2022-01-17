using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private Vector3 pos;

    

    void Update()
    {
        float moveH = Input.GetAxis("Mouse X") * moveSpeed;
        float moveV = Input.GetAxis("Mouse Y") * moveSpeed;

        transform.Translate(moveH, 0, moveV);
        MoveClamp();
    }

    void MoveClamp()
    {
        pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -11, 11);
        pos.z = Mathf.Clamp(pos.z, -12, 12);

        transform.position = pos;
    }
}