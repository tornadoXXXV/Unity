using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMissilenoVol : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    public float speed;
    private int timeCount = 0;
    private float seconds = 0;
    public int start;
    public int end;

    void Update()
    {
        timeCount += 1;
        seconds += Time.deltaTime;

        if (timeCount % 60 == 0 && seconds > start && seconds <= end)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす（ポイント）
            enemyMissileRb.AddForce(transform.forward * -speed);

            Destroy(enemyMissile, 8.0f);
        }
    }
}