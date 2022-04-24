using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    public class ItemCollect : MonoBehaviour
{
    private int Melo = 0;
    [SerializeField] private Text Textt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            Destroy(collision.gameObject);
            Melo++;
            Textt.text = "Watermelon: " + Melo;
        }
    }
    
}