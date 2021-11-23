using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    private void Start()
    {
        AdsManager.Instance.reqBannerAd();
        AdsManager.Instance.reqInterstitialAd();

        AdsManager.Instance.ShowBanner();
    }

    public void CallIntersitial()
    {
        AdsManager.Instance.ShowInterstitial();
    }

}
