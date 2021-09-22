using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Healer : IHCard
{
    public int ManaCost { get; set; }
    public int AtkDamage { get; set; }
    public int Health { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Healer()
    {
        ManaCost = 3;
        AtkDamage = 1;
        Health = 5;
        Name = "Healer";
        Description = "A nice healer";
    }

    public void OnBeingDrawed()
    {
        Debug.Log("Warrior has been drawn");
    }

    public void OnBeingPlayed()
    {
        Debug.Log("Warrior has being played");
    }
}
