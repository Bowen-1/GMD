using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFood : MonoBehaviour
{

    float totalTime;
    float timer;
    float interval = 3f;

    public GameObject[] foods;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        timer += Time.deltaTime;

        if (totalTime > 10f)
        {
            if (interval > 2f) {
                interval = interval - 0.3f;
                totalTime = 0;
            }
        }

        //生成物体
        if (timer > interval)
        {
           GameObject food= Instantiate(foods[Random.Range(0, foods.Length)], this.transform);
            food.transform.position = new Vector3(Random.Range(9.5f, 19f), -1);
            GameObject food2 = Instantiate(foods[Random.Range(0, foods.Length)], this.transform);
            food2.transform.position = new Vector3(Random.Range(9.5f, 19f), -1.86f);
            GameObject food3 = Instantiate(foods[Random.Range(0, foods.Length)], this.transform);
            food3.transform.position = new Vector3(Random.Range(9.5f, 19f), -2.79f);
            timer = 0;
        }
    }
}
