using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonEffects : MonoBehaviour
{

    [SerializeField] private TMP_Text text;

    private Color32 defaultColor = new Color32(214, 214, 214,255);
    private Color32 hoverColor = new Color32(255, 240, 130, 255);
    private Color32 clickColor = new Color32(190, 180, 40, 255);

    private void Awake()
    {
        text.color = defaultColor;
        //defaultColor = new Color(214, 214, 214);
        //hoverColor   = new Color(255, 240, 130);
        //clickColor   = new Color(190, 180, 40);
    }
    public void Idle()
    {
        text.color = defaultColor;
        //Debug.Log("IDLE " + this.name + " now the color is: " + text.color.ToString());
    }

    public void Hovering()
    {
        text.color = hoverColor;
        //Debug.Log("HOVER " + this.name + " now the color is: " + text.color.ToString());
    }

    public void Clicking()
    {
        text.color = clickColor;
        //Debug.Log("CLICKEADO " + this.name + " now the color is: " + text.color.ToString());
    }

}
