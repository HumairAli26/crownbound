using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private float move_horizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move_horizontal=Input.GetAxis("Horizontal");
    }
    void FixedUpdate() 
    {
        rb.linearVelocity = new Vector2(move_horizontal*speed, rb.linearVelocity.y);    
    }
}
