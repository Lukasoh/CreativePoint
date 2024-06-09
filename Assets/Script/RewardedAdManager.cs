using System;
using UnityEngine;
using GoogleMobileAds.Api;
using TMPro;

public class RewardedAdManager : MonoBehaviour
{
    

    HintMgr hintMgr;

    public TextMeshProUGUI myText;
    public GameObject[] loadingPnl;

    private string _adUnitId = "ca-app-pub-2211388425656579/9433268826";
    private RewardedAd _rewardedAd;
    bool isAdLoaded;
    bool lastConnection;

    public void Awake()
    {
        
        isAdLoaded = false;
    }

    public void Start()
    {
        hintMgr = FindObjectOfType<HintMgr>();

        // Initialize Google Mobile Ads SDK
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            LoadRewardedAd();
            
        });

        CheckInternetConnection();
    }

    public void Update()
    {
        UpdateLoadingPanel();

        // Check if internet connection is restored and attempt to reload ad
        if (!lastConnection && Application.internetReachability != NetworkReachability.NotReachable)
        {
            lastConnection = true;
            LoadRewardedAd();
            
        }
    }

    private void CheckInternetConnection()
    {
        lastConnection = Application.internetReachability != NetworkReachability.NotReachable;
    }

    private void UpdateLoadingPanel()
    {
        if (isAdLoaded)
        {
            SetLoadingPanelActive(false);
        }
        else if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            SetLoadingPanelActive(true);
            myText.text = "No internet connection";
        }
        else
        {
            SetLoadingPanelActive(true);
            myText.text = "Loading ad. Please wait a moment";
        }
    }

    private void SetLoadingPanelActive(bool isActive)
    {
        foreach (var panel in loadingPnl)
        {
            panel.SetActive(isActive);
        }
    }

    public void LoadRewardedAd()
    {
        var startTime = Time.time;


        if (_rewardedAd != null)
        {
            _rewardedAd.Destroy();
            _rewardedAd = null;
            Debug.Log("Rewarded Ad destroyed and now null");
        }
        

        var adRequest = new AdRequest();

        RewardedAd.Load(_adUnitId, adRequest, (RewardedAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                Debug.LogError("Rewarded ad Load failed with Error - " + error);
                isAdLoaded = false;
                return;
            }

            var loadTime = Time.time - startTime; // 로드 시간 계산
            Debug.Log("Ad load time: " + loadTime + " seconds");

            Debug.Log("Rewarded ad loaded with response: " + ad.GetResponseInfo());
            myText.text = "Loaded";
            isAdLoaded = true;
            _rewardedAd = ad;
            RegisterEventHandlers(_rewardedAd);
        });
    }

    

    public void ShowRewardedAd()
    {
        if (_rewardedAd != null && _rewardedAd.CanShowAd())
        {
            _rewardedAd.Show((Reward reward) =>
            {
                GiveRewardToUser();
                // Preload the next ad
                isAdLoaded = (_rewardedAd != null);
                LoadRewardedAd();
            });
        }
    }

    private void GiveRewardToUser()
    {
        if (!hintMgr.hintData.userHint[hintMgr.startNum])
        {
            hintMgr.hintData.userHint[hintMgr.startNum] = true;
            hintMgr.SaveProgressToJson();
            hintMgr.hintPnl[0].SetActive(true);
        }
        else if (hintMgr.hintData.userHint[hintMgr.startNum] && !hintMgr.hintData.userHint[hintMgr.startNum + 1])
        {
            hintMgr.hintData.userHint[hintMgr.startNum + 1] = true;
            hintMgr.SaveProgressToJson();
            hintMgr.hintPnl[1].SetActive(true);
        }
        else
        {
            hintMgr.hintData.userHint[hintMgr.startNum + 2] = true;
            hintMgr.SaveProgressToJson();
            hintMgr.hintPnl[2].SetActive(true);
        }
    }

    private void RegisterEventHandlers(RewardedAd ad)
    {
        ad.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(String.Format("Rewarded ad paid {0} {1}.", adValue.Value, adValue.CurrencyCode));
        };
        ad.OnAdImpressionRecorded += () =>
        {
            Debug.Log("Rewarded ad recorded an impression.");
        };
        ad.OnAdClicked += () =>
        {
            Debug.Log("Rewarded ad was clicked.");
        };
        ad.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("Rewarded ad full screen content opened.");
        };
        ad.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("Rewarded ad full screen content closed.");
            LoadRewardedAd();
            
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Rewarded ad failed to open full screen content with error: " + error);
            LoadRewardedAd();
            
        };
    }
}