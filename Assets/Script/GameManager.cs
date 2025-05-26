using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float sensitive = 0.01f;
    private int score = 0;
    public GameObject prefeb;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI MainMessage;
    public Button retrybtn;

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
    }
    public void UpdateScoreText()
    {
        scoreText.text = "남은 박스 수 : " + score;
    }
    public void GameStart()
    {
        for (int ii = 0; ii > -7; ii--)
        {
            for (int i = 0; i < 16; i++)
            {
                if (Random.Range(1, 100) < 80)
                {
                    GameObject box = Instantiate(prefeb);
                    box.transform.position += new Vector3(i, ii, 0);
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
            SendMessage("LOSE");
        }
        retrybtn.gameObject.SetActive(true);
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
