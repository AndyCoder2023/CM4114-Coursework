
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStateManager : MonoBehaviour
{

    public static GameStateManager instance = null;
    private int _counter;
    public HauntingAudioScript[] triggers;
    public int targetNum;
    public int targetTrigger;

    public TextMeshProUGUI txtPrompt;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayRandomZombie();
    }

    public void PlayRandomZombie()
    {
        targetTrigger = Random.Range(0, triggers.Length);
        triggers[targetTrigger].particle.Play();
        GenerateRandomNum();
        txtPrompt.text = "";

    }

    private void Update()
    {
        if (Input.GetKeyDown("" + targetNum))
        {
            triggers[targetTrigger].particle.Stop();
            AddToCounter(1);
            PlayRandomZombie();

        }
    }

    public void QueryInput()
    {
        txtPrompt.text = "Quick! Hit " + targetNum;
    }

    public void GenerateRandomNum()
    {
        targetNum = Random.Range(0, 9);
    }

    public void ClearUI()
    {
        txtPrompt.text = "";
    }

    public void AddToCounter(int val)
    {
        _counter += val;
    }

}
