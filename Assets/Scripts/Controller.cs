using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Data data;
    [SerializeField] private TextMeshProUGUI flasksText;

    // Start is called before the first frame update
    void Start()
    {
        data = new Data();
        data.flasks = BigDouble.Pow(10, 55000);
    }

    // Update is called once per frame
    void Update()
    {
        flasksText.text = data.flasks + " Flasks";
        data.flasks *= 100;
        print(data.flasks);
    }

    public void GenerateFlasks()
    {
        data.flasks += 1;
    }
}
