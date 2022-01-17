using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFireSingle2 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    //public AudioClip sound;
    private int timeCount = 0;
    private float seconds = 0;
    public int start;
    public int end;

    void Update()
    {
        timeCount += 1;
        seconds += Time.deltaTime;

        if ((timeCount+300) % 100 == 0 && seconds >= 3)
        {

            // 敵のミサイルを生成する
            GameObject Bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            Rigidbody BulletRb = Bullet.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす（ポイント）
            BulletRb.AddForce(transform.forward * speed);

            //AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);

            // 秒後に敵のミサイルを削除する。
            Destroy(Bullet, 6.0f);

        }
    }
}