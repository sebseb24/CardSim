using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Warrior : IHCard
{
    public int ManaCost { get; set; }
    public int AtkDamage { get; set; }
    public int Health { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Warrior()
    {
        ManaCost = 6;
        AtkDamage = 4;
        Health = 6;
        Name = "Warrior";
        Description = "A mean warrior";
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
