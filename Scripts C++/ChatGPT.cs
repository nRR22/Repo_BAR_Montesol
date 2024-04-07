using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatGPT : MonoBehaviour
{
    public TMP_Text mainScreenText;
    public TMP_Text memoryScreenText;
    private string input = "";
    private string memory = "";
    private string currentOperation = "";
    private bool isNegative = false;

    public void OnButtonClick()
    {
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (buttonName)
        {
            case "Button0":
            case "Button1":
            case "Button2":
            case "Button3":
            case "Button4":
            case "Button5":
            case "Button6":
            case "Button7":
            case "Button8":
            case "Button9":
                OnNumberButtonPressed(buttonName[6].ToString());
                break;
            case "ButtonAdd":
            case "ButtonSubtract":
            case "ButtonMultiply":
            case "ButtonDivide":
                OnOperationButtonPressed(buttonName.Substring(6));
                break;
            case "ButtonEquals":
                OnEqualsButtonPressed();
                break;
            case "ButtonDot":
                OnCommaButtonPressed();
                break;
            case "ButtonDelete":
                OnDeleteButtonPressed();
                break;
            case "ButtonClear":
                OnClearButtonPressed();
                break;
            case "ButtonClearMemory":
                OnClearMemoryButtonPressed();
                break;
            case "ButtonNegative":
                ChangeToNegative();
                break;
        }
    }

    private void OnNumberButtonPressed(string number)
    {
        input += number;
        UpdateDisplay();
    }

    private void OnOperationButtonPressed(string operation)
    {
        if (!string.IsNullOrEmpty(input))
        {
            memory += input + " " + operation + " ";
            currentOperation = operation;
            input = "";
            UpdateDisplay();
        }
    }

    private void OnEqualsButtonPressed()
    {
        if (!string.IsNullOrEmpty(input))
        {
            memory += input;
            input = CalculateMemory();
            currentOperation = "";
            memory = "";
            UpdateDisplay();
        }
    }

    private void OnCommaButtonPressed()
    {
        if (!input.Contains("."))
        {
            input += ".";
            UpdateDisplay();
        }
    }

    private void OnDeleteButtonPressed()
    {
        if (!string.IsNullOrEmpty(input))
        {
            input = input.Substring(0, input.Length - 1);
            UpdateDisplay();
        }
    }

    private void OnClearButtonPressed()
    {
        input = "";
        UpdateDisplay();
    }

    private void OnClearMemoryButtonPressed()
    {
        input = "";
        memory = "";
        UpdateDisplay();
    }

    private void ChangeToNegative()
    {
        isNegative = !isNegative;
        if (isNegative)
        {
            if (!string.IsNullOrEmpty(input) && input != "0")
            {
                if (input[0] != '-')
                {
                    input = "-" + input;
                }
            }
        }
        else
        {
            if (!string.IsNullOrEmpty(input) && input[0] == '-')
            {
                input = input.Substring(1);
            }
        }
        UpdateDisplay();
    }

    private string CalculateMemory()
    {
        // Implement your calculation logic here
        return "Implement calculation logic";
    }

    private void UpdateDisplay()
    {
        mainScreenText.text = input;
        memoryScreenText.text = memory;
    }
}

