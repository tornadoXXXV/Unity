using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWay : MonoBehaviour
{
    public GameObject enemyFireMissilePrefab;

    public int wayNumber;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < wayNumber; i++)
        {
            //Instantiateはプレハブからクローンを生産する
            GameObject enemyFireMissile = Instantiate(enemyFireMissilePrefab, transform.position, Quaternion.Euler(0, 7.5f - (7.5f * wayNumber) + (15 * i), 0));

            enemyFireMissile.transform.SetParent(this.gameObject.transform);
        }
    }
}
