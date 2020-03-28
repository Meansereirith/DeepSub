using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class Admobs
{

    private BannerView bannerView;
    private InterstitialAd interstitial;
   

    public Admobs()
    {

    }


    public void RequestBanner()
    {
        //test id
        //ca-app-pub-3940256099942544/6300978111

#if UNITY_EDITOR
        string adUnitId = "unused";
#elif UNITY_ANDROID 	
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";

#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif
        AdSize adSize = new AdSize(320, 70);

        bannerView = new BannerView(adUnitId, adSize, AdPosition.Bottom);


        AdRequest request = new AdRequest.Builder()
            .AddExtra("color_bg", "9B30FF")
            .Build();



        //bannerView.OnAdLeavingApplication += BannerView_OnAdLeavingApplication;
        //bannerView.OnAdClosed += BannerView_OnAdClosed;
        //bannerView.OnAdFailedToLoad += BannerView_OnAdFailedToLoad;

        bannerView.OnAdLeavingApplication += BannerView_OnAdLeavingApplication;
        bannerView.OnAdClosed += BannerView_OnAdClosed;
        bannerView.OnAdFailedToLoad += BannerView_OnAdFailedToLoad;
        // Load the banner with the request.
        bannerView.LoadAd(request);


       
        //  bannerView.Show();




    }


    private void BannerView_OnAdLeavingApplication(object sender, System.EventArgs e)
    {

        destroybanner();
    }

    private void BannerView_OnAdClosed(object sender, System.EventArgs e)
    {
        destroybanner();
    }

    private void BannerView_OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs e)
    {
        destroybanner();
    }

    public void destroybanner()
    {
        
        if (bannerView!=null)
        {
            bannerView.Destroy();
        }
       
    }



    public void RequestInterstitial()
    {
        
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);

    }


    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        interstitial.Destroy();
    }

    private void Interstitial_OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs e)
    {
        interstitial.Destroy();
    }

    private void Interstitial_OnAdLeavingApplication(object sender, System.EventArgs e)
    {
        interstitial.Destroy();
    }




    public void ShowInterstitial()
    {
        if (interstitial.IsLoaded())
        {
        
            interstitial.Show();
            interstitial.OnAdClosed += Interstitial_OnAdClosed;
            interstitial.OnAdFailedToLoad += Interstitial_OnAdFailedToLoad;
            interstitial.OnAdLeavingApplication += Interstitial_OnAdLeavingApplication;


        }
    }

    


}
