using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NeuralNetwork
{
    public List<Layer> layers;

    //int inputs;
    //int outputs;
    //int interLayers;
    //int layerSize;

    public NeuralNetwork(int inputs, int outputs, int interLayers, int layerSize)
    {
        //this.inputs = inputs;
        //this.outputs = outputs;
        //this.interLayers = interLayers;
        //this.layerSize = layerSize;

        layers = new List<Layer>
        {
            // Input layer
            new Layer(inputs, new float[0])
        };

        for (int i = 0; i < interLayers; i++)
        {
            layers.Add(new Layer(layerSize, layers[i].outputs));
        }

        // Output layer
        layers.Add(new Layer(outputs, layers[layers.Count-1].outputs));
    }

    public void PrintNeuralNetwork()
    {
        for (int i = 0; i < layers.Count; i++)
        {
            Debug.Log($"Layer {i} : {layers[i].PrintNeurons()}");
        }
    }
}
