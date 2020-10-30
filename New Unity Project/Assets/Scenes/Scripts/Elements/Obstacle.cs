using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public BoxCollider2D bd;
    private SpriteRenderer spriteRenderer;
    public ElementHolder.elements typeOfObstacle;
    private Rigidbody2D rigid;

    public Sprite fixedproblem;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    public ElementHolder.elements getElement() {
        return typeOfObstacle;
    }


    //Destroy on impact with player
    public void destroyThis() {
        spriteRenderer.sprite = null;
        Destroy(this);
    }

    public bool correctTyping(ElementHolder.elements givenElement) {
        return givenElement == ElementHolder.elements.fire && typeOfObstacle == ElementHolder.elements.wood;
    }

    public void changeSprite()
    {
        spriteRenderer.sprite = fixedproblem;
    }


}
