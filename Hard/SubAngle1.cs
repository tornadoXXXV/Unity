using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubAngle1 : MonoBehaviour
{
    private float seconds;

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds > 2)
        {
            // transformを取得
            Transform myTransform = this.transform;
            Vector3 worldAngle = myTransform.eulerAngles;

            if (seconds <= 6 && worldAngle.y >= 255)
            {
                // ワールド座標基準で、現在の回転量へ加算する
                myTransform.Rotate(0, -0.5f, 0, Space.World);
            }
        }
    }
}
