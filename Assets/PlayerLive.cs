using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLive : MonoBehaviour
{
    private Animator aim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            Debug.Log("death");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        aim = GetComponent<Animator>();
    }
    public void Die()
    {
        aim.SetTrigger("death");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
