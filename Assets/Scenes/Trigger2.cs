using UnityEngine.Playables;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public PlayableDirector chase;

    private void OnTriggerEnter(Collider other)
    {
        chase.Play();
    }
}
