using UnityEngine;
public class playermovements : MonoBehaviour
{
    private Rigidbody2D rb;
    private float mapwidth = 4f;
    private float maplength = 5f;
    public float speed = 15f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;
        Vector2 newposition = rb.position + new Vector2(x, y);
        newposition.x = Mathf.Clamp(newposition.x, - mapwidth, mapwidth);
        newposition.y = Mathf.Clamp(newposition.y, -maplength, maplength);
        rb.MovePosition(newposition);
       
    }
    public void OnCollisionEnter2D()
    {
        FindObjectOfType<gamemanager>().Endgame();
    }
}