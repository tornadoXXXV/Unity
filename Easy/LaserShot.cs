using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShot : MonoBehaviour
{
    private float length = 0;
    private float origin = 0;
    public float stop;
    public AudioClip Sound;
    LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        length += 1;
        if (length == 1)
        {
            AudioSource.PlayClipAtPoint(Sound, Camera.main.transform.position);
        }

        if (length / 10 >= stop)
        {
            origin += 1;
        }

        var positions = new Vector3[]{
        new Vector3(0, 0, origin/10),               // 開始点
        new Vector3(0, 0, length/10),               // 終了点
        };

        // 線を引く場所を指定する
        lineRenderer.SetPositions(positions);
    }
}
