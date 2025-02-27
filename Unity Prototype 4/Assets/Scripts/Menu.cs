using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{

    public GameObject optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.Instance.PlaySFX("Boton");
    }

    public void OptionsMenu()
    {
        optionsPanel.gameObject.SetActive(true);
        AudioManager.Instance.PlaySFX("Boton");
    }

    public void CloseOptions()
    {
        optionsPanel.gameObject.SetActive(false);
        AudioManager.Instance.PlaySFX("Boton");
    }
}
