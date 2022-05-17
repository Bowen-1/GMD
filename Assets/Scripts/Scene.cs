using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void SwitchScene(string name)
    {
        SceneManager.LoadScene(name);//跳转场景
    }

    public void DisplayVolume()
    {
        GameObject.FindGameObjectWithTag("yin").transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
    }
}
