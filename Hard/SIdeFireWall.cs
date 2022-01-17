using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIdeFireWall : MonoBehaviour
{
    public GameObject SideFirePrefab;
 
    public float FireSpeed;
    private int timeCount = 0;
    private int number;
    
    // Update is called once per frame
    void Update()
    {
        timeCount += 1;
        if (timeCount > 2)
        {
            GameObject sideFire = Instantiate(SideFirePrefab, transform.position, Quaternion.identity);

            Rigidbody sideFireRb = sideFire.GetComponent<Rigidbody>();

            sideFireRb.AddForce(transform.forward * FireSpeed);

            //AudioSource.PlayClipAtPoint(fireSound, transform.position);

            // 発射したミサイルを２秒後に破壊（削除）する。
            Destroy(sideFire, 3.0f);
        }


    }
}
