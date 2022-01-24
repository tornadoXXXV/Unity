using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip damageSound;
    public AudioClip destroySound;
    private int playerHP;
    private int maxHP = 5;
    public Slider hpSlider;
    public GameObject[] playerIcons;
    public static int destroyCount = 0;
    public bool isMuteki = false;

    public FireMissile fireMissile;

    private void Start()
    {
        UpdatePlayerIcons();

        playerHP = maxHP;

        hpSlider.maxValue = playerHP;
        hpSlider.value = playerHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("EnemyMissile") || (other.gameObject.CompareTag("EnemyLaser"))) && isMuteki == false)
        {
            playerHP -= 1;
            AudioSource.PlayClipAtPoint(damageSound, Camera.main.transform.position);

            if (other.gameObject.CompareTag("EnemyMissile"))
            {
                Destroy(other.gameObject);
            }
            
            hpSlider.value = playerHP;

            if (playerHP == 0)
            {
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                Destroy(effect, 1.0f);
                AudioSource.PlayClipAtPoint(destroySound, Camera.main.transform.position);
                this.gameObject.SetActive(false);

                destroyCount += 1;
                UpdatePlayerIcons();

                if (destroyCount < 3)
                {
                    Invoke("Retry", 1.0f);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                    destroyCount = 0;
                }
            }
        }
    }

    void UpdatePlayerIcons()
    {
        for (int i = 0; i < playerIcons.Length; i++)
        {
            if (destroyCount <= i)
            {
                playerIcons[i].SetActive(true);
            }
            else
            {
                playerIcons[i].SetActive(false);
            }
        }
    }

    void Retry()
    {
        this.gameObject.SetActive(true);

        playerHP = maxHP;

        hpSlider.value = playerHP;

        isMuteki = true;
        Invoke("MutekiOff", 2.0f);
    }

    void MutekiOff()
    {
        isMuteki = false;
    }
}
