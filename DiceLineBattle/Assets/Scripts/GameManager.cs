using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    private int money;
    public int currentMoney;

    public int winCount;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI currentMoneyText;

    private void Start()
    {
        winCount = 0;
    }

    private void Update()
    {
        moneyText.text = money.ToString();
        currentMoneyText.text = currentMoney.ToString();
    }

    public void PluseMoney()
    {
        money += 1000;
        currentMoney -= 1000;
    }

    public void MinusMoney()
    {
        if(money <= 0)
        {
            return;
        }

        money -= 1000;
        currentMoney += 1000;
    }

    private void SpawnUnit()
    {
        switch (money)
        {

            case 1000:
                break;

            case 2000:
                break;

            case 3000:
                break;

            case 4000:
                break;

            case 5000:
                break;

            case 6000:
                break;

            case 7000:
                break;

            case 8000:
                break;

            case 9000:
                break;

            case 10000:
                break;

            default:
                break;
        }

    }

}
