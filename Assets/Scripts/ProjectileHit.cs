using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    public float timerDisplay = 3.0f;
    AudioSource projectileAudio;

    // Start is called before the first frame update
    public void Start()
    {
        projectileAudio = GetComponent<AudioSource>();
        projectileAudio.Play();
    }


    void Update()
    {

        timerDisplay -= Time.deltaTime;
        if (timerDisplay < 0)
        {
            Object.Destroy(gameObject);
        }
    }
}
