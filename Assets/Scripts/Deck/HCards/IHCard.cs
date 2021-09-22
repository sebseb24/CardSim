using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHCard
{
    int ManaCost { get; set; }
    int AtkDamage { get; set; }
    int Health { get; set; }
    string Name { get; set; }

    string Description { get; set; }

    void OnBeingDrawed();

    void OnBeingPlayed();

}
