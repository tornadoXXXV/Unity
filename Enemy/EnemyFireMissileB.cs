using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMissileB : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    public float speed;
    private int timeCount;

    // Update is called once per frame
    void Update()
    {
        timeCount += 1;

        if (timeCount % 50 == 0)
        {
            GameObject missile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);
            Rigidbody missileRb = missile.GetComponent<Rigidbody>();
            missileRb.AddForce(transform.forward * speed);

            Destroy(missile, 10f);
        }

        if (timeCount == 500)
        {
            this.gameObject.AddComponent<Rotate>().pos = new Vector3(0, 90, 0);
        }
    }
}
