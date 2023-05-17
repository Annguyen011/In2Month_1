using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            anim.SetTrigger("death");
            rb.bodyType = RigidbodyType2D.Static;
            source.Play();
        }
    }
    //public void Restartlevel()
    //{
    //    SceneManager.LoadScene(SceneManager.SetActiveScene().name);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
