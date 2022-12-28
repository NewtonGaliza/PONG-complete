 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //para usarmos a UI
using UnityEngine.SceneManagement; //para usarmos carregamento de cenas

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerLeftScore;
    [SerializeField] private int playerRightScore;
    [SerializeField] private Text scoreText;
    [SerializeField] private AudioSource goalSound;

    // Start is called before the first frame update
    void Start()
    {
        //deixando o cursor do mouse invisivel
        Cursor.visible = false;
        
        playerLeftScore = 0;
        playerRightScore = 0;
        scoreText.text = playerLeftScore + " X " + playerRightScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GoToMenu();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }
    }

    public void AddScorePlayerLeft()
    {
        playerLeftScore += 1;
        addScoreText();
    }

    public void AddScorePLayerRight()
    {
        playerRightScore += 1;
        addScoreText();
    }

    public void addScoreText()
    {
        //acessando o componente de texto
        scoreText.text = playerLeftScore + " X " + playerRightScore;
        goalSound.Play();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void EndGame()
    {
        Application.Quit();
    }
}
