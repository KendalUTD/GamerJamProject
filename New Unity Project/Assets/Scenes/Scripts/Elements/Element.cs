using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Element : MonoBehaviour
{
    //What type of element
    public ElementHolder.elements element;
    private Rigidbody2D rigid;
    private SpriteRenderer spriteRenderer;

    public void Start ( ) {
        gameObject.tag = "Element";
        rigid = GetComponent<Rigidbody2D> ( );
        spriteRenderer = GetComponent<SpriteRenderer> ( );
    }

    public ElementHolder.elements getElement ( ) {
        return element;
    }

    //Destroy on impact with player
    public void destroyThis ( ) {
        spriteRenderer.sprite = null;
        Destroy ( this );
    }

}
