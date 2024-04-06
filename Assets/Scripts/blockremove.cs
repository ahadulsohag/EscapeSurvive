using UnityEngine;

public class blockremove : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/100f;
    }
    void Update()
    {
        if(transform.position.y < -9f)
        {
            Destroy(gameObject);
        }
    }
}
