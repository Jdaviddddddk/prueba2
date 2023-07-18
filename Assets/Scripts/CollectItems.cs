using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    private int cherries = 0;

 
    [SerializeField] private TextMeshProUGUI CherriesText;
    public AudioSource collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry")) 
        {
            collected.Play();
            Destroy(collision.gameObject);
            cherries++;
            CherriesText.text = "Cherries: " + cherries;
        }
    }
}
