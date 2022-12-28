using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private AudioSource ballHitSound;
    [SerializeField] private float randomDirectionX;
    [SerializeField] private float randomDirectionY;

    // Start is called before the first frame update
    void Start()
    {
        MoveBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MoveBall()
    {
        rigidBody.velocity = new Vector2(speed, speed);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        ballHitSound.Play();

        rigidBody.velocity += new Vector2(randomDirectionX, randomDirectionY);
    }
}
