using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPanelGenerator : MonoBehaviour
{
    public GameObject UIPanel;
    public GameObject buttonPrefab;
    
    private List<GameObject> gameObjects = new List<GameObject>();
    private InputManager inputManager;

    void Awake()
    {
        inputManager = gameObject.GetComponent<InputManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        AddButton(Inputs.BACK);
        AddButton(Inputs.ZERO);
        AddButton(Inputs.CHECK);
        
        AddButton(Inputs.SEVEN);
        AddButton(Inputs.EIGHT);
        AddButton(Inputs.NINE);

        AddButton(Inputs.FOUR);
        AddButton(Inputs.FIVE);
        AddButton(Inputs.SIX);

        AddButton(Inputs.ONE);
        AddButton(Inputs.TWO);
        AddButton(Inputs.THREE);
        
        AddButton(Inputs.CHANGE_SIGN);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddButton(string buttonText)
    {
        GameObject inputButton = Instantiate(buttonPrefab);
        inputButton.transform.SetParent(UIPanel.transform);
        inputButton.GetComponent<Button>().GetComponentInChildren<Text>().text = buttonText;
        inputButton.GetComponent<Button>().onClick.AddListener(() => { inputManager.UpdateResult(buttonText); });
        gameObjects.Add(inputButton);
    }
}
