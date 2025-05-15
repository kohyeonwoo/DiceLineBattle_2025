using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public List<GameObject> unit1Side = new List<GameObject>();

    public List<GameObject> unit2Side = new List<GameObject>();

    public TextMeshProUGUI unitCount1Text;

    public TextMeshProUGUI unitCount2Text;

    public Transform unit1SpawnLocation;

    public Transform unit2SpawnLocation;

    public int unitCount1;
    
    public int unitCount2;

    private GameObject spawnUnit;

    private void Start()
    {
        unitCount1 = 0;

        unitCount2 = 0;
    }

    private void Update()
    {
        unitCount1Text.text = unitCount1.ToString();

        unitCount2Text.text = unitCount2.ToString();
    }

    public void PlusUnitCount1()
    {
        if(unitCount1 >= 100)
        {
            return;
        }

        unitCount1++;

        SpawnUnit();
    }

    public void MinusUnitCount1()
    {

        if(unitCount1 <= 0)
        {
            return;
        }

         unitCount1--;

    }

    public void PlusUnitCount2()
    {
        if (unitCount2 >= 100)
        {
            return;
        }

        unitCount2++;
    }

    public void MinusUnitCount2()
    {

        if (unitCount2 <= 0)
        {
            return;
        }

        unitCount2--;

    }

    private void SpawnUnit()
    {
        float distance = 1.5f;

        Vector3 offset = new Vector3(0.0f, 0.0f, distance);
    }

}
