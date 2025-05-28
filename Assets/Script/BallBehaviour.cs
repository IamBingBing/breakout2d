using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ball;
    private Rigidbody2D rb; 
    void Start()
    {
        float randint = Random.Range(-0.5f, -0.5f);
        rb = ball.GetComponent<Rigidbody2D>();
        rb.linearVelocity= new Vector2(1 - randint, 1 + randint) *9;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ball enter");
        //Vector2 direct = rb.linearVelocity;
        //Vector2 rad = collision.contacts[0].normal;
        //rb.linearVelocity = Vector2.Reflect(direct , rad);
        switch (collision.gameObject.tag)
        {
            case "Box":
                GameManager.Instance.SetScore();

                if (GameManager.Instance.score == 0)
                {
                    GameManager.Instance.GameOver();
                }
                collision.gameObject.SetActive(false);
                break;
            case "bottom":
                GameManager.Instance.GameOver(false);
                break;
        }
        
    }

}
