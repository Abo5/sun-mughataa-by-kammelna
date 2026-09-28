using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class KRankPicker : DummyBaseDropMenu
{
	private sealed class <>c__DisplayClass12_0
	{
		public int index;

		public KRankPicker <>4__this;

		internal void <Awake>b__0()
		{
			//IL_002e: Expected O, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected I4, but got Unknown
			KRankPicker kRankPicker = <>4__this;
			<>4__this.SetSelectedIndex(index);
			object obj = ~(((DummyBaseDropMenu)kRankPicker).<IsToggled>k__BackingField ? 1 : 0);
			bool show = (byte)(1 & obj) != 0;
			<>4__this.UpdateUI(show);
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public PlayerRank.Ranks rank;

		internal bool <SetSelectedRank>b__0(PlayerRank.Ranks r)
		{
			//IL_000f: Expected O, but got I4
			object obj = r - rank;
			return obj == null;
		}
	}

	private Transform itemsLayout;

	private PopupUI popup;

	private Button itemPrefab;

	private Image selectedImage;

	private RankSprites rankSprites;

	private bool disableHigherRanks;

	private PlayerRank.Ranks[] items;

	private PlayerRank.Ranks[] hiddenRanks;

	public PlayerRank.Ranks SelectedItem
	{
		get
		{
			//IL_0014: Expected I4, but got I8
			//IL_002e: Expected O, but got I4
			//IL_00d0: Expected I4, but got O
			//IL_0082: Expected O, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			int num = (int)(base.<SelectedIndex>k__BackingField & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				PlayerRank.Ranks[] array = items;
				if (items != null)
				{
					bool flag2 = base.<SelectedIndex>k__BackingField < array.Length;
					object obj2 = !flag2;
					if (obj2 == null)
					{
						object obj3 = items + base.<SelectedIndex>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v2+20]");
						return PlayerRank.Ranks.AI;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (PlayerRank.Ranks)ex2;
			}
			return PlayerRank.Ranks.Beginner;
		}
	}

	public override object selectedItem
	{
		get
		{
			//IL_0096: Expected I4, but got I8
			//IL_00b0: Expected O, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_004b: Expected O, but got I4
			int num = (int)(base.<SelectedIndex>k__BackingField & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				PlayerRank.Ranks[] array = items;
				if (items != null)
				{
					bool flag2 = base.<SelectedIndex>k__BackingField < array.Length;
					object obj2 = !flag2;
					if (obj2 == null)
					{
						goto IL_00be;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return new IndexOutOfRangeException();
			}
			goto IL_00be;
			IL_00be:
			object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object result = default(object);
			return result;
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00e2: Expected I, but got O
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0064: Expected I, but got O
		//IL_01c5: Expected O, but got I4
		//IL_0837: Expected O, but got I
		//IL_0876: Expected O, but got I8
		//IL_0890: Expected O, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_073f: Expected O, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0788: Expected O, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02fe: Expected O, but got I4
		//IL_0349: Expected O, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_03a5: Expected O, but got I4
		//IL_08aa: Expected O, but got I
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I
		//IL_03fd: Expected I, but got O
		//IL_043c: Expected O, but got I
		//IL_0480: Expected O, but got I4
		//IL_04c6: Expected O, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_052c: Expected I, but got O
		//IL_0555: Expected O, but got I4
		//IL_0589: Expected O, but got I
		//IL_08fa: Expected O, but got I4
		//IL_0628: Expected O, but got I4
		//IL_0650: Expected O, but got I
		//IL_0688: Expected O, but got I
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_06d2: Expected O, but got I4
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected I4, but got Unknown
		object obj = 152989696;
		Selectable selectable = (Selectable)(typeof(Queue<string>) + 848);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75AE]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)2200;
			nint num = (nint)selectable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v40 (Il2CppClass<UnityEngine.UI.Selectable>)+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj3 = (nint)0 + (nint)2200;
			nint num = (nint)selectable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v40 (Il2CppClass<UnityEngine.UI.Selectable>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
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
		goto IL_080b;
		IL_0819:
		throw new IndexOutOfRangeException();
		IL_082b:
		object obj6 = (nint)0 + (nint)3904;
		base.<IsToggled>k__BackingField = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0338");
		IEnumerable<System.Int32Enum> source = default(IEnumerable<System.Int32Enum>);
		System.Int32Enum int32Enum = (System.Int32Enum)(base.<SelectedIndex>k__BackingField = (int)Enumerable.First(source));
		object obj7 = (long)int32Enum & 0x80000000L;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		PlayerRank.Ranks rank;
		if (obj8 == null)
		{
			PlayerRank.Ranks[] array = items;
			if (items != null)
			{
				bool flag4 = (int)int32Enum < array.Length;
				object obj9 = !flag4;
				if (obj9 != null)
				{
					goto IL_0819;
				}
				object obj10 = items + int32Enum;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v12+20]");
				rank = PlayerRank.Ranks.AI;
				bool flag5 = (object)rankSprites == null;
				object obj11 = !flag5;
				if (obj11 != null)
				{
					goto IL_07c3;
				}
			}
		}
		else
		{
			bool flag6 = (object)rankSprites == null;
			rank = PlayerRank.Ranks.Beginner;
			if (!flag6)
			{
				goto IL_07c3;
			}
		}
		goto IL_080b;
		IL_07c3:
		object sprite = ((RanksData<object>)(object)rankSprites).GetFor(rank, isNew: false);
		if ((object)selectedImage != null)
		{
			selectedImage.sprite = (Sprite)sprite;
			return;
		}
		goto IL_080b;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj12 = !flag7;
		if (obj12 != null)
		{
			goto IL_0150;
		}
		goto IL_080b;
		IL_0150:
		User localUser = sessionModel.LocalUser;
		PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(localUser);
		PlayerRank.Ranks[] array2;
		if (rank2 != null)
		{
			array2 = items;
			if (items != null)
			{
				object obj13 = array2.Length - 1;
				if ((nint)obj13 < 1)
				{
					goto IL_082b;
				}
				object obj14 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1272;
				object obj15 = (nint)0 + (nint)3288;
				object obj16 = obj13 + 8;
				bool flag8 = false;
				object obj17 = default(object);
				Selectable selectable2 = default(Selectable);
				UnityAction unityAction = default(UnityAction);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj17..ctor();
					if (obj17 == null)
					{
						break;
					}
					object obj18 = obj17 + 24;
					obj18 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					PlayerRank.Ranks[] array3 = items;
					if (items == null)
					{
						break;
					}
					object obj19 = obj16 - 8;
					bool flag9 = (nint)obj19 < array3.Length;
					object obj20 = !flag9;
					if (obj20 == null)
					{
						object obj21 = obj15;
						PlayerRank.Ranks[] source2 = hiddenRanks;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v14 (Ranks[])+v137 @ X24_v7*4]");
						bool flag10 = Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)source2, (System.Int32Enum)0);
						bool flag11 = !flag10;
						object obj22 = !flag11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v14 (Ranks[])+v137 @ X24_v7*4]");
						flag8 = false;
						if (obj22 != null)
						{
							goto IL_022c;
						}
						object obj23 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj24 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v17+E4]");
						bool flag12 = (nint)0 == 0;
						object obj25 = !flag12;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj26 = (nint)0 + (nint)888;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
						object obj27 = obj16 - 8;
						if ((object)selectable2 == null)
						{
							break;
						}
						object obj28 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj29 = (nint)0 + (nint)3168;
						unityAction..ctor(obj17, (IntPtr)obj29);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v28 (UnityEngine.UI.Selectable)+100]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v28 (UnityEngine.UI.Selectable)+100]");
						((UnityEvent)0).AddListener(unityAction);
						PlayerRank.Ranks[] array4 = items;
						if (items == null)
						{
							break;
						}
						bool flag13 = (nint)obj19 < array4.Length;
						object obj30 = !flag13;
						if (obj30 == null)
						{
							if ((object)rankSprites == null)
							{
								break;
							}
							Image targetGraphic = (Image)selectable2.m_TargetGraphic;
							object obj31 = (nint)0 + (nint)2048;
							RankSprites obj32 = rankSprites;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v25 (Ranks[])+v137 @ X24_v7*4]");
							object sprite2 = ((RanksData<object>)(object)obj32).GetFor(PlayerRank.Ranks.AI, isNew: false);
							if ((object)selectable2.m_TargetGraphic == null)
							{
								break;
							}
							object obj33 = typeof(System.IOAsyncCallback) + 2456;
							object obj34 = obj33;
							nint num2 = (nint)targetGraphic;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v30 (Il2CppClass<UnityEngine.UI.Image>)+130]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X1_v22+130]");
							bool flag14 = num3 < 0;
							object obj35 = !flag14;
							object obj36 = ~obj35;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v30 (Il2CppClass<UnityEngine.UI.Image>)+C8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X1_v22+130]");
								object obj37 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v32-8]");
								if (0 == (nint)obj34)
								{
									((Image)selectable2.m_TargetGraphic).sprite = (Sprite)sprite2;
									if (!disableHigherRanks)
									{
										flag8 = true;
									}
									else
									{
										PlayerRank.Ranks[] array5 = items;
										if (items == null)
										{
											break;
										}
										bool flag15 = (nint)obj19 < array5.Length;
										object obj38 = !flag15;
										if (obj38 != null)
										{
											goto IL_0819;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v36 (Ranks[])+v137 @ X24_v7*4]");
										object obj39 = (nint)0 - (nint)rank2.<Rank>k__BackingField;
										bool flag16 = (nint)obj39 < 0;
										bool flag17 = obj39 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v36 (Ranks[])+v137 @ X24_v7*4]");
										object obj40 = (nint)0 ^ (nint)rank2.<Rank>k__BackingField;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v36 (Ranks[])+v137 @ X24_v7*4]");
										object obj41 = 0 ^ obj39;
										object obj42 = obj40 & obj41;
										bool flag18 = (nint)obj42 < 0;
										bool flag19 = flag16 == flag18;
										object obj43 = !flag19;
										bool flag20 = (byte)((obj43 | flag17) ? 1 : 0) != 0;
										flag8 = flag20;
									}
									selectable2.interactable = flag8;
									obj21 = 0;
									goto IL_022c;
								}
							}
							throw new InvalidCastException();
						}
					}
					goto IL_0819;
					IL_022c:
					obj16--;
					if ((nint)obj19 > 0)
					{
						continue;
					}
					goto IL_06ec;
				}
			}
		}
		goto IL_080b;
		IL_080b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0819;
		IL_06ec:
		array2 = items;
		goto IL_082b;
	}

	private void OnItemClicked(int index)
	{
		//IL_0015: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		SetSelectedIndex(index);
		object obj = ~(base.<IsToggled>k__BackingField ? 1 : 0);
		bool show = (byte)(1 & obj) != 0;
		UpdateUI(show);
	}

	public void SetSelectedRank(PlayerRank.Ranks rank)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 504;
		object obj4 = (nint)0 + (nint)3176;
		object obj5 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C94F20");
		int selectedIndex = default(int);
		SetSelectedIndex(selectedIndex);
	}

	private void SetSelectedIndex(int index)
	{
		//IL_015e: Expected I4, but got I8
		//IL_0178: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		base.<SelectedIndex>k__BackingField = index;
		int num = (int)(index & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		PlayerRank.Ranks rank;
		if (obj == null)
		{
			PlayerRank.Ranks[] array = items;
			if (items != null)
			{
				bool flag2 = index < array.Length;
				object obj2 = !flag2;
				if (obj2 != null)
				{
					goto IL_013b;
				}
				object obj3 = items + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v14+20]");
				rank = PlayerRank.Ranks.AI;
				bool flag3 = (object)rankSprites == null;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					goto IL_00cd;
				}
			}
		}
		else
		{
			bool flag4 = (object)rankSprites == null;
			rank = PlayerRank.Ranks.Beginner;
			if (!flag4)
			{
				goto IL_00cd;
			}
		}
		goto IL_012d;
		IL_00cd:
		object sprite = ((RanksData<object>)(object)rankSprites).GetFor(rank, isNew: false);
		if ((object)selectedImage != null)
		{
			selectedImage.sprite = (Sprite)sprite;
			if (OnValueChanged != null)
			{
				OnValueChanged.Invoke(base.<SelectedIndex>k__BackingField);
			}
			return;
		}
		goto IL_012d;
		IL_013b:
		throw new IndexOutOfRangeException();
		IL_012d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_013b;
	}

	public void Toggle()
	{
		//IL_000b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		object obj = ~(base.<IsToggled>k__BackingField ? 1 : 0);
		bool show = (byte)(1 & obj) != 0;
		UpdateUI(show);
	}

	private void UpdateUI()
	{
		UpdateUI(base.<IsToggled>k__BackingField);
	}

	private void UpdateUI(bool show)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00af: Expected I, but got O
		//IL_0068: Expected O, but got I4
		Action action = default(Action);
		while (true)
		{
			base.<IsToggled>k__BackingField = show;
			UIChangedDelegate onUIUpdated;
			if (show)
			{
				Transform transform = popup.transform;
				UIExtensions.AttachToCanvas(transform, CanvasLayer.SecondaryCanvas, worldPositionStays: true);
				popup.PopFromCenter();
				base.<IsToggled>k__BackingField = true;
				onUIUpdated = base.OnUIUpdated;
				bool flag = base.OnUIUpdated == null;
				object obj = !flag;
				if (obj == null)
				{
					break;
				}
			}
			else
			{
				object obj2 = typeof(SqlSingle[]) + 2376;
				object obj3 = (nint)0 + (nint)3384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(this, (IntPtr)obj3);
				popup.ShrinkToParent(action);
				base.<IsToggled>k__BackingField = false;
				onUIUpdated = base.OnUIUpdated;
				if (base.OnUIUpdated == null)
				{
					break;
				}
			}
			IntPtr invoke_impl = ((Delegate)onUIUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)onUIUpdated).method_code;
			IntPtr method = ((Delegate)onUIUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v97 @ X3_v3 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public KRankPicker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01af: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		object handle = typeof(SqlDouble) + 3216;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X24_v2+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(SqlSingle[]) + 1336;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X24_v2+98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Array values = Enum.GetValues(typeFromHandle);
		IEnumerable<System.Int32Enum> source = Enumerable.Cast<System.Int32Enum>(values);
		System.Int32Enum[] array = Enumerable.ToArray(source);
		object obj6 = this + 112;
		obj6 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v14+18]");
		object obj7 = (nint)0 >= (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v14+18]");
		if ((object)(~obj7 | ((object)(-1) == null)) == null)
		{
			_ = 7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v14+18]");
			if ((nint)0 != 2)
			{
				_ = 8;
				object obj8 = this + 120;
				object obj9 = default(object);
				obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				((MonoBehaviour)this)..ctor();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void <UpdateUI>b__18_0()
	{
		Transform transform = popup.transform;
		Transform newParent = base.transform;
		UIExtensions.AttachToCanvas(transform, newParent, worldPositionStays: true);
	}
}
