using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float ZıplamaKuvveti;
    public bool zeminetemasedildi;
    float rasgeledeğer;
    int zıplatanzeminihtimali;
    Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
        zıplatanzeminihtimali = Random.Range(1,11);

        if(zıplatanzeminihtimali == 1)
        {
            anim.SetBool("ZıplatanZemin",true);
            ZıplamaKuvveti = 21f;
        }
        
        else
        {
            ZıplamaKuvveti = 14f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.relativeVelocity.y < 0)
        {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if(rb != null)
        {
            Vector2 zıplamaVelocity = rb.velocity;
            zıplamaVelocity.y = ZıplamaKuvveti;
            rb.velocity = zıplamaVelocity;

            if(zeminetemasedildi == false)
            {
                rasgeledeğer = Random.Range(1,6);
                Yonetici.skorsayisi+=rasgeledeğer;
                zeminetemasedildi = true;
            }
            anim.SetBool("TemasEdildi",true);
            Destroy(gameObject,1f);
        }    
        }


    }
}
