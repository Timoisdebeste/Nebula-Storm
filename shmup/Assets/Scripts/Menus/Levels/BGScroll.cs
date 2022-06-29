using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime);
        if(transform.position.y< -152f)
        {
            transform.position = StartPosition;
        }
    }
}
