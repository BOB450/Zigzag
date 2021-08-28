using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    public Text scoretxt;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        scoretxt.text = "0";
        InvokeRepeating("addscore", 2.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void addscore() 
    {
        
        num++;

        string stringmy = num.ToString();

        scoretxt.text = stringmy;
    }
}
