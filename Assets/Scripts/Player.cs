using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject Over_Panel;
    [SerializeField] GameObject pause_button;
    public float velocity;
    private Rigidbody2D rb;
    public AudioSource fall;
    public AudioSource fly;
    void Start()
    {
        Application.targetFrameRate = 120;
        rb =GetComponent<Rigidbody2D>();
        Over_Panel.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity= Vector2.up*velocity;
            fly.Play();
        }
    }
    public void Dead()
    {
        fall.Play();
        Time.timeScale = 0f;
        Over_Panel.SetActive(true);
        pause_button.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Respawn"))
        {
            fall.Play();
            Dead();
        }
    }
}
