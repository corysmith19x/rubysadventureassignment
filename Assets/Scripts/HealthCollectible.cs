using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public GameObject healthParticle;
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);

                GameObject healthEffect = Instantiate(healthParticle, transform.position, transform.rotation *= Quaternion.Euler(-90,0,0));
                controller.PlaySound(collectedClip);
                Destroy(gameObject);
            }
        }
    }
}
