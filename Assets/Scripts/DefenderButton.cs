using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour {

    ColorBlock original_color;

    public void ClickButton()
    {
        Debug.Log("defender clicked");

        var buttons = FindObjectsOfType<DefenderButton>();

        foreach(DefenderButton button in buttons)
        {
            original_color = button.GetComponent<Button>().colors;
                //this.gameObject.GetComponent<Button>().colors;

            original_color.normalColor = new Color(.2f, .2f, .2f);

            button.GetComponent<Button>().colors = original_color;
        }
        
        original_color = this.gameObject.GetComponent<Button>().colors;

        original_color.normalColor = new Color(1f, 1f, 1f);

        this.gameObject.GetComponent<Button>().colors = original_color;
        
    }

}
