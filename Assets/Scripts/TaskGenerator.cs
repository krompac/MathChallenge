using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TaskGenerator : MonoBehaviour
{
    public Text taskText;
    private List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        GenerateTask();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateTask()
    {
        numbers.RemoveAll(number => true);
        numbers.Add(Random.Range(1, 10));
        numbers.Add(Random.Range(1, 10));
        string operation = "+";

        taskText.text = string.Join(operation, numbers);
    }

    public bool CheckAnswer(int answer)
    {
        bool returnMe = numbers.Sum() == answer;

        if (returnMe)
        {
            GenerateTask();
        }

        return returnMe;
    }
}
