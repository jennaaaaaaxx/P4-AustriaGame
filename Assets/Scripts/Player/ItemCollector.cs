using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pickups = 0;

    [SerializeField] private Text pickupsText;
    [SerializeField] private AudioSource pickupSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            Destroy(collision.gameObject);
            pickups++;
            pickupsText.text = "Fruits: " + pickups;
            pickupSoundEffect.Play();
        }
    }
}
