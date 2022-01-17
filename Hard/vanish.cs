﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip sound;
    public int EndTime;
    private float seconds = 0;

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= EndTime)
        {
            // Debug.Log("ヨシ！");
            // エフェクトを発生させる
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // 0.5秒後にエフェクトを消す
            Destroy(effect, 0.5f);

            // 親オブジェクトを破壊する（ポイント；この使い方を覚えよう！）
            Destroy(transform.root.gameObject);

            // 効果音を出す
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
        }
    }
}