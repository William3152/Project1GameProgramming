using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Video;
    public Animator playerAnimation;
    public ChangeScene CS;
    void Start()
    {
        Video.SetActive(false);
    }

    public void playerAttack()
    {
        playerAnimation.SetTrigger("isAttack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0F);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(3.0f);
        CS.ChangeMyScene("Menu");
    }

    public void playVideo()
    {
        Video.SetActive(true);
    }

}
