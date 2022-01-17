using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMissile : EnemyHealth
{
    public GameObject enemyMissilePrefab;
    public GameObject enemyMeteorPrefab;
   
    private float speed;
    private int number;
    private float seconds;
    private EnemyHealth eh;

    void Start()
    {
        eh = GameObject.Find("MeteorShooter").GetComponent<EnemyHealth>();
    }

    void Update()
    {
        number = Random.Range(1, 10000);
        speed = Random.Range(500, 2000);
        seconds += Time.deltaTime;

        if (seconds >= 3 && eh.enemyHP >= 8000 && number <= 30)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb.AddForce(transform.forward * speed);     
               
            // ３秒後に敵のミサイルを削除する。
            Destroy(enemyMissile, 3.0f);
        }

        if (eh.enemyHP < 8000 && eh.enemyHP >= 6000 && number <= 50)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb.AddForce(transform.forward * speed);

            // ３秒後に敵のミサイルを削除する。
            Destroy(enemyMissile, 3.0f);
        }

        if (eh.enemyHP < 6000 && eh.enemyHP >= 4500 && number <= 70)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb.AddForce(transform.forward * speed);

            // ３秒後に敵のミサイルを削除する。
            Destroy(enemyMissile, 3.0f);
        }

        if (eh.enemyHP < 4500 && eh.enemyHP >= 3000 && number <= 55 && number > 20)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb.AddForce(transform.forward * speed);

            // ３秒後に敵のミサイルを削除する。
            Destroy(enemyMissile, 3.0f);           
        }

        if (eh.enemyHP < 4500 && eh.enemyHP >= 3000 && number <= 20)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile2 = Instantiate(enemyMeteorPrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb2 = enemyMissile2.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb2.AddForce(transform.forward * speed);

            Destroy(enemyMissile2, 3.0f);
        }

        if (eh.enemyHP < 3000 && eh.enemyHP >= 1000 && number > 30 && number <= 80)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb.AddForce(transform.forward * speed);

            // ３秒後に敵のミサイルを削除する。
            Destroy(enemyMissile, 3.0f);
        }

        if (eh.enemyHP < 3000 && eh.enemyHP >= 1000 && number <= 30)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile2 = Instantiate(enemyMeteorPrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb2 = enemyMissile2.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMissileRb2.AddForce(transform.forward * speed);

            Destroy(enemyMissile2, 3.0f);
        }
    }
}
