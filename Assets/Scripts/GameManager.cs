using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Assets.Scripts.Music.Scales;
using Assets.Scripts.Music;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    Game game;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    void Start()
    {
        //game = new Game();

        //NeuralNetwork nn = new NeuralNetwork(2, 2, 2, 4);
        //nn.PrintNeuralNetwork();

        Scale scale = new Scale(Notes.G);
        scale.PrintScale();
    }

    public void PrintCurrentDeck()
    {
        game.PrintCurrentDeck();
    }

    public void PrintPlayerHand(int index)
    {
        game.PrintPlayerHand(index);
    }
}
