using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentHelpPopup : MonoBehaviour
{
	private TextMeshProUGUI tournamentNameText;

	private Image tournamentImage;

	private GameObject publicTournamentMessage;

	private GameObject privateTournamentMessage;

	private GameObject officalTournamentMessage;

	private ScrollRect officalScrollRect;

	private Sprite publicTournamentSprite;

	private Sprite privateTournamentSprite;

	private Sprite OfficalTournamentSprite;

	private PopupUI popup;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 104;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Show(TournamentType type)
	{
		//IL_005e: Expected I, but got O
		//IL_0098: Expected I, but got O
		//IL_00d3: Expected I, but got O
		//IL_010d: Expected I, but got O
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04bf: Expected I, but got O
		//IL_04c7: Expected I4, but got O
		//IL_0506: Expected I, but got O
		//IL_050b: Expected I, but got O
		//IL_0515: Expected I4, but got O
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0276: Expected I, but got O
		//IL_027e: Expected I4, but got O
		//IL_0183: Expected I, but got O
		//IL_02b3: Expected I, but got O
		//IL_02bd: Expected I4, but got O
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01ce: Expected I, but got O
		//IL_01d6: Expected I4, but got O
		//IL_0571: Expected I, but got O
		//IL_02ee: Expected I, but got O
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0657: Expected O, but got I
		//IL_021b: Expected O, but got I4
		//IL_0220: Expected I, but got O
		//IL_0329: Expected I, but got O
		//IL_0233: Expected I, but got O
		//IL_023d: Expected I4, but got O
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_037f: Expected O, but got I
		//IL_038d: Expected I, but got O
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03bc: Expected O, but got I
		//IL_03ca: Expected I, but got O
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_0408: Expected O, but got I4
		//IL_0450: Expected O, but got I
		//IL_046b: Expected O, but got I
		//IL_0473: Expected I, but got O
		bool flag = (object)privateTournamentMessage == null;
		bool flag2 = (byte)type != 0;
		GameObject gameObject4;
		nint num2;
		nint num;
		if (!flag)
		{
			GameObject gameObject = privateTournamentMessage.gameObject;
			bool flag3 = (object)gameObject == null;
			flag2 = false;
			if (!flag3)
			{
				gameObject.SetActive(value: false);
				bool flag4 = (object)publicTournamentMessage == null;
				num = unchecked((nint)null);
				flag2 = false;
				if (!flag4)
				{
					GameObject gameObject2 = publicTournamentMessage.gameObject;
					bool flag5 = (object)gameObject2 == null;
					num = unchecked((nint)null);
					flag2 = false;
					if (!flag5)
					{
						gameObject2.SetActive(value: false);
						bool flag6 = (object)officalTournamentMessage == null;
						num = unchecked((nint)null);
						flag2 = false;
						if (!flag6)
						{
							GameObject gameObject3 = officalTournamentMessage.gameObject;
							bool flag7 = (object)gameObject3 == null;
							num = unchecked((nint)null);
							flag2 = false;
							if (!flag7)
							{
								gameObject3.SetActive(value: false);
								if (type != TournamentType.Public)
								{
									if (type != TournamentType.Official)
									{
										bool flag8 = type != TournamentType.Private;
										num = unchecked((nint)null);
										flag2 = false;
										if (flag8)
										{
											object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
											object obj2 = "The operation is not allowed on non-connected sockets." + 4088;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
											string format = default(string);
											object arg = default(object);
											string message = string.Format(format, arg);
											object obj3 = typeof(DataRelation) + 3808;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											Exception ex = default(Exception);
											ex..ctor(message);
											object obj4 = (nint)0 + (nint)888;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
											throw new OutOfMemoryException();
										}
										object obj5 = "Picking audio files is not supported on iOS" + 1872;
										TextMeshProExtensions.Localize(tournamentNameText, (string)obj5);
										bool flag9 = (object)tournamentImage == null;
										num = unchecked((nint)null);
										flag2 = (byte)(int)obj5 != 0;
										if (!flag9)
										{
											tournamentImage.sprite = privateTournamentSprite;
											gameObject4 = privateTournamentMessage;
											bool flag10 = (object)privateTournamentMessage == null;
											object obj6 = !flag10;
											num2 = unchecked((nint)null);
											if (obj6 != null)
											{
												goto IL_0523;
											}
											num = unchecked((nint)null);
											flag2 = (byte)(int)privateTournamentSprite != 0;
										}
									}
									else
									{
										object obj7 = "October" + 40;
										TextMeshProExtensions.Localize(tournamentNameText, (string)obj7);
										bool flag11 = (object)tournamentImage == null;
										num = unchecked((nint)null);
										flag2 = (byte)(int)obj7 != 0;
										if (!flag11)
										{
											tournamentImage.sprite = OfficalTournamentSprite;
											bool flag12 = (object)officalTournamentMessage == null;
											num = unchecked((nint)null);
											flag2 = (byte)(int)OfficalTournamentSprite != 0;
											if (!flag12)
											{
												GameObject gameObject5 = officalTournamentMessage.gameObject;
												bool flag13 = (object)gameObject5 == null;
												num = unchecked((nint)null);
												flag2 = false;
												if (!flag13)
												{
													gameObject5.SetActive(value: true);
													bool flag14 = (object)officalScrollRect == null;
													num = unchecked((nint)null);
													flag2 = true;
													if (!flag14)
													{
														officalScrollRect.verticalNormalizedPosition = 0f;
														object obj8 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														object obj9 = (nint)0 + (nint)872;
														DOGetter<float> dOGetter = default(DOGetter<float>);
														dOGetter..ctor((object)this, (IntPtr)obj9);
														object obj10 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														object obj11 = (nint)0 + (nint)880;
														DOSetter<float> dOSetter = default(DOSetter<float>);
														dOSetter..ctor((object)this, (IntPtr)obj11);
														object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
														object obj13 = obj12;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v44+E4]");
														bool flag15 = (nint)0 == 0;
														object obj14 = !flag15;
														if (obj14 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, 1f, 0.35f);
														object obj15 = (nint)0 + (nint)2752;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
														object obj16 = (nint)0 + (nint)2864;
														num = (nint)obj16;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
														flag2 = true;
														goto IL_057f;
													}
												}
											}
										}
									}
								}
								else
								{
									object obj17 = "Picking audio files is not supported on iOS" + 2752;
									TextMeshProExtensions.Localize(tournamentNameText, (string)obj17);
									bool flag16 = (object)tournamentImage == null;
									num = unchecked((nint)null);
									flag2 = (byte)(int)obj17 != 0;
									if (!flag16)
									{
										tournamentImage.sprite = publicTournamentSprite;
										gameObject4 = publicTournamentMessage;
										bool flag17 = (object)publicTournamentMessage == null;
										num2 = unchecked((nint)null);
										num = unchecked((nint)null);
										flag2 = (byte)(int)publicTournamentSprite != 0;
										if (!flag17)
										{
											goto IL_0523;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_05aa;
		IL_057f:
		if ((object)popup != null)
		{
			popup.SlideFromBottom();
			return;
		}
		goto IL_05aa;
		IL_05aa:
		throw new NullReferenceException();
		IL_0523:
		GameObject gameObject6 = gameObject4.gameObject;
		bool flag18 = (object)gameObject6 == null;
		num = num2;
		flag2 = false;
		if (!flag18)
		{
			gameObject6.SetActive(value: true);
			num = unchecked((nint)null);
			flag2 = true;
			goto IL_057f;
		}
		goto IL_05aa;
	}

	private float <Show>b__11_0()
	{
		return officalScrollRect.verticalNormalizedPosition;
	}

	private void <Show>b__11_1(float value)
	{
		officalScrollRect.verticalNormalizedPosition = value;
	}
}
