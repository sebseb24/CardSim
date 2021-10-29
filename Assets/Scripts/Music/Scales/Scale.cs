using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Music;
using Assets.Scripts.Music.Scales;

public class Scale
{
    List<Notes> scale = new List<Notes>();

    public Scale(Notes tonic)
    {
        IScales scaleForm = new MajorScale();
        Notes curr = tonic;

        scale.Add(curr);
        for (int i = 0; i < 6; i++)
        {
            int index = ((int)curr) + (int)scaleForm.ScaleForm[i];
            if (index >= 12)
                index -= 12;
            curr = (Notes)index;
            scale.Add(curr);
        }
    }

    public void PrintScale()
    {
        foreach (Notes note in scale)
        {
            Debug.Log($"{note} ");
        }
    }
}
