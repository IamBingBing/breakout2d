using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float sensitive = 0.05f;
    public int score = 0;
    public GameObject prefeb;
    public GameObject ball;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI MainMessage;
    public Button retrybtn;
    public List<GameObject> boxs;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        GameStart();

    }
    public void SetScore(int point = -1)
    {
        score += point;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "남은 박스 수 : " + score;
    }
    public void GameStart()
    {
        boxs.Clear();
        score = 0;
        Time.timeScale = 1;
        ball.transform.position = new Vector3(0, 0, 0);
        for (int ii = 0; ii > -7; ii--)
        {
            for (int i = 0; i < 16; i++)
            {
                if (Random.Range(1, 100) < 80)
                {
                    GameObject box = Instantiate(prefeb);
                    box.transform.position += new Vector3(i+1, ii, 0);
                    score++;
                    
                }
            }
        }
        retrybtn.gameObject.SetActive(true);
        sendMessage("");
        UpdateScoreText();
    }
    public void GameOver(bool win = true)
    {
        if (win)
        {
            sendMessage("WIN!");
        }
        else
        {
            sendMessage("LOSE");
        }
        Time.timeScale = 0;
        retrybtn.gameObject.SetActive(true);
        foreach (GameObject box in boxs)
        {
            if (box.name.Contains("Clone")) {
                Destroy(box);
            }
           
        }
    }
    public void sendMessage(string text)
    {
        MainMessage.text = text;
    }
    public void setSensitive(float value)
    {
        sensitive = value;
    }
}
