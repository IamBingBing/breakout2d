using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Bar : MonoBehaviour
{
    public int direction;
    public int movement = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("has been enter");
        movement = direction;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        movement = 2;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) )
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
        if (movement != direction)
        {
            transform.Translate (  new Vector3(direction * GameManager.Instance.sensitive , 0, 0));

        }
        
        
    }
}
