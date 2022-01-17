using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletPrefab_UP;
    public GameObject bulletPrefab_DOWN;
    public float speed;
    //public AudioClip sound;
    private int timeCount = 0;
    private float seconds = 0;
    private float value = 1;
    public int start;
    public int end;

    void Update()
    {
        timeCount += 1;
        seconds += Time.deltaTime;
        if (timeCount % 30 == 0)
        {
            value += 1;
            if (value % 2 == 0 && seconds >= 3)
            {
                // 敵のミサイルを生成する
                GameObject Bullet = Instantiate(bulletPrefab_UP, transform.position, Quaternion.identity);

                Rigidbody BulletRb = Bullet.GetComponent<Rigidbody>();

                // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす（ポイント）
                BulletRb.AddForce(transform.forward * speed);

                //AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
                
                // 秒後に敵のミサイルを削除する。
                Destroy(Bullet, 6.0f);
            }

            if (value % 2 == 1 && seconds >= 3)
            {
                // 敵のミサイルを生成する
                GameObject BulletD = Instantiate(bulletPrefab_DOWN, transform.position, Quaternion.identity);

                Rigidbody BulletDRb = BulletD.GetComponent<Rigidbody>();

                // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす（ポイント）
                BulletDRb.AddForce(transform.forward * speed);

                //AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
               
                // 秒後に敵のミサイルを削除する。
                Destroy(BulletD, 6.0f);
            }
        }
    }
}