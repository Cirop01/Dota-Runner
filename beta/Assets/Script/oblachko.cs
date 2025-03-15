using UnityEngine;
using System.Collections;

public class LoopingColoredConsoleMessage : MonoBehaviour
{
    [SerializeField] private string messageToPrint = "ПОШЕЛ НАХУЙ";
    [SerializeField] private Color textColor = Color.green;
    [SerializeField] private float delayBetweenMessages = 1f;

    void Start()
    {

        StartCoroutine(MessageLoop());
    }

    IEnumerator MessageLoop()
    {
        while (true)
        {

            PrintColoredMessage(messageToPrint, textColor);
            

            yield return new WaitForSeconds(delayBetweenMessages);
        }
    }


    public void PrintColoredMessage(string text, Color color)
    {

        string colorHex = ColorUtility.ToHtmlStringRGBA(color);

        string coloredMessage = $"<color=#{colorHex}>{text}</color>";

        Debug.Log(coloredMessage);
    }
}