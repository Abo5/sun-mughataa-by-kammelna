using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using ListView;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ReferralRewardItem : ListViewItem<ReferralRewardHolder, int>
{
	private TextMeshProUGUI titleText;

	private Button claimButton;

	private TextMeshProUGUI coinsText;

	private TextMeshProUGUI subscriptionText;

	private TextMeshProUGUI itemsText;

	private Image progressBar;

	private TextMeshProUGUI progressText;

	private TextMeshProUGUI claimText;

	private UserReferralRewardModel reward
	{
		get
		{
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
			return (UserReferralRewardModel)0;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		Button button = claimButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		object obj3 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object obj4 = this + 192;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void ClaimReward()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_018d: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		//IL_0069: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_011d: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00c5: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		PopupWindow.ShowLoading((string)msgBody);
		object obj5 = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661E]");
		object obj6 = (nint)0 & (nint)1;
		UserReferralRewardModel userReferralRewardModel;
		UserReferralRewardModel userReferralRewardModel2;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
			userReferralRewardModel = (UserReferralRewardModel)0;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
			userReferralRewardModel2 = (UserReferralRewardModel)0;
			if (!flag2)
			{
				goto IL_00d3;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
			userReferralRewardModel = (UserReferralRewardModel)0;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
			userReferralRewardModel2 = (UserReferralRewardModel)0;
			if (obj8 != null)
			{
				goto IL_00d3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ReferralHandler.ClaimReward(userReferralRewardModel2);
		return;
		IL_00d3:
		ReferralHandler.ClaimReward(userReferralRewardModel);
	}

	public override void Setup(ReferralRewardHolder datum, bool firstTime)
	{
		ReferralRewardHolder datum2 = default(ReferralRewardHolder);
		bool firstTime2 = default(bool);
		base.Setup(datum2, firstTime2);
		Populate();
	}

	private unsafe void Populate()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_01df: Expected I, but got O
		//IL_0213: Expected I, but got O
		//IL_087f: Expected O, but got I
		//IL_08a0: Expected I, but got O
		//IL_024c: Expected I, but got O
		//IL_02ce: Expected I, but got O
		//IL_0304: Expected I, but got O
		//IL_0338: Expected I, but got O
		//IL_08f1: Expected O, but got I
		//IL_0912: Expected I, but got O
		//IL_0371: Expected I, but got O
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_0447: Expected I, but got O
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_0964: Expected O, but got I
		//IL_0984: Expected O, but got I4
		//IL_0994: Expected I, but got O
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_0549: Expected O, but got I4
		//IL_0595: Expected O, but got I4
		//IL_05a2: Expected I, but got O
		//IL_05d7: Expected O, but got I4
		//IL_05e4: Expected I, but got O
		//IL_0617: Expected O, but got I4
		//IL_0624: Expected I, but got O
		//IL_0657: Expected O, but got I4
		//IL_0664: Expected I, but got O
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_0771: Expected O, but got I4
		//IL_07af: Expected O, but got I4
		//IL_06dd: Expected O, but got I4
		//IL_072e: Expected I, but got O
		//IL_09b2: Expected O, but got I
		//IL_09d2: Expected O, but got I4
		//IL_07dc: Expected O, but got I4
		//IL_0a01: Expected O, but got I4
		//IL_0a06: Expected I, but got O
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6620]");
		object obj2 = (nint)0 & (nint)1;
		TextMeshProUGUI textMeshProUGUI;
		TextMeshProUGUI textMeshProUGUI2;
		if (obj2 != null)
		{
			textMeshProUGUI = titleText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661E]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			textMeshProUGUI2 = titleText;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			textMeshProUGUI = titleText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661E]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			textMeshProUGUI2 = titleText;
			if (obj5 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		bool flag3 = (nint)0 == 0;
		textMeshProUGUI = textMeshProUGUI2;
		if (!flag3)
		{
			goto IL_0163;
		}
		goto IL_083d;
		IL_084b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0859;
		IL_0859:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_083d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_084b;
		IL_0083:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_0163;
		}
		goto IL_083d;
		IL_0163:
		TextMeshProUGUI textMesh = textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+18]");
		TextMeshProExtensions.FixArabic(textMesh, (string)0);
		SetupClaimButton();
		bool flag5 = (object)coinsText == null;
		object[] array = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+18]");
		nint num = 0;
		if (!flag5)
		{
			Transform transform = coinsText.transform;
			bool flag6 = (object)transform == null;
			array = null;
			num = unchecked((nint)null);
			if (!flag6)
			{
				Transform parent = transform.parent;
				bool flag7 = (object)parent == null;
				array = null;
				num = unchecked((nint)null);
				if (!flag7)
				{
					GameObject gameObject = parent.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
					bool flag8 = (nint)0 == 0;
					array = null;
					num = unchecked((nint)null);
					if (!flag8)
					{
						bool flag9 = (object)gameObject == null;
						array = null;
						num = unchecked((nint)null);
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8+20]");
							bool flag10 = (nint)0 == 0;
							bool flag11 = !flag10;
							gameObject.SetActive(flag11);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
							bool flag12 = (nint)0 == 0;
							array = null;
							num = (flag11 ? 1 : 0);
							if (!flag12)
							{
								int num2 = default(int);
								string text = num2.ToString();
								TextMeshProExtensions.FixArabic(coinsText, text);
								bool flag13 = (object)subscriptionText == null;
								array = null;
								num = (nint)text;
								if (!flag13)
								{
									Transform transform2 = subscriptionText.transform;
									bool flag14 = (object)transform2 == null;
									array = null;
									num = unchecked((nint)null);
									if (!flag14)
									{
										Transform parent2 = transform2.parent;
										bool flag15 = (object)parent2 == null;
										array = null;
										num = unchecked((nint)null);
										if (!flag15)
										{
											GameObject gameObject2 = parent2.gameObject;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
											object obj9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
											bool flag16 = (nint)0 == 0;
											array = null;
											num = unchecked((nint)null);
											if (!flag16)
											{
												bool flag17 = (object)gameObject2 == null;
												array = null;
												num = unchecked((nint)null);
												if (!flag17)
												{
													object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+24]");
													bool flag18 = (nint)0 == 0;
													bool active = !flag18;
													gameObject2.SetActive(active);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
													bool flag19 = (nint)0 == 0;
													array = null;
													num = 1;
													if (!flag19)
													{
														object obj11 = 153100288 + 1024;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
														object[] array2 = default(object[]);
														bool flag20 = array2 == null;
														array = null;
														object obj12 = default(object);
														num = (nint)(&obj12);
														if (!flag20)
														{
															object obj13 = default(object);
															bool flag21 = obj13 == null;
															nint num3 = (nint)(&obj12);
															if (!flag21)
															{
																nint num4 = (nint)array2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
																num3 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																bool flag22 = ex == null;
																array = null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
																num = 0;
																if (flag22)
																{
																	goto IL_0859;
																}
															}
															bool flag23 = array2.Length == 0;
															array = null;
															num = num3;
															if (flag23)
															{
																goto IL_084b;
															}
															object obj14 = "DNQUALIFIER" + 1456;
															object obj15 = array2 + 32;
															obj15 = obj13;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															TextMeshProExtensions.Localize(subscriptionText, (string)obj14, array2);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
															object obj16 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
															bool flag24 = (nint)0 == 0;
															object obj17 = 0;
															array = array2;
															num = (nint)obj14;
															if (!flag24)
															{
																object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
																object obj19 = obj18;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v36+E4]");
																bool flag25 = (nint)0 == 0;
																object obj20 = !flag25;
																if (obj20 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v27+28]");
																StoreItem storeItem = Store.GetStoreItem(0);
																bool flag26 = (object)itemsText == null;
																obj17 = 0;
																array = array2;
																num = unchecked((nint)null);
																if (!flag26)
																{
																	Transform transform3 = itemsText.transform;
																	bool flag27 = (object)transform3 == null;
																	obj17 = 0;
																	array = array2;
																	num = unchecked((nint)null);
																	if (!flag27)
																	{
																		Transform parent3 = transform3.parent;
																		bool flag28 = (object)parent3 == null;
																		obj17 = 0;
																		array = array2;
																		num = unchecked((nint)null);
																		if (!flag28)
																		{
																			GameObject gameObject3 = parent3.gameObject;
																			bool flag29 = (object)gameObject3 == null;
																			obj17 = 0;
																			array = array2;
																			num = unchecked((nint)null);
																			if (!flag29)
																			{
																				bool flag30 = storeItem == null;
																				bool flag31 = !flag30;
																				gameObject3.SetActive(flag31);
																				bool flag32 = storeItem == null;
																				array = null;
																				num = (flag31 ? 1 : 0);
																				if (!flag32)
																				{
																					bool flag33 = (object)itemsText == null;
																					obj17 = 0;
																					array = null;
																					num = (flag31 ? 1 : 0);
																					if (flag33)
																					{
																						goto IL_083d;
																					}
																					itemsText.isRightToLeftText = false;
																					TextMeshProExtensions.FixArabic(itemsText, storeItem.<name>k__BackingField);
																					array = null;
																					num = (nint)storeItem.<name>k__BackingField;
																				}
																				object obj21 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
																				object obj22 = obj21;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v46+E4]");
																				bool flag34 = (nint)0 == 0;
																				object obj23 = !flag34;
																				if (obj23 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				}
																				List<UserReferralModel> successfulReferrals = ReferralHandler.SuccessfulReferrals;
																				bool flag35 = successfulReferrals == null;
																				obj17 = 0;
																				if (!flag35)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
																					object obj24 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
																					bool flag36 = (nint)0 == 0;
																					obj17 = 0;
																					if (!flag36)
																					{
																						bool flag37 = (object)progressBar == null;
																						obj17 = 0;
																						if (!flag37)
																						{
																							float num5 = successfulReferrals._size;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v34+2C]");
																							float fillAmount = num5 / 0f;
																							progressBar.fillAmount = fillAmount;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
																							bool flag38 = (nint)0 == 0;
																							obj17 = 0;
																							num = unchecked((nint)null);
																							if (!flag38)
																							{
																								string text2 = num2.ToString();
																								TextMeshProExtensions.FixArabic(progressText, text2);
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
								}
							}
						}
					}
				}
			}
		}
		goto IL_083d;
	}

	private unsafe void SetupClaimButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_0298: Expected O, but got I4
		//IL_0206: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_0250: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_0112: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_0391: Expected O, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected I4, but got Unknown
		//IL_053a: Expected O, but got I
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0452: Expected O, but got I4
		//IL_0480: Expected O, but got I4
		//IL_0569: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		//IL_04ad: Expected O, but got Ref
		//IL_0587: Expected O, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04f2: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6621]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		Button button;
		object obj5;
		Button button2;
		if (obj2 != null)
		{
			obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			button = claimButton;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661E]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			button2 = claimButton;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			button = claimButton;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661E]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			button2 = claimButton;
			if (obj7 != null)
			{
				goto IL_009f;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		object obj8 = 0;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v30+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj3 = obj5;
		button = button2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		object obj11 = 0;
		if (obj10 != null)
		{
			goto IL_00fc;
		}
		goto IL_025e;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X22_v2+30]");
		object obj12 = (nint)0 & (nint)1;
		bool interactable;
		if (obj12 != null)
		{
			interactable = false;
		}
		else
		{
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v20+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			List<UserReferralModel> successfulReferrals = ReferralHandler.SuccessfulReferrals;
			int size = successfulReferrals._size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X22_v2+2C]");
			object obj15 = (nint)size - (nint)0;
			bool flag5 = (nint)obj15 < 0;
			int size2 = successfulReferrals._size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X22_v2+2C]");
			int num = (int)((nint)size2 ^ (nint)0);
			int num2 = successfulReferrals._size ^ obj15;
			int num3 = num & num2;
			bool flag6 = num3 < 0;
			bool flag7 = flag5 == flag6;
			interactable = flag7;
		}
		Selectable selectable;
		selectable.interactable = interactable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		object obj16 = 0;
		object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v9+30]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		object obj19 = ~obj18;
		if (obj19 == null)
		{
			object obj20 = 1062501089;
		}
		else
		{
			object obj20 = 1058642330;
		}
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v7+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		ColorBlock colorBlock = default(ColorBlock);
		claimButton.colors = (ColorBlock)(&colorBlock);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		object obj23 = 0;
		object obj24 = "Read object reference Id '{0}' for {1}." + 832;
		object obj25 = "Read object reference Id '{0}' for {1}." + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v18+30]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		object obj27 = ~obj26;
		object text = ((obj27 != null) ? obj25 : obj24);
		TextMeshProExtensions.Localize(claimText, (string)text);
		return;
		IL_0147:
		bool flag11 = obj8 == null;
		object obj28 = !flag11;
		selectable = button;
		if (obj28 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02e1;
		IL_02be:
		_ = 1;
		obj8 = obj11;
		obj3 = obj5;
		selectable = button2;
		goto IL_02e1;
		IL_009f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		obj8 = 0;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v30+E4]");
		bool flag12 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralRewardItem)+48]");
		obj11 = 0;
		obj5 = obj3;
		button2 = button;
		if (!flag12)
		{
			goto IL_00fc;
		}
		goto IL_025e;
		IL_025e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661B]");
		object obj29 = (nint)0 & (nint)1;
		bool flag13 = obj29 == null;
		object obj30 = !flag13;
		obj8 = obj11;
		obj3 = obj5;
		button = button2;
		if (obj30 != null)
		{
			goto IL_0147;
		}
		goto IL_02be;
		IL_00fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661B]");
		object obj31 = (nint)0 & (nint)1;
		bool flag14 = obj31 == null;
		obj11 = obj8;
		obj5 = obj3;
		button2 = button;
		if (!flag14)
		{
			goto IL_0147;
		}
		goto IL_02be;
	}
}
