using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource Bang;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject FlashLights;

    void OnTriggerEnter()
    {
        Bang.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        FlashLights.SetActive(true);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.03f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        FlashLights.SetActive(false);
    }
}
