using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public Colors color;
    public Values value;

    public Card(Values value, Colors color)
    {
        this.color = color;
        this.value = value;
    }
}
