using System;

using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

//namespace Flurry.Tumblr {
//
//	[Protocol, Model]
//	[BaseType (typeof(NSObject), Name = "FlurryTumblrDelegate")]
//	interface FlurryTumblrDelegate
//	{
//		[Export ("flurryTumblrPostError:errorType:")]
//		void PostError (NSError error, TumblrErrorType errorType);
//
//		[Export ("flurryTumblrPostSuccess")]
//		void PostSuccess ();
//	}
//
//	interface IFlurryTumblrShareParameters { }
//
//	[Protocol, Model]
//	[BaseType (typeof(NSObject), Name = "IFlurryTumblrShareParameters")]
//	interface FlurryTumblrShareParameters
//	{
//		[Export ("iOSDeepLink", ArgumentSemantic.Retain)]
//		string IOSDeepLink { get; set; }
//
//		[Export ("androidDeepLink", ArgumentSemantic.Retain)]
//		string AndroidDeepLink { get; set; }
//
//		[Export ("webLink", ArgumentSemantic.Retain)]
//		string WebLink { get; set; }
//	}
//
//	[BaseType (typeof(NSObject), Name = "FlurryTextShareParameters")]
//	interface FlurryTextShareParameters : FlurryTumblrShareParameters
//	{
//		[Export ("text", ArgumentSemantic.Strong)]
//		string Text { get; set; }
//
//		[Export ("title", ArgumentSemantic.Strong)]
//		string Title { get; set; }
//	}
//
//	[BaseType (typeof(NSObject), Name = "FlurryImageShareParameters")]
//	interface FlurryImageShareParameters : FlurryTumblrShareParameters
//	{
//		[Export ("imageURL", ArgumentSemantic.Strong)]
//		string ImageUrl { get; set; }
//
//		[Export ("imageCaption", ArgumentSemantic.Strong)]
//		string ImageCaption { get; set; }
//	}
//
//	[BaseType (typeof(NSObject), Name = "FlurryTumblr")]
//	interface FlurryTumblr
//	{
//		[Static, Export ("setConsumerKey:consumerSecret:")]
//		void SetConsumerKey (string consumerKey, string consumerSecret);
//
//		[Static, Export ("setConsumerKey:consumerSecret:consumerScheme:")]
//		void SetConsumerKey (string consumerKey, string consumerSecret, string urlScheme);
//
//		[Static, Export ("post:presentingViewController:")]
//		void Post (IFlurryTumblrShareParameters parameters, UIViewController presentingController);
//
//		[Static, Export ("setDelegate:")]
//		void SetDelegate (FlurryTumblrDelegate @delegate);
//
//		[Static, Export ("tumblrLogo")]
//		UIImage TumblrLogo { get; }
//
//		[Static, Export ("handleURL:")]
//		bool HandleUrl (NSUrl url);
//	}
//}
