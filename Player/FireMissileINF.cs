using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissileINF : MonoBehaviour
{
    public GameObject missilePrefab;
    public float missileSpeed;
    private int timeCount;
    public AudioClip fireSound;

    void Update()
    {
        timeCount += 1;
        if (Input.GetButton("Jump"))
        {
            if (timeCount % 2 == 0)
            {
                // プレハブからミサイルオブジェクトを作成し、それをmissileという名前の箱に入れる。
                GameObject missile = Instantiate(missilePrefab, transform.position, Quaternion.identity);

                Rigidbody missileRb = missile.GetComponent<Rigidbody>();

                missileRb.AddForce(transform.forward * missileSpeed);

                AudioSource.PlayClipAtPoint(fireSound, Camera.main.transform.position);

                Destroy(missile, 0.5f);
            }
        }
    }
}