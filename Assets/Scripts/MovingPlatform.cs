using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA, pointB;
    public float speed;
    Vector3 targetPoint;

    private void Start()
    {
        targetPoint = pointB.position;
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, pointA.position) < 0.05f)
        {
            targetPoint = pointB.position;
        }

        if (Vector2.Distance(transform.position, pointB.position) < 0.05f)
        {
            targetPoint = pointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
}
