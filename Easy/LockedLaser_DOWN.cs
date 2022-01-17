using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedLaser_DOWN : MonoBehaviour
{
    private float length = 0;
    public float stop;
    public float LENGTH;
    public AudioClip Sound;
    LineRenderer lineRenderer;
    BoxCollider bc;
    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        bc = this.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (length <= LENGTH)
        {
            length += 3;            
            
        }

        if (length == 3)
        {
            AudioSource.PlayClipAtPoint(Sound, Camera.main.transform.position);
        }

        var positions = new Vector3[]{
        new Vector3(0, 0, 0),               // 開始点
        new Vector3(0, 0, -length/10),               // 終了点
        };
       
        bc.center = new Vector3(0, 0, -length/20);
        bc.size = new Vector3(0, 0, -length / 10);

        // 線を引く場所を指定する
        lineRenderer.SetPositions(positions);
    }
}
