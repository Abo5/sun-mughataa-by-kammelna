using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RankLine : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Image> <>9__10_0;

		public static Action<Image> <>9__10_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <InitializeLine>b__10_0(Image im)
		{
			GameObject gameObject = im.gameObject;
			gameObject.SetActive(value: true);
		}

		internal void <InitializeLine>b__10_1(Image im)
		{
			GameObject gameObject = im.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private RankLineSection[] rankSections;

	private AvatarInitializer MyBubblePrefab;

	private AvatarInitializer BuddyBubblePrefab;

	private Button snapButton;

	protected ScrollRect scrollRect;

	protected RectTransform contentPanel;

	private float maxY;

	private float minY;

	private AvatarInitializer myAvatarBubble;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Initialize();
		Button button = snapButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	public void InitializeLine(PlayerRank rank)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0056: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0a06: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_0a33: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_0a68: Expected O, but got I
		//IL_0198: Expected O, but got I
		//IL_0be5: Expected O, but got I
		//IL_0bf5: Expected O, but got I
		//IL_0c17: Expected O, but got I4
		//IL_0c27: Expected O, but got I
		//IL_02f4: Expected O, but got I
		//IL_0b1c: Expected O, but got I
		//IL_0b2c: Expected O, but got I
		//IL_0b4e: Expected O, but got I4
		//IL_0b5e: Expected O, but got I
		//IL_0e05: Expected I, but got O
		//IL_0aa5: Expected O, but got I
		//IL_0ab5: Expected O, but got I
		//IL_0ad7: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_0207: Expected O, but got I4
		//IL_0c57: Expected O, but got I4
		//IL_0b8e: Expected O, but got I4
		//IL_0e4e: Expected O, but got I
		//IL_0e56: Expected I, but got O
		//IL_0e67: Expected I, but got O
		//IL_0e85: Expected O, but got I
		//IL_0e96: Expected O, but got I4
		//IL_0af5: Expected O, but got I
		//IL_006e: Expected I, but got O
		//IL_007f: Expected I, but got O
		//IL_0225: Expected O, but got I
		//IL_0cc8: Expected O, but got I4
		//IL_0ce3: Expected O, but got I4
		//IL_0c87: Expected O, but got I
		//IL_034f: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00b3: Expected O, but got I4
		//IL_0bbe: Expected O, but got I
		//IL_0d10: Expected O, but got I
		//IL_03e9: Expected O, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected I4, but got Unknown
		//IL_0d45: Expected O, but got I
		//IL_0447: Expected O, but got I4
		//IL_0d90: Expected O, but got I4
		//IL_0474: Expected O, but got I
		//IL_0db8: Expected O, but got I
		//IL_0dca: Expected O, but got I
		//IL_04a9: Expected O, but got I
		//IL_0504: Expected O, but got I
		//IL_0538: Expected O, but got I4
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected I4, but got Unknown
		//IL_05b0: Expected O, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected I4, but got Unknown
		//IL_060e: Expected O, but got I4
		//IL_063b: Expected O, but got I
		//IL_0670: Expected O, but got I
		//IL_06b7: Expected O, but got I4
		//IL_0704: Expected O, but got I
		//IL_0738: Expected O, but got I4
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected I4, but got Unknown
		//IL_07b0: Expected O, but got I4
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected I4, but got Unknown
		//IL_080e: Expected O, but got I4
		//IL_083b: Expected O, but got I
		//IL_0870: Expected O, but got I
		//IL_08cb: Expected O, but got I
		//IL_08ff: Expected O, but got I4
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected I4, but got Unknown
		//IL_0977: Expected O, but got I4
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected I4, but got Unknown
		//IL_09ab: Expected O, but got I4
		//IL_09b0: Expected I, but got O
		if (rank != null)
		{
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4032;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
			object obj3 = (nint)0 + (nint)3080;
			object obj4 = (nint)0 + (nint)2192;
			Action<object> action = (Action<object>)(object)rank;
			object obj5 = 0;
			Action<object> action4 = default(Action<object>);
			Action<object> action6 = default(Action<object>);
			while (true)
			{
				object obj6 = obj5 + 1;
				IEnumerable<object> enumeration;
				object obj11;
				object obj43;
				nint num12;
				if ((nint)obj6 < (nint)rank.<Rank>k__BackingField)
				{
					RankLineSection[] array = rankSections;
					if (rankSections == null)
					{
						break;
					}
					bool flag = (nint)obj5 < array.Length;
					object obj7 = !flag;
					if (obj7 == null)
					{
						object obj8 = (object)rankSections + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v48+20]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v48+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v49+28]");
						enumeration = (IEnumerable<object>)0;
						object obj10 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v32+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v32+B8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v54+8]");
							action = (Action<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v54+8]");
							bool flag2 = (nint)0 == 0;
							object obj12 = !flag2;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v54+8]");
								Action<object> action2 = (Action<object>)0;
								goto IL_0b6c;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj10 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v32+B8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v54+8]");
							Action<object> action2 = (Action<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v54+8]");
							bool flag3 = (nint)0 == 0;
							object obj13 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v54+8]");
							action = (Action<object>)0;
							if (obj13 == null)
							{
								goto IL_0b6c;
							}
						}
						goto IL_0dfd;
					}
				}
				else
				{
					RankLineSection[] array2 = rankSections;
					if ((nint)obj6 == (nint)rank.<Rank>k__BackingField)
					{
						if (rankSections == null)
						{
							break;
						}
						bool flag4 = (nint)obj5 < array2.Length;
						object obj14 = !flag4;
						if (obj14 == null)
						{
							object obj15 = (object)rankSections + obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v28+20]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v28+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v29+28]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v29+28]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v30+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v30+20]");
							GameObject gameObject = ((UnityEngine.Component)0).gameObject;
							if ((object)gameObject == null)
							{
								break;
							}
							bool flag5 = rank.<SubRanksCount>k__BackingField < 0;
							bool flag6 = rank.<SubRanksCount>k__BackingField == 0;
							int num = rank.<SubRanksCount>k__BackingField ^ rank.<SubRanksCount>k__BackingField;
							int num2 = rank.<SubRanksCount>k__BackingField & num;
							bool flag7 = num2 < 0;
							bool flag8 = flag5 == flag7;
							object obj18 = !flag6;
							bool active = (byte)((flag8 & obj18) ? 1 : 0) != 0;
							gameObject.SetActive(active);
							RankLineSection[] array3 = rankSections;
							if (rankSections == null)
							{
								break;
							}
							bool flag9 = (nint)obj5 < array3.Length;
							object obj19 = !flag9;
							if (obj19 == null)
							{
								object obj20 = (object)rankSections + obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v33+20]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v33+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v34+28]");
								object obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v34+28]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v35+28]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v35+28]");
								GameObject gameObject2 = ((UnityEngine.Component)0).gameObject;
								if ((object)gameObject2 == null)
								{
									break;
								}
								object obj23 = rank.<SubRanksCount>k__BackingField - 1;
								bool flag10 = (nint)obj23 < 0;
								bool flag11 = obj23 == null;
								int num3 = rank.<SubRanksCount>k__BackingField ^ 1;
								int num4 = rank.<SubRanksCount>k__BackingField ^ obj23;
								int num5 = num3 & num4;
								bool flag12 = num5 < 0;
								bool flag13 = flag10 == flag12;
								object obj24 = !flag11;
								bool active2 = (byte)((flag13 & obj24) ? 1 : 0) != 0;
								gameObject2.SetActive(active2);
								RankLineSection[] array4 = rankSections;
								if (rankSections == null)
								{
									break;
								}
								bool flag14 = (nint)obj5 < array4.Length;
								object obj25 = !flag14;
								if (obj25 == null)
								{
									object obj26 = (object)rankSections + obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v38+20]");
									object obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v38+20]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v39+28]");
									object obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v39+28]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v40+18]");
									bool flag15 = (nint)0 < (nint)3;
									object obj29 = !flag15;
									object obj30 = ~obj29;
									if (obj30 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v40+30]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v40+30]");
										GameObject gameObject3 = ((UnityEngine.Component)0).gameObject;
										if ((object)gameObject3 == null)
										{
											break;
										}
										object obj31 = rank.<SubRanksCount>k__BackingField - 2;
										bool flag16 = (nint)obj31 < 0;
										bool flag17 = obj31 == null;
										int num6 = rank.<SubRanksCount>k__BackingField ^ 2;
										int num7 = rank.<SubRanksCount>k__BackingField ^ obj31;
										int num8 = num6 & num7;
										bool flag18 = num8 < 0;
										bool flag19 = flag16 == flag18;
										object obj32 = !flag17;
										bool active3 = (byte)((flag19 & obj32) ? 1 : 0) != 0;
										gameObject3.SetActive(active3);
										RankLineSection[] array5 = rankSections;
										if (rankSections == null)
										{
											break;
										}
										bool flag20 = (nint)obj5 < array5.Length;
										object obj33 = !flag20;
										if (obj33 == null)
										{
											object obj34 = (object)rankSections + obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v43+20]");
											object obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v43+20]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v44+28]");
											object obj36 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v44+28]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v45+38]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v45+38]");
											GameObject gameObject4 = ((UnityEngine.Component)0).gameObject;
											if ((object)gameObject4 == null)
											{
												break;
											}
											object obj37 = rank.<SubRanksCount>k__BackingField - 3;
											bool flag21 = (nint)obj37 < 0;
											bool flag22 = obj37 == null;
											int num9 = rank.<SubRanksCount>k__BackingField ^ 3;
											int num10 = rank.<SubRanksCount>k__BackingField ^ obj37;
											int num11 = num9 & num10;
											bool flag23 = num11 < 0;
											bool flag24 = flag21 == flag23;
											object obj38 = !flag22;
											bool flag25 = (byte)((flag24 & obj38) ? 1 : 0) != 0;
											gameObject4.SetActive(flag25);
											bool flag26 = (nint)obj6 != 6;
											action = (Action<object>)flag25;
											num12 = unchecked((nint)null);
											obj5 = obj6;
											if (flag26)
											{
												continue;
											}
											goto IL_0c8c;
										}
									}
								}
							}
						}
					}
					else
					{
						if (rankSections == null)
						{
							break;
						}
						bool flag27 = (nint)obj5 < array2.Length;
						object obj39 = !flag27;
						if (obj39 == null)
						{
							object obj40 = (object)rankSections + obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v16+20]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v16+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v17+28]");
							enumeration = (IEnumerable<object>)0;
							object obj42 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v14+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v14+B8]");
								obj43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v20+10]");
								action = (Action<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v20+10]");
								bool flag28 = (nint)0 == 0;
								object obj44 = !flag28;
								if (obj44 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v20+10]");
									Action<object> action3 = (Action<object>)0;
									goto IL_0c35;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj42 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v14+B8]");
								obj43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v20+10]");
								Action<object> action3 = (Action<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v20+10]");
								bool flag29 = (nint)0 == 0;
								object obj45 = !flag29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v20+10]");
								action = (Action<object>)0;
								if (obj45 == null)
								{
									goto IL_0c35;
								}
							}
							goto IL_0dfd;
						}
					}
				}
				goto IL_0dd9;
				IL_0c8c:
				RankLineSection[] array6 = rankSections;
				if (rankSections == null)
				{
					break;
				}
				object obj46 = rank.<Rank>k__BackingField - 1;
				bool flag30 = (nint)obj46 < array6.Length;
				object obj47 = !flag30;
				if (obj47 == null)
				{
					object obj48 = (object)rankSections + obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v11+20]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v11+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v12+20]");
					object obj50 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v12+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					int <SubRanksCount>k__BackingField = rank.<SubRanksCount>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v13+18]");
					bool flag31 = (nint)<SubRanksCount>k__BackingField < (nint)0;
					object obj51 = !flag31;
					if (obj51 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v12+20]");
						object obj52 = (nint)0 + (nint)rank.<SubRanksCount>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v14+20]");
						SnapTo((Transform)0);
						return;
					}
				}
				goto IL_0dd9;
				IL_0b6c:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v32+E4]");
				bool flag32 = (nint)0 == 0;
				object obj53 = !flag32;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj54 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v52+B8]");
					obj11 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num13 = (nint)obj3;
				action4..ctor(obj11, (IntPtr)obj3);
				object obj55 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v55+B8]");
				object obj56 = (nint)0 + (nint)8;
				obj56 = action4;
				object obj57 = 0;
				Action<object> action5 = action4;
				goto IL_0ea3;
				IL_0dfd:
				num12 = (nint)obj4;
				ArraysExtensions.ForEach(enumeration, action);
				bool flag33 = (nint)obj6 == 6;
				obj5 = obj6;
				if (!flag33)
				{
					continue;
				}
				goto IL_0c8c;
				IL_0ea3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action = action5;
				goto IL_0dfd;
				IL_0c35:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v14+E4]");
				bool flag34 = (nint)0 == 0;
				object obj58 = !flag34;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj59 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v24+B8]");
					obj43 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj60 = (nint)0 + (nint)3088;
				num13 = (nint)obj60;
				action6..ctor(obj43, (IntPtr)obj60);
				object obj61 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v23+B8]");
				obj56 = (nint)0 + (nint)16;
				obj56 = action6;
				obj57 = 0;
				action5 = action6;
				goto IL_0ea3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0dd9;
		IL_0dd9:
		throw new IndexOutOfRangeException();
	}

	public void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0160: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E785B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
		InitializeLine(rank);
		PlaceMe();
		PlaceBuddies();
	}

	private void SnapTo(Transform target)
	{
		//IL_003b: Expected O, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		Canvas.ForceUpdateCanvases();
		Transform transform = scrollRect.transform;
		Vector3 position = contentPanel.position;
		Vector3 vector = transform.InverseTransformPoint((Vector3)0);
		Transform transform2 = scrollRect.transform;
		Vector3 position2 = target.position;
		object obj = typeof(UsageHint) + 928;
		Vector3 vector2 = transform2.InverseTransformPoint((Vector3)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default(object);
		float max = (float)obj4 - (float)obj4;
		object obj5 = default(object);
		float num = (float)obj5 - (float)obj5;
		Vector2 vector3 = VectorExtensions.ClampY((Vector2)0, num, max);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(contentPanel, (Vector2)0, num);
	}

	public void SnapToMe()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_02b8: Expected O, but got I
		//IL_02ca: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E785D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_02cb;
		IL_02d9:
		throw new IndexOutOfRangeException();
		IL_02cb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02d9;
		IL_0150:
		User localUser = sessionModel.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
		if (rank != null)
		{
			RankLineSection[] array = rankSections;
			if (rankSections != null)
			{
				object obj8 = rank.<Rank>k__BackingField - 1;
				bool flag3 = (nint)obj8 < array.Length;
				object obj9 = !flag3;
				if (obj9 != null)
				{
					goto IL_02d9;
				}
				object obj10 = (object)rankSections + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v6+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v7+20]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v7+20]");
					if ((nint)0 != 0)
					{
						int <SubRanksCount>k__BackingField = rank.<SubRanksCount>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v8+18]");
						bool flag4 = (nint)<SubRanksCount>k__BackingField < (nint)0;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v7+20]");
							object obj14 = (nint)0 + (nint)rank.<SubRanksCount>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9+20]");
							SnapTo((Transform)0);
							return;
						}
						goto IL_02d9;
					}
				}
			}
		}
		goto IL_02cb;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			goto IL_0150;
		}
		goto IL_02cb;
	}

	private void ShowSnapButton(bool show)
	{
		GameObject gameObject = snapButton.gameObject;
		gameObject.SetActive(show);
	}

	private void PlaceMe()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02be: Expected O, but got I
		//IL_02d8: Expected O, but got I
		//IL_0302: Expected O, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E785E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_0329;
		IL_0337:
		throw new IndexOutOfRangeException();
		IL_0329:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0337;
		IL_0150:
		User localUser = sessionModel.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
		if (rank != null)
		{
			RankLineSection[] array = rankSections;
			if (rankSections != null)
			{
				object obj8 = rank.<Rank>k__BackingField - 1;
				bool flag3 = (nint)obj8 < array.Length;
				object obj9 = !flag3;
				if (obj9 != null)
				{
					goto IL_0337;
				}
				object obj10 = (object)rankSections + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v6+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+20]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+20]");
					if ((nint)0 != 0)
					{
						int <SubRanksCount>k__BackingField = rank.<SubRanksCount>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+18]");
						bool flag4 = (nint)<SubRanksCount>k__BackingField < (nint)0;
						object obj13 = !flag4;
						if (obj13 != null)
						{
							goto IL_0337;
						}
						object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj15 = (nint)0 + (nint)480;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+20]");
						object obj16 = (nint)0 + (nint)rank.<SubRanksCount>k__BackingField;
						object obj17 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10+E4]");
						bool flag5 = (nint)0 == 0;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
						object obj19 = this + 88;
						object obj20 = default(object);
						obj19 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (obj19 != null)
						{
							((AvatarInitializer)obj19).InitializeMyAvatar();
							return;
						}
					}
				}
			}
		}
		goto IL_0329;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj21 = !flag6;
		if (obj21 != null)
		{
			goto IL_0150;
		}
		goto IL_0329;
	}

	private void PlaceBuddies()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0089: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_00bf: Expected I, but got O
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
		object obj3 = (nint)0 + (nint)1424;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		((List<object>)obj6).ForEach(action);
	}

	private Transform GetPositionForRank(PlayerRank rank)
	{
		//IL_0059: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00a1: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0121: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0156: Expected O, but got I
		if (rank != null)
		{
			RankLineSection[] array = rankSections;
			if (rankSections != null)
			{
				object obj = rank.<Rank>k__BackingField - 1;
				bool flag = (nint)obj < array.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_0164;
				}
				object obj3 = (object)rankSections + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+20]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+20]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+20]");
					if ((nint)0 != 0)
					{
						int <SubRanksCount>k__BackingField = rank.<SubRanksCount>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6+18]");
						bool flag2 = (nint)<SubRanksCount>k__BackingField < (nint)0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+20]");
							object obj7 = (nint)0 + (nint)rank.<SubRanksCount>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+20]");
							return (Transform)0;
						}
						goto IL_0164;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0164;
		IL_0164:
		return (Transform)(object)new IndexOutOfRangeException();
	}

	public RankLine()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F78]");
		maxY = 0f;
		base..ctor();
	}

	private void <PlaceBuddies>b__16_0(FriendProfile friendProfile)
	{
		//IL_0013: Expected O, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_0201: Expected O, but got I4
		if (friendProfile != null)
		{
			FriendGameData gameData = friendProfile.GetGameData((Games?)(object)0);
			if (gameData != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				PlayerRank playerRank = default(PlayerRank);
				playerRank..ctor(gameData.Points);
				if (playerRank != null)
				{
					RankLineSection[] array = rankSections;
					if (rankSections != null)
					{
						object obj2 = playerRank.<Rank>k__BackingField - 1;
						bool flag = (nint)obj2 < array.Length;
						object obj3 = !flag;
						if (obj3 != null)
						{
							goto IL_023a;
						}
						object obj4 = (object)rankSections + obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+20]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+20]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+20]");
							if ((nint)0 != 0)
							{
								int <SubRanksCount>k__BackingField = playerRank.<SubRanksCount>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v10+18]");
								bool flag2 = (nint)<SubRanksCount>k__BackingField < (nint)0;
								object obj7 = !flag2;
								if (obj7 != null)
								{
									goto IL_023a;
								}
								object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj9 = (nint)0 + (nint)480;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+20]");
								object obj10 = (nint)0 + (nint)playerRank.<SubRanksCount>k__BackingField;
								object obj11 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+E4]");
								bool flag3 = (nint)0 == 0;
								object obj12 = !flag3;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
								AvatarData data = friendProfile;
								AvatarInitializer avatarInitializer = default(AvatarInitializer);
								if ((object)avatarInitializer != null)
								{
									avatarInitializer.Initialize(data);
									return;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_023a;
		IL_023a:
		throw new IndexOutOfRangeException();
	}
}
