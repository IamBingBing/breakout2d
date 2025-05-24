using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float sensitive = 0.01f;
    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
    }
}
