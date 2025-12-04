using UnityEngine.Playables;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public PlayableDirector timeline1;

    private void OnTriggerEnter(Collider other)
    {
        timeline1.Play();
    }
}
