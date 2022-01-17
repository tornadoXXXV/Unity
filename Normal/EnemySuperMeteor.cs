using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuperMeteor : EnemyHealth
{
    public GameObject enemySuperMeteorPrefab;
    private float speed;  
    private float seconds;
    private EnemyHealth eh;
    private int count = 1;

    void Start()
    {
        eh = GameObject.Find("MeteorShooter").GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 150;
        seconds += Time.deltaTime;
        if(count == 1)
        {
            if (eh.enemyHP < 1000)
            {
                // 敵のミサイルを生成する
                GameObject enemySuperMeteor = Instantiate(enemySuperMeteorPrefab, transform.position, Quaternion.identity);

                Rigidbody enemySuperMeteorRb = enemySuperMeteor.GetComponent<Rigidbody>();

                // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす
                enemySuperMeteorRb.AddForce(transform.forward * speed);
                count += 1;

            }
        }
        
    }
   
}
