using TMPro;
using UnityEngine;

public class DrawButtonCtrl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI drawText;
    public DrawLines drawLines;
    int toggle = 0;
    public void Change()
    {
        toggle = (toggle + 1) % 2;
        if (toggle == 1)
        {
            drawText.text = "Stop";
            drawLines.AllowDraw(true);
        }
        else
        {
            drawText.text = "Draw";
            drawLines.AllowDraw(false);
        }
    }
}
