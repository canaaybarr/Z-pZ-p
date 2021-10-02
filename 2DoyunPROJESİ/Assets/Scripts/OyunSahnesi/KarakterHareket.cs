using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float harekethızı;

    public float yatayhareket;

    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket*harekethızı*Time.deltaTime,rb.velocity.y);

        Vector2 yeniscale = transform.localScale;

        if (yatayhareket > 0)
        {
            yeniscale.x = 0.30f;
        }
        if (yatayhareket < 0)
        {
            yeniscale.x = -0.30f;
        }
        transform.localScale = yeniscale;

    }    

}
