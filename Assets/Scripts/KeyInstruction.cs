using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class KeyInstruction : MonoBehaviour {


    public static KeyInstruction Gm;

    public Image[] UIImage;

    // Use this for initialization
    void Awake () {
        Screen.fullScreen = false;

        Gm = this;
    }
	
	// Update is called once per frame
	void Update () {
        KeyUPDownchange();
    }


    void InitColor()
    {

        for (int i = 0; i < UIImage.Length; i++)
        {
            UIImage[i].color = new Color(255, 255, 255);
        }
    }

    public void KeyUPDownchange()
    {
        // wsad
        if (Input.GetKeyUp(KeyCode.K))
        {
            Color myColor = new Color32(255, 255, 255, 255);

            KeyInstruction.Gm.UIImage[2].color = myColor;
        }
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            Color myColor = new Color32(180, 180, 180, 255);

            KeyInstruction.Gm.UIImage[2].color = myColor;
        }
       


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Color myColor = new Color32(180, 180, 180, 255);

            KeyInstruction.Gm.UIImage[0].color = myColor;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Color myColor = new Color32(180, 180, 180, 255);

            KeyInstruction.Gm.UIImage[1].color = myColor;
        }


        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Color myColor = new Color32(255, 255, 255, 255);

            KeyInstruction.Gm.UIImage[0].color = myColor;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Color myColor = new Color32(255, 255, 255, 255);

            KeyInstruction.Gm.UIImage[1].color = myColor;
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Color myColor = new Color32(180, 180, 180, 255);

            KeyInstruction.Gm.UIImage[0].color = myColor;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Color myColor = new Color32(180, 180, 180, 255);

            KeyInstruction.Gm.UIImage[1].color = myColor;
        }



    }

}
