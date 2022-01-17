using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor2 : MonoBehaviour
{   
    public GameObject effectPrefab;
    public AudioClip sound;


    // Start is called before the first frame update
    void Update()
    {
        if (this.transform.position.z < -15)
        {
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
            this.GetComponent<SphereCollider>().radius = 0.6f;
            Destroy(this);
            Destroy(effect, 0.5f);
        }
    }
}
