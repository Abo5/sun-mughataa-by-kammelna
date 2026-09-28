using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UI.Popups;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class MassStageProgressPopup : MonoBehaviour
{
	private static class Messages
	{
		public const string WonDescription = "STAGE_WON_DESCRIPTION";

		public const string FailedDescription = "STAGE_LOST_DESCRIPTION";

		public const string ReservedDescription = "STAGE_RESERVED_DESCRIPTION";
	}

	private sealed class <>c__DisplayClass15_0
	{
		public MassEventStageResultFeedData feedData;

		internal void <Show>b__0(MassStageProgressPopup progressPopup)
		{
			MassEventStageResultFeedData massEventStageResultFeedData = feedData;
			progressPopup.Populate(massEventStageResultFeedData.<EventId>k__BackingField, massEventStageResultFeedData.<StageId>k__BackingField, massEventStageResultFeedData.<Rank>k__BackingField, massEventStageResultFeedData.<Points>k__BackingField, massEventStageResultFeedData.<Status>k__BackingField);
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public MassStageProgressPopup <>4__this;

		public int rank;

		public int points;

		public MassEventNextStageEligibility eligibilityStatus;

		public int stageId;

		public Action <>9__1;

		internal void <Populate>b__0(MassEventModel model)
		{
			//IL_0010: Expected O, but got I
			//IL_00d2: Expected I, but got O
			//IL_00f4: Expected O, but got I
			//IL_015b: Expected O, but got I4
			//IL_01b1: Expected O, but got I4
			//IL_0704: Expected I, but got O
			//IL_070d: Expected O, but got I4
			//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd6: Expected O, but got Unknown
			//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c03: Expected O, but got Unknown
			//IL_0725: Unknown result type (might be due to invalid IL or missing references)
			//IL_072a: Expected O, but got Unknown
			//IL_0741: Expected O, but got I
			//IL_043b: Expected I, but got O
			//IL_0444: Expected O, but got I4
			//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2b: Expected O, but got Unknown
			//IL_0c58: Expected O, but got I
			//IL_046b: Expected I, but got O
			//IL_0474: Expected O, but got I4
			//IL_025b: Expected I, but got O
			//IL_0264: Expected O, but got I4
			//IL_0810: Unknown result type (might be due to invalid IL or missing references)
			//IL_0815: Expected O, but got Unknown
			//IL_0820: Unknown result type (might be due to invalid IL or missing references)
			//IL_0825: Expected O, but got Unknown
			//IL_0830: Unknown result type (might be due to invalid IL or missing references)
			//IL_0835: Expected O, but got Unknown
			//IL_0840: Unknown result type (might be due to invalid IL or missing references)
			//IL_0845: Expected O, but got Unknown
			//IL_04a8: Expected I, but got O
			//IL_0c9d: Expected F8, but got O
			//IL_0cad: Expected F4, but got O
			//IL_0cc5: Expected O, but got I
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected O, but got Unknown
			//IL_02a6: Expected O, but got I
			//IL_04e9: Expected I, but got O
			//IL_04f2: Expected O, but got I4
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected O, but got Unknown
			//IL_0d10: Expected O, but got I
			//IL_0d18: Expected F4, but got O
			//IL_0d28: Expected O, but got I
			//IL_0d44: Expected F4, but got O
			//IL_0d44: Expected O, but got I4
			//IL_0d54: Expected O, but got I
			//IL_0d89: Expected I, but got O
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected O, but got Unknown
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Expected O, but got Unknown
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_08da: Expected I4, but got O
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Expected O, but got Unknown
			//IL_054d: Expected O, but got I
			//IL_0929: Expected O, but got I4
			//IL_098a: Expected I4, but got O
			//IL_0620: Unknown result type (might be due to invalid IL or missing references)
			//IL_0625: Expected O, but got Unknown
			//IL_0630: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Expected O, but got Unknown
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Expected O, but got Unknown
			//IL_0650: Unknown result type (might be due to invalid IL or missing references)
			//IL_0655: Expected O, but got Unknown
			//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5c: Expected O, but got Unknown
			//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a79: Expected O, but got Unknown
			//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b02: Expected O, but got Unknown
			//IL_0b18: Expected O, but got I
			//IL_0b20: Expected I, but got O
			//IL_0b2e: Expected I, but got O
			//IL_0b71: Expected O, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E604A]");
			MassStageProgressPopup massStageProgressPopup = (MassStageProgressPopup)0;
			bool flag = (object)<>4__this == null;
			MassEventModel massEventModel = model;
			int num3;
			Graphic playerRankingBackground;
			object obj10;
			object obj11;
			object obj12;
			double num6;
			object obj16;
			float num5;
			if (!flag)
			{
				<>4__this.Clear();
				massStageProgressPopup = <>4__this;
				bool flag2 = (object)<>4__this == null;
				massEventModel = model;
				if (!flag2)
				{
					bool flag3 = model == null;
					massEventModel = model;
					if (!flag3)
					{
						IThemeColorProfile themeColorProfile = model.GenerateTheme();
						bool flag4 = (object)massStageProgressPopup.themeProvider == null;
						massEventModel = null;
						if (!flag4)
						{
							massStageProgressPopup.themeProvider.UpdateTheme(themeColorProfile);
							bool flag5 = (object)<>4__this == null;
							nint num = unchecked((nint)null);
							massEventModel = (MassEventModel)themeColorProfile;
							if (!flag5)
							{
								object obj = (nint)0 + (nint)1712;
								<>4__this.SetRankStrip(rank, points);
								massEventModel = (MassEventModel)obj;
								object obj2 = Enumerable.Last((IEnumerable<object>)model.<Stages>k__BackingField);
								bool flag6 = obj2 == null;
								num = points;
								if (!flag6)
								{
									massStageProgressPopup = (MassStageProgressPopup)eligibilityStatus;
									if (eligibilityStatus != MassEventNextStageEligibility.EligibleToReserve)
									{
										if ((nint)massStageProgressPopup != 1)
										{
											bool flag7 = (object)massStageProgressPopup == null;
											object obj3 = !flag7;
											num = points;
											if (obj3 != null)
											{
												object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3744;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
												object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj6 = "destinationTimeZone" + 1848;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
												ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
												string paramName = default(string);
												object actualValue = default(object);
												ex..ctor(paramName, actualValue, null);
												object obj7 = (nint)0 + (nint)808;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
												throw new OutOfMemoryException();
											}
											massStageProgressPopup = <>4__this;
											bool flag8 = (object)<>4__this == null;
											num = points;
											if (!flag8)
											{
												bool flag9 = (object)massStageProgressPopup.failedTitle == null;
												num = points;
												if (!flag9)
												{
													int num2 = stageId;
													massStageProgressPopup.failedTitle.SetActive(value: true);
													bool flag10 = (object)<>4__this == null;
													num = unchecked((nint)null);
													massEventModel = (MassEventModel)1;
													if (!flag10)
													{
														num3 = stageId + 1;
														massStageProgressPopup = (MassStageProgressPopup)(object)("SERVICE_DISABLED" + 640);
														int num4 = num3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v28 (System.Object)+10]");
														object obj8 = (nint)num4 - (nint)0;
														bool flag11 = obj8 == null;
														<>4__this.SetDescription((string)(object)massStageProgressPopup, num3, flag11);
														MassStageProgressPopup massStageProgressPopup2 = <>4__this;
														bool flag12 = (object)<>4__this == null;
														bool flag13 = flag11;
														num = num3;
														massEventModel = (MassEventModel)(object)massStageProgressPopup;
														if (!flag12)
														{
															playerRankingBackground = massStageProgressPopup2.playerRankingBackground;
															bool flag14 = (object)massStageProgressPopup2.playerRankingBackground == null;
															flag13 = flag11;
															num = num3;
															massEventModel = (MassEventModel)(object)massStageProgressPopup;
															if (!flag14)
															{
																object obj9 = <>4__this + 124;
																obj10 = <>4__this + 120;
																obj11 = <>4__this + 116;
																obj12 = <>4__this + 112;
																flag13 = flag11;
																num = num3;
																goto IL_0c95;
															}
														}
													}
												}
											}
										}
										else
										{
											massStageProgressPopup = <>4__this;
											bool flag15 = (object)<>4__this == null;
											num = points;
											if (!flag15)
											{
												bool flag16 = (object)massStageProgressPopup.wonTitle == null;
												num = points;
												if (!flag16)
												{
													massStageProgressPopup.wonTitle.SetActive(value: true);
													massStageProgressPopup = <>4__this;
													bool flag17 = (object)<>4__this == null;
													num = unchecked((nint)null);
													massEventModel = (MassEventModel)1;
													if (!flag17)
													{
														bool flag18 = (object)massStageProgressPopup.wonAnimationRect == null;
														num = unchecked((nint)null);
														massEventModel = (MassEventModel)1;
														if (!flag18)
														{
															GameObject gameObject = massStageProgressPopup.wonAnimationRect.gameObject;
															bool flag19 = (object)gameObject == null;
															num = unchecked((nint)null);
															massEventModel = null;
															if (!flag19)
															{
																gameObject.SetActive(value: true);
																massStageProgressPopup = <>4__this;
																bool flag20 = (object)<>4__this == null;
																num = unchecked((nint)null);
																massEventModel = (MassEventModel)1;
																if (!flag20)
																{
																	object obj13 = typeof(UsageHint) + 744;
																	object obj14 = obj13;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v33+B8]");
																	object obj15 = 0;
																	num5 = (float)obj15;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v34+4]");
																	obj16 = 0;
																	TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(massStageProgressPopup.wonAnimationRect, (Vector2)0, (float)obj15);
																	massStageProgressPopup = (MassStageProgressPopup)((nint)0 + (nint)2432);
																	massEventModel = (MassEventModel)(object)massStageProgressPopup;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
																	bool flag21 = (object)<>4__this == null;
																	num6 = 1.0;
																	num = unchecked((nint)null);
																	if (!flag21)
																	{
																		int num2 = stageId + 1;
																		massStageProgressPopup = (MassStageProgressPopup)(object)("SERVICE_DISABLED" + 656);
																		int num7 = num2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v28 (System.Object)+10]");
																		object obj17 = (nint)num7 - (nint)0;
																		bool flag22 = obj17 == null;
																		<>4__this.SetDescription((string)(object)massStageProgressPopup, num2, flag22);
																		MassStageProgressPopup massStageProgressPopup3 = <>4__this;
																		bool flag23 = (object)<>4__this == null;
																		num6 = 1.0;
																		bool flag13 = flag22;
																		num = num2;
																		massEventModel = (MassEventModel)(object)massStageProgressPopup;
																		if (!flag23)
																		{
																			playerRankingBackground = massStageProgressPopup3.playerRankingBackground;
																			bool flag24 = (object)massStageProgressPopup3.playerRankingBackground == null;
																			num6 = 1.0;
																			flag13 = flag22;
																			num = num2;
																			massEventModel = (MassEventModel)(object)massStageProgressPopup;
																			if (!flag24)
																			{
																				object obj9 = <>4__this + 108;
																				obj10 = <>4__this + 104;
																				obj11 = <>4__this + 100;
																				obj12 = <>4__this + 96;
																				flag13 = flag22;
																				num3 = num2;
																				num = num2;
																				goto IL_0c95;
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
									else
									{
										massStageProgressPopup = <>4__this;
										bool flag25 = (object)<>4__this == null;
										num = points;
										if (!flag25)
										{
											bool flag26 = (object)massStageProgressPopup.reservedTitle == null;
											num = points;
											if (!flag26)
											{
												int num2 = stageId;
												massStageProgressPopup.reservedTitle.SetActive(value: true);
												bool flag27 = (object)<>4__this == null;
												num = unchecked((nint)null);
												massEventModel = (MassEventModel)1;
												if (!flag27)
												{
													massStageProgressPopup = (MassStageProgressPopup)(object)("SERVICE_DISABLED" + 648);
													int num8 = stageId;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v28 (System.Object)+10]");
													object obj18 = (nint)num8 - (nint)0;
													bool flag28 = obj18 == null;
													<>4__this.SetDescription((string)(object)massStageProgressPopup, stageId, flag28);
													MassStageProgressPopup massStageProgressPopup4 = <>4__this;
													bool flag29 = (object)<>4__this == null;
													bool flag13 = flag28;
													num = stageId;
													massEventModel = (MassEventModel)(object)massStageProgressPopup;
													if (!flag29)
													{
														playerRankingBackground = massStageProgressPopup4.playerRankingBackground;
														bool flag30 = (object)massStageProgressPopup4.playerRankingBackground == null;
														flag13 = flag28;
														num = stageId;
														massEventModel = (MassEventModel)(object)massStageProgressPopup;
														if (!flag30)
														{
															num3 = stageId + 1;
															object obj9 = <>4__this + 140;
															obj10 = <>4__this + 136;
															obj11 = <>4__this + 132;
															obj12 = <>4__this + 128;
															flag13 = flag28;
															num = stageId;
															goto IL_0c95;
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
			goto IL_0bb7;
			IL_0bb7:
			throw new NullReferenceException();
			IL_0ae0:
			GameObject gameObject2;
			Action action;
			PopupStack.Push(gameObject2, action);
			return;
			IL_0c95:
			num6 = (double)obj10;
			obj16 = obj11;
			num5 = (float)obj12;
			massStageProgressPopup = (MassStageProgressPopup)(object)playerRankingBackground;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v3 (MassStageProgressPopup)+2B0]");
			massEventModel = (MassEventModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v3 (MassStageProgressPopup)+2A8] (should have been resolved before IL gen)");
			MassStageProgressPopup massStageProgressPopup5 = <>4__this;
			if ((object)<>4__this != null)
			{
				massStageProgressPopup = (MassStageProgressPopup)(object)model.<Stages>k__BackingField;
				if (model.<Stages>k__BackingField != null)
				{
					MassStagesProgressIndicator progressIndicator = massStageProgressPopup5.progressIndicator;
					if ((object)massStageProgressPopup5.progressIndicator != null)
					{
						massStageProgressPopup5.progressIndicator.Clear();
						progressIndicator._numberOfStages = (int)((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource;
						massStageProgressPopup = (MassStageProgressPopup)(object)progressIndicator._massEventStagesStatus;
						if (progressIndicator._massEventStagesStatus != null)
						{
							((UnityEngine.Object)massStageProgressPopup).m_CachedPtr = (IntPtr)num3;
							((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource = (CancellationTokenSource)1;
							_ = eligibilityStatus;
							if ((nint)((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource >= 1)
							{
								int num9 = 0;
								do
								{
									num9++;
									massStageProgressPopup5.progressIndicator.CreateNewStageMark(num9);
								}
								while (num9 < progressIndicator._numberOfStages);
							}
							massStageProgressPopup5.progressIndicator.FillStageStatus();
							massStageProgressPopup5.progressIndicator.CreateStageConnectors((int)((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource, num3);
							massStageProgressPopup = <>4__this;
							bool flag31 = (object)<>4__this == null;
							nint num = num3;
							massEventModel = (MassEventModel)(object)((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource;
							if (!flag31)
							{
								massStageProgressPopup = (MassStageProgressPopup)(object)massStageProgressPopup.popup;
								bool flag32 = (object)massStageProgressPopup.popup == null;
								num = num3;
								massEventModel = (MassEventModel)(object)((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource;
								if (!flag32)
								{
									bool flag33 = (object)massStageProgressPopup.themeProvider == null;
									num = num3;
									massEventModel = (MassEventModel)(object)((MonoBehaviour)massStageProgressPopup).m_CancellationTokenSource;
									if (!flag33)
									{
										object obj19 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
										gameObject2 = massStageProgressPopup.themeProvider.gameObject;
										object obj20 = this + 40;
										action = (Action)obj20;
										Action action3;
										if (obj20 != null)
										{
											object obj21 = obj19;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v37+E4]");
											bool flag34 = (nint)0 == 0;
											nint num10 = num3;
											Action action2 = null;
											action3 = action;
											if (!flag34)
											{
												goto IL_0ae0;
											}
										}
										else
										{
											object obj22 = typeof(SqlSingle[]) + 2376;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj23 = (nint)0 + (nint)816;
											nint num10 = (nint)obj23;
											Action action4 = default(Action);
											action4..ctor(this, (IntPtr)obj23);
											<>9__1 = action4;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj21 = obj19;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v37+E4]");
											bool flag35 = (nint)0 == 0;
											object obj24 = !flag35;
											action = action4;
											bool flag13 = false;
											Action action2 = action4;
											action3 = action4;
											if (obj24 != null)
											{
												goto IL_0ae0;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										action = action3;
										goto IL_0ae0;
									}
								}
							}
						}
					}
				}
			}
			goto IL_0bb7;
		}

		internal void <Populate>b__1()
		{
			MassStageProgressPopup massStageProgressPopup = <>4__this;
			massStageProgressPopup.popup.PopFromCenter();
		}
	}

	private static readonly AddressReference<MassStageProgressPopup> Address;

	private PopupUI popup;

	private ThemeProvider themeProvider;

	private GameObject wonTitle;

	private GameObject failedTitle;

	private GameObject reservedTitle;

	private RectTransform wonAnimationRect;

	private NormalPlaceItem playerRankingStrip;

	private Graphic playerRankingBackground;

	private Color wonColor;

	private Color failedColor;

	private Color reservedColor;

	private TextMeshProUGUI descriptionText;

	private MassStagesProgressIndicator progressIndicator;

	public static void Show(MassEventStageResultFeedData feedData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3784;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2632;
		object obj5 = (nint)0 + (nint)800;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = feedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)2120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Populate(long massId, int stageId, int rank, int points, MassEventNextStageEligibility eligibilityStatus)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008a: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj4 = (nint)0 + (nint)808;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		MassTournamentManager.GetMassEvent(massId, action);
	}

	private void SetRankStrip(int rank, int points)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6047]");
		object obj3 = (nint)0 & (nint)1;
		NormalPlaceItem normalPlaceItem;
		NormalPlaceItem normalPlaceItem2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			normalPlaceItem = playerRankingStrip;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			normalPlaceItem2 = playerRankingStrip;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			normalPlaceItem = playerRankingStrip;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			normalPlaceItem2 = playerRankingStrip;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		normalPlaceItem = normalPlaceItem2;
		goto IL_0168;
		IL_0168:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LeaderBoardPlayer leaderBoardPlayer = default(LeaderBoardPlayer);
		leaderBoardPlayer..ctor(localUser);
		leaderBoardPlayer.LastPoints = points;
		leaderBoardPlayer.LastRank = rank;
		normalPlaceItem.Populate(leaderBoardPlayer);
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0168;
	}

	private void SetDescription(string description, int playerLastStageReached, bool isFinals)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004a: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_01a7: Expected I, but got O
		//IL_01b7: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj4 = obj;
		string content;
		if (isFinals)
		{
			object key = "fetch_products" + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			content = LocalizationText.GetText((string)key);
			object obj6 = 0;
		}
		else
		{
			object key2 = "Network Authentication Required" + 3304;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int n = playerLastStageReached + 1;
			content = LocalizationText.GetOrdinalText((string)key2, n);
			object obj6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = StringUtil.NoBreak(content);
		object[] array = default(object[]);
		object obj10;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj11;
		if (array != null)
		{
			bool flag4 = text == null;
			obj10 = 0;
			if (!flag4)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj11 = 0;
				if (flag5)
				{
					goto IL_0273;
				}
			}
			if (array.Length != 0)
			{
				object obj12 = array + 32;
				obj12 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(descriptionText, description, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj10 = 0;
		}
		ex = new IndexOutOfRangeException();
		obj11 = obj10;
		goto IL_0273;
		IL_0273:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void Clear()
	{
		wonTitle.SetActive(value: false);
		failedTitle.SetActive(value: false);
		reservedTitle.SetActive(value: false);
		GameObject gameObject = wonAnimationRect.gameObject;
		gameObject.SetActive(value: false);
		int num = ShortcutExtensions.DOKill(wonAnimationRect, complete: true);
	}

	static MassStageProgressPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "LAK" + 3888;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3056;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
