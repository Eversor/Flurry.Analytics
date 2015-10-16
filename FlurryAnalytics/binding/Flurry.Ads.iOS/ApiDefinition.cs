using System;

using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Flurry.Ads {

	[BaseType (typeof(NSObject), Name = "FlurryAdTargeting")]
	interface FlurryAdTargeting
	{
		[Static, Export ("targeting")]
		FlurryAdTargeting Targeting { get; }

		[Export ("location", ArgumentSemantic.Retain)]
		CLLocation Location { get; set; }

		[Export ("userCookies", ArgumentSemantic.Retain)]
		NSDictionary UserCookies { get; set; }

		[Export ("keywords", ArgumentSemantic.Retain)]
		NSDictionary Keywords { get; set; }

		[Export ("testAdsEnabled")]
		bool TestAdsEnabled { get; set; }
	}

	[BaseType (typeof(NSObject), Name = "FlurryAds")]
	interface FlurryAds
	{
		[Static, Export ("fetchAdForSpace:frame:size:")]
		void FetchAdForSpace (string space, CGRect frame, AdSize size);

		[Static, Export ("adReadyForSpace:")]
		bool AdReadyForSpace (string space);

		[Static, Export ("displayAdForSpace:onView:viewControllerForPresentation:")]
		void DisplayAdForSpace (string space, UIView view, UIViewController viewControllerForPresentation);

		[Obsolete ("This method has been deprecated. Use the overload that accepts a UIView instead.")]
		[Static, Export ("displayAdForSpace:modallyForViewController:")]
		void DisplayAdForSpace (string space, UIViewController viewController);

		[Static, Export ("fetchAndDisplayAdForSpace:view:viewController:size:")]
		void FetchAndDisplayAdForSpace (string space, UIView viewContainer, UIViewController viewControllerForPresentation, AdSize size);

		[Static, Export ("removeAdFromSpace:")]
		void RemoveAdFromSpace (string space);

		[Static, Export ("initialize:")]
		void Initialize (UIViewController rvc);

		[Static, Export ("setAdDelegate:")]
		void SetAdDelegate (NSObject @delegate);

		[Static, Export ("enableTestAds:")]
		void EnableTestAds (bool enable);

		[Static, Export ("setUserCookies:")]
		void SetUserCookies (NSDictionary userCookies);

		[Static, Export ("clearUserCookies")]
		void ClearUserCookies ();

		[Static, Export ("setKeywordsForTargeting:")]
		void SetKeywordsForTargeting (NSDictionary keywords);

		[Static, Export ("clearKeywords")]
		void ClearKeywords ();

//		[Static, Export ("addCustomAdNetwork:withProperties:")]
//		void AddCustomAdNetwork (FlurryCustomAdNetwork adNetworkClass, FlurryCustomAdNetworkProperties adNetworkProperties);
	}

	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "FlurryAdDelegate")]
	interface FlurryAdDelegate
	{
		[Export ("spaceDidReceiveAd:")]
		void SpaceDidReceiveAd (string adSpace);

		[Export ("spaceDidFailToReceiveAd:error:")]
		void SpaceDidFailToReceiveAd (string adSpace, NSError error);

		[Export ("spaceShouldDisplay:interstitial:")]
		bool SpaceShouldDisplay (string adSpace, bool interstitial);

		[Export ("spaceShouldDisplay:forType:")]
		bool SpaceShouldDisplay (string adSpace, AdType type);

		[Export ("spaceDidRender:interstitial:")]
		void SpaceDidRender (string space, bool interstitial);

		[Export ("spaceDidFailToRender:error:")]
		void SpaceDidFailToRender (string space, NSError error);

		[Export ("spaceWillDismiss:interstitial:")]
		void SpaceWillDismiss (string adSpace, bool interstitial);

		[Export ("spaceDidDismiss:interstitial:")]
		void SpaceDidDismiss (string adSpace, bool interstitial);

		[Export ("spaceWillLeaveApplication:")]
		void SpaceWillLeaveApplication (string adSpace);

		[Export ("spaceWillExpand:")]
		void SpaceWillExpand (string adSpace);

		[Export ("spaceWillCollapse:")]
		void SpaceWillCollapse (string adSpace);

		[Export ("spaceDidCollapse:")]
		void SpaceDidCollapse (string adSpace);

		[Export ("spaceDidReceiveClick:")]
		void SpaceDidReceiveClick (string adSpace);

		[Export ("spaceClickActionDidFail:error:")]
		void SpaceClickActionDidFail (string adSpace, NSError error);

		[Export ("videoDidFinish:")]
		void VideoDidFinish (string adSpace);

		[Export ("videoDidNotFinish:")]
		void VideoDidNotFinish (string adSpace);

		[Export ("appSpotMillennialAppKey")]
		string AppSpotMillennialAppKey ();

		[Export ("appSpotMillennialInterstitalAppKey")]
		string AppSpotMillennialInterstitalAppKey ();

		[Export ("appSpotInMobiAppKey")]
		string AppSpotInMobiAppKey ();

		[Export ("appSpotFANAppPlacementID")]
		string AppSpotFANAppPlacementID ();

		[Export ("appSpotAdMobPublisherID")]
		string AppSpotAdMobPublisherID ();

		[Export ("appSpotMobclixApplicationID")]
		string AppSpotMobclixApplicationID ();

		[Export ("appSpotJumptapPublisherID")]
		string AppSpotJumptapPublisherID ();

		[Export ("appSpotJumptapSiteID")]
		string AppSpotJumptapSiteID ();

		[Export ("appSpotJumptapBannerAdSpotID")]
		string AppSpotJumptapBannerAdSpotID ();

		[Export ("appSpotJumptapLeaderboardAdSpotID")]
		string AppSpotJumptapLeaderboardAdSpotID ();

		[Export ("appSpotJumptapMediumRectangleAdSpotID")]
		string AppSpotJumptapMediumRectangleAdSpotID ();

		[Obsolete ("This method has been deprecated. Use FlurryAds.Initialze() instead.")]
		[Export ("appSpotRootViewController")]
		NSObject AppSpotRootViewController ();

		[Export ("appSpotAccelerometerEnabled")]
		bool AppSpotAccelerometerEnabled ();
	}
}

