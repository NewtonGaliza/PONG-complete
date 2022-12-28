using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool goalLeft;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // goalLeft == true
        if (goalLeft)
        {
            //acessando o script GameManager
            //gol do jogadorRight
            FindObjectOfType<GameManager>().AddScorePLayerRight();
            //o collider se torna a bola pela colisao
            collider.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            //gol do jogadorLeft
            FindObjectOfType<GameManager>().AddScorePlayerLeft();
            collider.gameObject.transform.position = Vector2.zero;
        }
    }
}
