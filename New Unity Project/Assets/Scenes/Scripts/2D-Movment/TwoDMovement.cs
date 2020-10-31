using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TwoDMovement : MonoBehaviour {

    public string newGameScene;

    enum moves {
        None,
        Up,
        Down,
        Right,
        Left
    }

    public int speed;
    private KeyCode moveUp;
    private KeyCode moveDown;
    private KeyCode moveRight;
    private KeyCode moveLeft;
    private Vector2 movement;
    private bool buffered;
    private SpriteRenderer spriteRenderer;
    private moves previousMoves;
    private bool cancelSameMove;

    public Sprite Up;
    public Sprite Down;
    public Sprite Right;
    public Sprite Left;

    public TextMeshProUGUI instruction;


	// Use this for initialization
	void Start () {
        cancelSameMove = false;
        previousMoves = moves.None;
        moveUp = KeyCode.W;
        moveDown = KeyCode.S;
        moveRight = KeyCode.D;
        moveLeft = KeyCode.A;
        movement.x = 0;
        movement.y = 0;
        spriteRenderer = GetComponent<SpriteRenderer> ( );
        if ( spriteRenderer.sprite == null )
            spriteRenderer.sprite = Up;
        

    }

    // Update is called once per frame
    void Update ( ) {

if(Input.GetKeyDown(KeyCode.Escape))
     {
        SceneManager.LoadScene(newGameScene);
     }

        if ( !cancelSameMove ) {

            if ( Input.GetKeyDown ( moveUp ) ) {
                movement.y += 1;
                spriteRenderer.sprite = Up;
                previousMoves = moves.Up;
                instruction.enabled = false;
            }
            if ( Input.GetKeyDown ( moveDown ) ) {
                movement.y -= 1;
                spriteRenderer.sprite = Down;
                previousMoves = moves.Down;
                instruction.enabled = false;
            }
            if ( Input.GetKeyDown ( moveRight ) ) {
                movement.x += 1;
                spriteRenderer.sprite = Right;
                previousMoves = moves.Right;
                instruction.enabled = false;
            }
            if ( Input.GetKeyDown ( moveLeft ) ) {
                movement.x -= 1;
                spriteRenderer.sprite = Left;
                previousMoves = moves.Left;
                instruction.enabled = false;
            }
        } else {
            if ( Input.GetKeyDown ( moveUp ) && previousMoves != moves.Up ) {
                movement.y += 1;
                spriteRenderer.sprite = Up;
                previousMoves = moves.Up;
                cancelSameMove = false;
            }
            if ( Input.GetKeyDown ( moveDown ) && previousMoves != moves.Down ) {
                movement.y -= 1;
                spriteRenderer.sprite = Down;
                previousMoves = moves.Down;
                cancelSameMove = false;
            }
            if ( Input.GetKeyDown ( moveRight ) && previousMoves != moves.Right ) {
                movement.x += 1;
                spriteRenderer.sprite = Right;
                previousMoves = moves.Right;
                cancelSameMove = false;
            }
            if ( Input.GetKeyDown ( moveLeft ) && previousMoves != moves.Left ) {
                movement.x -= 1;
                spriteRenderer.sprite = Left;
                previousMoves = moves.Left;
                cancelSameMove = false;
            }
        }
        UpdateVector ( movement * speed );
        movement.Set ( 0, 0 );
    }

    void UpdateVector ( Vector2 movement ) {
        transform.position = transform.position + (Vector3)movement;
    }

    public void disableSameMovement ( ) {
        cancelSameMove = true;
    }


}