namespace Flurry.Ads.Banner {

	interface IFlurryAdBannerDelegate { }

	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "FlurryAdBannerDelegate")]
	interface FlurryAdBannerDelegate
	{
		[Export ("adBannerDidFetchAd:"), EventArgs ("DidFetchAd")]
		void DidFetchAd (FlurryAdBanner bannerAd);

		[Export ("adBannerDidRender:"), EventArgs ("DidRenderAd")]
		void DidRenderAd (FlurryAdBanner bannerAd);

		[Export ("adBannerWillPresentFullscreen:"), EventArgs ("WillPresentFullscreen")]
		void WillPresentFullscreen (FlurryAdBanner bannerAd);

		[Export ("adBannerWillLeaveApplication:"), EventArgs ("WillLeaveApplication")]
		void WillLeaveApplication (FlurryAdBanner bannerAd);

		[Export ("adBannerWillDismissFullscreen:"), EventArgs ("WillDismissFullscreen")]
		void WillDismissFullscreen (FlurryAdBanner bannerAd);

		[Export ("adBannerDidDismissFullscreen:"), EventArgs ("DidDismissFullscreen")]
		void DidDismissFullscreen (FlurryAdBanner bannerAd);

		[Export ("adBannerDidReceiveClick:"), EventArgs ("DidReceiveClick")]
		void DidReceiveClick (FlurryAdBanner bannerAd);

		[Export ("adBannerVideoDidFinish:"), EventArgs ("DidFinishVideo")]
		void DidFinishVideo (FlurryAdBanner bannerAd);

		[Export ("adBanner:adError:errorDescription:"), EventArgs ("BannerAdError")]
		void Error (FlurryAdBanner bannerAd, AdError adError, NSError errorDescription);
	}

	[BaseType (typeof(NSObject), Name = "FlurryAdBanner", Delegates = new[] { "AdDelegate" }, Events = new[] { typeof (FlurryAdBannerDelegate) })]
	interface FlurryAdBanner
	{
		[Export ("space")]
		string Space { get; set; }

		[Export ("targeting", ArgumentSemantic.Retain)]
		FlurryAdTargeting Targeting { get; set; }

		[NullAllowed, Export ("adDelegate", ArgumentSemantic.Assign)]
		IFlurryAdBannerDelegate AdDelegate { get; set; }

		[Export ("ready")]
		bool Ready { get; }

		[Export ("initWithSpace:")]
		IntPtr Constructor (string space);

		[Export ("fetchAdForFrame:")]
		void FetchAdForFrame (CGRect frame);

		[Export ("displayAdInView:viewControllerForPresentation:")]
		void DisplayAdInView (UIView view, UIViewController viewController);

		[Export ("fetchAndDisplayAdInView:viewControllerForPresentation:")]
		void FetchAndDisplayAdInView (UIView view, UIViewController viewController);
	}
}

