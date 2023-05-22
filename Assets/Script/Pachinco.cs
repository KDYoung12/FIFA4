using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pachinco : MonoBehaviour
{
    [SerializeField]
    private Text resultText;

    [SerializeField]
    private InputField enforceField;

    public void OnClickButton()
    {
        int randint = Random.Range(1, 101);
        if (enforceField.text == "")
        {
            resultText.text = "현재 강화 레벨을 입력해주세요.";
        }
        else
        {
            switch (enforceField.text)
            {
                case "1":
                    if (randint >= 1 && randint < 101)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "2":
                    if (randint >= 1 && randint < 82)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "3":
                    if (randint >= 1 && randint < 64)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "4":
                    if (randint >= 1 && randint < 50)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "5":
                    if (randint >= 1 && randint < 26)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "6":
                    if (randint >= 1 && randint < 15)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "7":
                    if (randint >= 1 && randint < 7)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "8":
                    if (randint >= 1 && randint < 4)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                case "9":
                    if (randint >= 1 && randint < 2)
                    {
                        resultText.text = "RESULT : SUCCESS";
                        Debug.Log(randint);
                    }
                    else
                    {
                        resultText.text = "RESULT : FAILURE";
                        Debug.Log(randint);
                    }
                    break;
                default:
                    resultText.text = "현재 강화 레벨을 입력해주세요.";
                    break;
            }
        }        
    }
}
