using UnityEngine;

public class HauntingAudioScript : MonoBehaviour
{

    public ParticleSystem particle;


    void OnTriggerEnter(Collider ent)
    {

        if (particle.isPlaying)
        {
            GameStateManager.instance.QueryInput();

        }
    }

    void OnTriggerExit(Collider ext)
    {
        GameStateManager.instance.ClearUI();
    }


}



