using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions ={-1.91f, -0.63f, 0.58f, 1.83f};

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(
                cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, 4)], 8f, 0),
                Quaternion.Euler(new Vector3(90, 180, 0)));
            yield return new WaitForSeconds(2.5f);
        }
    }

}
