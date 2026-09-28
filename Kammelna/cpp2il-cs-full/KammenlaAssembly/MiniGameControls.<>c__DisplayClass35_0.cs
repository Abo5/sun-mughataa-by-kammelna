using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MiniGameControls : MonoBehaviour
{
	private sealed class <>c__DisplayClass35_0
	{
		public MiniGameControls <>4__this;

		public int rewardValue;

		public GameObject rewardUi;

		public TweenCallback <>9__2;

		internal void <AnimateReward>b__0()
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_004b: Expected O, but got I
			//IL_0057: Expected O, but got I
			//IL_00a0: Expected O, but got I4
			//IL_016c: Expected O, but got I
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_011a: Expected O, but got I
			//IL_0128: Expected I, but got O
			MiniGameControls miniGameControls = <>4__this;
			int num = ShortcutExtensions.DOKill(miniGameControls.prizeText);
			MiniGameControls miniGameControls2 = <>4__this;
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = (nint)0 + (nint)2944;
			object obj3 = (nint)0 + (nint)2800;
			string text = miniGameControls2.prizeText.text;
			int num2 = int.Parse(text);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)2528;
			int endValue = rewardValue + num2;
			Tweener tweener = AnimationExtensions.DONumber(miniGameControls2.prizeText, endValue, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			object obj7 = this + 40;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				return;
			}
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)1744;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj9);
			<>9__2 = tweenCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}

		internal void <AnimateReward>b__2()
		{
			MiniGameControls miniGameControls = <>4__this;
			MiniGame miniGame = miniGameControls.miniGame;
			int totalReward = miniGame.<State>k__BackingField.TotalReward;
			TextMeshProExtensions.SetNumber(miniGameControls.prizeText, totalReward);
		}

		internal void <AnimateReward>b__1()
		{
			Transform transform = rewardUi.transform;
			Transform transform2 = <>4__this.transform;
			Transform parent = transform2.parent;
			transform.SetParent(parent);
			Transform transform3 = rewardUi.transform;
			transform3.SetAsLastSibling();
		}
	}

	private RectTransform welcomeMessage;

	private Button playNowButton;

	private Button claimButton;

	private Button discardButton;

	private Button watchButton;

	private Button discardActionButton;

	private Button playAgainButton;

	private Button exitButton;

	private CanvasGroup infoGroup;

	private ElegantLoadingIndicator loader;

	private DiscreteProgressIndicator remainingHearts;

	private DiscreteProgressIndicator discardCardsCount;

	private GameObject discardCountParent;

	private Button claimPanelButton;

	private TextMeshProUGUI prizeText;

	private TextMeshProUGUI ownedAcesText;

	private MiniGame miniGame;

	private Button[] allButtons;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a58: Expected O, but got I
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0a78: Expected O, but got I
		//IL_0aa2: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0066: Expected I, but got O
		//IL_0074: Expected I, but got O
		//IL_0091: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00e8: Expected I, but got O
		//IL_00f6: Expected I, but got O
		//IL_0110: Expected O, but got I4
		//IL_012f: Expected O, but got I
		//IL_0155: Expected I, but got O
		//IL_0163: Expected I, but got O
		//IL_017d: Expected O, but got I4
		//IL_019c: Expected O, but got I
		//IL_01c2: Expected I, but got O
		//IL_01d0: Expected I, but got O
		//IL_01ea: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_022f: Expected I, but got O
		//IL_023d: Expected I, but got O
		//IL_0257: Expected O, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_0a12: Expected O, but got I4
		//IL_0314: Expected O, but got I
		//IL_0336: Expected O, but got I4
		//IL_034f: Expected O, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0448: Expected O, but got I8
		//IL_03e5: Expected O, but got I
		//IL_0407: Expected O, but got I4
		//IL_0420: Expected O, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0533: Expected O, but got I4
		//IL_0549: Expected O, but got I
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_04c8: Expected O, but got I
		//IL_04ea: Expected O, but got I4
		//IL_0503: Expected O, but got I
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_0642: Expected O, but got I8
		//IL_05df: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_061a: Expected O, but got I
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_072d: Expected O, but got I4
		//IL_0743: Expected O, but got I
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_06c2: Expected O, but got I
		//IL_06e4: Expected O, but got I4
		//IL_06fd: Expected O, but got I
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_0844: Expected O, but got I4
		//IL_085a: Expected O, but got I
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_07d9: Expected O, but got I
		//IL_07fb: Expected O, but got I4
		//IL_0814: Expected O, but got I
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected O, but got Unknown
		//IL_095b: Expected O, but got I4
		//IL_0971: Expected O, but got I
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		//IL_08f0: Expected O, but got I
		//IL_0912: Expected O, but got I4
		//IL_092b: Expected O, but got I
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)184;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2576;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 160;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj4;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		bool flag2 = obj7 == null;
		object obj9 = 0;
		object obj10 = this;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag2)
		{
			object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj12 = (nint)0 + (nint)2568;
			((MiniGame)obj7).OnInitialized += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (nint)obj12;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj12);
			bool flag3 = (object)miniGame == null;
			obj9 = 0;
			obj10 = this;
			if (!flag3)
			{
				object obj13 = (nint)0 + (nint)2592;
				miniGame.OnGameStart += action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num = (nint)obj13;
				Action action3 = default(Action);
				action3..ctor(this, (IntPtr)obj13);
				bool flag4 = (object)miniGame == null;
				obj9 = 0;
				obj10 = this;
				if (!flag4)
				{
					object obj14 = (nint)0 + (nint)2584;
					miniGame.OnMoveSent += action3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)obj14;
					Action<object> action4 = default(Action<object>);
					action4..ctor((object)this, (IntPtr)obj14);
					bool flag5 = (object)miniGame == null;
					obj9 = 0;
					obj10 = this;
					if (!flag5)
					{
						object obj15 = (nint)0 + (nint)2528;
						miniGame.OnMove += action4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num = (nint)obj15;
						Action<object> action5 = default(Action<object>);
						action5..ctor((object)this, (IntPtr)obj15);
						bool flag6 = (object)miniGame == null;
						obj9 = 0;
						obj10 = this;
						if (!flag6)
						{
							object obj16 = typeof(TypeConverter<ushort, char>) + 1840;
							miniGame.OnClaim += action5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							object obj17 = default(object);
							bool flag7 = obj17 == null;
							obj9 = 0;
							num = 0;
							obj10 = 7;
							if (!flag7)
							{
								bool flag8 = (object)discardButton == null;
								object obj18 = 7;
								if (!flag8)
								{
									object obj19 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v27+40]");
									obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag9 = ex == null;
									obj9 = 0;
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v27+40]");
									obj10 = 0;
									if (flag9)
									{
										goto IL_0a36;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
								if ((nint)0 != 0)
								{
									object obj20 = obj17 + 32;
									obj20 = discardButton;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag10 = (object)watchButton == null;
									obj18 = discardButton;
									if (!flag10)
									{
										object obj21 = obj17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v26+40]");
										obj18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag11 = ex == null;
										obj9 = 0;
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v26+40]");
										obj10 = 0;
										if (flag11)
										{
											goto IL_0a36;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
									object obj22 = 0 & 0xFFFFFFFEL;
									if (obj22 != null)
									{
										object obj23 = obj17 + 40;
										obj23 = watchButton;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag12 = (object)discardActionButton == null;
										obj18 = watchButton;
										if (!flag12)
										{
											object obj24 = obj17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v25+40]");
											obj18 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag13 = ex == null;
											obj9 = 0;
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v25+40]");
											obj10 = 0;
											if (flag13)
											{
												goto IL_0a36;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
										bool flag14 = (nint)0 < (nint)2;
										object obj25 = !flag14;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
										object obj26 = -2;
										bool flag15 = obj26 == null;
										object obj27 = ~obj25;
										object obj28 = obj27 | flag15;
										if (obj28 == null)
										{
											object obj29 = obj17 + 48;
											obj29 = discardActionButton;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											bool flag16 = (object)playNowButton == null;
											obj18 = discardActionButton;
											if (!flag16)
											{
												object obj30 = obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v24+40]");
												obj18 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag17 = ex == null;
												obj9 = 0;
												num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v24+40]");
												obj10 = 0;
												if (flag17)
												{
													goto IL_0a36;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
											object obj31 = 0 & 0xFFFFFFFCL;
											if (obj31 != null)
											{
												object obj32 = obj17 + 56;
												obj32 = playNowButton;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												bool flag18 = (object)playAgainButton == null;
												obj18 = playNowButton;
												if (!flag18)
												{
													object obj33 = obj17;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v23+40]");
													obj18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag19 = ex == null;
													obj9 = 0;
													num = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v23+40]");
													obj10 = 0;
													if (flag19)
													{
														goto IL_0a36;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
												bool flag20 = (nint)0 < (nint)4;
												object obj34 = !flag20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
												object obj35 = -4;
												bool flag21 = obj35 == null;
												object obj36 = ~obj34;
												object obj37 = obj36 | flag21;
												if (obj37 == null)
												{
													object obj38 = obj17 + 64;
													obj38 = playAgainButton;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													bool flag22 = (object)exitButton == null;
													obj18 = playAgainButton;
													if (!flag22)
													{
														object obj39 = obj17;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v22+40]");
														obj18 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
														bool flag23 = ex == null;
														obj9 = 0;
														num = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v22+40]");
														obj10 = 0;
														if (flag23)
														{
															goto IL_0a36;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
													bool flag24 = (nint)0 < (nint)5;
													object obj40 = !flag24;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
													object obj41 = -5;
													bool flag25 = obj41 == null;
													object obj42 = ~obj40;
													object obj43 = obj42 | flag25;
													if (obj43 == null)
													{
														object obj44 = obj17 + 72;
														obj44 = exitButton;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														bool flag26 = (object)claimButton == null;
														obj18 = exitButton;
														if (!flag26)
														{
															object obj45 = obj17;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v21+40]");
															obj18 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
															bool flag27 = ex == null;
															obj9 = 0;
															num = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v21+40]");
															obj10 = 0;
															if (flag27)
															{
																goto IL_0a36;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
														bool flag28 = (nint)0 < (nint)6;
														object obj46 = !flag28;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v29+18]");
														object obj47 = -6;
														bool flag29 = obj47 == null;
														object obj48 = ~obj46;
														object obj49 = obj48 | flag29;
														if (obj49 == null)
														{
															object obj50 = obj17 + 80;
															obj50 = claimButton;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															object obj51 = this + 168;
															obj51 = obj17;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															ResetUi();
															Initialize();
															RegisterButtonEvents();
															return;
														}
													}
												}
											}
										}
									}
								}
								IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
								obj9 = 0;
								num = 0;
								obj10 = obj18;
							}
						}
					}
				}
			}
		}
		ex = new NullReferenceException();
		goto IL_0a36;
		IL_0a36:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void RegisterButtonEvents()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00c5: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_010f: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_0159: Expected I, but got O
		//IL_018b: Expected O, but got I
		//IL_01a3: Expected I, but got O
		//IL_01d5: Expected O, but got I
		//IL_01ed: Expected I, but got O
		//IL_021f: Expected O, but got I
		//IL_0237: Expected I, but got O
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_029d: Expected I, but got O
		//IL_02cc: Expected O, but got I4
		Button button = playNowButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = claimButton;
		object obj3 = (nint)0 + (nint)2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = claimPanelButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj3);
		button3.m_OnClick.AddListener(unityAction3);
		Button button4 = discardButton;
		object obj4 = (nint)0 + (nint)2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj4);
		button4.m_OnClick.AddListener(unityAction4);
		Button button5 = watchButton;
		object obj5 = (nint)0 + (nint)2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj5);
		button5.m_OnClick.AddListener(unityAction5);
		Button button6 = discardActionButton;
		object obj6 = (nint)0 + (nint)2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction6 = default(UnityAction);
		unityAction6..ctor(this, (IntPtr)obj6);
		button6.m_OnClick.AddListener(unityAction6);
		Button button7 = playAgainButton;
		object obj7 = (nint)0 + (nint)2600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction7 = default(UnityAction);
		unityAction7..ctor(this, (IntPtr)obj7);
		button7.m_OnClick.AddListener(unityAction7);
		Button button8 = exitButton;
		object obj8 = (nint)0 + (nint)2560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction8 = default(UnityAction);
		unityAction8..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = typeof(RegisteredWaitHandle) + 3136;
		button8.m_OnClick.AddListener(unityAction8);
		GameObject popup = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v32+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action, persistent: true);
	}

	private void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_0217: Expected O, but got I
		//IL_022d: Expected O, but got I4
		//IL_023d: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_01c2: Expected O, but got I4
		//IL_0459: Expected O, but got I
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_047e: Expected F4, but got I
		//IL_0330: Expected O, but got I
		//IL_034a: Expected O, but got I4
		//IL_0286: Expected O, but got I
		//IL_0388: Expected O, but got I4
		//IL_0400: Expected O, but got I4
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64AC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v45+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v45+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool canNotPlayMiniGameOnWeb = MiniGameInfo.CanNotPlayMiniGameOnWeb;
		bool flag3 = !canNotPlayMiniGameOnWeb;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0129;
		IL_03d6:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float secondsTillNextMiniGameTrial = MiniGameInfo.SecondsTillNextMiniGameTrial;
		object methodName = "Index = {0} position = {1}" + 608;
		Invoke((string)methodName, secondsTillNextMiniGameTrial);
		return;
		IL_01a8:
		object obj9;
		bool flag5 = obj9 == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v28+B8]");
		object obj12 = 0;
		object methodName2 = "Index = {0} position = {1}" + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v21+4]");
		Invoke((string)methodName2, 0f);
		return;
		IL_02fe:
		ShowButton(playNowButton, 0f);
		return;
		IL_007c:
		if (MiniGameInfo.CanNotPlayMiniGameOnWeb)
		{
			return;
		}
		goto IL_0129;
		IL_0129:
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		object obj14;
		if ((nint)0 != 0)
		{
			bool delayIsActive = MiniGameInfo.DelayIsActive;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v28+E4]");
			obj9 = 0;
			bool flag6 = !delayIsActive;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v28+E4]");
			obj14 = 0;
			object obj15 = obj11;
			if (!flag6)
			{
				goto IL_01a8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool delayIsActive2 = MiniGameInfo.DelayIsActive;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v28+E4]");
			obj9 = 0;
			bool flag7 = !delayIsActive2;
			object obj16 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v28+E4]");
			obj14 = 0;
			object obj15 = obj11;
			if (obj16 != null)
			{
				goto IL_01a8;
			}
		}
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
			object obj17 = (nint)0 & (nint)1;
			if (obj17 != null)
			{
				goto IL_02a3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
			object obj18 = (nint)0 & (nint)1;
			bool flag8 = obj18 == null;
			object obj19 = !flag8;
			if (obj19 != null)
			{
				goto IL_02a3;
			}
		}
		_ = 1;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		object obj22 = obj20;
		if (obj21 != null)
		{
			goto IL_02d8;
		}
		goto IL_039e;
		IL_02d8:
		int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials >= 1)
		{
			goto IL_02fe;
		}
		goto IL_03d6;
		IL_039e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int miniGameRemainingTrials2 = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials2 >= 1)
		{
			goto IL_02fe;
		}
		goto IL_03d6;
		IL_02a3:
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		obj22 = obj20;
		if (!flag10)
		{
			goto IL_02d8;
		}
		goto IL_039e;
	}

	private void OnInitialized()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0123: Expected I, but got O
		//IL_009d: Expected O, but got I
		claimPanelButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(claimPanelButton);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -300f, 0.3f);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
		object obj3 = (nint)0 + (nint)2488;
		loader.StartLoading();
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(infoGroup, 1f, 0.3f);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOAnchorPosY(welcomeMessage, -1300f, 0.5f);
		TweenCallback tweenCallback = TweenHelpers.Disable(welcomeMessage);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void OnGameStart(MiniGameState state)
	{
		StopLoading();
		GameObject gameObject = remainingHearts.gameObject;
		gameObject.SetActive(value: true);
		remainingHearts.MaxProgress = state.<RemainingMoves>k__BackingField;
		remainingHearts.CurrentProgress = state.<RemainingMoves>k__BackingField;
		discardCardsCount.MaxProgress = state.<CardsPerMove>k__BackingField;
	}

	private void OnMoveSent()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		claimPanelButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(claimPanelButton);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -300f, 0.3f);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
		loader.StartLoading();
		discardCountParent.SetActive(value: false);
		object obj3 = typeof(SqlSingle[]) + 3912;
		discardCardsCount.CurrentProgress = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(prizeText, 0, 0.3f);
	}

	private void OnMove(MiniGameState state)
	{
		remainingHearts.CurrentProgress = state.<RemainingMoves>k__BackingField;
	}

	private void OnClaim(MiniGameState state)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_0115: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 784;
		remainingHearts.CurrentProgress = state.<RemainingMoves>k__BackingField;
		UpdateOwnedAces();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
		bool flag2 = miniGameRemainingTrials < 0;
		bool flag3 = miniGameRemainingTrials == 0;
		int num = miniGameRemainingTrials ^ miniGameRemainingTrials;
		int num2 = miniGameRemainingTrials & num;
		bool flag4 = num2 < 0;
		bool flag5 = flag2 == flag4;
		object obj4 = !flag3;
		object obj5 = flag5 & obj4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			object obj7 = 80;
		}
		else
		{
			object obj7 = 88;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MiniGameControls)+v124 @ X8_v5]");
		ShowButton((Button)0);
	}

	private void ResetUi()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0245: Expected I, but got O
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_017c: Expected O, but got I4
		claimPanelButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(claimPanelButton);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -300f, 0.3f);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
		object obj3 = typeof(UsageHint) + 744;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13+B8]");
		object obj5 = 0;
		welcomeMessage.anchoredPosition = (Vector2)0;
		infoGroup.alpha = 0.4f;
		GameObject gameObject = remainingHearts.gameObject;
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		gameObject.SetActive(value: false);
		TextMeshProExtensions.SetNumber(prizeText, 0);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v21+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		TextMeshProExtensions.SetNumber(ownedAcesText, aces);
		GameObject gameObject2 = discardCountParent.gameObject;
		gameObject2.SetActive(value: false);
		discardCardsCount.CurrentProgress = 0;
		StopLoading();
	}

	private void UpdateActiveButton()
	{
		//IL_0023: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0128: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected I4, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0214: Expected O, but got I
		//IL_00a0: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		object obj = (nint)0 + (nint)2272;
		bool flag = Enumerable.Any((IEnumerable<object>)<State>k__BackingField.<Rewards>k__BackingField);
		MiniGame miniGame2 = this.miniGame;
		if (flag)
		{
			MiniGameState <State>k__BackingField2 = miniGame2.<State>k__BackingField;
			bool flag2 = <State>k__BackingField2.<RemainingMoves>k__BackingField == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				object obj3 = 48;
				goto IL_01fd;
			}
		}
		MiniGameState <State>k__BackingField3 = miniGame2.<State>k__BackingField;
		if (<State>k__BackingField3.<RemainingMoves>k__BackingField > 0)
		{
			object obj3 = 56;
		}
		else
		{
			object obj4 = typeof(MemberAchievementClanFeedData) + 784;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
			object obj7 = miniGameRemainingTrials - 1;
			bool flag4 = (nint)obj7 < 0;
			int num = miniGameRemainingTrials ^ 1;
			int num2 = miniGameRemainingTrials ^ obj7;
			int num3 = num & num2;
			bool flag5 = num3 < 0;
			bool flag6 = flag4 == flag5;
			object obj8 = !flag6;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				object obj3 = 88;
			}
			else
			{
				object obj3 = 80;
			}
		}
		goto IL_01fd;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MiniGameControls)+v154 @ X8_v7]");
		ShowButton((Button)0);
	}

	private void HideClaimPanel()
	{
		claimPanelButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(claimPanelButton);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -300f, 0.3f);
	}

	private void ShowClaimPanel()
	{
		claimPanelButton.interactable = true;
		RectTransform target = UIExtensions.rectTransform(claimPanelButton);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, 0f, 0.3f);
	}

	private void HideAllButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
	}

	private void ShowButton(Button button, float duration = 0.3f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_010a: Expected I, but got O
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		//IL_0150: Expected F4, but got I
		//IL_0150: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
		Transform target = button.transform;
		int num = ShortcutExtensions.DOKill(target);
		int num2 = ShortcutExtensions.DOKill(((Selectable)button).m_TargetGraphic);
		button.interactable = true;
		GameObject gameObject = button.gameObject;
		gameObject.SetActive(value: true);
		float duration2 = duration * 0.5f;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(((Selectable)button).m_TargetGraphic, 1f, duration2);
		Transform target2 = button.transform;
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v5+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v6+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, (Vector3)0, 0f);
	}

	private void HideButton(Button button)
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00e7: Expected F4, but got O
		//IL_00e7: Expected O, but got I4
		object obj = (nint)0 + (nint)2736;
		object obj2 = (nint)0 + (nint)2504;
		Transform target = button.transform;
		int num = ShortcutExtensions.DOKill(target);
		int num2 = ShortcutExtensions.DOKill(((Selectable)button).m_TargetGraphic);
		button.interactable = false;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(((Selectable)button).m_TargetGraphic, 0f, 0.1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Transform target2 = button.transform;
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+B8]");
		object obj5 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, (Vector3)0, (float)obj5);
		TweenCallback tweenCallback = TweenHelpers.Disable(button);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void StartLoading()
	{
		loader.StartLoading();
	}

	private void StopLoading()
	{
		//IL_0021: Expected O, but got I
		loader.Freeze();
		object obj = (nint)0 + (nint)2504;
		Transform target = loader.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0f, 0.2f);
		TweenCallback tweenCallback = TweenHelpers.Disable(loader);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public Tween AnimateReward(GameObject rewardUi, int rewardValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0401: Expected O, but got I
		//IL_041b: Expected O, but got I4
		//IL_013c: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0242: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0459: Expected O, but got I4
		//IL_02bf: Expected I, but got O
		//IL_0307: Expected I, but got O
		//IL_04da: Expected O, but got I
		//IL_04f8: Expected O, but got I4
		//IL_0353: Expected O, but got I
		//IL_036e: Expected O, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_055c: Expected O, but got I
		//IL_056e: Expected F4, but got O
		//IL_056e: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj4;
		object obj6;
		object obj11;
		object obj13;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = obj2 + 32;
			obj4 = rewardUi;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			MiniGame miniGame = this.miniGame;
			if ((object)this.miniGame != null)
			{
				MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
				if (miniGame.<State>k__BackingField != null)
				{
					bool flag = <State>k__BackingField.<RemainingMoves>k__BackingField == 0;
					object obj5 = !flag;
					if (obj5 != null)
					{
						goto IL_01b7;
					}
					obj6 = typeof(MemberAchievementClanFeedData) + 784;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v48+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
						object obj8 = (nint)0 & (nint)1;
						if (obj8 != null)
						{
							goto IL_0159;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
						object obj9 = (nint)0 & (nint)1;
						bool flag2 = obj9 == null;
						object obj10 = !flag2;
						if (obj10 != null)
						{
							goto IL_0159;
						}
					}
					_ = 1;
					obj11 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v61+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					obj13 = obj11;
					if (obj12 != null)
					{
						goto IL_018e;
					}
					goto IL_046f;
				}
			}
		}
		goto IL_0506;
		IL_0159:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v61+E4]");
		bool flag4 = (nint)0 == 0;
		obj13 = obj11;
		if (!flag4)
		{
			goto IL_018e;
		}
		goto IL_046f;
		IL_046f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials > 0)
		{
			goto IL_01b7;
		}
		goto IL_04a4;
		IL_018e:
		int miniGameRemainingTrials2 = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials2 > 0)
		{
			goto IL_01b7;
		}
		goto IL_04a4;
		IL_04a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF030]");
		Transform transform;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF030]");
			transform = ((Component)0).transform;
			bool flag5 = (object)transform == null;
			object obj14 = !flag5;
			if (obj14 != null)
			{
				goto IL_0202;
			}
		}
		goto IL_0506;
		IL_0506:
		return (Tween)(object)new NullReferenceException();
		IL_01b7:
		if ((object)prizeText != null)
		{
			transform = prizeText.transform;
			if ((object)transform != null)
			{
				goto IL_0202;
			}
		}
		goto IL_0506;
		IL_0202:
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj17 = (nint)0 + (nint)1728;
		object obj18 = (nint)0 + (nint)1736;
		Vector3 position = transform.position;
		object obj19 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj17);
		Sequence s2 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		Sequence s3 = TweenSettingsExtensions.AppendInterval(s2, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj18);
		Sequence s4 = TweenSettingsExtensions.AppendCallback(s3, tweenCallback2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+20]");
			Transform target = ((GameObject)0).transform;
			float duration = default(float);
			TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOMove(target, (Vector3)0, duration);
			Sequence s5 = TweenSettingsExtensions.Append(s4, t);
			if (obj4 != null)
			{
				Transform target2 = ((GameObject)obj4).transform;
				object obj21 = typeof(UsageHint) + 816;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v13+B8]");
				object obj23 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(target2, (Vector3)0, (float)obj23);
				Sequence s6 = TweenSettingsExtensions.Join(s5, t2);
				TweenCallback callback = TweenHelpers.Disable((GameObject)obj4);
				return TweenSettingsExtensions.AppendCallback(s6, callback);
			}
		}
		goto IL_0506;
	}

	public void OnCardSelected(List<MiniGameCard> cards)
	{
		//IL_004e: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_013c: Expected O, but got I
		GameObject gameObject = discardButton.gameObject;
		bool activeSelf = gameObject.activeSelf;
		if (activeSelf)
		{
			((MiniGameControls)activeSelf).HideButton(discardButton);
		}
		discardCountParent.SetActive(value: true);
		discardCardsCount.CurrentProgress = cards._size;
		MiniGame miniGame = this.miniGame;
		bool shouldWatchAd = miniGame.visuals.ShouldWatchAd;
		bool flag = !shouldWatchAd;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 64;
		}
		else
		{
			object obj3 = 72;
		}
		MiniGame miniGame2 = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame2.<State>k__BackingField;
		if (cards._size == <State>k__BackingField.<CardsPerMove>k__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MiniGameControls)+v104 @ X8_v6]");
			ShowButton((Button)0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MiniGameControls)+v104 @ X8_v6]");
			((MiniGameControls)shouldWatchAd).HideButton((Button)0);
		}
	}

	public void FinishDrawingCards()
	{
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (Enumerable.Any((IEnumerable<object>)<State>k__BackingField.<Rewards>k__BackingField))
		{
			MiniGame miniGame2 = this.miniGame;
			MiniGameState <State>k__BackingField2 = miniGame2.<State>k__BackingField;
			if (<State>k__BackingField2.<RemainingMoves>k__BackingField >= 1)
			{
				claimPanelButton.interactable = true;
				RectTransform target = UIExtensions.rectTransform(claimPanelButton);
				int num = ShortcutExtensions.DOKill(target);
				RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, 0f, 0.3f);
			}
		}
		UpdateActiveButton();
	}

	private void UpdateOwnedAces()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_014d: Expected I, but got O
		string text = ownedAcesText.text;
		int num = int.Parse(text);
		MiniGame miniGame = this.miniGame;
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)2512;
		object obj4 = (nint)0 + (nint)2528;
		int totalReward = miniGame.<State>k__BackingField.TotalReward;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int endValue = totalReward + num;
		Tweener tweener = AnimationExtensions.DONumber(ownedAcesText, endValue, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Tweener tweener2 = AnimationExtensions.DONumber(prizeText, 0, 0.3f);
	}

	private void OnPlayNowButtonClicked()
	{
		//IL_003d: Expected O, but got I
		this.miniGame.SendStart();
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void OnClaimButtonClicked()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00b5: Expected I, but got O
		miniGame.SendClaim();
		claimPanelButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(claimPanelButton);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(claimPanelButton);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -300f, 0.3f);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
	}

	private void OnDiscardButtonClicked()
	{
		HideButton(discardButton);
		discardCountParent.SetActive(value: true);
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		visuals.hand.ReturnRewardCards();
		visuals.statusUi.Hide();
	}

	private void OnWatchButtonClicked()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		MiniGame miniGame = this.miniGame;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		miniGame.visuals.RequestAd(action);
	}

	private void OnDiscardActionButtonClicked()
	{
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		visuals.hand.SendMove();
	}

	private void OnPlayAgainButtonClicked()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		this.miniGame.SendStart();
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsPlayAgain();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnExitButtonClicked()
	{
		MiniGame miniGame = this.miniGame;
		miniGame.visuals.Exit();
	}

	public void FinishGameNow()
	{
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (Enumerable.Any((IEnumerable<object>)<State>k__BackingField.<Rewards>k__BackingField))
		{
			OnClaimButtonClicked();
		}
		else
		{
			this.miniGame.SendCleanup();
		}
	}

	private void <UpdateOwnedAces>b__38_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0189: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63DC]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI textMesh;
		TextMeshProUGUI textMeshProUGUI;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			textMesh = ownedAcesText;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			textMeshProUGUI = ownedAcesText;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			textMesh = ownedAcesText;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			textMeshProUGUI = ownedAcesText;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		textMesh = textMeshProUGUI;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b4;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00b4;
		IL_00b4:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		TextMeshProExtensions.SetNumber(textMesh, aces);
	}

	private void <OnWatchButtonClicked>b__42_0()
	{
		ShowButton(discardActionButton);
	}
}
