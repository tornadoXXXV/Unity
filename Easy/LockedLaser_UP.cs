using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedLaser_UP : MonoBehaviour
{
    private float length = 0;
    public float stop;
    public AudioClip Sound;
    public float LENGTH;
    private float seconds = 0;
    LineRenderer lineRenderer;
    BoxCollider bc;
    //Vector3 hitPos;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        bc = this.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if(seconds >= 3)
        {
            if(length <= LENGTH)
            {
                length += 5;
            }
            
            if (length == 5)
            {
                AudioSource.PlayClipAtPoint(Sound, Camera.main.transform.position);
            }

            var positions = new Vector3[]{
            new Vector3(0, 0, 0),               // 開始点
            new Vector3(0, 0, length/10),               // 終了点
            };

            bc.size = new Vector3(0, 0, length*2 / 10);

            // 線を引く場所を指定する
            lineRenderer.SetPositions(positions);
        }
    }
}
