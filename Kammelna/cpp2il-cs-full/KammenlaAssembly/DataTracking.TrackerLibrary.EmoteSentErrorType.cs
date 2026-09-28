using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Jackaroo;
using Server.Models;
using UI.Popups.Chat;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

namespace DataTracking;

public static class TrackerLibrary
{
	public enum EmoteSentErrorType
	{
		NotEnoughAces,
		IsNotPlayer,
		BuyError
	}

	private class TrackerEvent : ITrackEvent
	{
		[Serializable]
		private sealed class <>c
		{
			public static readonly <>c <>9;

			public static Func<string, bool> <>9__7_0;

			static <>c()
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1792;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = default(object);
				obj2..ctor();
				object obj3 = obj;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}

			internal bool <GetEventString>b__7_0(string s)
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				//IL_0072: Expected O, but got I4
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = StringsExtensions.IsNullOrEmpty(s);
				return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			}
		}

		private readonly TrackingContext _context;

		private readonly TrackingFeature _feature;

		private readonly TrackingPlacement _placement;

		private readonly TrackingOutcome _outcome;

		private readonly string _label;

		private readonly float? _value;

		public TrackerEvent(TrackingContext context, TrackingFeature feature, TrackingPlacement placement, TrackingOutcome outcome, string label = null, float? value = null)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 32;
			obj = label;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public unsafe string GetEventString()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0348: Expected O, but got Ref
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_006a: Expected O, but got Ref
			//IL_008d: Expected O, but got I8
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d5: Expected O, but got Ref
			//IL_0100: Expected O, but got I4
			//IL_0116: Expected O, but got I
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0174: Expected O, but got Ref
			//IL_0197: Expected O, but got I8
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected O, but got Unknown
			//IL_01f6: Expected O, but got I4
			//IL_020c: Expected O, but got I
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected O, but got Unknown
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected O, but got Unknown
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Expected O, but got Unknown
			//IL_029f: Expected O, but got I4
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Expected O, but got Unknown
			//IL_0385: Expected O, but got I
			//IL_0391: Expected O, but got I
			//IL_03a1: Expected O, but got I
			//IL_03b1: Expected O, but got I
			//IL_03d3: Expected O, but got I4
			//IL_02e6: Expected O, but got I4
			//IL_03f1: Expected O, but got I
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Expected O, but got Unknown
			//IL_041b: Expected O, but got I
			//IL_042c: Expected I, but got O
			//IL_044a: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj2 = default(object);
			string text = ((Enum)(&obj2)).ToString();
			IEnumerable<object> enumerable = default(IEnumerable<object>);
			if (enumerable != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				if ((nint)0 != 0)
				{
					object obj3 = enumerable + 32;
					obj3 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj4 = default(object);
					string text2 = ((Enum)(&obj4)).ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X21_v6-8]");
					object obj5 = 0 & 0xFFFFFFFEL;
					if (obj5 != null)
					{
						object obj6 = enumerable + 40;
						obj6 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj7 = default(object);
						string text3 = ((Enum)(&obj7)).ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X21_v8-10]");
						bool flag = (nint)0 < (nint)2;
						object obj8 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X21_v8-10]");
						object obj9 = -2;
						bool flag2 = obj9 == null;
						object obj10 = ~obj8;
						object obj11 = obj10 | flag2;
						if (obj11 == null)
						{
							object obj12 = enumerable + 48;
							obj12 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj13 = default(object);
							string text4 = ((Enum)(&obj13)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X21_v10-18]");
							object obj14 = 0 & 0xFFFFFFFCL;
							if (obj14 != null)
							{
								object obj15 = enumerable + 56;
								obj15 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X21_v12-20]");
								bool flag3 = (nint)0 < (nint)4;
								object obj16 = !flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X21_v12-20]");
								object obj17 = -4;
								bool flag4 = obj17 == null;
								object obj18 = ~obj16;
								object obj19 = obj18 | flag4;
								if (obj19 == null)
								{
									object obj20 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1792;
									object obj21 = enumerable + 64;
									obj21 = _label;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj22 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v33+E4]");
									bool flag5 = (nint)0 == 0;
									object obj23 = !flag5;
									if (obj23 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj22 = obj20;
									}
									object obj24 = "1.2.840.113549.1.12.1.5" + 1488;
									object obj25 = (nint)0 + (nint)2000;
									object obj26 = (nint)0 + (nint)2856;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v33+B8]");
									object obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v19+8]");
									Func<object, bool> predicate = (Func<object, bool>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v19+8]");
									bool flag6 = (nint)0 == 0;
									object obj28 = !flag6;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v33+E4]");
										bool flag7 = (nint)0 == 0;
										object obj29 = !flag7;
										if (obj29 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj22 = obj20;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v33+B8]");
										object obj30 = 0;
										object obj31 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj32 = (nint)0 + (nint)3776;
										Func<object, bool> func = default(Func<object, bool>);
										func..ctor(obj30, (IntPtr)obj32);
										object obj33 = obj20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v27+B8]");
										object obj34 = (nint)0 + (nint)8;
										obj34 = func;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										predicate = func;
									}
									IEnumerable<object> enumerable2 = Enumerable.Where(enumerable, predicate);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97D90");
									string result = default(string);
									return result;
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (string)(object)new NullReferenceException();
		}

		public string GetEventLabel()
		{
			return _label;
		}

		public TrackingContext GetContext()
		{
			return _context;
		}

		public TrackingFeature GetFeature()
		{
			return _feature;
		}

		public TrackingPlacement GetPlacement()
		{
			return _placement;
		}

		public TrackingOutcome GetOutcome()
		{
			return _outcome;
		}

		public float? GetEventValue()
		{
			return _value;
		}
	}

	public static ITrackEvent OnboardingTutorialStarted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Onboarding, TrackingFeature.FirstUseExperience, TrackingPlacement.Onboarding, TrackingOutcome.OnboardingStarted, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent OnboardingTutorialScreenViewed(int currentScreen)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "SERVICE_DISABLED" + 2008;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Onboarding, TrackingFeature.FirstUseExperience, TrackingPlacement.Onboarding, TrackingOutcome.OnboardingScreenViewed, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent OnboardingTutorialCompleted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Onboarding, TrackingFeature.FirstUseExperience, TrackingPlacement.Onboarding, TrackingOutcome.OnboardingCompleted, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent OnboardingTutorialSkipped()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Onboarding, TrackingFeature.FirstUseExperience, TrackingPlacement.Onboarding, TrackingOutcome.OnboardingSkipped, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRegisterViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Register, TrackingPlacement.SignIn, TrackingOutcome.RegisterViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRegisterClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Register, TrackingPlacement.SignIn, TrackingOutcome.RegisterClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRegisterSucceeded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Register, TrackingPlacement.SignIn, TrackingOutcome.RegisterSucceeded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRegisterError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Register, TrackingPlacement.SignIn, TrackingOutcome.RegisterError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountLoginViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Login, TrackingPlacement.SignIn, TrackingOutcome.LoginViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountLoginClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Login, TrackingPlacement.SignIn, TrackingOutcome.LoginClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountLoginSucceeded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Login, TrackingPlacement.SignIn, TrackingOutcome.LoginSucceeded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountLoginError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Login, TrackingPlacement.SignIn, TrackingOutcome.LoginError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountAutoLoginSucceeded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.Login, TrackingPlacement.SignIn, TrackingOutcome.AutoLoginSucceeded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRestPasswordViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.ResetPassword, TrackingPlacement.SignIn, TrackingOutcome.RestPasswordViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRestPasswordClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.ResetPassword, TrackingPlacement.SignIn, TrackingOutcome.ResetPasswordClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRestPasswordSucceeded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.ResetPassword, TrackingPlacement.SignIn, TrackingOutcome.ResetPasswordSucceeded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountRestPasswordError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.ResetPassword, TrackingPlacement.SignIn, TrackingOutcome.ResetPasswordError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialLoginClicked(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.LoginClicked, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialConnected(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.SocialConnected, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialConnectError(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.SocialConnectionError, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialRegisterSucceeded(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.RegisterSucceeded, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialRegisterError(SocialPlatform platform, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = "1.2.840.113549.1.12.1.5" + 1488;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		string label = friendlyName + (string)obj2 + error;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.RegisterError, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialLinked(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.SocialLinked, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialLinkedError(SocialPlatform platform, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = "1.2.840.113549.1.12.1.5" + 1488;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		string label = friendlyName + (string)obj2 + error;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.SocialLinkedError, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialUnLinked(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.SocialUnlinked, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AccountSocialUnlinkedError(SocialPlatform platform, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = "1.2.840.113549.1.12.1.5" + 1488;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		string label = friendlyName + (string)obj2 + error;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Account, TrackingFeature.SocialSignin, TrackingPlacement.SignIn, TrackingOutcome.SocialUnlinkedError, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MainMenuViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.HomeScreen, TrackingPlacement.HomeScreen, TrackingOutcome.MainMenuViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuRankedClicked(bool isSub, int remainingTrials)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		string label;
		if (isSub)
		{
			object obj2 = "DNQUALIFIER" + 3712;
			label = (string)obj2;
			object obj3 = remainingTrials;
		}
		else
		{
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1216;
			object obj4 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj5 = default(object);
			string text = string.Format((string)format, obj5);
			object obj3 = obj5;
			label = text;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.HomeScreen, TrackingOutcome.RankedClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuFriendlyClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.HomeScreen, TrackingOutcome.FriendlyClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuRoomListViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.HomeScreen, TrackingOutcome.RoomListViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent VisitStore(TrackingPlacement trackingPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.StoreHome, trackingPlacement, TrackingOutcome.StoreClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent VisitSubscriptionStore(TrackingPlacement trackingPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.InAppPurchase, trackingPlacement, TrackingOutcome.SubscribeClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent VisitCurrencyStore(TrackingPlacement trackingPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.InAppPurchase, trackingPlacement, TrackingOutcome.BuyCurrencyClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent VisitMiniGame(TrackingPlacement trackingPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.MiniGame, trackingPlacement, TrackingOutcome.MiniGameClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuFastTrackClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.HomeScreen, TrackingOutcome.FastTrackClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuOfflinePlayClicked(string onlineState)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.HomeScreen, TrackingOutcome.OfflinePlayClicked, onlineState, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuRankedAdCompleted(int remainingTrials)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1216;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.HomeScreen, TrackingOutcome.RankedAdCompleted, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuRoomCreated(string roomType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Rooms, TrackingPlacement.RoomList, TrackingOutcome.RoomCreated, roomType, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuRoomJoined()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Rooms, TrackingPlacement.RoomList, TrackingOutcome.RoomJoinClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuRoomWatched()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Rooms, TrackingPlacement.RoomList, TrackingOutcome.RoomWatchClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuChallengeRoomWatched()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Rooms, TrackingPlacement.RoomList, TrackingOutcome.RoomChallengeWatchClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuPoorConnectionViewed(float latency)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float value2 = default(float);
		float? value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.PoorConnectionPopup, TrackingOutcome.PoorConnectionViewed, null, value);
		return trackerEvent;
	}

	public static ITrackEvent MenuPoorConnectionPlayAnywayClicked(float latency)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float value2 = default(float);
		float? value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.PoorConnectionPopup, TrackingOutcome.PlayAnywayClicked, null, value);
		return trackerEvent;
	}

	public static ITrackEvent MenuPoorConnectionBackClicked(float latency)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float value2 = default(float);
		float? value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.PoorConnectionPopup, TrackingOutcome.BackClicked, null, value);
		return trackerEvent;
	}

	public static ITrackEvent OnlySubsPopupViewed(TrackingFeature trackingFeature)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, trackingFeature, TrackingPlacement.OnlyForSubsPopup, TrackingOutcome.OnlySubsViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent OnlySubsPopupSubscribeClicked(TrackingFeature trackingFeature, TrackingOutcome trackingOutcome, string furtherContext)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, trackingFeature, TrackingPlacement.OnlyForSubsPopup, trackingOutcome, furtherContext, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent OnlySubsPopupBackClicked(TrackingFeature trackingFeature)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, trackingFeature, TrackingPlacement.OnlyForSubsPopup, TrackingOutcome.BackClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotEnoughAcesPopupViewed(TrackingFeature trackingFeature)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, trackingFeature, TrackingPlacement.NotEnoughAcesPopup, TrackingOutcome.NotEnoughAcesViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotEnoughAcesPopupBoughtProduct(TrackingFeature trackingFeature, string product)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, trackingFeature, TrackingPlacement.NotEnoughAcesPopup, TrackingOutcome.CurrencyBought, product, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuAnnouncementButtonClicked(int announcementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.AnnouncementButton, TrackingPlacement.HomeScreen, TrackingOutcome.AnnouncementButtonClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuFlashSaleShown(int flashSaleId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FlashSale, TrackingPlacement.HomeScreen, TrackingOutcome.FlashSaleShown, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuFlashSaleClicked(int flashSaleId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FlashSale, TrackingPlacement.HomeScreen, TrackingOutcome.FlashSaleClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MenuSwitchGameClickedAfterNewGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.SwitchGame, TrackingPlacement.HomeScreen, TrackingOutcome.SwitchGameClickedAfterNewGame, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SwitchGameViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.SwitchGame, TrackingPlacement.SwitchGamePage, TrackingOutcome.SwitchGamePageViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SwitchGameOnboardingViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.SwitchGame, TrackingPlacement.SwitchGameOnboardingPage, TrackingOutcome.SwitchGameOnboardingPageViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SwitchGameClicked(string game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.SwitchGame, TrackingPlacement.SwitchGamePage, TrackingOutcome.SwitchGameClicked, game, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SwitchGameOnboardingClicked(string game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.SwitchGame, TrackingPlacement.SwitchGameOnboardingPage, TrackingOutcome.SwitchGameOnboardingClicked, game, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SwitchGameBackClicked(string currentGame)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.SwitchGame, TrackingPlacement.SwitchGamePage, TrackingOutcome.SwitchGameBackClicked, currentGame, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileFullProfileViewed(bool isMine, TrackingPlacement placement)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		object obj = "Material with texture name \"" + 3200;
		object obj2 = "October" + 1504;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isMine;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, placement, TrackingOutcome.FullProfileViewed, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileFullProfileLoadError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, TrackingPlacement.FullProfile, TrackingOutcome.FullProfileLoadError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileMiniProfileViewed(TrackingPlacement placement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, placement, TrackingOutcome.MiniProfileViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileMiniProfileLiked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, TrackingPlacement.MiniProfile, TrackingOutcome.MiniProfileLiked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileMiniProfileAddFriend()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, TrackingPlacement.MiniProfile, TrackingOutcome.MiniProfileAddFriend, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileMiniProfileLoadError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, TrackingPlacement.MiniProfile, TrackingOutcome.MiniProfileLoadError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileAvatarUploaded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Customization, TrackingPlacement.Settings, TrackingOutcome.AvatarUploaded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileAvatarRemoved()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Customization, TrackingPlacement.Settings, TrackingOutcome.AvatarRemoved, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileTitleActivated(string title)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Customization, TrackingPlacement.ProfileSettings, TrackingOutcome.TitleActivated, title, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileBioUpdated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Customization, TrackingPlacement.ProfileSettings, TrackingOutcome.BioUpdated, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileAchievementDescriptionViewed(string achievementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, TrackingPlacement.FullProfile, TrackingOutcome.AchievementDescriptionViewed, achievementId, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ProfileTrophyDescriptionViewed(string trophyId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Profile, TrackingPlacement.FullProfile, TrackingOutcome.TrophyDescriptionViewed, trophyId, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotificationCenterViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.Notification, TrackingPlacement.NotificationCenter, TrackingOutcome.NotificationCenterViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotificationViewed(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.Notification, TrackingPlacement.NotificationCenter, TrackingOutcome.NotificationViewed, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotificationActionClicked(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.Notification, TrackingPlacement.NotificationCenter, TrackingOutcome.NotificationActionClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotificationReadMoreClicked(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.Notification, TrackingPlacement.NotificationCenter, TrackingOutcome.NotificationReadMoreClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NotificationDismissed(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.Notification, TrackingPlacement.NotificationCenter, TrackingOutcome.NotificationDismissed, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ForcedNotificationViewed(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.ForcedNotification, TrackingPlacement.NotificationCenter, TrackingOutcome.ForcedNotificationViewed, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ForcedNotificationActionClicked(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.ForcedNotification, TrackingPlacement.NotificationCenter, TrackingOutcome.ForcedNotificationActionClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ForcedNotificationDismissed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.ForcedNotification, TrackingPlacement.NotificationCenter, TrackingOutcome.ForcedNotificationsDismissed, null, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent UserFeedViewed(UserFeedType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.UserFeed, TrackingPlacement.NotificationCenter, TrackingOutcome.UserFeedViewed, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent UserFeedClicked(UserFeedType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.UserFeed, TrackingPlacement.NotificationCenter, TrackingOutcome.UserFeedClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent UserFeedGroupClicked(UserFeedType type)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_005e: Expected O, but got Ref
		//IL_004f: Expected O, but got I4
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3728;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj3 = default(object);
		string text = ((Enum)(&obj3)).ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.UserFeed, TrackingPlacement.NotificationCenter, TrackingOutcome.UserFeedClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent UserFeedsDismissed(UserFeedType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.UserFeed, TrackingPlacement.NotificationCenter, TrackingOutcome.UserFeedsDismissed, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FriendsCenterViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Friends, TrackingPlacement.HomeScreen, TrackingOutcome.FriendsCenterViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PrivateMessageSent(bool isFriendOnline)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "not" + 1568;
		object obj2 = "not" + 1032;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isFriendOnline;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Friends, TrackingPlacement.PrivateChat, TrackingOutcome.PrivateMessageSent, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameInviteSent(bool isFriendOnline)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "not" + 1568;
		object obj2 = "not" + 1032;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isFriendOnline;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.ShareGame, TrackingPlacement.GameLobby, TrackingOutcome.GameInviteSent, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TournamentInviteSent(bool invitedAllFriends, bool isFriendOnline)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		object obj = "alignContent" + 24;
		object obj2 = "not" + 1568;
		object obj3 = "not" + 1032;
		object obj4 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isFriendOnline;
		object obj5 = !flag;
		object obj6 = ~obj5;
		object label = ((obj6 != null) ? obj3 : obj2);
		bool flag2 = !invitedAllFriends;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			label = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Tournament, TrackingPlacement.TournamentView, TrackingOutcome.TournamentInviteSent, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsViewed(bool canPlay)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "COORDINATE_TYPE_GCJ_02" + 1856;
		object obj2 = "Cannot populate JSON object onto type '{0}'." + 1432;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !canPlay;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGameViewed, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGameError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsClaim(string prizeSequence)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGameClaim, prizeSequence, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsPlayed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGamePlayed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsPlayAgain()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGamePlayedAgain, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsExitBeforeCompleted(string rewardVideoOrder)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGameExitBeforeCompleted, rewardVideoOrder, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MiniGameProjectsRewardVideoCompleted(string rewardVideoOrder)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MiniGame, TrackingPlacement.MiniGame, TrackingOutcome.MiniGameRewardVideoCompleted, rewardVideoOrder, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PredictAndWinFirstTime()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MatchPrediction, TrackingPlacement.MatchPrediction, TrackingOutcome.PredictFirstTime, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PredictAndWinViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MatchPrediction, TrackingPlacement.MatchPrediction, TrackingOutcome.PredictViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PredictAndWinFailedScreenshot()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MatchPrediction, TrackingPlacement.MatchPrediction, TrackingOutcome.PredictFailScreenshot, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PredictAndWinFailedRequest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MatchPrediction, TrackingPlacement.MatchPrediction, TrackingOutcome.PredictFailedRequest, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PredictAndWinTweetAttempted(bool hasAvatar)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "WhiteSmoke" + 144;
		object obj2 = "WhiteSmoke" + 168;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !hasAvatar;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MatchPrediction, TrackingPlacement.MatchPrediction, TrackingOutcome.PredictTweetAttempted, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PredictAndWinSucceeded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.RewardedEngagement, TrackingFeature.MatchPrediction, TrackingPlacement.MatchPrediction, TrackingOutcome.PredictSucceeded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TournamentJoined(TournamentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Tournament, TrackingPlacement.TournamentsList, TrackingOutcome.TournamentJoined, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TournamentMassEntered(MassEventModel model)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005c: Expected O, but got I4
		if (model != null)
		{
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
			long num = default(long);
			string label = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TrackerEvent trackerEvent = default(TrackerEvent);
			trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.MassEvents, TrackingPlacement.TournamentsList, TrackingOutcome.MassJoined, label, (float?)(object)0);
			return trackerEvent;
		}
		return (ITrackEvent)new NullReferenceException();
	}

	public static ITrackEvent ChatGiftBombCreationViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.GiftBomb, TrackingPlacement.GiftBombCreation, TrackingOutcome.BombCreationViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChatGiftBombBought(GiftBombType type, bool withMessage, int price)
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0180: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_01a4: Expected F4, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		TrackingOutcome outcome;
		switch (type)
		{
		case GiftBombType.Subscription:
			outcome = TrackingOutcome.SubscriptionBombBought;
			break;
		case GiftBombType.Currency:
			outcome = TrackingOutcome.CurrencyBombBought;
			break;
		default:
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)1912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (ITrackEvent)new OutOfMemoryException();
		}
		}
		object label = "WhiteSmoke" + 152;
		object obj5 = "WhiteSmoke" + 176;
		object obj6 = (nint)0 + (nint)88;
		object obj7 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !withMessage;
		object obj8 = !flag;
		object obj9 = ~obj8;
		if (obj9 != null)
		{
			label = obj5;
		}
		float? value = price;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.GiftBomb, TrackingPlacement.GiftBombCreation, outcome, (string)label, value);
		return trackerEvent;
	}

	public static ITrackEvent ChatSubBombClaimViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.GiftBomb, TrackingPlacement.Chat, TrackingOutcome.SubBombClaimViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChatSubBombClaimClickedLike()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.GiftBomb, TrackingPlacement.GiftBombClaimPopup, TrackingOutcome.SubBombClaimLiked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChatSubBombClaimDismissed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.GiftBomb, TrackingPlacement.GiftBombClaimPopup, TrackingOutcome.SubBombClaimDismissed, null, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent ChatSubBombClaimSentParticle(ChatPinnedAvatarParticle particle)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.GiftBomb, TrackingPlacement.Chat, TrackingOutcome.SubBombClaimThanks, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChatSubBombPinkedAvatarClickedLike()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.GiftBomb, TrackingPlacement.Chat, TrackingOutcome.PinnedAvatarLikeClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent CommunityLeaderboardViewed(ILeaderboardSource tab)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Expected I, but got O
		//IL_0051: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_01bf: Expected O, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object obj2;
		if (tab != null)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
			obj2 = (nint)0 + (nint)2000;
			object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
			nint num = (nint)tab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<ILeaderboardSource>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<ILeaderboardSource>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00cd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<ILeaderboardSource>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00cd;
			}
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0165;
		}
		return (ITrackEvent)new NullReferenceException();
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ X0_v3] (should have been resolved before IL gen)");
		string text = default(string);
		string label = (string)((text != null) ? text : obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Leaderboards, TrackingPlacement.CommunityList, TrackingOutcome.LeaderboardViewed, label, (float?)(object)0);
		return trackerEvent;
		IL_00cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0165;
	}

	public static ITrackEvent ShopMainShopViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.StoreHome, TrackingPlacement.Shop, TrackingOutcome.MainShopViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopSubShopViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.InAppPurchase, TrackingPlacement.Shop, TrackingOutcome.SubShopViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopBannerClicked(string id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 416;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		string label = (string)obj + id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.StoreHome, TrackingPlacement.Shop, TrackingOutcome.BannerClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopCodeActivateClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.CodeActivation, TrackingPlacement.Shop, TrackingOutcome.CodeActivateClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopCodeActivateError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.CodeActivation, TrackingPlacement.Shop, TrackingOutcome.CodeActivateError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopUniqueItemLoaded(int itemId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.UniqueItems, TrackingPlacement.Shop, TrackingOutcome.UniqueItemLoaded, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopUniqueItemClicked(int itemId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.UniqueItems, TrackingPlacement.Shop, TrackingOutcome.UniqueItemClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopUniqueItemAttemptBuy(bool hasEnoughCurrency)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 3072;
		object obj2 = "Network Authentication Required" + 2224;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !hasEnoughCurrency;
		object obj4 = !flag;
		object obj5 = ~obj4;
		string label = (string)((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.UniqueItems, TrackingPlacement.Shop, TrackingOutcome.UniqueItemAttemptBuy, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShopUniqueItemAttemptBuy(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.UniqueItems, TrackingPlacement.Shop, TrackingOutcome.UniqueItemAttemptBuy, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StoreAnimatedRoomThemeViewed(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.ItemsStore, TrackingPlacement.Shop, TrackingOutcome.AnimatedRoomThemeViewed, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StoreAnimatedRoomThemeActivated(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.ItemsStore, TrackingPlacement.Shop, TrackingOutcome.AnimatedRoomThemeActivated, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StoreAnimatedRoomThemePreviewedNoBuy(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.ItemsStore, TrackingPlacement.Shop, TrackingOutcome.AnimatedRoomThemePreviewedNoBuy, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StoreAnimatedRoomThemePreviewedAndBought(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.ItemsStore, TrackingPlacement.Shop, TrackingOutcome.AnimatedRoomThemePreviewedAndBought, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameAnimatedRoomThemeApplied(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.ItemsStore, TrackingPlacement.InGame, TrackingOutcome.AnimatedRoomThemeApplied, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent RoomCreatedWithAnimatedTheme(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Rooms, TrackingPlacement.RoomList, TrackingOutcome.RoomCreatedWithAnimatedTheme, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TournamentAnimatedRoomThemeAddon(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Tournament, TrackingPlacement.TournamentsList, TrackingOutcome.AnimatedRoomThemeTournamentAddon, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SettingsAnimatedRoomThemeActivated(int itemId, string itemName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, itemName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.Customization, TrackingPlacement.Settings, TrackingOutcome.AnimatedRoomThemeActivatedInSettings, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameQuickReplyClicked(string category)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.QuickReplyClicked, category, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameQuickReplyTop4Clicked(bool fromTop4)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1544;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1528;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !fromTop4;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.QuickReplyTop4Clicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameQuickReplyPanelOpened()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.QuickReplyPanelOpened, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameEmoteSent(string emoteID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.EmoteSent, emoteID, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent GameEmoteSentError(EmoteSentErrorType error)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.EmoteSent, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameQuickReplyTextClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.GameQuickReplyTextClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameQuickReplyEmoteClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.GameQuickReplyEmoteClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameShowProjectsClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.ShowProjectsClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameHideProjectsClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.HideProjectsClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameProjectClicked(string project)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.ProjectClicked, project, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameShareClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.ShareGame, TrackingPlacement.InGame, TrackingOutcome.ShareClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameSendSawaButtonClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.SendSawaButtonClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameSawaButtonClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.SawaButtonClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameSendFastSawaClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.SendFastSawaClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameSawaCancelClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.SawaCancelClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameKashoButtonViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.KashoButtonViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameKashoButtonClicked(bool isAfterBid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3672;
		object obj2 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3680;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isAfterBid;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.KashoButtonClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameForfeitWindowViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.ForfeitWindowViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameForfeitConfirmClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.ForfeitConfirmClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameFireModeClicked(bool active)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !active;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.GameFireModeClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameAnimatedGiftBought(int giftId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.GameAnimatedGiftBought, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameAnimatedGiftClickedCanBuy(bool canBuy)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "COORDINATE_TYPE_GCJ_02" + 1832;
		object obj2 = "COORDINATE_TYPE_GCJ_02" + 1848;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !canBuy;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.GameAnimatedGiftClickedCanBuy, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameUserSentGift(bool isSpectator, int quantity)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_00a0: Expected F4, but got I4
		object obj = "AvailableVoices" + 3192;
		object obj2 = "AvailableVoices" + 3176;
		object obj3 = (nint)0 + (nint)88;
		object obj4 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isSpectator;
		object obj5 = !flag;
		object obj6 = ~obj5;
		object label = ((obj6 != null) ? obj2 : obj);
		float? value = quantity;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.ItemsStore, TrackingPlacement.InGame, TrackingOutcome.GiftSent, (string)label, value);
		return trackerEvent;
	}

	public static ITrackEvent GameSawaSlapClicked(bool canBuy)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "COORDINATE_TYPE_GCJ_02" + 1832;
		object obj2 = "COORDINATE_TYPE_GCJ_02" + 1848;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !canBuy;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.GameSawaSlapClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameCardSlapClicked(bool canBuy)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "COORDINATE_TYPE_GCJ_02" + 1832;
		object obj2 = "COORDINATE_TYPE_GCJ_02" + 1848;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !canBuy;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.GameCardSlapClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameSafeExitClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.Gameplay, TrackingPlacement.InGame, TrackingOutcome.SafeExitClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameVoiceJoined()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.VoiceChat, TrackingPlacement.InGame, TrackingOutcome.VoiceCallJoined, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent EndGamePopupViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.EndGame, TrackingPlacement.EndGamePopup, TrackingOutcome.EndGamePopupViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent EndGameWatchClicked(bool isPlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Picking audio files is not supported on iOS" + 392;
		object obj2 = "SetRoomVariables request error" + 2152;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isPlayer;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.EndGame, TrackingPlacement.EndGamePopup, TrackingOutcome.WatchClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent EndGameExitClicked(bool isPlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Picking audio files is not supported on iOS" + 392;
		object obj2 = "SetRoomVariables request error" + 2152;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isPlayer;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.EndGame, TrackingPlacement.EndGamePopup, TrackingOutcome.ExitRoomClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent EndGamePlayMoreClicked(bool isPlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Picking audio files is not supported on iOS" + 392;
		object obj2 = "SetRoomVariables request error" + 2152;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isPlayer;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FindingGame, TrackingPlacement.EndGamePopup, TrackingOutcome.NextGameClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent EndGameStatsClicked(bool isPlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Picking audio files is not supported on iOS" + 392;
		object obj2 = "SetRoomVariables request error" + 2152;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isPlayer;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameStatistics, TrackingPlacement.EndGamePopup, TrackingOutcome.GameStatsClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent EndGameStatisticsShown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameStatistics, TrackingPlacement.EndGamePopup, TrackingOutcome.GameStatisticsViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameDisableChatClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Chat, TrackingPlacement.InGame, TrackingOutcome.DisableChatClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameDontShowSawaToggled(bool active)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !active;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.DontShowSawaToggled, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent GameSoundToggled(Preferences.GameSoundState state)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.GameSoundToggled, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AnimatedRoomSoundToggledOff(string roomThemeName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.AnimatedRoomSoundToggledOff, roomThemeName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent AnimatedRoomSoundToggledOn(string roomThemeName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.AnimatedRoomSoundToggledOn, roomThemeName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameDontShowJackarooTipsToggled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.DontShowJackarooTipsToggled, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GamePerspectiveChangeClicked(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "ThisIsFakeReceiptData" + 520;
		object obj2 = "ThisIsFakeReceiptData" + 496;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.InGame, TrackingOutcome.PerspectiveChangeClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackStartMatchingClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.StartMatchingClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackBuyTicketError(TrackingPlacement trackingPlacement, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.FastTrack, trackingPlacement, TrackingOutcome.BuyTicketError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackNotEnoughTickets(TrackingPlacement trackingPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.FastTrack, trackingPlacement, TrackingOutcome.NotEnoughTicketsPopupViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackHasUnfinishedMatchesError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.HasUnfinishedMatchesError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackMatchSeconds(TrackingPlacement trackingPlacement, int seconds)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = seconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, trackingPlacement, TrackingOutcome.MatchedInSeconds, null, value);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackEndMatchingFromMenuClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.EndMatchingClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackUnmatchedAfterTimeUp(TrackingPlacement trackingPlacement, int timer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		//IL_004d: Expected O, but got I4
		object format = "ThisIsFakeReceiptData" + 352;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, trackingPlacement, TrackingOutcome.UnmatchedAfterTimeUp, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackWatchUnfinishedMatchClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.WatchUnfinishedMatchClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackLogoClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.LogoClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackHelpClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.HelpClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackHelpFirstTimeViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.HelpFirstTimeViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackBackToMainMenuClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.BackToMainMenuClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackEndMatchingFromGameClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FastTrack, TrackingPlacement.FastTrackHome, TrackingOutcome.EndMatchingClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackClaimRankClicked(TrackingPlacement trackingPlacement, int ftLv, int ftSt, int nearAwardLv, int nearAwardSt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object format = "LAK" + 376;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj3;
		if (ftLv <= nearAwardLv)
		{
			if (ftLv == nearAwardLv)
			{
				if (ftSt > nearAwardSt)
				{
					goto IL_0019;
				}
				if (ftSt == nearAwardSt)
				{
					obj3 = "SERVICE_DISABLED" + 1488;
					goto IL_0124;
				}
			}
			obj3 = "DNQUALIFIER" + 3848;
			goto IL_0124;
		}
		goto IL_0019;
		IL_0019:
		obj3 = "Unsupported map type" + 104;
		goto IL_0124;
		IL_0124:
		string label = text + (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, trackingPlacement, TrackingOutcome.ClaimRankClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackNextStageClicked(TrackingPlacement trackingPlacement, int ftLv, int ftSt, int nearAwardLv, int nearAwardSt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object format = "LAK" + 376;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj3;
		if (ftLv <= nearAwardLv)
		{
			if (ftLv == nearAwardLv)
			{
				if (ftSt > nearAwardSt)
				{
					goto IL_0019;
				}
				if (ftSt == nearAwardSt)
				{
					obj3 = "SERVICE_DISABLED" + 1488;
					goto IL_0124;
				}
			}
			obj3 = "DNQUALIFIER" + 3848;
			goto IL_0124;
		}
		goto IL_0019;
		IL_0019:
		obj3 = "Unsupported map type" + 104;
		goto IL_0124;
		IL_0124:
		string label = text + (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, trackingPlacement, TrackingOutcome.NextStageClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	private static string GetStageClaimUpLabel(int ftLv, int ftSt, int nearAwardLv, int nearAwardSt)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		if (ftLv <= nearAwardLv)
		{
			if (ftLv == nearAwardLv)
			{
				if (ftSt > nearAwardSt)
				{
					goto IL_0005;
				}
				if (ftSt == nearAwardSt)
				{
					return "SERVICE_DISABLED" + 1488;
				}
			}
			return "DNQUALIFIER" + 3848;
		}
		goto IL_0005;
		IL_0005:
		return "Unsupported map type" + 104;
	}

	public static ITrackEvent FastTrackForfeitClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.ForfeitClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackForfeitMatchAfterWarningClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.FastTrackForfeitAfterWarningClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackSameTeammateTimerUp(int timer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "ThisIsFakeReceiptData" + 352;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.SameTeammateTimerUp, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackWaitTeammateApprovalTimerUp(int timer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "ThisIsFakeReceiptData" + 352;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.WaitTeammateApprovalTimeUp, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackPopUpMisMatchWinWhenLose()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object label = "Picking audio files is not supported on iOS" + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.PopUpMisMatch, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackPopUpMisMatchLoseWhenWin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object label = "Picking audio files is not supported on iOS" + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.PopUpMisMatch, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackRoundFinishTime(float seconds)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float value2 = default(float);
		float? value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.FastTrackRoundFinishTime, null, value);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackNextRoundClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.NextRoundClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackExitRoundClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.ExitRoundClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackContinueWithNewPlayerClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.ContinueNewPlayerClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackContinueWithSamePlayerClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.ContinueSamePlayerClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackLost(int ftLv, int ftSt, int nearAwardLv, int nearAwardSt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object format = "LAK" + 376;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj3;
		if (ftLv <= nearAwardLv)
		{
			if (ftLv == nearAwardLv)
			{
				if (ftSt > nearAwardSt)
				{
					goto IL_0019;
				}
				if (ftSt == nearAwardSt)
				{
					obj3 = "SERVICE_DISABLED" + 1488;
					goto IL_0124;
				}
			}
			obj3 = "DNQUALIFIER" + 3848;
			goto IL_0124;
		}
		goto IL_0019;
		IL_0019:
		obj3 = "Unsupported map type" + 104;
		goto IL_0124;
		IL_0124:
		string label = text + (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.FastTrackLost, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent FastTrackComplete()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.FastTrack, TrackingPlacement.InGame, TrackingOutcome.FastTrackComplete, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevIOSRequestingAdWhileIdfaStatus(string idfaStatus)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.Ads, TrackingPlacement.Background, TrackingOutcome.RequestAdWhileIdfaStatues, idfaStatus, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevPurchaseServerError(string errorCode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.InAppPurchase, TrackingPlacement.Background, TrackingOutcome.PurchaseServerError, errorCode, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevAuthenticationCleared(string reason)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.Login, TrackingPlacement.Background, TrackingOutcome.AuthCleared, reason, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevPingPongFirstReading(string connectionLevel, int latency)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = latency;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.DeviceInfo, TrackingPlacement.Background, TrackingOutcome.PingPongFirstReading, connectionLevel, value);
		return trackerEvent;
	}

	public static ITrackEvent DevLowMemory(long freeSpace)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005f: Expected O, but got I8
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected I8, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		object obj = "Material with texture name \"" + 2616;
		object obj2 = "LAK" + 1416;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj4 = freeSpace - 28000000;
		bool flag = (nint)obj4 < 0;
		bool flag2 = obj4 == null;
		long num = freeSpace ^ 0x1AB3F00;
		long num2 = freeSpace ^ obj4;
		long num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		object label = ((obj7 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.DeviceInfo, TrackingPlacement.Background, TrackingOutcome.LowMemory, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevLogoScriptShown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Dev, TrackingFeature.LogoScript, TrackingPlacement.HomeScreen, TrackingOutcome.LogoScriptShown, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevDebugButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Dev, TrackingFeature.LogoScript, TrackingPlacement.HomeScreen, TrackingOutcome.DebugButtons, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevMethods(string methodName = "")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Dev, TrackingFeature.LogoScript, TrackingPlacement.HomeScreen, TrackingOutcome.DevMethods, methodName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DevShowTestAd(string adType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Dev, TrackingFeature.LogoScript, TrackingPlacement.HomeScreen, TrackingOutcome.ShowTestAd, adType, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceGameSound(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.Settings, TrackingOutcome.GameSound, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceChatSound(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.Settings, TrackingOutcome.ChatSound, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceGameMusic(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.Settings, TrackingOutcome.GameMusic, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceVoiceActor(string voiceActor)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.VoiceActor, voiceActor, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceMultiVoiceActor(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.MultiVoiceActor, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceCardDim(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.CardDim, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceBidPredetermine(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.BidPredetermine, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceAllowDifferentCardElevation(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.AllowDifferentCardElevation, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceShowJackarooTips(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Drop Menu Toggle" + 2544;
		object obj2 = "DNQUALIFIER" + 3304;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.ShowJackarooTips, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceGamePlayPerspective(bool isTopDown)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "ThisIsFakeReceiptData" + 848;
		object obj2 = "SetRoomVariables request error" + 696;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isTopDown;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.GamePlayPerspective, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreferenceNotificationPermissionGranted(bool isGranted)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "https://www.kammelna.com/Home/Terms" + 2800;
		object obj2 = "https://www.kammelna.com/Home/Terms" + 3112;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isGranted;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.HomeScreen, TrackingOutcome.PushNotificationPermission, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PushNotificationEnabledButtonClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.PushNotification, TrackingPlacement.HomeScreen, TrackingOutcome.PushNotificationEnabled, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PushNotificationAskLaterButtonClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Preferences, TrackingFeature.PushNotification, TrackingPlacement.HomeScreen, TrackingOutcome.PushNotificationAsklater, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PushNotificationOpened(bool isNotificationClicked)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Network Authentication Required" + 2296;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 792;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isNotificationClicked;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.PushNotification, TrackingPlacement.Background, TrackingOutcome.PushNotificationOpened, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsOwnedAces(float aces)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float value2 = default(float);
		float? value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.OwnedAces, null, value);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsRankedPoints(float points)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float value2 = default(float);
		float? value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.RankPoints, null, value);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsAdsBySameUser(int currentAdNumber)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		object format = "utf-32" + 3872;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.AdsBySameUser, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsOwnCards(bool ownsCards)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "October" + 1624;
		object obj2 = "DNQUALIFIER" + 3720;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !ownsCards;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.Cards, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsActiveCard(StoreOwnedItem card)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		StoreOwnedItem storeOwnedItem = default(StoreOwnedItem);
		if (storeOwnedItem != null)
		{
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
			string name = storeOwnedItem.name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TrackerEvent trackerEvent = default(TrackerEvent);
			trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.ActiveCard, name, (float?)(object)0);
			return trackerEvent;
		}
		return (ITrackEvent)new NullReferenceException();
	}

	public static ITrackEvent StatisticsOwnRooms(bool ownsRooms)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "October" + 1624;
		object obj2 = "DNQUALIFIER" + 3720;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !ownsRooms;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.Rooms, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsActiveRoom(StoreOwnedItem room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		StoreOwnedItem storeOwnedItem = default(StoreOwnedItem);
		if (storeOwnedItem != null)
		{
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
			string name = storeOwnedItem.name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TrackerEvent trackerEvent = default(TrackerEvent);
			trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.ActiveRoom, name, (float?)(object)0);
			return trackerEvent;
		}
		return (ITrackEvent)new NullReferenceException();
	}

	public static ITrackEvent StatisticsScreenCutOut(bool state)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "HH:mm:ss.ffZ" + 912;
		object obj2 = "Network Authentication Required" + 1368;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !state;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.ScreenCutOut, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent StatisticsSocialLinked(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.SocialLink, friendlyName, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GameReplaySaved(bool isSubscribed)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "SubscribeGroup request Error" + 8;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1296;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isSubscribed;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.EndGamePopup, TrackingOutcome.GameReplaySaved, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent GoToReplayClicked(TrackingPlacement placement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.GameReplay, placement, TrackingOutcome.GotoReplayClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent DeleteReplayClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.Settings, TrackingOutcome.DeleteReplayClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent CommentAdded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.CommentAdded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SpeedChanged(float multiplier)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = "WhiteSmoke" + 584;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float num = default(float);
		string text = num.ToString();
		string label = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.GameSpeedChanged, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PauseClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.CommentAdded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent SubscribedToWatchReplay()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.SubscribedToWatchReplay, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ToggleShowPlayingCardsClicked(bool show)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "SetRoomVariables request error" + 560;
		object obj2 = "HH:mm:ss.ffZ" + 1328;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !show;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.ToggleShowPlayingCardsClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ToggleShowControlPanelClicked(bool show)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "SetRoomVariables request error" + 560;
		object obj2 = "HH:mm:ss.ffZ" + 1328;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !show;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.ToggleShowControlPanelClicked, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ShowCommentClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.ShowCommentClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent NextAklahClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.NextAklahClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent PreviousAklahClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.GameReplay, TrackingPlacement.GameReplay, TrackingOutcome.PreviousAklahClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChallengeCreated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FriendlyChallenge, TrackingPlacement.HomeScreen, TrackingOutcome.ChallengeCreated, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChallengeCreateClickedNotEnoughAces()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FriendlyChallenge, TrackingPlacement.HomeScreen, TrackingOutcome.ChallengeRequestedNoAces, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChallengeRejected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FriendlyChallenge, TrackingPlacement.HomeScreen, TrackingOutcome.ChallengeRejected, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChallengeCanceled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FriendlyChallenge, TrackingPlacement.HomeScreen, TrackingOutcome.ChallengeCanceled, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ChallengeAccepted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.FriendlyChallenge, TrackingPlacement.HomeScreen, TrackingOutcome.ChallengeAccepted, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_AllRules(JackarooAllowedRules allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		int num = default(int);
		string label = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRulesEnum, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_Ace(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleAce, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_KingBlack(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleKingBlack, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_KingRed(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleKingRed, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_QueenBlack(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleQueenBlack, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_QueenRed(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleQueenRed, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_JackBlack(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleJackBlack, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_JackRed(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleJackRed, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_Ten(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleTen, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_Seven(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleSeven, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_BlockedBase(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleBlockBase, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_TwoConsecutive(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRuleTwoConsecutive, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent JackarooCreateRoomClicked_PassSameColor(string allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Game, TrackingFeature.JackarooCustomRules, TrackingPlacement.RoomList, TrackingOutcome.CustomRulePassSameColor, allowedRules, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MarketingGrantRedeemed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.MarketingGrant, TrackingPlacement.Routing, TrackingOutcome.MarketingGrantRedeemed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent MarketingGrantRedeemError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.MarketingGrant, TrackingPlacement.Routing, TrackingOutcome.MarketingGrantRedeemError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteDeepLinkOpened()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.Routing, TrackingOutcome.TVInviteDeepLinkOpened, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteCheckRequested()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteCheckRequested, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteAvailableViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteAvailableViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteBusyViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteBusyViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteSubscribersOnlyViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteSubscribersOnlyViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteAcceptClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteAcceptClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteRejectClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteRejectClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteClaimSucceeded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteClaimSucceeded, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteClaimRaceLost()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteClaimRaceLost, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVInviteClaimError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVInviteClaimError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVCreateGamePopupViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVCreateGamePopupViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVCreateGamePopupClosed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVCreateGamePopupClosed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent TVRoomCreated(string roomType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.KammelnaTV, TrackingPlacement.TVCreateGameInvite, TrackingOutcome.TVRoomCreated, roomType, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanTabOpened(bool firstOpen)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 376;
		object obj2 = "Read object reference Id '{0}' for {1}." + 3080;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !firstOpen;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Clan, TrackingPlacement.ClanLanding, TrackingOutcome.ClanTabOpened, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanOnboardingViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Clan, TrackingPlacement.ClanLanding, TrackingOutcome.ClanOnboardingViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanLandingViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanLanding, TrackingOutcome.ClanLandingViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanDiscoveryOpened()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, TrackingFeature.Clan, TrackingPlacement.ClanDiscovery, TrackingOutcome.ClanDiscoveryOpened, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanBrowserViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanBrowser, TrackingOutcome.ClanBrowserViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanSearchPerformed(bool hasQuery)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "WhiteSmoke" + 160;
		object obj2 = "AvailableVoices" + 2728;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !hasQuery;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanBrowser, TrackingOutcome.ClanSearchPerformed, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanListLoadError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanBrowser, TrackingOutcome.ClanListLoadError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanInfoViewed(bool isMember)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "Material with texture name \"" + 448;
		object obj2 = "Unsupported map type" + 2904;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !isMember;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanInfoViewed, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanProfileLoadError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanProfileLoadError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanProgressViewed(int tier)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = tier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanLockedLevel, TrackingOutcome.ClanProgressViewed, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanCreateViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanCreateViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanLogoEditorOpened()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanLogoEditorOpened, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanLogoSaved()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanLogoSaved, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanCreateClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanCreateClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanCreated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanCreated, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanCreateError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanCreateError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanCreateNotEnoughAces()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.NotEnoughAcesPopup, TrackingOutcome.ClanCreateNotEnoughAces, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanEdited()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanEdited, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanEditError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanCreate, TrackingOutcome.ClanEditError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanJoinRequestClicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequested()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanJoinRequested, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanJoinRequestError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestCanceled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanJoinRequestCanceled, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestCancelError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanInfo, TrackingOutcome.ClanJoinRequestCancelError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestsViewed(int count)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = count;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanJoinRequestsViewed, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestAccepted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanJoinRequestAccepted, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestAcceptError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanJoinRequestAcceptError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestRejected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanJoinRequestRejected, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanJoinRequestRejectError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanJoinRequestRejectError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanControlPanelViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanControlPanelViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanLeaveClicked(string role)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanLeaveClicked, role, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanLeft()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanLeft, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanLeaveError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanLeaveError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanMemberKicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanMemberKicked, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanMemberKickError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanMemberKickError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanRolesViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanRolesViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanPermissionsViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanPermissionsViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanMemberPromoted(string permissions)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanMemberPromoted, permissions, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanMemberDemoted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanMemberDemoted, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanPermissionsUpdateError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanPermissionsUpdateError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanOwnershipTransferViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanOwnershipTransferViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanOwnershipTransferred()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanOwnershipTransferred, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanOwnershipTransferError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanOwnershipTransferError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultViewed(bool canManage)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		object obj = "COORDINATE_TYPE_GCJ_02" + 1840;
		object obj2 = "Material with texture name \"" + 448;
		object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		bool flag = !canManage;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object label = ((obj5 != null) ? obj2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanVaultViewed, (string)label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultDepositViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanVaultDepositViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultDepositClicked(int amount)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanVaultDepositClicked, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultDeposited(int amount)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanVaultDeposited, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultDepositError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanVaultDepositError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultDepositNotEnoughAces(int amount)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.NotEnoughAcesPopup, TrackingOutcome.ClanVaultDepositNotEnoughAces, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanSupportRequestViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanSupportRequestViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanSupportRequestClicked(int amount, int days)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1304;
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string label = string.Format((string)format, arg, arg2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanSupportRequestClicked, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanSupportRequestCreated(int amount)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanSupportRequestCreated, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanSupportRequestError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanSupportRequestError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanVaultDonorsViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanVault, TrackingOutcome.ClanVaultDonorsViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanAutoRenewalEnabled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanAutoRenewalEnabled, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanAutoRenewalDisabled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanAutoRenewalDisabled, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanAutoRenewalError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanAutoRenewalError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanEmblemUpgradeClicked(int tier)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = tier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanLockedLevel, TrackingOutcome.ClanEmblemUpgradeClicked, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanEmblemUpgraded(int tier)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I4
		object obj = (nint)0 + (nint)88;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = tier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanLockedLevel, TrackingOutcome.ClanEmblemUpgraded, null, value);
		return trackerEvent;
	}

	public static ITrackEvent ClanEmblemUpgradeError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Monetization, TrackingFeature.Clan, TrackingPlacement.ClanLockedLevel, TrackingOutcome.ClanEmblemUpgradeError, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanChatMessageSent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Communication, TrackingFeature.Clan, TrackingPlacement.ClanChat, TrackingOutcome.ClanChatMessageSent, null, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent ClanActivityCreatorViewed(ClanActivityType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanFeed, TrackingOutcome.ClanActivityCreatorViewed, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent ClanActivityCreated(ClanActivityType type, string details = null)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1112;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		string label;
		if (string.IsNullOrEmpty(details))
		{
			ClanActivityType clanActivityType = default(ClanActivityType);
			label = ((Enum)(&clanActivityType)).ToString();
			IntPtr intPtr = default(IntPtr);
			object obj3 = (nint)intPtr;
			object obj4 = null;
		}
		else
		{
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj5 = default(object);
			label = string.Format((string)format, obj5, details);
			object obj3 = details;
			object obj4 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanFeed, TrackingOutcome.ClanActivityCreated, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanActivityCreateError(ClanActivityType type, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1112;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1280;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string label = string.Format((string)format, arg, error);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanFeed, TrackingOutcome.ClanActivityCreateError, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent ClanActivityCreateNotEnoughVault(ClanActivityType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanFeed, TrackingOutcome.ClanActivityCreateNotEnoughVault, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent ClanActivityDeleted(ClanActivityType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanFeed, TrackingOutcome.ClanActivityDeleted, label, (float?)(object)0);
		return trackerEvent;
	}

	public unsafe static ITrackEvent ClanActivityDeleteError(ClanActivityType type)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Expected O, but got Ref
		//IL_005d: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		object obj2 = default(object);
		string label = ((Enum)(&obj2)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanFeed, TrackingOutcome.ClanActivityDeleteError, label, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanInternalLeaderboardViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanLeaderboard, TrackingOutcome.ClanInternalLeaderboardViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanRollbackBannerViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanRollbackBannerViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanRollbackConfirmViewed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanRollbackConfirmViewed, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanRollbackRestored()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanRollbackRestored, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanRollbackWindowExpired()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanRollbackWindowExpired, null, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent ClanRollbackError(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Social, TrackingFeature.Clan, TrackingPlacement.ClanControlPanel, TrackingOutcome.ClanRollbackError, error, (float?)(object)0);
		return trackerEvent;
	}

	public static ITrackEvent UiClicked(TrackingFeature feature, TrackingPlacement placement, TrackingOutcome outcome)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerEvent trackerEvent = default(TrackerEvent);
		trackerEvent..ctor(TrackingContext.Navigation, feature, placement, outcome, null, (float?)(object)0);
		return trackerEvent;
	}
}
