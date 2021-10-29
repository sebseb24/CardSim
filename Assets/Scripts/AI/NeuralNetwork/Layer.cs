using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer
{
    public List<Neuron> neurons;
    public int length;
    public float[] inputs;
    public float[] outputs;

    public Layer(int length, float[] inputs)
    {
        this.length = length;
        this.inputs = inputs;

        neurons = new List<Neuron>();
        for (int i = 0; i < length; i++)
        {
            neurons.Add(new Neuron(inputs));
        }

        GenerateLayerOutputs();
    }

    // Dot product of a vector * matrix
    private void GenerateLayerOutputs()
    {
        outputs = new float[neurons.Count];
        for (int i = 0; i < neurons.Count; i++)
        {
            outputs[i] = neurons[i].CalculateOutput();
        }
    }

    public string PrintNeurons()
    {
        string line = "";
        for (int i = 0; i < outputs.Length; i++)
        {
            line += $"{outputs[i]}  ";
        }

        return line;
    }
}
