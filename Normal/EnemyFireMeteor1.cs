using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMeteor1 : EnemyHealth
{
    public GameObject enemyBigMeteorPrefab;
    private float speed;
    private int number;
    private float seconds;
    private EnemyHealth eh;

    void Start()
    {
        eh = GameObject.Find("MeteorShooter").GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        number = Random.Range(1, 10000);
        speed = Random.Range(500, 2000);
        seconds += Time.deltaTime;

        if (eh.enemyHP < 3000 && eh.enemyHP >= 1000 && number <= 10)
        {
            // 敵のミサイルを生成する
            GameObject enemyMeteor = Instantiate(enemyBigMeteorPrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMeteorRb = enemyMeteor.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
            enemyMeteorRb.AddForce(transform.forward * speed);

            Destroy(enemyMeteor, 3.0f);
        }

    }
}
