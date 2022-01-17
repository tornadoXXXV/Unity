using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWallAngle1 : MonoBehaviour
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

            if (seconds <= 6 && worldAngle.y >= 187.5)
            {
                // ワールド座標基準で、現在の回転量へ加算する
                myTransform.Rotate(0, -0.5f, 0, Space.World);
            }

            if (seconds > 6 && seconds <= 12 && worldAngle.y <= 240)
            {
                myTransform.Rotate(0, 0.25f, 0, Space.World);
            }

            if (seconds > 12 && seconds <= 24 && worldAngle.y >= 135)
            {
                myTransform.Rotate(0, -0.25f, 0, Space.World);
            }

            if (seconds > 24 && seconds <= 36 && worldAngle.y <= 240)
            {
                myTransform.Rotate(0, 0.25f, 0, Space.World);
            }

            if (seconds > 36 && seconds <= 48 && worldAngle.y >= 135)
            {
                myTransform.Rotate(0, -0.25f, 0, Space.World);
            }

            if (seconds > 48 && seconds <= 60 && worldAngle.y <= 240)
            {
                myTransform.Rotate(0, 0.25f, 0, Space.World);
            }
        }
    }
}
