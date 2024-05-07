using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour
{
    public float speed = 2f;
    public GameObject road;
    
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            Instantiate(road, new Vector3(0, 13.22f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
