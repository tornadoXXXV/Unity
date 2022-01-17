using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearN : MonoBehaviour
{
    public AudioClip clearSound;
    private EnemyHealth eh;
    private int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        eh = GameObject.Find("MeteorShooter").GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (eh.enemyHP <= 0 && count == 1)
        {
            count += 1;
            AudioSource.PlayClipAtPoint(clearSound, Camera.main.transform.position);
            Invoke("StageClear", 2.0f);
        }
    }

    void StageClear()
    {
        SceneManager.LoadScene("Clear");
    }
}