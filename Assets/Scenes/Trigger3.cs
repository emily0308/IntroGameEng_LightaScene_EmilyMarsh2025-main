using UnityEngine.Playables;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public PlayableDirector Christmas;

    private void OnTriggerEnter(Collider other)
    {
        Christmas.Play();
    }
}
