using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchAdToFinishLevel : MonoBehaviour
{
    public GameObject buttonVideo;

    private void OnEnable()
    {
        var _go = Resources.Load("LevelMap/Final Level/Level Map " + (GlobalValue.levelPlaying + 1)) as GameObject;
        if(_go==null)
        {
            buttonVideo.SetActive(false);
            enabled = false;
        }
    }


   

    private void AdsManager_AdResult(bool isSuccess, int rewarded)
    {
        
        if (isSuccess)
        {
            MenuManager.Instance.NextLevel();
        }
    }
}
