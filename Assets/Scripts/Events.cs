using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public Text events;
    public MagicItself comp;
    public MyMagic me;
    int commonMax;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (me.count > comp.count)
        {
            events.text = "Computer";
        }
        if (me.count < comp.count)
        {
            events.text = "You";
        }
        if (me.count == comp.count)
        {
            events.text = "No one. It's a draw!";
        }
    }
    
}
