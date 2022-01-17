using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip sound;
    public int enemyHP;
    public Slider hpSlider;
    public int scoreValue;
    private ScoreManager sm;
    public GameObject[] items;
    public bool isMuteki = false;
    private int countM = 1;

    private void Start()
    {
        if (hpSlider)
        {
            //スライダーの最大値
            hpSlider.maxValue = enemyHP;

            //スライダーの現在値
            hpSlider.value = enemyHP;
        }
        // Application.targetFrameRate = 60;
    }

    private void OnTriggerEnter(Collider other)
    {
        // もしもぶつかった相手に「Missile」というタグ（Tag）がついていたら、
        if (other.gameObject.CompareTag("Missile") && isMuteki == false)
        {
            
            
            // 敵のHPを１ずつ減少させる
            enemyHP -= 1;
            //Debug.Log(enemyHP);
            // ミサイルを破壊する
            Destroy(other.gameObject);

            if (hpSlider)
            {
                //スライダーの現在値
                hpSlider.value = enemyHP;
            }          

            if(countM == 1)
            {
                if (enemyHP < 1000)
                {
                    isMuteki = true;
                    Invoke("MutekiOff", 7.0f);
                    countM += 1;
                }
            }
            

            // 敵のHPが０になったら敵オブジェクトを破壊する。
            if (enemyHP == 0)
            {
                // エフェクトを発生させる
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                // 0.5秒後にエフェクトを消す
                Destroy(effect, 0.5f);


                // 親オブジェクトを破壊する
                Destroy(transform.root.gameObject);

                // 効果音を出す
                AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);

                if(items.Length != 0)
                {
                    int itemNumber = Random.Range(0, items.Length);
                    Instantiate(items[itemNumber], transform.position, Quaternion.identity);
                }
            }
        }
    }

    void MutekiOff()
    {
        isMuteki = false;
    }
}
