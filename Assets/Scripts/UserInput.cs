using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserInput : MonoBehaviour
{
    private string input;
    public GameObject inputField;

    public void saveInput()
    {
        input = inputField.GetComponent<Text>().text;
    }
}
