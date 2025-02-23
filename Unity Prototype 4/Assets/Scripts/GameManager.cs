using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button restartButton;
    public Button menuButton;
    public GameObject gameOverScreen;
    public TextMeshProUGUI waveText;
    GameObject player;

    public bool isGameActive;


    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            waveText.gameObject.SetActive(false);
            gameOverScreen.gameObject.SetActive(true);
            isGameActive = false;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Game Menu");
    }
}
