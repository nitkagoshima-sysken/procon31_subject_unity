using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalscore : MonoBehaviour
{
    public Text scoretext;
    public static int Totalscore;

    void Start()
    {
        Totalscore = decisionbutton.score;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Totalscore.ToString();
    }
}
