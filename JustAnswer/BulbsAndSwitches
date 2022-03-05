/*
     // Every time, you flip a switch, first bulb is toggled
		// If a bulb is switched off, adjacent bulb is toggled
		// Identify the state of the bulbs after `n` times the switched is pressed
		
		// Only condition to remember
		// 1. You flip a switch, the first bulb is toggled.
		// 2. When a bulb is flipped from on to off, the adjacent bulb will get toggled.
             
             
            // Input: false true true false true
            // 1:     true  true true false true
            // 2      false false false true true
            // 3      true false false true true
            // 4:     false true false true true
            // 5:     true true false true true

            // Input: false false false true true
            // 5:     true false true true true

*/

public void BulbState()
{

    /*           
    // Input: false true true false true
    // 1:     true  true true false true
    // 2      false false false true true
    // 3      true false false true true
    // 4:     false true false true true
    // 5:     true true false true true

    // Input: false false false true true
    // 5:     true false true true true
    */

    bool[] _bulbs = new bool[5] {  false,//    false,
                                   false, //   true,
                                   false, //   true,
                                   true,//    false,
                                   true  //  true
                                };

    int n = 5;

    while (n != 0)
    {
        for (int i = 0; i < _bulbs.Length; i++)
        {
            if (i == 0 && _bulbs[i] == true)
            {
                _bulbs[i] = false;
                continue;
            }
            else if (i == 0 && _bulbs[i] == false)
            {
                _bulbs[i] = true;
                break;
            }
            else if (_bulbs[i] == true)
            {
                _bulbs[i] = false;
            }
            else
            {
                _bulbs[i] = true;
                break;
            }
        }

        n--;
    }

    foreach (var bulb in _bulbs)
    {
        Console.WriteLine(bulb);
    }
}
