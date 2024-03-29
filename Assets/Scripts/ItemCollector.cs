using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Strawberry = 0;

    [SerializeField] private Text StrawberryText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Strawberry++;
    
           StrawberryText.text = "Strawberry :"+ Strawberry;


        }
    }
    
}
