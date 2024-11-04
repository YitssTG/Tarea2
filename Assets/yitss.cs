using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yitss : MonoBehaviour
{
    public int direcx = 1;
    public int direcy = 1;
    public float g;
    private SpriteRenderer renderizado;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        renderizado = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(direcx * g, direcy * g);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "x")
        {
            direcy = direcy * -1;
            renderizado.flipY = !renderizado.flipY;
        }
        if (collision.gameObject.tag == "y")
        {

            renderizado.flipX = !renderizado.flipX;
            direcx = direcx * -1;
        }
    }
}