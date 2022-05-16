using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

     float backspeed=0.8f;//backpeed
     float fowerspeed=0;//fowerspeed

    bool SpeedDown; //boolean of speed down

    bool YoYo;//boolean of up and down

    public float timeInvincible = 1.0f;
    bool isInvincible;
    float invincibleTimer;

    Animator animator;


    public float Energy;
    public int Points;

    public Image Energyui;
    public Text PointsText;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();//get animator
    }

    // Update is called once per frame
    void Update()
    {//Press K to speed up

        YoYoFunction();
        UISwitch();
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpeedDown = false;
            if (fowerspeed <= (backspeed))
            {
                fowerspeed+=0.2f;
                Points++;
                if (Energy > 0)
                    Energy--;
            }
        }
        if (Input.GetKeyUp(KeyCode.K)) //unpress K to speed cut
        {
            SpeedDown = true;//start speeding cut
        }

        if (SpeedDown)
        {
            if(fowerspeed>0)
            fowerspeed -= 0.005f; //speeding cut with time
        }
        animator.SetFloat("pao", fowerspeed);//hero knight animation for running
        transform.Translate(Vector2.left * (backspeed - fowerspeed)*4 * Time.deltaTime);  //hero knight moving

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }


    float speed;//speed of up and down
    int YoYoInt=1;

    void YoYoFunction()//up and down movement
    {
        if (!YoYo)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (YoYoInt > 0)
                {
                    YoYoInt--;
                    speed = 2;
                    YoYo = true;
                    Invoke("FobidMove", 0.5f);  
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (YoYoInt < 2)
                {
                    YoYoInt++;
                    speed = -2;
                    YoYo = true;
                    Invoke("FobidMove", 0.5f);
                }
            }
        }

        if (YoYo)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

    }


    //points 
    void UISwitch()
    {
        Energyui.fillAmount = Energy / 100;
        PointsText.text = "Score:" + Points;
        if (Energy <= 0)
        {
            success.SetActive(true);
            this.enabled = false;
        }

    }



    void FobidMove()
    {
        YoYo = false;
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "zudang")
        {
            animator.Play("death");
            Invoke("dead", 0.5f);
        }
        if (collision.gameObject.tag == "food")
        {
            if (Energy < 100)
            {
                if (isInvincible) return;

                Energy += 10;
                isInvincible = true;
                invincibleTimer = timeInvincible;
            }
            Destroy(collision.gameObject);
        }
    }

    void dead()
    {
        backspeed = 0;
        fail.SetActive(true);
        this.enabled = false;
    }

    public GameObject success,fail;//success and fail scenery
}
