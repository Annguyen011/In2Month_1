using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextMeshPro;
    [SerializeField] private AudioSource m_AudioSource;
    private int cherries = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            m_AudioSource.Play();
            Destroy(collision.gameObject);
            cherries++;
            m_TextMeshPro.SetText("Cherries:" + cherries);
        }
    }
}
