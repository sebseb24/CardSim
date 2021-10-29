using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron
{
    float[] inputs;
    float[] weights;
    float bias;

    public Neuron(float[] inputs)
    {
        bias = Random.value;
        this.inputs = inputs;

        weights = new float[inputs.Length];
        for (int i = 0; i < weights.Length; i++)
        {
            weights[i] = Random.value;
        }
    }

    // Dot Product
    public float CalculateOutput()
    {
        float output = bias;
        for (int i = 0; i < inputs.Length; i++)
        {
            output += inputs[i] * weights[i];
        }

        return output;
    }
}
