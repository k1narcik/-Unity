using UnityEngine;

public class MoveObjects : MonoBehaviour
{

    public static float speed = 2.5f;

    public float seconds;

     void Start()
    {
        InvokeRepeating("Accelerate", 0, seconds);
    }
 
    public void Accelerate()
    {
        speed += 1;
    }
    

      void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
