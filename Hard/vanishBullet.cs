using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishBullet : MonoBehaviour
{
   
    public int EndTime;
    private float seconds = 0;
 
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= EndTime)
        {
            // タグが同じオブジェクトを全て取得する
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("EnemyMissile");

            foreach (GameObject gameObj in gameObjects)
            {
                Destroy(gameObj);

            }            
        }
    }
}