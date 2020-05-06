using System;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public GameObject textObject;
    private Text textComponent;
    private TaskGenerator taskGenerator;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = textObject.GetComponent<Text>();
        textComponent.text = "";

        taskGenerator = gameObject.GetComponent<TaskGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateResult(string input)
    {
        switch (input)
        {
            case Inputs.CHANGE_SIGN:
                if (textComponent.text.Length > 0)
                {
                    textComponent.text = (int.Parse(textComponent.text) * (-1)).ToString();
                }
                break;
            case Inputs.BACK:
                textComponent.text = "";
                break;
            //TO DO
            case Inputs.CHECK:
                if (int.TryParse(textComponent.text, out int result) && taskGenerator.CheckAnswer(result))
                { 
                    textComponent.text = "";
                }

                break;
            default:
                if (Int32.TryParse(input, out int res))
                {
                    if (textComponent.text == "0")
                    {
                        textComponent.text = "";
                    }

                    string newText = textComponent.text + input;
                    if (Math.Abs(int.Parse(newText)) < 999)
                    {
                        textComponent.text = newText;
                    }
                }
                break;
        }
    }
}
