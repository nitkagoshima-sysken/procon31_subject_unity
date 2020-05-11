using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class decisionbutton : MonoBehaviour
{
    public static int score;
    public static int Turn=1;
    public Text turntext;
    public Text scoretext;
    public  void decision()
    {
        SceneManager.LoadScene(0);
    }
    private void Start()
    {
        
    }
    public void point()
    {
      if(kaitouran.bcount == 2 && kaitouran.gcount ==1 && kaitouran.ycount == 0)
        {
            score = score + 3;
        }
      else if(kaitouran.gcount == 2 && kaitouran.ycount == 1 && kaitouran.bcount == 0)
        {
            score = score + 3;
        }
    }
    
    public void delete()
    {
        kaitouran.bcount = 0;
        kaitouran.ycount = 0;
        kaitouran.gcount = 0;

        if(Turn == 3)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Turn++;
        }
    }

    
   
    private void Update()
    {
        scoretext.text = score.ToString();
        turntext.text = Turn.ToString();
    }
}