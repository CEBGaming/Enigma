using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoffee : MonoBehaviour
{
    public float SpawnX;

    public GameObject Coffee;
    public GameObject Milk;
    public float MaxSpawnX;
    public float MaxSpawnY;
    public float X;

    private float Rand;
    public bool isCreated;

    //IEnumerator SpawnRandom;
    //public IEnumerator SpawnCoffeeRandom;

    // Start is called before the first frame update
    void Start()
    {
        MaxSpawnX = 8.96f;
        isCreated = false;
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        Rand = Random.Range(1,2);
        //Invoke("RandomCoffeeSpawn", Rand);
    }

    void RandomCoffeeSpawn()
    {
        X = Random.Range(-MaxSpawnX, MaxSpawnX);
        //GameObject newDrop = Instantiate(Coffee, transform);
        //newDrop.transform.position = transform.position + new Vector3(X, 4.5f, 0f);
        if (!isCreated)
        {
            Instantiate(Coffee, new Vector3(X, 4.5f, 0f), Quaternion.identity);
            isCreated = true;
        }

    }

    IEnumerator SpawnCoroutine()
    {

        yield return new WaitForSeconds(Rand);

        if (Random.value <= 0.6f)
        {
            X = Random.Range(-MaxSpawnX, MaxSpawnX);
            Instantiate(Coffee, new Vector3(X, 4.5f, 0f), Quaternion.identity);
        }

        else
        {
            X = Random.Range(-MaxSpawnX, MaxSpawnX);
            Instantiate(Milk, new Vector3(X, 4.5f, 0f), Quaternion.identity);
        }

        StartCoroutine(SpawnCoroutine());
    }

}
