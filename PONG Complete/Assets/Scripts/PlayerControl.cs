using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private bool playerLeft;

    [SerializeField] private float yMin;
    [SerializeField] private float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLeft)
        {
            MovePleyerLeft();
        }
        else
        {
            MovePlayerRight();
        }
    }

    private void MovePleyerLeft()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime );
        }
    }

    private void MovePlayerRight()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); 
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }


    }














}
