using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NdXpY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int DiceNotationCalc(string[] dice)
    {

        int result = 0;
        foreach (string i in dice)
        {
            int multiplier;
            int dieSize;
            int modifier;

            /*  split at "d"
             *  split[0] = multiplier
             *  try to split2 at "+" or "-"
             *  split2[0] = dieSize
             *  split2[1] = modifier
             *  except: split[1] = dieSize
             *  for i in range multiplier:
             *      result += randBetween(1, dieSize)
             *      
             *  result += modifier
             *  return result
             */
        }

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
