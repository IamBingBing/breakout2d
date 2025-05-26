using UnityEngine;

public class senstivebtn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    public void restart()
    {
        GameManager.Instance.GameStart();
    }
    
}
