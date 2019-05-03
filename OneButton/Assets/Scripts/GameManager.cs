using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class GameManager : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 20f;
    public GameObject winPanel;

    [SerializeField] Text conter;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        winPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        conter.text = "Time: " + currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;            
            winPanel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
