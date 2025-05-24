using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Bar : MonoBehaviour
{
    public int direction;
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            direction = 1;
        }
        else if (!Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        else
        {
            direction = 0;
        }
        transform.Translate (  new Vector3(direction * GameManager.Instance.sensitive , 0, 0));
    }
}
