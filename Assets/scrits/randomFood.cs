using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomFood : MonoBehaviour
{

    float timer;//食物生成间隔

    public GameObject[] foods;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;//随时间增加
        //生成物体
        if (timer > 3f)
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
