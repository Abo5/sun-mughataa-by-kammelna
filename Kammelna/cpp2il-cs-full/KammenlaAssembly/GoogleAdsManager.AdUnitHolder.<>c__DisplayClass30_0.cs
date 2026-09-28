using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using GoogleMobileAds.Api;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.SceneManagement;

public class GoogleAdsManager : ScriptableObject
{
	private class AdUnitHolder
	{
		private sealed class <>c__DisplayClass27_0
		{
			public AdUnitHolder <>4__this;

			public string error;

			internal void <FireAdFailedToLoad>b__0()
			{
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Expected O, but got Unknown
				//IL_0063: Expected O, but got I4
				AdUnitHolder adUnitHolder = <>4__this;
				adUnitHolder.isBeingRequested = false;
				Ad ad = adUnitHolder.ad;
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.AdEvent(AdSDK.Admob, AdAction.Error, ad.AdType, ad.AdPlace);
				AdUnitHolder adUnitHolder2 = <>4__this;
				adUnitHolder2._adsManager.AdFailedToLoad(<>4__this, error);
			}
		}

		private sealed class <>c__DisplayClass28_0
		{
			public AdUnitHolder <>4__this;

			public Reward reward;

			internal unsafe void <FireUserEarnedReward>b__0()
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				//IL_08bd: Expected O, but got I4
				//IL_0037: Expected O, but got I4
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected O, but got Unknown
				//IL_007b: Expected O, but got Ref
				//IL_00a0: Expected O, but got Ref
				//IL_00b6: Expected I, but got O
				//IL_00c6: Expected O, but got I
				//IL_00ef: Expected O, but got I
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected O, but got Unknown
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Expected O, but got Unknown
				//IL_01d6: Expected O, but got Ref
				//IL_0247: Expected O, but got I8
				//IL_01ec: Expected I, but got O
				//IL_01fc: Expected O, but got I
				//IL_0225: Expected O, but got I
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027a: Expected O, but got Unknown
				//IL_02cc: Expected O, but got I4
				//IL_02ed: Expected O, but got Ref
				//IL_0366: Expected O, but got I4
				//IL_0376: Expected O, but got I4
				//IL_0396: Unknown result type (might be due to invalid IL or missing references)
				//IL_039b: Expected O, but got Unknown
				//IL_0303: Expected I, but got O
				//IL_0313: Expected O, but got I
				//IL_033c: Expected O, but got I
				//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bf: Expected O, but got Unknown
				//IL_048f: Expected O, but got I8
				//IL_0434: Expected I, but got O
				//IL_0444: Expected O, but got I
				//IL_046d: Expected O, but got I
				//IL_04be: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c3: Expected O, but got Unknown
				//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d7: Expected O, but got Unknown
				//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_04eb: Expected O, but got Unknown
				//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ff: Expected O, but got Unknown
				//IL_0508: Unknown result type (might be due to invalid IL or missing references)
				//IL_050d: Expected O, but got Unknown
				//IL_0564: Expected O, but got I4
				//IL_08ec: Expected O, but got I
				//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_08fa: Expected I4, but got Unknown
				//IL_0902: Expected O, but got I4
				//IL_0939: Expected O, but got I4
				//IL_0608: Expected O, but got Ref
				//IL_063c: Expected O, but got Ref
				//IL_0654: Unknown result type (might be due to invalid IL or missing references)
				//IL_0659: Expected O, but got Unknown
				//IL_0663: Unknown result type (might be due to invalid IL or missing references)
				//IL_0668: Expected O, but got Unknown
				//IL_0785: Expected O, but got I4
				//IL_078e: Expected O, but got I4
				//IL_07c6: Expected O, but got I4
				//IL_07cf: Expected O, but got I4
				//IL_0837: Expected O, but got I4
				//IL_0840: Expected O, but got I4
				object obj = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				AdUnitHolder adUnitHolder = <>4__this;
				bool flag = <>4__this == null;
				string text = (string)4;
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				if (!flag)
				{
					bool flag2 = (object)adUnitHolder.ad == null;
					text = (string)4;
					if (!flag2)
					{
						object obj2 = typeof(SqlSingle[]) + 2816;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array = default(object[]);
						bool flag3 = array == null;
						AdType adType = default(AdType);
						text = (string)(&adType);
						if (!flag3)
						{
							string text2 = default(string);
							bool flag4 = text2 == null;
							string text3 = (string)(&adType);
							if (!flag4)
							{
								nint num = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
								text3 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag5 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								if (flag5)
								{
									goto IL_0879;
								}
							}
							bool flag6 = array.Length == 0;
							text = text3;
							if (flag6)
							{
								goto IL_086b;
							}
							object obj3 = array + 32;
							obj3 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							AdUnitHolder adUnitHolder2 = <>4__this;
							bool flag7 = <>4__this == null;
							text = text2;
							if (!flag7)
							{
								bool flag8 = (object)adUnitHolder2.ad == null;
								text = text2;
								if (!flag8)
								{
									object obj4 = typeof(SqlSingle[]) + 2768;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
									string text4 = default(string);
									bool flag9 = text4 == null;
									AdPlace adPlace = default(AdPlace);
									string text5 = (string)(&adPlace);
									if (!flag9)
									{
										nint num2 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
										text5 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag10 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
										text = (string)0;
										if (flag10)
										{
											goto IL_0879;
										}
									}
									object obj5 = array.Length & 0xFFFFFFFEL;
									bool flag11 = obj5 == null;
									text = text5;
									if (flag11)
									{
										goto IL_086b;
									}
									object obj6 = array + 40;
									obj6 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Reward reward = this.reward;
									bool flag12 = this.reward == null;
									text = text4;
									if (!flag12)
									{
										object obj7 = 153100288 + 1024;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
										string text6 = default(string);
										bool flag13 = text6 == null;
										double num3 = default(double);
										string text7 = (string)(&num3);
										if (!flag13)
										{
											nint num4 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
											text7 = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag14 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
											text = (string)0;
											if (flag14)
											{
												goto IL_0879;
											}
										}
										bool flag15 = array.Length < 2;
										object obj8 = !flag15;
										object obj9 = array.Length - 2;
										bool flag16 = obj9 == null;
										object obj10 = ~obj8;
										object obj11 = obj10 | flag16;
										text = text7;
										if (obj11 != null)
										{
											goto IL_086b;
										}
										object obj12 = array + 48;
										obj12 = text6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Reward reward2 = this.reward;
										bool flag17 = this.reward == null;
										text = text6;
										if (!flag17)
										{
											bool flag18 = reward2.Type == null;
											string text8 = text6;
											if (!flag18)
											{
												nint num5 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
												text8 = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag19 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
												text = (string)0;
												if (flag19)
												{
													goto IL_0879;
												}
											}
											object obj13 = array.Length & 0xFFFFFFFCL;
											bool flag20 = obj13 == null;
											text = text8;
											if (flag20)
											{
												goto IL_086b;
											}
											object format = "___# Content push apply failed [{0}]: {1}" + 568;
											object obj14 = typeof(DataRelation) + 856;
											object obj15 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3024;
											object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
											object obj17 = array + 56;
											obj17 = reward2.Type;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											string text9 = string.Format((string)format, array);
											object obj18 = obj14;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v24+E4]");
											bool flag21 = (nint)0 == 0;
											object obj19 = !flag21;
											object message = text9;
											if (obj19 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												message = text9;
											}
											Debug.Log(message);
											object obj20 = obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v25+B8]");
											object obj21 = 0;
											int num6 = obj21 + 1;
											obj21 = num6;
											ITrackEvent trackEvent = TrackerLibrary.StatisticsAdsBySameUser(num6);
											object obj22 = obj16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v27+E4]");
											bool flag22 = (nint)0 == 0;
											object obj23 = !flag22;
											if (obj23 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Tracker.DesignEvent(trackEvent);
											AdUnitHolder adUnitHolder3 = <>4__this;
											bool flag23 = <>4__this == null;
											AdType adType2 = AdType.Rewarded;
											text = null;
											if (!flag23)
											{
												bool flag24 = (object)adUnitHolder3.ad == null;
												adType2 = AdType.Rewarded;
												text = null;
												if (!flag24)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
													AdUnitHolder adUnitHolder4 = <>4__this;
													bool flag25 = <>4__this == null;
													adType2 = AdType.Rewarded;
													AdType adType3 = default(AdType);
													text = (string)(&adType3);
													if (!flag25)
													{
														bool flag26 = (object)adUnitHolder4.ad == null;
														adType2 = AdType.Rewarded;
														text = (string)(&adType3);
														if (!flag26)
														{
															object format2 = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
															object action = "utf-32" + 1184;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
															object arg = default(object);
															object arg2 = default(object);
															string text10 = string.Format((string)format2, arg, arg2);
															FirebaseTrack.Event((string)action, text10);
															AdUnitHolder adUnitHolder5 = <>4__this;
															bool flag27 = <>4__this == null;
															AdPlace adPlace2 = AdPlace.MiniGame;
															adType2 = AdType.Rewarded;
															text = text10;
															if (!flag27)
															{
																Ad ad = adUnitHolder5.ad;
																bool flag28 = (object)adUnitHolder5.ad == null;
																adPlace2 = AdPlace.MiniGame;
																adType2 = AdType.Rewarded;
																text = text10;
																if (!flag28)
																{
																	adPlace2 = ad.AdPlace;
																	adType2 = ad.AdType;
																	Tracker.AdEvent(AdSDK.Admob, AdAction.Complete, ad.AdType, ad.AdPlace);
																	AdUnitHolder adUnitHolder6 = <>4__this;
																	bool flag29 = <>4__this == null;
																	object obj24 = 0;
																	text = (string)1;
																	if (!flag29)
																	{
																		GoogleAdsManager adsManager = adUnitHolder6._adsManager;
																		bool flag30 = (object)adUnitHolder6._adsManager == null;
																		obj24 = 0;
																		text = (string)1;
																		if (!flag30)
																		{
																			Action<AdType, AdPlace> onAdComplete = adsManager.OnAdComplete;
																			if (adsManager.OnAdComplete != null)
																			{
																				Ad ad2 = adUnitHolder6.ad;
																				bool flag31 = (object)adUnitHolder6.ad == null;
																				obj24 = 0;
																				text = (string)1;
																				if (flag31)
																				{
																					goto IL_085d;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ X9_v8 (System.Action`2<AdType, AdPlace>)+18] (should have been resolved before IL gen)");
																			}
																			IdfaPermission.AdCompleted();
																			return;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_085d;
				IL_0879:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
				throw new OutOfMemoryException();
				IL_085d:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_086b;
				IL_086b:
				ex = new IndexOutOfRangeException();
				goto IL_0879;
			}
		}

		private sealed class <>c__DisplayClass30_0
		{
			public AdUnitHolder <>4__this;

			public AdError adError;

			internal void <FireAdFailedToOpen>b__0()
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Expected O, but got Unknown
				//IL_0055: Expected O, but got I4
				AdUnitHolder adUnitHolder = <>4__this;
				Ad ad = adUnitHolder.ad;
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.AdEvent(AdSDK.Admob, AdAction.Error, ad.AdType, ad.AdPlace);
				AdUnitHolder adUnitHolder2 = <>4__this;
				string message = adError.GetMessage();
				adUnitHolder2._adsManager.AdFailedToLoad(<>4__this, message);
			}
		}

		private sealed class <>c__DisplayClass32_0
		{
			public AdUnitHolder <>4__this;

			public AdValue adValue;

			internal void <FireAdPaid>b__0()
			{
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Expected O, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected O, but got Unknown
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected O, but got Unknown
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Expected O, but got Unknown
				object obj = typeof(SqlSingle[]) + 2816;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj2 = typeof(SqlSingle[]) + 2768;
				object format = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
				object action = "___# Content push apply failed [{0}]: {1}" + 3464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object arg = default(object);
				object arg2 = default(object);
				string type = string.Format((string)format, arg, arg2);
				FirebaseTrack.Event((string)action, type);
			}
		}

		private Ad ad;

		private readonly GoogleAdsManager _adsManager;

		public RewardedAd rewarded;

		public InterstitialAd interstitial;

		public BannerView banner;

		public bool isBeingRequested;

		public string adID
		{
			get
			{
				Ad ad = this.ad;
				if ((object)this.ad != null)
				{
					return ad.AdId;
				}
				return (string)(object)new NullReferenceException();
			}
		}

		public AdType type
		{
			get
			{
				//IL_0041: Expected I4, but got O
				Ad ad = this.ad;
				if ((object)this.ad != null)
				{
					return ad.AdType;
				}
				NullReferenceException ex = new NullReferenceException();
				return (AdType)ex;
			}
		}

		public AdPlace place
		{
			get
			{
				//IL_0041: Expected I4, but got O
				Ad ad = this.ad;
				if ((object)this.ad != null)
				{
					return ad.AdPlace;
				}
				NullReferenceException ex = new NullReferenceException();
				return (AdPlace)ex;
			}
		}

		public bool isRewarded
		{
			get
			{
				//IL_0050: Expected I4, but got O
				Ad ad = this.ad;
				if ((object)this.ad != null)
				{
					return ad.AdType == AdType.Rewarded;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}

		public bool isInterstitial
		{
			get
			{
				//IL_005e: Expected I4, but got O
				//IL_003c: Expected O, but got I4
				Ad ad = this.ad;
				if ((object)this.ad != null)
				{
					object obj = ad.AdType - 1;
					return obj == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}

		public bool isBanner
		{
			get
			{
				//IL_005e: Expected I4, but got O
				//IL_003c: Expected O, but got I4
				Ad ad = this.ad;
				if ((object)this.ad != null)
				{
					object obj = ad.AdType - 2;
					return obj == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}

		public bool isRewardedAdReady
		{
			get
			{
				//IL_000b: Expected I4, but got O
				//IL_0034: Expected I4, but got O
				if ((int)(~rewarded) == 0)
				{
					return rewarded.CanShowAd();
				}
				return (byte)(int)rewarded != 0;
			}
		}

		public bool isInterstitialAdReady
		{
			get
			{
				//IL_000b: Expected I4, but got O
				//IL_0034: Expected I4, but got O
				if ((int)(~interstitial) == 0)
				{
					return interstitial.CanShowAd();
				}
				return (byte)(int)interstitial != 0;
			}
		}

		public AdUnitHolder(Ad ad, GoogleAdsManager adsManager)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = ad;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = adsManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public void SetRewardedAd(RewardedAd ra)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0471: Expected O, but got I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected O, but got Unknown
			//IL_02cb: Expected O, but got I
			//IL_02d9: Expected I, but got O
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010a: Expected O, but got I
			//IL_0118: Expected I, but got O
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_031c: Expected O, but got I
			//IL_032a: Expected I, but got O
			//IL_0159: Expected O, but got I
			//IL_0167: Expected I, but got O
			//IL_0359: Expected O, but got I
			//IL_0367: Expected I, but got O
			//IL_0196: Expected O, but got I
			//IL_01a4: Expected I, but got O
			//IL_0396: Expected O, but got I
			//IL_03a4: Expected I, but got O
			//IL_01d3: Expected O, but got I
			//IL_01e1: Expected I, but got O
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Expected O, but got Unknown
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected O, but got Unknown
			//IL_03e7: Expected O, but got I
			//IL_03f5: Expected I, but got O
			//IL_0224: Expected O, but got I
			//IL_0232: Expected I, but got O
			//IL_0424: Expected O, but got I
			//IL_0432: Expected I, but got O
			//IL_0261: Expected O, but got I
			//IL_026f: Expected I, but got O
			Ad ad = this.ad;
			object obj = typeof(DataRelation) + 856;
			if (ad.AdType != AdType.Rewarded)
			{
				object message = "___# Content push apply failed [{0}]: {1}" + 728;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v47+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogError(message);
			}
			else if (ra != null)
			{
				object obj4 = this + 32;
				if (obj4 != null)
				{
					object obj5 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj6 = (nint)0 + (nint)2560;
					Action action = default(Action);
					action..ctor(this, (IntPtr)obj6);
					((RewardedAd)obj4).OnAdClicked -= action;
					object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1072;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj8 = (nint)0 + (nint)2608;
					Action<object> action2 = default(Action<object>);
					action2..ctor((object)this, (IntPtr)obj8);
					rewarded.OnAdPaid -= action2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj9 = (nint)0 + (nint)2584;
					Action action3 = default(Action);
					action3..ctor(this, (IntPtr)obj9);
					rewarded.OnAdImpressionRecorded -= action3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj10 = (nint)0 + (nint)2568;
					Action action4 = default(Action);
					action4..ctor(this, (IntPtr)obj10);
					rewarded.OnAdFullScreenContentClosed -= action4;
					object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1048;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = (nint)0 + (nint)2576;
					Action<object> action5 = default(Action<object>);
					action5..ctor((object)this, (IntPtr)obj12);
					rewarded.OnAdFullScreenContentFailed -= action5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)2600;
					Action action6 = default(Action);
					action6..ctor(this, (IntPtr)obj13);
					rewarded.OnAdFullScreenContentOpened -= action6;
				}
				rewarded = ra;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj14 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = (nint)0 + (nint)2560;
				Action action7 = default(Action);
				action7..ctor(this, (IntPtr)obj15);
				rewarded.OnAdClicked += action7;
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)2608;
				Action<object> action8 = default(Action<object>);
				action8..ctor((object)this, (IntPtr)obj17);
				rewarded.OnAdPaid += action8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = (nint)0 + (nint)2584;
				Action action9 = default(Action);
				action9..ctor(this, (IntPtr)obj18);
				rewarded.OnAdImpressionRecorded += action9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj19 = (nint)0 + (nint)2568;
				Action action10 = default(Action);
				action10..ctor(this, (IntPtr)obj19);
				rewarded.OnAdFullScreenContentClosed += action10;
				object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1048;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21 = (nint)0 + (nint)2576;
				Action<object> action11 = default(Action<object>);
				action11..ctor((object)this, (IntPtr)obj21);
				rewarded.OnAdFullScreenContentFailed += action11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj22 = (nint)0 + (nint)2600;
				Action action12 = default(Action);
				action12..ctor(this, (IntPtr)obj22);
				rewarded.OnAdFullScreenContentOpened += action12;
			}
			else
			{
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj24 = !flag2;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message2 = "___# Content push apply failed [{0}]: {1}" + 752;
				Debug.LogError(message2);
			}
		}

		public void SetInterstitialAd(InterstitialAd ia)
		{
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Expected O, but got Unknown
			//IL_0414: Expected O, but got I4
			//IL_043b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0440: Expected O, but got Unknown
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Expected O, but got Unknown
			//IL_0483: Expected O, but got I4
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected O, but got Unknown
			//IL_025a: Expected O, but got I
			//IL_0268: Expected I, but got O
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0099: Expected O, but got I
			//IL_00a7: Expected I, but got O
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_02ab: Expected O, but got I
			//IL_02b9: Expected I, but got O
			//IL_00e8: Expected O, but got I
			//IL_00f6: Expected I, but got O
			//IL_02e8: Expected O, but got I
			//IL_02f6: Expected I, but got O
			//IL_0125: Expected O, but got I
			//IL_0133: Expected I, but got O
			//IL_0325: Expected O, but got I
			//IL_0333: Expected I, but got O
			//IL_0162: Expected O, but got I
			//IL_0170: Expected I, but got O
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected O, but got Unknown
			//IL_0376: Expected O, but got I
			//IL_0384: Expected I, but got O
			//IL_01b3: Expected O, but got I
			//IL_01c1: Expected I, but got O
			//IL_03b3: Expected O, but got I
			//IL_03c1: Expected I, but got O
			//IL_01f0: Expected O, but got I
			//IL_01fe: Expected I, but got O
			Ad ad = this.ad;
			object message;
			if (ad.AdType == AdType.Interstitial)
			{
				if (ia != null)
				{
					object obj = this + 40;
					if (obj != null)
					{
						object obj2 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj3 = (nint)0 + (nint)2560;
						Action action = default(Action);
						action..ctor(this, (IntPtr)obj3);
						((InterstitialAd)obj).OnAdClicked -= action;
						object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1072;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj5 = (nint)0 + (nint)2608;
						Action<object> action2 = default(Action<object>);
						action2..ctor((object)this, (IntPtr)obj5);
						interstitial.OnAdPaid -= action2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj6 = (nint)0 + (nint)2584;
						Action action3 = default(Action);
						action3..ctor(this, (IntPtr)obj6);
						interstitial.OnAdImpressionRecorded -= action3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj7 = (nint)0 + (nint)2568;
						Action action4 = default(Action);
						action4..ctor(this, (IntPtr)obj7);
						interstitial.OnAdFullScreenContentClosed -= action4;
						object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1048;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj9 = (nint)0 + (nint)2576;
						Action<object> action5 = default(Action<object>);
						action5..ctor((object)this, (IntPtr)obj9);
						interstitial.OnAdFullScreenContentFailed -= action5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj10 = (nint)0 + (nint)2600;
						Action action6 = default(Action);
						action6..ctor(this, (IntPtr)obj10);
						interstitial.OnAdFullScreenContentOpened -= action6;
					}
					interstitial = ia;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj11 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = (nint)0 + (nint)2560;
					Action action7 = default(Action);
					action7..ctor(this, (IntPtr)obj12);
					interstitial.OnAdClicked += action7;
					object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1072;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj14 = (nint)0 + (nint)2608;
					Action<object> action8 = default(Action<object>);
					action8..ctor((object)this, (IntPtr)obj14);
					interstitial.OnAdPaid += action8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj15 = (nint)0 + (nint)2584;
					Action action9 = default(Action);
					action9..ctor(this, (IntPtr)obj15);
					interstitial.OnAdImpressionRecorded += action9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj16 = (nint)0 + (nint)2568;
					Action action10 = default(Action);
					action10..ctor(this, (IntPtr)obj16);
					interstitial.OnAdFullScreenContentClosed += action10;
					object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1048;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj18 = (nint)0 + (nint)2576;
					Action<object> action11 = default(Action<object>);
					action11..ctor((object)this, (IntPtr)obj18);
					interstitial.OnAdFullScreenContentFailed += action11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj19 = (nint)0 + (nint)2600;
					Action action12 = default(Action);
					action12..ctor(this, (IntPtr)obj19);
					interstitial.OnAdFullScreenContentOpened += action12;
					return;
				}
				object obj20 = typeof(DataRelation) + 856;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj22 = !flag;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				message = "___# Content push apply failed [{0}]: {1}" + 744;
			}
			else
			{
				object obj23 = typeof(DataRelation) + 856;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj25 = !flag2;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				message = "___# Content push apply failed [{0}]: {1}" + 720;
			}
			Debug.LogError(message);
		}

		public void SetBannerAd(BannerView bv)
		{
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Expected O, but got Unknown
			//IL_048e: Expected O, but got I4
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Expected O, but got Unknown
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Expected O, but got Unknown
			//IL_04fd: Expected O, but got I4
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected O, but got Unknown
			//IL_0297: Expected O, but got I
			//IL_02a5: Expected I, but got O
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0099: Expected O, but got I
			//IL_00a7: Expected I, but got O
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Expected O, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_02e8: Expected O, but got I
			//IL_02f6: Expected I, but got O
			//IL_00e8: Expected O, but got I
			//IL_00f6: Expected I, but got O
			//IL_0325: Expected O, but got I
			//IL_0333: Expected I, but got O
			//IL_0125: Expected O, but got I
			//IL_0133: Expected I, but got O
			//IL_0362: Expected O, but got I
			//IL_0370: Expected I, but got O
			//IL_0162: Expected O, but got I
			//IL_0170: Expected I, but got O
			//IL_039f: Expected O, but got I
			//IL_03ad: Expected I, but got O
			//IL_019f: Expected O, but got I
			//IL_01ad: Expected I, but got O
			//IL_03dc: Expected O, but got I
			//IL_03ea: Expected I, but got O
			//IL_01dc: Expected O, but got I
			//IL_01ea: Expected I, but got O
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Expected O, but got Unknown
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			//IL_042d: Expected O, but got I
			//IL_043b: Expected I, but got O
			//IL_022d: Expected O, but got I
			//IL_023b: Expected I, but got O
			Ad ad = this.ad;
			object message;
			if (ad.AdType == AdType.Banner)
			{
				if (bv != null)
				{
					object obj = this + 48;
					if (obj != null)
					{
						object obj2 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj3 = (nint)0 + (nint)2560;
						Action action = default(Action);
						action..ctor(this, (IntPtr)obj3);
						((BannerView)obj).OnAdClicked -= action;
						object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1072;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj5 = (nint)0 + (nint)2608;
						Action<object> action2 = default(Action<object>);
						action2..ctor((object)this, (IntPtr)obj5);
						banner.OnAdPaid -= action2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj6 = (nint)0 + (nint)2584;
						Action action3 = default(Action);
						action3..ctor(this, (IntPtr)obj6);
						banner.OnAdImpressionRecorded -= action3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj7 = (nint)0 + (nint)2568;
						Action action4 = default(Action);
						action4..ctor(this, (IntPtr)obj7);
						banner.OnAdFullScreenContentClosed -= action4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj8 = (nint)0 + (nint)2600;
						Action action5 = default(Action);
						action5..ctor(this, (IntPtr)obj8);
						banner.OnAdFullScreenContentOpened -= action5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj9 = (nint)0 + (nint)2592;
						Action action6 = default(Action);
						action6..ctor(this, (IntPtr)obj9);
						banner.OnBannerAdLoaded -= action6;
						object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2568;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj11 = (nint)0 + (nint)2576;
						Action<object> action7 = default(Action<object>);
						action7..ctor((object)this, (IntPtr)obj11);
						banner.OnBannerAdLoadFailed -= action7;
					}
					banner = bv;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj12 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)2560;
					Action action8 = default(Action);
					action8..ctor(this, (IntPtr)obj13);
					banner.OnAdClicked += action8;
					object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1072;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj15 = (nint)0 + (nint)2608;
					Action<object> action9 = default(Action<object>);
					action9..ctor((object)this, (IntPtr)obj15);
					banner.OnAdPaid += action9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj16 = (nint)0 + (nint)2584;
					Action action10 = default(Action);
					action10..ctor(this, (IntPtr)obj16);
					banner.OnAdImpressionRecorded += action10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj17 = (nint)0 + (nint)2568;
					Action action11 = default(Action);
					action11..ctor(this, (IntPtr)obj17);
					banner.OnAdFullScreenContentClosed += action11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj18 = (nint)0 + (nint)2600;
					Action action12 = default(Action);
					action12..ctor(this, (IntPtr)obj18);
					banner.OnAdFullScreenContentOpened += action12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj19 = (nint)0 + (nint)2592;
					Action action13 = default(Action);
					action13..ctor(this, (IntPtr)obj19);
					banner.OnBannerAdLoaded += action13;
					object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2568;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj21 = (nint)0 + (nint)2576;
					Action<object> action14 = default(Action<object>);
					action14..ctor((object)this, (IntPtr)obj21);
					banner.OnBannerAdLoadFailed += action14;
					return;
				}
				object obj22 = typeof(DataRelation) + 856;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj24 = !flag;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				message = "___# Content push apply failed [{0}]: {1}" + 736;
			}
			else
			{
				object obj25 = typeof(DataRelation) + 856;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj27 = !flag2;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				message = "___# Content push apply failed [{0}]: {1}" + 712;
			}
			Debug.LogError(message);
		}

		public void FireAdLoaded()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_006a: Expected I, but got O
			//IL_0094: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2544;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		public void FireAdFailedToLoad(string error)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00aa: Expected I, but got O
			//IL_00d9: Expected O, but got I4
			object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)2832;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 24;
			obj7 = error;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		public void FireUserEarnedReward(Reward reward)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00aa: Expected I, but got O
			//IL_00d9: Expected O, but got I4
			object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)2840;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 24;
			obj7 = reward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		private void FireAdOpened()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_006a: Expected I, but got O
			//IL_0094: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2552;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		private void FireAdFailedToOpen(AdError adError)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00aa: Expected I, but got O
			//IL_00d9: Expected O, but got I4
			object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)2848;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 24;
			obj7 = adError;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		private void FireAdClicked()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_006a: Expected I, but got O
			//IL_0094: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2520;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		private void FireAdPaid(AdValue adValue)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00aa: Expected I, but got O
			//IL_00d9: Expected O, but got I4
			object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)2856;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 24;
			obj7 = adValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		private void FireAdImpressionRecorded()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_006a: Expected I, but got O
			//IL_0094: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2536;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		private void FireAdClosed()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_006a: Expected I, but got O
			//IL_0094: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2528;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}

		public void BeforeLoadingAd()
		{
			isBeingRequested = true;
		}

		private void <FireAdLoaded>b__26_0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			isBeingRequested = false;
			Ad ad = this.ad;
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.AdEvent(AdSDK.Admob, AdAction.Loaded, ad.AdType, ad.AdPlace);
			_adsManager.AdLoaded(this);
		}

		private void <FireAdOpened>b__29_0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			Ad ad = this.ad;
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.AdEvent(AdSDK.Admob, AdAction.Start, ad.AdType, ad.AdPlace);
			_adsManager.AdOpened(this);
		}

		private void <FireAdClicked>b__31_0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00db: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(SqlSingle[]) + 2768;
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
			object action = "___# Content push apply failed [{0}]: {1}" + 3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			string text = string.Format((string)format, arg, arg2);
			FirebaseTrack.Event((string)action, text);
			Ad ad = this.ad;
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.AdEvent(AdSDK.Admob, AdAction.Clicked, ad.AdType, ad.AdPlace);
		}

		private void <FireAdImpressionRecorded>b__33_0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(SqlSingle[]) + 2768;
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
			object action = "https://www.kammelna.com/Home/Terms" + 744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			string text = string.Format((string)format, arg, arg2);
			FirebaseTrack.Event((string)action, text);
		}

		private void <FireAdClosed>b__34_0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			Ad ad = this.ad;
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.AdEvent(AdSDK.Admob, AdAction.Closed, ad.AdType, ad.AdPlace);
			_adsManager.AdClosed(this);
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public Ad ad;

		public GoogleAdsManager <>4__this;

		internal AdUnitHolder <GetAdUnit>b__0(string _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = ad;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (AdUnitHolder)obj2;
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public AdUnitHolder adUnit;

		internal void <RequestRewardedVideo>b__0(RewardedAd rewardedAd, LoadAdError loadError)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			if (loadError != null)
			{
				string message = loadError.GetMessage();
				adUnit.FireAdFailedToLoad(message);
			}
			else if (rewardedAd != null)
			{
				adUnit.SetRewardedAd(rewardedAd);
				adUnit.FireAdLoaded();
			}
			else
			{
				object error = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3784;
				adUnit.FireAdFailedToLoad((string)error);
			}
		}
	}

	private sealed class <>c__DisplayClass39_0
	{
		public AdUnitHolder adUnit;

		internal void <RequestInterstitial>b__0(InterstitialAd interstitialAd, LoadAdError loadError)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			if (loadError != null)
			{
				string message = loadError.GetMessage();
				adUnit.FireAdFailedToLoad(message);
			}
			else if (interstitialAd != null)
			{
				adUnit.SetInterstitialAd(interstitialAd);
				adUnit.FireAdLoaded();
			}
			else
			{
				object error = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3784;
				adUnit.FireAdFailedToLoad((string)error);
			}
		}
	}

	private sealed class <>c__DisplayClass45_0
	{
		public AdUnitHolder adUnit;

		public GoogleAdsManager <>4__this;

		internal void <AdFailedToLoad>g__RequestAdAgain|0()
		{
			//IL_00b9: Expected O, but got I
			//IL_0084: Expected O, but got I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00fc: Expected O, but got I
			AdUnitHolder adUnitHolder = adUnit;
			Ad ad = adUnitHolder.ad;
			if (ad.AdType != AdType.Banner)
			{
				if (ad.AdType != AdType.Interstitial)
				{
					bool flag = ad.AdType == AdType.Rewarded;
					object obj = !flag;
					if (obj != null)
					{
						object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
						ex..ctor();
						object obj3 = (nint)0 + (nint)2488;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						throw new OutOfMemoryException();
					}
					((GoogleAdsManager)(object)adUnitHolder).RequestRewardedVideo(adUnitHolder);
				}
				else
				{
					RequestInterstitial(adUnitHolder);
				}
			}
			else
			{
				IntPtr intPtr = default(IntPtr);
				<>4__this.RequestBanner((Rect)(nint)intPtr);
			}
		}
	}

	private sealed class <>c__DisplayClass52_0
	{
		public GoogleAdsManager <>4__this;

		public AdPlace adPlace;

		internal void <ShowRewardedAd>b__0()
		{
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00ae: Expected O, but got I
			//IL_00bf: Expected I, but got O
			AdPlace adPlace = this.adPlace;
			AdUnitHolder adUnit = <>4__this.GetAdUnit(this.adPlace, AdType.Rewarded);
			if (adUnit.rewarded != null)
			{
				bool flag = adUnit.rewarded.CanShowAd();
				bool flag2 = !flag;
				adPlace = AdPlace.MiniGame;
				if (!flag2)
				{
					object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3336;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj2 = (nint)0 + (nint)2616;
					Action<object> action = default(Action<object>);
					action..ctor((object)adUnit, (IntPtr)obj2);
					adUnit.rewarded.Show(action);
					return;
				}
			}
			object obj3 = typeof(DataRelation) + 856;
			object message = "___# Content push apply failed [{0}]: {1}" + 688;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			<>4__this.RequestAndShowRewardedVideo(adUnit);
		}
	}

	private sealed class <>c__DisplayClass53_0
	{
		public GoogleAdsManager <>4__this;

		public AdPlace adPlace;

		internal void <ShowInterstitialAd>b__0()
		{
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			//IL_00e0: Expected O, but got I4
			AdPlace adPlace = this.adPlace;
			AdUnitHolder adUnit = <>4__this.GetAdUnit(this.adPlace, AdType.Interstitial);
			if (adUnit.interstitial != null)
			{
				bool flag = adUnit.interstitial.CanShowAd();
				bool flag2 = !flag;
				adPlace = AdPlace.MiniGame;
				if (!flag2)
				{
					adUnit.interstitial.Show();
					return;
				}
			}
			object obj = typeof(DataRelation) + 856;
			object message = "___# Content push apply failed [{0}]: {1}" + 440;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			<>4__this.RequestAndShowInterstitial(adUnit);
		}
	}

	private sealed class <>c__DisplayClass54_0
	{
		public GoogleAdsManager <>4__this;

		public Rect rect;

		internal void <ShowBannerAd>b__0()
		{
			AdUnitHolder adUnit = <>4__this.GetAdUnit(AdPlace.Offline, AdType.Banner);
			<>4__this.SetShowWhenReady(adUnit);
			<>4__this.RequestBanner((Rect)adUnit);
		}
	}

	private static int _adsCompletedBySameUser;

	private Action<AdType, AdPlace> m_OnAdStart;

	private Action<AdType, AdPlace> m_OnAdComplete;

	private Action<AdType, AdPlace, string> m_OnAdError;

	private Action<AdType, AdPlace, bool> m_OnAdLoaded;

	private Action<AdType, AdPlace> m_OnAdClosed;

	private Action<AdType, AdPlace, string> m_OnAdFailedToLoad3Times;

	private AdInventory adInventory;

	private Dictionary<string, AdUnitHolder> adUnitsHolder;

	private Rect bannerPosition;

	private int adFailedToLoadCount;

	private AdPlace? adPlaceToShow;

	private AdType? adTypeToShow;

	public event Action<AdType, AdPlace> OnAdStart
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
			object obj2 = this + 24;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
			object obj2 = this + 24;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<AdType, AdPlace> OnAdComplete
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<AdType, AdPlace, string> OnAdError
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 912;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 912;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<AdType, AdPlace, bool> OnAdLoaded
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 904;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 904;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<AdType, AdPlace> OnAdClosed
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<AdType, AdPlace, string> OnAdFailedToLoad3Times
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 912;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 912;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013a: Expected O, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0166: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F50]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.Web)
		{
			return;
		}
		goto IL_011a;
		IL_011a:
		object obj6 = typeof(TypeConverter<ushort, char>) + 528;
		object obj7 = (nint)0 + (nint)3488;
		object obj8 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		return;
		IL_007d:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.Web)
		{
			return;
		}
		goto IL_011a;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)3488;
		object obj3 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//IL_00ab: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0113: Expected O, but got I4
		adFailedToLoadCount = 0;
		_ = 0;
		_ = 0;
		AdUnitHolder adUnit = GetAdUnit(AdPlace.Offline, AdType.Banner);
		bool flag = adUnit == null;
		GoogleAdsManager googleAdsManager = (GoogleAdsManager)(object)adUnit;
		if (!flag)
		{
			bool flag2 = adUnit.banner == null;
			googleAdsManager = (GoogleAdsManager)(object)adUnit.banner;
			if (!flag2)
			{
				adUnit.banner.Destroy();
				googleAdsManager = (GoogleAdsManager)(object)adUnit.banner;
			}
		}
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F52]");
		object obj2 = (nint)0 & (nint)1;
		System.Int32Enum? int32Enum;
		if (obj2 != null)
		{
			AdPlace? rewardedAdPlace = googleAdsManager.GetRewardedAdPlace();
			object obj3 = (??)rewardedAdPlace & 1;
			bool flag3 = obj3 == null;
			object obj4 = !flag3;
			int32Enum = (System.Int32Enum?)rewardedAdPlace;
			if (obj4 == null)
			{
				return;
			}
		}
		else
		{
			object obj5 = (nint)0 + (nint)1760;
			_ = 1;
			AdPlace? rewardedAdPlace2 = ((GoogleAdsManager)obj5).GetRewardedAdPlace();
			object obj6 = (??)rewardedAdPlace2 & 1;
			bool flag4 = obj6 == null;
			int32Enum = (System.Int32Enum?)rewardedAdPlace2;
			if (flag4)
			{
				return;
			}
		}
		System.Int32Enum value = int32Enum.Value;
		AdUnitHolder adUnit2 = GetAdUnit((AdPlace)value, AdType.Rewarded);
		((GoogleAdsManager)(object)adUnit2).RequestRewardedVideo(adUnit2);
	}

	private void PreloadRewardedAd()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0091: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F52]");
		object obj2 = (nint)0 & (nint)1;
		System.Int32Enum? int32Enum;
		if (obj2 != null)
		{
			AdPlace? rewardedAdPlace = GetRewardedAdPlace();
			object obj3 = (??)rewardedAdPlace & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			int32Enum = (System.Int32Enum?)rewardedAdPlace;
			if (obj4 == null)
			{
				return;
			}
		}
		else
		{
			object obj5 = (nint)0 + (nint)1760;
			_ = 1;
			AdPlace? rewardedAdPlace2 = ((GoogleAdsManager)obj5).GetRewardedAdPlace();
			object obj6 = (??)rewardedAdPlace2 & 1;
			bool flag2 = obj6 == null;
			int32Enum = (System.Int32Enum?)rewardedAdPlace2;
			if (flag2)
			{
				return;
			}
		}
		System.Int32Enum value = int32Enum.Value;
		AdUnitHolder adUnit = GetAdUnit((AdPlace)value, AdType.Rewarded);
		((GoogleAdsManager)(object)adUnit).RequestRewardedVideo(adUnit);
	}

	private AdPlace? GetRewardedAdPlace()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_022b: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_0259: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0454: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0506: Expected O, but got I4
		//IL_053e: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F53]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0281;
		IL_044e:
		return (AdPlace?)(object)0;
		IL_0514:
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v60+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!MiniGameInfo.StillHaveMovesLeft)
		{
			goto IL_044e;
		}
		goto IL_057d;
		IL_057d:
		return (AdPlace?)new System.Int32Enum?((System.Int32Enum)0);
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00b0;
		}
		goto IL_0281;
		IL_0281:
		_ = 1;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00e5;
		}
		goto IL_02c7;
		IL_00b0:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v27+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00e5;
		}
		goto IL_02c7;
		IL_02c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj2;
		goto IL_00e5;
		IL_00e5:
		object obj15 = typeof(Queue<string>) + 848;
		object obj16 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v27+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v11+18]");
		if ((nint)0 != 6)
		{
			goto IL_044e;
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v49+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User localUser = sessionModel.LocalUser;
			if (SFSKammelnaUserExtensions.IsSubscribed(localUser))
			{
				return (AdPlace?)(object)0;
			}
			obj9 = typeof(MemberAchievementClanFeedData) + 784;
			object obj20 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v55+E4]");
			if ((nint)0 != 0)
			{
				if (!MiniGameInfo.CanPlayMiniGameNow)
				{
					goto IL_0514;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool canPlayMiniGameNow = MiniGameInfo.CanPlayMiniGameNow;
				bool flag7 = !canPlayMiniGameNow;
				object obj21 = !flag7;
				if (obj21 == null)
				{
					goto IL_0514;
				}
			}
			goto IL_057d;
		}
		return (AdPlace?)new NullReferenceException();
	}

	private AdUnitHolder GetAdUnit(AdPlace adPlace, AdType adType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00f2: Expected I, but got O
		//IL_0112: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)adInventory != null)
			{
				Ad ad = adInventory.GetAd(adPlace, adType);
				object obj4 = obj2 + 16;
				obj4 = ad;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = obj4;
				if (obj4 != null)
				{
					object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3656;
					object obj7 = (nint)0 + (nint)2464;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, object> func = default(Func<object, object>);
					func..ctor(obj2, (IntPtr)obj7);
					Dictionary<string, AdUnitHolder> dict = adUnitsHolder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+18]");
					return (AdUnitHolder)DictionaryExtensions.GetOrPut((IDictionary<object, object>)dict, 0, func);
				}
			}
		}
		return (AdUnitHolder)(object)new NullReferenceException();
	}

	private AdUnitHolder GetBannerAdUnit()
	{
		return GetAdUnit(AdPlace.Offline, AdType.Banner);
	}

	private bool IsShowAdWhenReady(AdUnitHolder adUnit)
	{
		//IL_012f: Expected I4, but got O
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected I4, but got Unknown
		if ((nint)adPlaceToShow == 1 && (nint)adTypeToShow == 1)
		{
			if (adUnit != null)
			{
				Ad ad = adUnit.ad;
				if ((object)adUnit.ad != null)
				{
					AdPlace adPlace = ad.AdPlace;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GoogleAdsManager)+70]");
					bool flag = (nint)adPlace != (nint)0;
					bool result = false;
					if (!flag)
					{
						object obj = (??)adPlaceToShow & 1;
						bool flag2 = obj == null;
						result = false;
						if (!flag2)
						{
							AdType adType = ad.AdType;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GoogleAdsManager)+78]");
							object obj2 = (nint)adType - (nint)0;
							bool flag3 = obj2 == null;
							result = (byte)((flag3 & (??)adTypeToShow) ? 1 : 0) != 0;
						}
					}
					return result;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	private void SetShowWhenReady(AdUnitHolder adUnit)
	{
		Ad ad = adUnit.ad;
		System.Int32Enum? int32Enum = (System.Int32Enum)ad.AdPlace;
		adPlaceToShow = (AdPlace?)int32Enum;
		System.Int32Enum? int32Enum2 = (System.Int32Enum)ad.AdType;
		adTypeToShow = (AdType?)int32Enum2;
	}

	private void SetShowWhenReady(AdPlace adPlace, AdType adType)
	{
		System.Int32Enum? int32Enum = (System.Int32Enum)adPlace;
		adPlaceToShow = (AdPlace?)int32Enum;
		System.Int32Enum? int32Enum2 = (System.Int32Enum)adType;
		adTypeToShow = (AdType?)int32Enum2;
	}

	private void ClearShowWhenReady()
	{
		//IL_000b: Expected O, but got I4
		//IL_0016: Expected O, but got I4
		adTypeToShow = (AdType?)(object)0;
		adPlaceToShow = (AdPlace?)(object)0;
	}

	private unsafe void RequestAndShowRewardedVideo(AdUnitHolder adUnit)
	{
		//IL_005f: Expected O, but got Ref
		Ad ad = adUnit.ad;
		System.Int32Enum? int32Enum = (System.Int32Enum)ad.AdPlace;
		adPlaceToShow = (AdPlace?)int32Enum;
		System.Int32Enum? int32Enum2 = (System.Int32Enum?)(adTypeToShow = (AdType?)new System.Int32Enum?((System.Int32Enum)ad.AdType));
		((GoogleAdsManager)(&int32Enum2)).RequestRewardedVideo(adUnit);
	}

	private void RequestRewardedVideo(AdUnitHolder adUnit)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_006e: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0238: Expected O, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0395: Expected O, but got I4
		//IL_02a4: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02ff: Expected O, but got I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0423: Expected O, but got I
		//IL_0434: Expected I, but got O
		//IL_0452: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		AdUnitHolder adUnitHolder = default(AdUnitHolder);
		obj3 = adUnitHolder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		string text2;
		object message3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v12+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v5+24]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v12+38]");
				if ((nint)0 == 1)
				{
					object obj6 = typeof(DataRelation) + 856;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v31+E4]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message = "_InputUv1BufferOffset" + 4056;
					Debug.Log(message);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v12+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v12+20]");
					if (((RewardedAd)0).CanShowAd())
					{
						object obj9 = typeof(DataRelation) + 856;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v27+E4]");
						bool flag2 = (nint)0 == 0;
						object obj11 = !flag2;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object message2 = "___# Content push apply failed [{0}]: {1}" + 696;
						Debug.Log(message2);
						return;
					}
					obj4 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v12+10]");
				object obj12 = 0;
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v13+24]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v13+20]");
				Tracker.AdEvent(AdSDK.Admob, AdAction.Request, (AdType)num, AdPlace.MiniGame);
				object obj16 = obj3;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v17+10]");
				object obj17 = 0;
				object obj18 = typeof(SqlSingle[]) + 2784;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				AdRequest adRequest = default(AdRequest);
				adRequest..ctor();
				object obj19 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 632;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj20 = (nint)0 + (nint)2472;
				Action<object, object> action = default(Action<object, object>);
				action..ctor(obj2, (IntPtr)obj20);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18+18]");
				RewardedAd.Load((string)0, adRequest, action);
				return;
			}
			object obj21 = "_InputUv1BufferOffset" + 4016;
			object obj22 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1384;
			string text = (string)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v5+18]");
			text2 = (string)obj21 + (string)0 + (string)obj22;
			object obj23 = typeof(DataRelation) + 856;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v5+E4]");
			bool flag4 = (nint)0 == 0;
			message3 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v5+18]");
			object obj25 = 0;
			if (!flag4)
			{
				goto IL_0134;
			}
		}
		else
		{
			object format = "_InputUv1BufferOffset" + 4024;
			text2 = string.Format((string)format, (object)null);
			object obj26 = typeof(DataRelation) + 856;
			object obj24 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v5+E4]");
			bool flag5 = (nint)0 == 0;
			object obj27 = !flag5;
			message3 = text2;
			string text = null;
			object obj25 = null;
			if (obj27 != null)
			{
				goto IL_0134;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.LogError(text2);
		return;
		IL_0134:
		Debug.LogError(message3);
	}

	private void RequestAndShowInterstitial(AdUnitHolder adUnit)
	{
		Ad ad = adUnit.ad;
		System.Int32Enum? int32Enum = (System.Int32Enum)ad.AdPlace;
		adPlaceToShow = (AdPlace?)int32Enum;
		System.Int32Enum? int32Enum2 = (System.Int32Enum)ad.AdType;
		adTypeToShow = (AdType?)int32Enum2;
		RequestInterstitial(adUnit);
	}

	private static void RequestInterstitial(AdUnitHolder adUnit)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_02af: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I4
		//IL_01e3: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0325: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_023e: Expected O, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0380: Expected O, but got I
		//IL_0391: Expected I, but got O
		//IL_03af: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = adUnit;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v12+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v2+24]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v12+38]");
			if ((nint)0 == 1)
			{
				object obj6 = typeof(DataRelation) + 856;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "_InputUv1BufferOffset" + 4048;
				Debug.Log(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v12+28]");
			bool flag2 = (nint)0 == 0;
			AdUnitHolder adUnitHolder = adUnit;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v12+28]");
				if (((InterstitialAd)0).CanShowAd())
				{
					object obj9 = typeof(DataRelation) + 856;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v25+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message2 = "___# Content push apply failed [{0}]: {1}" + 944;
					Debug.Log(message2);
					return;
				}
				obj4 = obj3;
				adUnitHolder = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v12+10]");
			object obj12 = 0;
			object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v13+24]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v13+20]");
			Tracker.AdEvent(AdSDK.Admob, AdAction.Request, (AdType)num, AdPlace.MiniGame);
			object obj16 = obj3;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v17+10]");
			object obj17 = 0;
			object obj18 = typeof(SqlSingle[]) + 2784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AdRequest adRequest = default(AdRequest);
			adRequest..ctor();
			object obj19 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)2480;
			Action<object, object> action = default(Action<object, object>);
			action..ctor(obj2, (IntPtr)obj20);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v18+18]");
			InterstitialAd.Load((string)0, adRequest, action);
		}
		else
		{
			object obj21 = "_InputUv1BufferOffset" + 4016;
			object obj22 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v2+18]");
			string message3 = (string)obj21 + (string)0 + (string)obj22;
			object obj23 = typeof(DataRelation) + 856;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v11+E4]");
			if ((nint)0 != 0)
			{
				Debug.LogError(message3);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.LogError(message3);
		}
	}

	private void RequestBannerOnTop()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_019c: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F59]");
		object obj2 = (nint)0 & (nint)1;
		object obj4;
		object obj5 = default(object);
		object obj6;
		if (obj2 != null)
		{
			Rect safeArea = UnityEngine.Device.Screen.safeArea;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj4 = obj5;
			obj6 = obj5;
			if (!flag)
			{
				goto IL_008d;
			}
		}
		else
		{
			_ = 1;
			Rect safeArea2 = UnityEngine.Device.Screen.safeArea;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj4 = obj5;
			obj6 = obj5;
			if (obj7 != null)
			{
				goto IL_008d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((nint)obj6 > 0)
		{
			goto IL_00af;
		}
		goto IL_0184;
		IL_0192:
		IntPtr intPtr = default(IntPtr);
		RequestBanner((Rect)(nint)intPtr);
		return;
		IL_00af:
		Rect safeArea3 = UnityEngine.Device.Screen.safeArea;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		goto IL_0192;
		IL_0184:
		int width = UnityEngine.Device.Screen.width;
		goto IL_0192;
		IL_008d:
		if ((nint)obj4 > 0)
		{
			goto IL_00af;
		}
		goto IL_0184;
	}

	private void RequestBannerWithLatestPosition()
	{
		//IL_000a: Expected O, but got I
		IntPtr intPtr = default(IntPtr);
		RequestBanner((Rect)(nint)intPtr);
	}

	private void RequestBanner(Rect rect)
	{
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03ef: Invalid comparison between F4 and I4
		//IL_042f: Invalid comparison between F4 and I4
		//IL_00cd: Expected F4, but got I8
		//IL_0453: Expected O, but got F4
		//IL_046d: Expected O, but got I4
		//IL_00ec: Expected F4, but got I8
		//IL_01ee: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_027b: Invalid comparison between F4 and I4
		//IL_048b: Expected O, but got I
		//IL_02ac: Expected I4, but got F4
		//IL_029f: Expected I4, but got I8
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02ff: Expected I4, but got F4
		//IL_02ff: Expected I4, but got F4
		//IL_0307: Expected I4, but got F4
		//IL_030f: Expected I4, but got F4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		AdUnitHolder adUnit = GetAdUnit(AdPlace.Offline, AdType.Banner);
		if (adUnit != null && adUnit.banner != null)
		{
			adUnit.banner.Destroy();
		}
		AdUnitHolder adUnit2 = GetAdUnit(AdPlace.Offline, AdType.Banner);
		Rect rect2 = default(Rect);
		bannerPosition = rect2;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		Rect rect3 = rect2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect3 = bannerPosition;
		}
		object obj4 = typeof(SqlSingle[]) + 2800;
		float deviceScale = MobileAds.Utils.GetDeviceScale();
		float num = (float)rect3 / deviceScale;
		float num2 = ((num != 2.139095E+09f) ? num : 2.1474836E+09f);
		float deviceScale2 = MobileAds.Utils.GetDeviceScale();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GoogleAdsManager)+5C]");
		float num3 = 0f / deviceScale2;
		float num4 = ((num3 != 2.139095E+09f) ? num3 : 2.1474836E+09f);
		object obj5 = num2 | num4;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		BannerView bannerAd;
		if (obj6 == null)
		{
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v32+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v32+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v16+30]");
			AdSize currentOrientationAnchoredAdaptiveBannerAdSizeWithWidth = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(0);
			Ad ad = adUnit2.ad;
			object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			BannerView bannerView = default(BannerView);
			bannerView..ctor(ad.AdId, currentOrientationAnchoredAdaptiveBannerAdSizeWithWidth, AdPosition.Top);
			int num5 = 0;
			int num6 = 0;
			AdSize adSize = currentOrientationAnchoredAdaptiveBannerAdSizeWithWidth;
			bannerAd = bannerView;
		}
		else
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float deviceScale3 = MobileAds.Utils.GetDeviceScale();
			object obj13 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GoogleAdsManager)+60]");
			num3 = 0f / deviceScale3;
			int width = (int)((num3 != 2.139095E+09f) ? ((int)num3) : 2147483648L);
			AdSize currentOrientationAnchoredAdaptiveBannerAdSizeWithWidth2 = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(width);
			Ad ad2 = adUnit2.ad;
			object obj15 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			BannerView bannerView2 = default(BannerView);
			bannerView2..ctor(ad2.AdId, currentOrientationAnchoredAdaptiveBannerAdSizeWithWidth2, (int)num2, (int)num4);
			int num5 = (int)num4;
			int num6 = (int)num2;
			AdSize adSize = currentOrientationAnchoredAdaptiveBannerAdSizeWithWidth2;
			bannerAd = bannerView2;
		}
		object obj16 = typeof(SqlSingle[]) + 2784;
		adUnit2.SetBannerAd(bannerAd);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AdRequest adRequest = default(AdRequest);
		adRequest..ctor();
		adUnit2.banner.LoadAd(adRequest);
	}

	private void DestroyBannerView()
	{
		AdUnitHolder adUnit = GetAdUnit(AdPlace.Offline, AdType.Banner);
		if (adUnit != null && adUnit.banner != null)
		{
			adUnit.banner.Destroy();
		}
	}

	private void AdLoaded(AdUnitHolder adUnit)
	{
		//IL_00ca: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0299: Expected O, but got I
		if (!IsShowAdWhenReady(adUnit))
		{
			return;
		}
		Action<AdType, AdPlace, bool> onAdLoaded = this.OnAdLoaded;
		object obj;
		nint num;
		bool flag4;
		AdUnitHolder adUnitHolder2;
		IntPtr intPtr = default(IntPtr);
		object obj2 = default(object);
		bool flag6 = default(bool);
		AdUnitHolder adUnitHolder;
		if (this.OnAdLoaded != null)
		{
			bool flag = adUnit == null;
			adUnitHolder = adUnit;
			if (!flag)
			{
				Ad ad = adUnit.ad;
				bool flag2 = (object)adUnit.ad == null;
				adUnitHolder = adUnit;
				if (!flag2)
				{
					bool flag3 = IsShowAdWhenReady(adUnit);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X23_v2 (System.Action`3<AdType, AdPlace, System.Boolean>)+28]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ X23_v2 (System.Action`3<AdType, AdPlace, System.Boolean>)+18] (should have been resolved before IL gen)");
					num = (nint)ad.AdPlace;
					flag4 = flag3;
					adUnitHolder2 = (AdUnitHolder)ad.AdType;
					goto IL_0141;
				}
			}
		}
		else
		{
			bool flag5 = adUnit == null;
			num = intPtr;
			obj = obj2;
			flag4 = flag6;
			adUnitHolder2 = adUnit;
			adUnitHolder = adUnit;
			if (!flag5)
			{
				goto IL_0141;
			}
		}
		goto IL_024c;
		IL_0141:
		Ad ad2 = adUnit.ad;
		bool flag7 = (object)adUnit.ad == null;
		intPtr = num;
		obj2 = obj;
		flag6 = flag4;
		adUnitHolder = adUnitHolder2;
		if (!flag7)
		{
			if (ad2.AdType != AdType.Banner)
			{
				if (ad2.AdType != AdType.Interstitial)
				{
					bool flag8 = ad2.AdType == AdType.Rewarded;
					object obj3 = !flag8;
					intPtr = num;
					obj2 = obj;
					flag6 = flag4;
					adUnitHolder = adUnitHolder2;
					if (obj3 != null)
					{
						object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
						ex..ctor();
						object obj5 = (nint)0 + (nint)3480;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						throw new OutOfMemoryException();
					}
					ShowRewardedAd(ad2.AdPlace);
				}
				else
				{
					ShowInterstitialAd(ad2.AdPlace);
				}
			}
			else
			{
				AdOpened(adUnit);
			}
			return;
		}
		goto IL_024c;
		IL_024c:
		throw new NullReferenceException();
	}

	private void AdFailedToLoad(AdUnitHolder adUnit, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0290: Expected O, but got I
		//IL_02a1: Expected I, but got O
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0374: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_0216: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_0246: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = adUnit;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AdUnitHolder adUnitHolder = (AdUnitHolder)obj3;
		if (!IsShowAdWhenReady((AdUnitHolder)obj3))
		{
			return;
		}
		Action<AdType, AdPlace, string> onAdError = this.OnAdError;
		bool flag = this.OnAdError == null;
		string text = error;
		if (!flag)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v8+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v9+20]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v9+24]");
			adUnitHolder = (AdUnitHolder)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X8_v5 (System.Action`3<AdType, AdPlace, System.String>)+18] (should have been resolved before IL gen)");
		}
		object obj7 = this + 104;
		if ((nint)obj7 > 2)
		{
			obj7 = 0;
			_ = 0;
			_ = 0;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v15+10]");
			object obj9 = 0;
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v16+24]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v16+20]");
				Tracker.AdEvent(AdSDK.Admob, AdAction.FailedToLoad3Times, (AdType)num, AdPlace.MiniGame);
				Action<AdType, AdPlace, string> onAdFailedToLoad3Times = this.OnAdFailedToLoad3Times;
				if (this.OnAdFailedToLoad3Times == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v16+24]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v16+20]");
				Tracker.AdEvent(AdSDK.Admob, AdAction.FailedToLoad3Times, (AdType)num2, AdPlace.MiniGame);
				Action<AdType, AdPlace, string> onAdFailedToLoad3Times = this.OnAdFailedToLoad3Times;
				bool flag2 = this.OnAdFailedToLoad3Times == null;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					return;
				}
			}
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v6+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v7+20]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v7+24]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v21 (System.Action`3<AdType, AdPlace, System.String>)+18]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v21 (System.Action`3<AdType, AdPlace, System.String>)+40]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v21 (System.Action`3<AdType, AdPlace, System.String>)+28]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v175 @ X5_v1 (should have been resolved before IL gen)");
		}
		object obj20 = obj7 + 1;
		obj7 = obj20;
		object obj21 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)2488;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj22);
		object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj25 = !flag3;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	private void AdOpened(AdUnitHolder adUnit)
	{
		//IL_000b: Expected O, but got I4
		//IL_0016: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_018b: Expected O, but got I4
		adTypeToShow = (AdType?)(object)0;
		adPlaceToShow = (AdPlace?)(object)0;
		Action<AdType, AdPlace> onAdStart = this.OnAdStart;
		if (this.OnAdStart != null)
		{
			Ad ad = adUnit.ad;
			AdUnitHolder adUnitHolder = (AdUnitHolder)ad.AdType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ X8_v1 (System.Action`2<AdType, AdPlace>)+18] (should have been resolved before IL gen)");
		}
		else
		{
			AdUnitHolder adUnitHolder = adUnit;
		}
		Ad ad2 = adUnit.ad;
		if (ad2.AdType == AdType.Banner)
		{
			return;
		}
		adFailedToLoadCount = 0;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F80]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_012d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_012d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.IOS)
		{
			return;
		}
		goto IL_0156;
		IL_0156:
		object obj5 = typeof(System.IOAsyncCallback) + 2392;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v13+B8]");
		object obj7 = 0;
		obj7 = 1;
		return;
		IL_012d:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.IOS)
		{
			goto IL_0156;
		}
	}

	private void AdClosed(AdUnitHolder adUnit)
	{
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_020b: Expected I, but got O
		//IL_0235: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_0180: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_010c: Expected O, but got I
		Ad ad = adUnit.ad;
		bool flag = ad.AdType != AdType.Interstitial;
		AdUnitHolder adUnitHolder = adUnit;
		if (!flag)
		{
			object obj = typeof(RegisteredWaitHandle) + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Reward reward = default(Reward);
			reward..ctor();
			object obj2 = "Index = {0} position = {1}" + 1816;
			adUnitHolder = (AdUnitHolder)obj2;
			object obj3 = reward + 16;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action<AdType, AdPlace> onAdComplete = this.OnAdComplete;
			if (this.OnAdComplete != null)
			{
				Ad ad2 = adUnit.ad;
				nint num = (nint)ad2.AdPlace;
				adUnitHolder = (AdUnitHolder)ad2.AdType;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v15 (System.Action`2<AdType, AdPlace>)+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X8_v15 (System.Action`2<AdType, AdPlace>)+18] (should have been resolved before IL gen)");
			}
			IdfaPermission.AdCompleted();
		}
		Action<AdType, AdPlace> onAdClosed = this.OnAdClosed;
		if (this.OnAdClosed != null)
		{
			Ad ad3 = adUnit.ad;
			nint num = (nint)ad3.AdPlace;
			adUnitHolder = (AdUnitHolder)ad3.AdType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7 (System.Action`2<AdType, AdPlace>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X8_v7 (System.Action`2<AdType, AdPlace>)+18] (should have been resolved before IL gen)");
		}
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3496;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void UserEarnedReward(AdUnitHolder adUnit, Reward reward)
	{
		Action<AdType, AdPlace> onAdComplete = this.OnAdComplete;
		if (this.OnAdComplete != null)
		{
			Ad ad = adUnit.ad;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ X8_v1 (System.Action`2<AdType, AdPlace>)+18] (should have been resolved before IL gen)");
		}
		IdfaPermission.AdCompleted();
	}

	private void AdImpressionRecorded(AdUnitHolder adUnit)
	{
	}

	private void PaidEvent(AdUnitHolder adUnit, AdValue adValue)
	{
	}

	private void AdClickedEvent(AdUnitHolder adUnit)
	{
	}

	public void ShowRewardedAd(AdPlace adPlace)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2496;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		IdfaPermission.Check(action);
	}

	public void ShowInterstitialAd(AdPlace adPlace)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2504;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		IdfaPermission.Check(action);
	}

	public void ShowBannerAd(Rect rect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008a: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2512;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		IdfaPermission.Check(action);
	}

	public void ShowBannerAdOnTop()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		IdfaPermission.Check(action);
	}

	public float GetBannerHeight()
	{
		//IL_0058: Expected F4, but got I4
		AdUnitHolder adUnit = GetAdUnit(AdPlace.Offline, AdType.Banner);
		if (adUnit.banner != null)
		{
			return adUnit.banner.GetHeightInPixels();
		}
		return 0f;
	}

	public GoogleAdsManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = this + 80;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <ShowBannerAdOnTop>b__55_0()
	{
		AdUnitHolder adUnit = GetAdUnit(AdPlace.Offline, AdType.Banner);
		SetShowWhenReady(adUnit);
		RequestBannerOnTop();
	}
}
