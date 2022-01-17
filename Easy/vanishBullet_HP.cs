using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishBullet_HP : MonoBehaviour
{
    private OriEnemyHealth eh;
    public GameObject effectPrefab;
    public AudioClip sound;

    void Start()
    {
        eh = GameObject.Find("chou").GetComponent<OriEnemyHealth>();
    }
 
    void Update()
    {
        if (eh.enemyHP <= 0)
        {
            // タグが同じオブジェクトを全て取得する
            GameObject[] gameObjects1 = GameObject.FindGameObjectsWithTag("EnemyMissile");
            GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag("EnemyLaser");


            foreach (GameObject gameObj1 in gameObjects1)
            {           
                // エフェクトを発生させる
                GameObject effect = Instantiate(effectPrefab, gameObj1.transform.position, Quaternion.identity);

                // 0.5秒後にエフェクトを消す
                Destroy(effect, 0.5f);

                // 親オブジェクトを破壊する
                Destroy(gameObj1);

                // 効果音を出す
                AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
            } 

            foreach (GameObject gameObj2 in gameObjects2)
            {
                // 親オブジェクトを破壊する
                Destroy(gameObj2);
            }            
        }
    }
}