namespace Flurry.Ads.Interstitial {

	interface IFlurryAdInterstitialDelegate { }

	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "FlurryAdInterstitialDelegate")]
	interface FlurryAdInterstitialDelegate
	{
		[Export ("adInterstitialDidFetchAd:"), EventArgs ("DidFetchAd")]
		void DidFetchAd (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialDidRender:"), EventArgs ("DidRenderAd")]
		void DidRenderAd (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialWillPresent:"), EventArgs ("WillPresentAd")]
		void WillPresentAd (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialWillLeaveApplication:"), EventArgs ("WillLeaveApplication")]
		void WillLeaveApplication (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialWillDismiss:"), EventArgs ("WillDismissAd")]
		void WillDismissAd (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialDidDismiss:"), EventArgs ("DidDismissAd")]
		void DidDismissAd (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialDidReceiveClick:"), EventArgs ("DidReceiveClick")]
		void DidReceiveClick (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitialVideoDidFinish:"), EventArgs ("DidFinishVideo")]
		void DidFinishVideo (FlurryAdInterstitial interstitialAd);

		[Export ("adInterstitial:adError:errorDescription:"), EventArgs ("InterstitialAdError")]
		void Error (FlurryAdInterstitial interstitialAd, AdError adError, NSError errorDescription);
	}

	[BaseType (typeof(NSObject), Name = "FlurryAdInterstitial", Delegates = new[] { "AdDelegate" }, Events = new[] { typeof (FlurryAdInterstitialDelegate) })]
	interface FlurryAdInterstitial
	{
		[Export ("space")]
		string Space { get; }

		[Export ("targeting", ArgumentSemantic.Retain)]
		FlurryAdTargeting Targeting { get; set; }

		[NullAllowed, Export ("adDelegate", ArgumentSemantic.Assign)]
		IFlurryAdInterstitialDelegate AdDelegate { get; set; }

		[Export ("ready")]
		bool Ready { get; }

		[Export ("initWithSpace:")]
		IntPtr Constructor (string space);

		[Export ("fetchAd")]
		void FetchAd ();

		[Export ("presentWithViewController:")]
		void PresentWithViewController (UIViewController presentingViewController);
	}
}

namespace Flurry.Ads.Native {
	
	[BaseType (typeof(NSObject), Name = "FlurryAdNativeAsset")]
	interface FlurryAdNativeAsset
	{
		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; }

		[Export ("type")]
		AssetType Type { get; }

		[Export ("value", ArgumentSemantic.Retain)]
		string Value { get; }

		[Export ("width")]
		int Width { get; }

		[Export ("height")]
		int Height { get; }
	}

	interface IFlurryAdNativeDelegate { }

	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "FlurryAdNativeDelegate")]
	interface FlurryAdNativeDelegate
	{
		[Export ("adNativeDidFetchAd:"), EventArgs("DidFetchAd")]
		void DidFetchAd (FlurryAdNative nativeAd);

		[Export ("adNativeWillPresent:"), EventArgs("WillPresentAd")]
		void WillPresentAd (FlurryAdNative nativeAd);

		[Export ("adNativeWillLeaveApplication:"), EventArgs("WillLeaveApplication")]
		void WillLeaveApplication (FlurryAdNative nativeAd);

		[Export ("adNativeWillDismiss:"), EventArgs("WillDismissAd")]
		void WillDismissAd (FlurryAdNative nativeAd);

		[Export ("adNativeDidDismiss:"), EventArgs("DidDismissAd")]
		void DidDismissAd (FlurryAdNative nativeAd);

		[Export ("adNativeDidReceiveClick:"), EventArgs("DidReceiveClick")]
		void DidReceiveClick (FlurryAdNative nativeAd);

		[Export ("adNative:adError:errorDescription:"), EventArgs("NativeAdError")]
		void Error (FlurryAdNative nativeAd, AdError adError, NSError errorDescription);

		[Export ("adNativeDidLogImpression:"), EventArgs("DidLogImpression")]
		void DidLogImpression (FlurryAdNative nativeAd);
	}

	[BaseType (typeof(NSObject), Name = "FlurryAdNative", Delegates = new[] { "AdDelegate" }, Events = new[] { typeof (FlurryAdNativeDelegate) })]
	interface FlurryAdNative
	{
		[Export ("space")]
		string Space { get; }

		[NullAllowed, Export ("adDelegate", ArgumentSemantic.Assign)]
		IFlurryAdNativeDelegate AdDelegate { get; set; }

		[Export ("ready")]
		bool Ready { get; }

		[Export ("expired")]
		bool Expired { get; }

		[Export ("assetList")]
		NSObject[] AssetList { get; }

		[Export ("trackingView", ArgumentSemantic.Retain)]
		UIView TrackingView { get; set; }

		[Export ("viewControllerForPresentation", ArgumentSemantic.Retain)]
		UIViewController ViewControllerForPresentation { get; set; }

		[Export ("videoViewContainer", ArgumentSemantic.Retain)]
		UIView VideoViewContainer { get; set; }

		[Export ("targeting", ArgumentSemantic.Retain)]
		FlurryAdTargeting Targeting { get; set; }

		[Export ("initWithSpace:")]
		IntPtr Constructor (string space);

		[Export ("fetchAd")]
		void FetchAd ();

		[Export ("assetListForType:")]
		NSObject[] AssetListForType (AssetType type);

		[Export ("removeTrackingView")]
		void RemoveTrackingView ();

		[Export ("isVideoAd")]
		bool IsVideoAd { get; }
	}

	[BaseType (typeof(NSObject), Name = "FlurryAdNativeStyle")]
	interface FlurryAdNativeStyle
	{
		[Static, Field ("STYLE1_SMALL", "__Internal")]
		int Style1Small { get; }

		[Static, Field ("STYLE1_MEDIUM", "__Internal")]
		int Style1Medium { get; }

		[Static, Field ("STYLE1_LARGE", "__Internal")]
		int Style1Large { get; }

		[Static, Field ("STYLE1_XLARGE", "__Internal")]
		int Style1XLarge { get; }

		[Static, Field ("STYLE2_SMALL", "__Internal")]
		int Style2Small { get; }

		[Static, Field ("STYLE2_MEDIUM", "__Internal")]
		int Style2Medium { get; }


		[Export ("style")]
		string Style { get; }

		[Export ("initWithStyle:")]
		IntPtr Constructor (int styleNum);
	}
}
