using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementHolder : MonoBehaviour
{
    public enum elements {
        nothing,
        water,
        earth,
        fire,
        wood,
        metal
    }
    public Obstacle obs1, obs2, obs3, obs4, obs5;

    public elements currentElement = elements.nothing;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D> ( );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D ( Collider2D other ) {
        if ( other.gameObject.tag.Equals("Element" )) {
            currentElement = other.GetComponent<Element>().getElement ( );
            other.GetComponent<Element> ( ).destroyThis ( );
            Destroy ( other );
            obs1.bd.isTrigger = true;
            obs2.bd.isTrigger = true;
            obs3.bd.isTrigger = true;
            obs4.bd.isTrigger = true;
            obs5.bd.isTrigger = true;
        }
        if ( other.gameObject.tag.Equals ( "Finish" ) ) {
            Debug.Log ( "Yata!" );
            //Temporary Quit Game
            //Will load back to School Scene once reached
            Application.Quit();
        }
        if(other.gameObject.tag.Equals("Obstacle"))
        {
            Debug.Log("Collided with Obstacle");
            if (currentElement.Equals(other.GetComponent<Obstacle>().getElement()))
            {
                if (other.GetComponent<Obstacle>().getElement().Equals("Fire") || other.GetComponent<Obstacle>().getElement().Equals("Water"))
                {
                    other.GetComponent<Obstacle>().destroyThis();
                    Destroy(other);
                }
                else
                {
                    other.GetComponent<Obstacle>().bd.enabled = false;
                    other.GetComponent<Obstacle>().changeSprite();
                }
            }

            
        }
       /* if ( other.gameObject.tag.Equals ( "Obstacle" ) ) {
            Debug.Log ( "Here" );
            if ( currentElement != elements.nothing ) {
                bool correct = other.GetComponent<Obstacle> ( ).correctTyping ( currentElement );
                Debug.Log ( currentElement );
                if ( correct ) {
                    other.GetComponent<Obstacle> ( ).destroyThis ( );
                    Destroy ( other );
                    currentElement = elements.nothing;
                    Debug.Log ( "Correct element" );
                }
            } else {
                GetComponent<TwoDMovement> ( ).disableSameMovement ( );
            }
        }
       */
        Debug.Log ( "Collided" );
    }
}
