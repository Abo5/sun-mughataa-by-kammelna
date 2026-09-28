using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class FastTrackInfoPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Image, bool> <>9__26_0;

		public static Func<Image, bool> <>9__27_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <InitHearts>b__26_0(Image h)
		{
			//IL_0067: Expected I4, but got O
			if ((object)h != null)
			{
				GameObject gameObject = h.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeInHierarchy;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <InitProgressBreadCrumps>b__27_0(Image w)
		{
			//IL_0067: Expected I4, but got O
			if ((object)w != null)
			{
				GameObject gameObject = w.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeInHierarchy;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public List<RankUI> levelRanks;

	public GameObject FTStageIndicator;

	public TextMeshProUGUI stageText;

	public HorizontalLayoutGroup horizontalLayout;

	public List<Image> FTHeartsList;

	public Image Heart;

	public List<Image> FTRoundsBreadCrumps;

	public RankUI FTAwardRank;

	public Sprite futureStage;

	public Sprite completedStage;

	public bool LoadPreviousState;

	private TextMeshProUGUI counter;

	protected int FTLevel;

	protected int FTStage;

	protected int FTStageFixedUI;

	protected int FTRoundsWon;

	protected int FTHearts;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89A0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig currentSFS = Config.CurrentSFS;
		bool flag2 = currentSFS == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008b;
		IL_007d:
		currentSFS = Config.CurrentSFS;
		goto IL_008b;
		IL_008b:
		if (currentSFS.<IsFastTrack>k__BackingField)
		{
			InitFT();
			RegisterEventsListeners();
		}
	}

	private void OnDestroy()
	{
		UnRegisterEventsListeners();
	}

	protected virtual void InitFT()
	{
		//IL_001d: Expected I, but got O
		//IL_002d: Expected O, but got I
		//IL_003d: Expected O, but got I
		InitFTInfo();
		InitLevelRanks();
		InitCurrentStage();
		InitHearts();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4 (Il2CppClass<FastTrackInfoPanel>)+1B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4 (Il2CppClass<FastTrackInfoPanel>)+1C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void SwitchScale()
	{
		//IL_0011: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0327: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_03c9: Expected O, but got F8
		//IL_01c0: Expected F8, but got I4
		//IL_00be: Expected F8, but got I4
		//IL_01ef: Expected F8, but got I4
		//IL_043a: Expected I4, but got O
		//IL_00ed: Expected F8, but got I4
		//IL_03f1: Expected I4, but got O
		//IL_029a: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_0278: Expected O, but got F8
		//IL_0198: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected F8, but got I4
		//IL_0161: Expected F8, but got I4
		//IL_016a: Expected O, but got I4
		bool flag = levelRanks == null;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		List<object>.Enumerator enumerator6;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj = (nint)0 + (nint)3168;
			object obj2 = ((List<object>)(object)levelRanks).get_Item(0);
			bool flag2 = obj2 == null;
			num = 0;
			if (!flag2)
			{
				Transform transform = ((Component)obj2).transform;
				bool flag3 = (object)transform == null;
				num = 0;
				if (!flag3)
				{
					Vector3 localScale = transform.localScale;
					object obj3 = typeof(UsageHint) + 816;
					object obj4 = (nint)0 + (nint)456;
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8+B8]");
					object obj6 = 0;
					List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
					List<object>.Enumerator enumerator = enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v9+C]");
					object obj7 = enumerator - 0;
					double num3 = default(double);
					double num2 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v9+10]");
					double num4 = num2 - 0.0;
					double num6 = default(double);
					double num5 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v9+14]");
					num6 = num5 - 0.0;
					object obj8 = obj7 * obj7;
					double num7 = num4 * num4;
					double num8 = (double)obj8 + num7;
					double num9 = num6 * num6;
					enumerator2 = (List<object>.Enumerator)(num9 + num8);
					List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
					Component component = default(Component);
					if ((nint)enumerator2 < 786163454)
					{
						bool flag4 = levelRanks == null;
						num3 = 786163454.0;
						num = 0;
						if (!flag4)
						{
							List<object>.Enumerator enumerator3 = ((List<object>)(object)levelRanks).GetEnumerator();
							num3 = 786163454.0;
							enumerator2 = enumerator4;
							while (true)
							{
								num = (int)obj4;
								bool flag5 = enumerator5.MoveNext();
								bool flag6 = !flag5;
								enumerator6 = enumerator4;
								if (flag6)
								{
									break;
								}
								if ((object)component == null)
								{
									goto IL_016f;
								}
								Transform transform2 = component.transform;
								if ((object)transform2 != null)
								{
									transform2.localScale = (Vector3)0;
									num6 = 1066192077.0;
									num3 = 1066192077.0;
									enumerator2 = (List<object>.Enumerator)1066192077;
									continue;
								}
								goto IL_0186;
							}
							goto IL_027d;
						}
					}
					else
					{
						bool flag7 = levelRanks == null;
						num3 = 786163454.0;
						num = 0;
						if (!flag7)
						{
							List<object>.Enumerator enumerator7 = ((List<object>)(object)levelRanks).GetEnumerator();
							num3 = 786163454.0;
							enumerator2 = enumerator4;
							while (true)
							{
								num = (int)obj4;
								bool flag8 = enumerator5.MoveNext();
								bool flag9 = !flag8;
								enumerator6 = enumerator4;
								if (flag9)
								{
									break;
								}
								if ((object)component == null)
								{
									goto IL_0288;
								}
								Transform transform3 = component.transform;
								if ((object)transform3 != null)
								{
									transform3.localScale = (Vector3)0;
									num6 = 1.0;
									num3 = 1.0;
									enumerator2 = (List<object>.Enumerator)1.0;
									continue;
								}
								goto IL_029f;
							}
							goto IL_027d;
						}
					}
				}
			}
		}
		goto IL_0306;
		IL_016f:
		NullReferenceException ex = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_0306;
		IL_0288:
		NullReferenceException ex2 = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_0306;
		IL_0306:
		throw new NullReferenceException();
		IL_0186:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		num = 0;
		goto IL_0306;
		IL_029f:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		num = 0;
		goto IL_0306;
		IL_027d:
		enumerator6.Dispose();
	}

	private void RegisterEventsListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0032: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(UsageHint) + 72;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<FastTrackInfoPanel>)+180]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.OnFastTrackRecordUpdated += action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.OnFastTrackRecordUpdated += action;
	}

	private void UnRegisterEventsListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0032: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(UsageHint) + 72;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<FastTrackInfoPanel>)+180]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.OnFastTrackRecordUpdated -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.OnFastTrackRecordUpdated -= action;
	}

	private void InitFTInfo()
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0123: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_0371: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_03e7: Expected O, but got I
		//IL_03f7: Expected O, but got I
		//IL_03af: Expected O, but got I4
		//IL_0424: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_07a6: Expected O, but got I
		//IL_07c8: Expected O, but got I4
		//IL_04f3: Expected O, but got I4
		//IL_0221: Expected O, but got I4
		//IL_047e: Expected O, but got I
		//IL_048e: Expected O, but got I
		//IL_04b0: Expected O, but got I4
		//IL_07df: Expected O, but got I4
		//IL_0568: Expected O, but got I
		//IL_052b: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_0637: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_05c2: Expected O, but got I
		//IL_05d2: Expected O, but got I
		//IL_05f4: Expected O, but got I4
		//IL_066f: Expected O, but got I
		//IL_067f: Expected O, but got I
		//IL_0811: Expected O, but got I4
		//IL_0950: Expected O, but got I
		//IL_0a27: Expected O, but got I4
		//IL_0844: Expected O, but got I
		//IL_085e: Expected O, but got I4
		//IL_09b2: Expected O, but got I
		//IL_09c2: Expected O, but got I
		//IL_09e4: Expected O, but got I4
		//IL_06e4: Expected O, but got I
		//IL_0a9c: Expected O, but got I
		//IL_0a5f: Expected O, but got I
		//IL_0a6f: Expected O, but got I
		//IL_08d4: Expected O, but got I
		//IL_08e4: Expected O, but got I
		//IL_089c: Expected O, but got I4
		//IL_0b4e: Expected O, but got I4
		//IL_091d: Expected O, but got I4
		//IL_0746: Expected O, but got I
		//IL_0756: Expected O, but got I
		//IL_0778: Expected O, but got I4
		//IL_0af6: Expected O, but got I
		//IL_0b06: Expected O, but got I
		//IL_0b86: Expected O, but got I
		//IL_0b96: Expected O, but got I
		//IL_0bb8: Expected O, but got I4
		object obj;
		object obj8;
		object obj6;
		if (LoadPreviousState)
		{
			obj = typeof(UsageHint) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_0079;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_0079;
				}
			}
			_ = 1;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj8 = obj6;
			if (obj7 != null)
			{
				goto IL_00ae;
			}
			goto IL_03c5;
		}
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		FTLevel = fTLevel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		if ((FTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2)) != 0)
		{
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v27+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser3);
			FTStageFixedUI = fTStage;
			object obj15 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v25+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			object obj17 = 0;
			if (obj16 == null)
			{
				goto IL_02b7;
			}
		}
		else
		{
			FTStageFixedUI = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4000]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v25+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				object obj17 = 0;
				goto IL_02b7;
			}
		}
		goto IL_02c6;
		IL_0540:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v15+24]");
		FTStage = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = obj6;
			if (!flag7)
			{
				goto IL_05b2;
			}
		}
		else
		{
			_ = 1;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			object obj20 = obj6;
			if (obj21 != null)
			{
				goto IL_05b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v65+8]");
		object obj23 = 0;
		goto IL_0684;
		IL_09a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v41+8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v41+8]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 != null)
		{
			goto IL_0a74;
		}
		goto IL_0bc6;
		IL_0a74:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v22+28]");
		FTRoundsWon = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj27 = (nint)0 & (nint)1;
		object obj29;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+E4]");
			bool flag10 = (nint)0 == 0;
			object obj28 = obj29;
			if (!flag10)
			{
				goto IL_0ae6;
			}
		}
		else
		{
			_ = 1;
			obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			object obj28 = obj29;
			if (obj30 != null)
			{
				goto IL_0ae6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v44+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v26+8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v26+8]");
		bool flag12 = (nint)0 == 0;
		object obj34 = !flag12;
		if (obj34 != null)
		{
			goto IL_0b0b;
		}
		goto IL_0bc6;
		IL_093a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj35 = (nint)0 & (nint)1;
		if (obj35 != null)
		{
			obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+E4]");
			bool flag13 = (nint)0 == 0;
			object obj36 = obj29;
			if (!flag13)
			{
				goto IL_09a2;
			}
		}
		else
		{
			_ = 1;
			obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+E4]");
			bool flag14 = (nint)0 == 0;
			object obj37 = !flag14;
			object obj36 = obj29;
			if (obj37 != null)
			{
				goto IL_09a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v36+8]");
		obj25 = 0;
		goto IL_0a74;
		IL_0bc6:
		throw new NullReferenceException();
		IL_092b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_093a;
		IL_0b0b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v30+2C]");
		FTHearts = 0;
		return;
		IL_0ae6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v50+B8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v32+8]");
		obj33 = 0;
		goto IL_0b0b;
		IL_02b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_02c6;
		IL_02c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser4 = sessionModel4.LocalUser;
		int fTRoundsWon = SFSKammelnaUserExtensions.GetFTRoundsWon(localUser4);
		FTRoundsWon = fTRoundsWon;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		User localUser5 = sessionModel5.LocalUser;
		int fTHearts = SFSKammelnaUserExtensions.GetFTHearts(localUser5);
		FTHearts = fTHearts;
		return;
		IL_046e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v79+8]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v79+8]");
		bool flag15 = (nint)0 == 0;
		object obj42 = !flag15;
		if (obj42 != null)
		{
			goto IL_0540;
		}
		goto IL_0bc6;
		IL_08b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v52+8]");
		object obj44 = 0;
		goto IL_08e9;
		IL_08e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v48+24]");
		FTStageFixedUI = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
		bool flag16 = (nint)0 == 0;
		object obj45 = !flag16;
		if (obj45 == null)
		{
			goto IL_092b;
		}
		goto IL_093a;
		IL_0736:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v59+8]");
		obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v59+8]");
		bool flag17 = (nint)0 == 0;
		object obj47 = !flag17;
		if (obj47 != null)
		{
			goto IL_08e9;
		}
		goto IL_0bc6;
		IL_0079:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
		bool flag18 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag18)
		{
			goto IL_00ae;
		}
		goto IL_03c5;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v83+8]");
		object obj49 = 0;
		goto IL_03fc;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v90+8]");
		obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v90+8]");
		bool flag19 = (nint)0 == 0;
		object obj51 = !flag19;
		if (obj51 != null)
		{
			goto IL_03fc;
		}
		goto IL_0bc6;
		IL_03fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v12+20]");
		FTLevel = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj52 = (nint)0 & (nint)1;
		if (obj52 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			bool flag20 = (nint)0 == 0;
			object obj53 = obj6;
			if (!flag20)
			{
				goto IL_046e;
			}
		}
		else
		{
			_ = 1;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			bool flag21 = (nint)0 == 0;
			object obj54 = !flag21;
			object obj53 = obj6;
			if (obj54 != null)
			{
				goto IL_046e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v74+8]");
		obj41 = 0;
		goto IL_0540;
		IL_0701:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
		bool flag22 = (nint)0 == 0;
		object obj56 = obj6;
		if (!flag22)
		{
			goto IL_0736;
		}
		goto IL_08b2;
		IL_0684:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v18+24]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj57 = (nint)0 & (nint)1;
				if (obj57 != null)
				{
					goto IL_0701;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj58 = (nint)0 & (nint)1;
				bool flag23 = obj58 == null;
				object obj59 = !flag23;
				if (obj59 != null)
				{
					goto IL_0701;
				}
			}
			_ = 1;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
			bool flag24 = (nint)0 == 0;
			object obj60 = !flag24;
			obj56 = obj6;
			if (obj60 != null)
			{
				goto IL_0736;
			}
			goto IL_08b2;
		}
		FTStageFixedUI = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+E4]");
		bool flag25 = (nint)0 == 0;
		object obj61 = !flag25;
		if (obj61 == null)
		{
			goto IL_092b;
		}
		goto IL_093a;
		IL_05b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v60+B8]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v70+8]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v70+8]");
		bool flag26 = (nint)0 == 0;
		object obj63 = !flag26;
		if (obj63 != null)
		{
			goto IL_0684;
		}
		goto IL_0bc6;
	}

	protected virtual void InitLevelRanks()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_0528: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_0247: Expected O, but got I4
		//IL_03ed: Expected O, but got I4
		//IL_02f0: Expected O, but got I4
		//IL_0412: Expected I, but got O
		//IL_0422: Expected O, but got I
		//IL_0451: Expected I, but got O
		//IL_0479: Expected O, but got F8
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_037d: Expected I, but got O
		//IL_038d: Expected O, but got I
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_04b4: Expected O, but got I4
		//IL_0108: Expected I, but got O
		//IL_011b: Expected O, but got I4
		object obj = (nint)0 + (nint)456;
		object obj2 = (nint)0 + (nint)3168;
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj6 = (nint)0 + (nint)448;
		object obj7 = FTStageFixedUI - 1;
		List<object>.Enumerator enumerator = ((List<object>)(object)levelRanks).GetEnumerator();
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		Component component = default(Component);
		object obj9 = default(object);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		SessionModel sessionModel = default(SessionModel);
		SessionModel sessionModel2 = default(SessionModel);
		PlayerRank playerRank2 = default(PlayerRank);
		while (true)
		{
			object obj8 = obj;
			if (enumerator2.MoveNext())
			{
				NullReferenceException ex;
				if ((object)component != null)
				{
					GameObject gameObject = component.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: false);
						continue;
					}
					ex = new NullReferenceException();
					obj8 = 0;
				}
				else
				{
					ex = new NullReferenceException();
				}
				obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				bool flag = (nint)obj8 != 1;
				enumerator3 = (List<object>.Enumerator)0;
				OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj8 = obj6;
				enumerator2.Dispose();
				if (obj9 != null)
				{
					ex2 = new OutOfMemoryException();
					enumerator3 = (List<object>.Enumerator)obj9;
					break;
				}
			}
			else
			{
				enumerator2.Dispose();
			}
			List<object>.Enumerator enumerator4 = enumerator3;
			int num = 0;
			bool flag9;
			do
			{
				bool flag2 = num < 6;
				object obj10 = !flag2;
				object obj11 = ~obj10;
				if (obj11 == null && FTLevel == 1)
				{
					break;
				}
				object obj12 = ((List<object>)(object)levelRanks).get_Item(num);
				GameObject gameObject2 = ((Component)obj12).gameObject;
				gameObject2.SetActive(value: true);
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v15+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				User localUser = sessionModel.LocalUser;
				PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
				object obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v21+E4]");
				bool flag4 = (nint)0 == 0;
				object obj16 = !flag4;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num2 = num + 1;
				PlayerRank playerRank = PlayerRank.FastTrackAward(FTLevel, num2);
				if (rank.<Points>k__BackingField > playerRank.<Points>k__BackingField)
				{
					object obj17 = ((List<object>)(object)levelRanks).get_Item(num);
					object obj18 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v44+E4]");
					bool flag5 = (nint)0 == 0;
					object obj19 = !flag5;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					User localUser2 = sessionModel2.LocalUser;
					PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(localUser2);
					object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					playerRank2..ctor(rank2.<Points>k__BackingField);
					nint num3 = (nint)obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v26 (Il2CppClass<System.Object>)+1B0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X8_v26 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
					obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				}
				else
				{
					object obj22 = ((List<object>)(object)levelRanks).get_Item(num);
					object obj23 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v21+E4]");
					bool flag6 = (nint)0 == 0;
					object obj24 = !flag6;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRank playerRank3 = PlayerRank.FastTrackAward(FTLevel, num2);
					nint num4 = (nint)obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v22 (Il2CppClass<System.Object>)+1B0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v504 @ X8_v22 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
				}
				object obj25 = ((List<object>)(object)levelRanks).get_Item(num);
				nint num5 = (nint)obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ X8_v16 (Il2CppClass<System.Object>)+1B8] (should have been resolved before IL gen)");
				bool flag7 = num >= (nint)obj7;
				enumerator4 = (List<object>.Enumerator)1.0;
				if (!flag7)
				{
					object obj26 = ((List<object>)(object)levelRanks).get_Item(num);
					bool flag8 = obj26 == null;
					object obj27 = !flag8;
					if (obj27 == null)
					{
						throw new NullReferenceException();
					}
					nint num6 = (nint)obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v534 @ X8_v18 (Il2CppClass<System.Object>)+1B8] (should have been resolved before IL gen)");
					enumerator4 = (List<object>.Enumerator)1053609165;
				}
				flag9 = num2 == 8;
				num = num2;
			}
			while (!flag9);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E6C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	protected unsafe virtual void InitCurrentStage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected I4, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_0071: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "SetRoomVariables request error" + 2544;
		object obj2 = (nint)0 + (nint)3072;
		int num = this + 136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize((string)input);
		string text2 = ((int*)num)->ToString();
		string text3 = text + (string)obj2 + text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v2 (System.Int32)-58]");
		TextMeshProExtensions.FixArabic((TextMeshProUGUI)0, text3);
		Transform transform = FTStageIndicator.transform;
		int index = ((int*)num)->m_value - 1;
		object obj5 = ((List<object>)(object)levelRanks).get_Item(index);
		Transform transform2 = ((Component)obj5).transform;
		int siblingIndex = transform2.GetSiblingIndex();
		transform.SetSiblingIndex(siblingIndex);
		object obj6 = ((List<object>)(object)levelRanks).get_Item(index);
		GameObject gameObject = ((Component)obj6).gameObject;
		gameObject.SetActive(value: false);
	}

	protected unsafe virtual void InitHearts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_03ef: Expected O, but got I4
		//IL_03fd: Expected O, but got I4
		//IL_0406: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		//IL_041d: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_04b3: Expected O, but got I4
		//IL_044b: Expected O, but got I
		//IL_0465: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_0544: Expected I, but got O
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_050f: Expected O, but got I
		//IL_1497: Expected O, but got I
		//IL_14b1: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_05b6: Expected I, but got O
		//IL_057f: Expected O, but got I
		//IL_170e: Expected O, but got I
		//IL_171e: Expected O, but got I
		//IL_1740: Expected O, but got I4
		//IL_1542: Expected O, but got I
		//IL_14df: Expected I, but got O
		//IL_1501: Expected O, but got I4
		//IL_02b3: Expected native int or pointer, but got F4
		//IL_02bc: Expected I4, but got F4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected I4, but got Unknown
		//IL_060f: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_027a: Expected O, but got I4
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected O, but got Unknown
		//IL_15a8: Expected O, but got I4
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected O, but got Unknown
		//IL_1780: Expected O, but got I
		//IL_1791: Expected I, but got O
		//IL_17af: Expected O, but got I
		//IL_17ca: Expected O, but got I4
		//IL_0625: Expected O, but got I
		//IL_02aa: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_063e: Expected O, but got I
		//IL_0661: Expected O, but got I4
		//IL_066a: Expected O, but got I4
		//IL_1693: Expected O, but got I
		//IL_068b: Expected I4, but got O
		//IL_0362: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_06a5: Expected O, but got I
		//IL_1384: Expected O, but got I4
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_0826: Expected F4, but got I4
		//IL_082f: Expected O, but got I4
		//IL_1624: Expected O, but got I4
		//IL_162d: Expected O, but got I4
		//IL_163b: Expected O, but got I4
		//IL_0d50: Expected O, but got I
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected O, but got Unknown
		//IL_0d7d: Expected F4, but got I4
		//IL_0d8d: Expected O, but got I4
		//IL_08e3: Expected O, but got I4
		//IL_08ec: Expected O, but got I4
		//IL_139f: Expected I, but got O
		//IL_13af: Expected O, but got I
		//IL_13ed: Expected O, but got I4
		//IL_0eb4: Expected O, but got I4
		//IL_0ebd: Expected F4, but got I4
		//IL_0ece: Expected O, but got I4
		//IL_06d1: Expected I4, but got O
		//IL_0928: Expected I4, but got O
		//IL_1414: Expected O, but got I4
		//IL_0f2b: Expected O, but got I4
		//IL_0f34: Expected F4, but got I4
		//IL_0d3f: Expected O, but got I4
		//IL_06e7: Expected I4, but got O
		//IL_0711: Expected O, but got I4
		//IL_094e: Expected I, but got O
		//IL_1450: Expected O, but got I4
		//IL_0f7b: Expected I, but got O
		//IL_0a43: Expected O, but got I
		//IL_0a5d: Expected O, but got I4
		//IL_10b2: Expected O, but got I
		//IL_10cc: Expected O, but got I4
		//IL_09ae: Expected I, but got O
		//IL_0989: Expected O, but got I
		//IL_0fdb: Expected I, but got O
		//IL_0fb6: Expected O, but got I
		//IL_0ad3: Expected O, but got I4
		//IL_0adc: Expected O, but got I4
		//IL_0a78: Expected I, but got O
		//IL_0a9a: Expected O, but got I4
		//IL_0785: Expected I4, but got O
		//IL_078e: Expected O, but got I4
		//IL_1154: Expected O, but got I4
		//IL_115d: Expected F4, but got I4
		//IL_116e: Expected O, but got I4
		//IL_10e8: Expected I, but got O
		//IL_110a: Expected O, but got I4
		//IL_09ff: Expected O, but got I4
		//IL_102c: Expected O, but got I4
		//IL_0b00: Expected O, but got I
		//IL_0b1a: Expected O, but got I4
		//IL_11b2: Expected O, but got I
		//IL_11cc: Expected O, but got I4
		//IL_08a2: Expected I4, but got O
		//IL_0a15: Expected O, but got I4
		//IL_0a1e: Expected O, but got I4
		//IL_0e38: Expected O, but got I4
		//IL_0e41: Expected F4, but got I4
		//IL_1053: Expected O, but got I4
		//IL_105c: Expected F4, but got I4
		//IL_106d: Expected O, but got I4
		//IL_0b41: Expected O, but got I4
		//IL_0b4a: Expected O, but got I4
		//IL_1204: Expected O, but got I4
		//IL_120d: Expected F4, but got I4
		//IL_121e: Expected O, but got I4
		//IL_0b5c: Expected native int or pointer, but got F4
		//IL_0b65: Expected I4, but got F4
		//IL_0b8f: Expected O, but got I4
		//IL_0b97: Expected O, but got I4
		//IL_0ba0: Expected O, but got I4
		//IL_1254: Expected I4, but got O
		//IL_128f: Expected O, but got I4
		//IL_1298: Expected F4, but got I4
		//IL_12a9: Expected O, but got I4
		//IL_12b9: Expected O, but got I4
		//IL_0bd2: Expected O, but got I4
		//IL_0be0: Expected O, but got I4
		//IL_12fc: Expected O, but got I
		//IL_131e: Expected O, but got I4
		//IL_0de0: Expected F4, but got I4
		//IL_0de8: Expected O, but got F4
		//IL_0c15: Expected O, but got I4
		//IL_0c1e: Expected O, but got I4
		//IL_0c30: Expected O, but got I4
		//IL_1347: Expected F4, but got I4
		//IL_0c42: Expected native int or pointer, but got F4
		//IL_0c4b: Expected I4, but got F4
		//IL_0c75: Expected O, but got I4
		//IL_0c7d: Expected O, but got I4
		//IL_0c86: Expected O, but got I4
		//IL_0cb9: Expected O, but got I
		//IL_0cdb: Expected O, but got I4
		//IL_0858: Expected O, but got I4
		//IL_0860: Expected O, but got I4
		//IL_0cfc: Expected F4, but got I4
		object obj = 152993792;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89A7]");
		object obj3 = (nint)0 & (nint)1;
		List<object>.Enumerator enumerator;
		Component component;
		object obj5;
		Component component2;
		object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v127+E4]");
			bool flag = (nint)0 == 0;
			component = null;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			component2 = null;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_00ab;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v127+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			component = null;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			component2 = null;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			if (obj7 != null)
			{
				goto IL_00ab;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BF]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		component = component2;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_00ee;
		}
		goto IL_0483;
		IL_1832:
		int num;
		int num2;
		if (num >= num2)
		{
			goto IL_1354;
		}
		object obj10 = (nint)0 + (nint)872;
		object obj11 = typeof(SqlSingle[]) + 3912;
		double num4 = default(double);
		double num3 = num4;
		float num6 = default(float);
		float num5 = num6;
		float num7 = 1.06032006E+09f;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator2 = enumerator3;
		int num8;
		Func<object, bool> func = (Func<object, bool>)num8;
		bool flag5;
		bool flag4 = flag5;
		object obj13 = default(object);
		object obj12 = obj13;
		int num9 = num;
		object obj15 = default(object);
		int num12;
		TextMeshProUGUI textMeshProUGUI;
		int num16 = default(int);
		float num10;
		float num11;
		while (true)
		{
			List<Image> fTHeartsList = FTHeartsList;
			bool flag6 = FTHeartsList == null;
			num4 = num3;
			num6 = num5;
			object obj14 = 1;
			num10 = 1.0712385E+09f;
			num11 = num7;
			obj15 = 146685952;
			enumerator3 = enumerator2;
			flag5 = flag4;
			obj13 = obj12;
			num = num9;
			if (flag6)
			{
				break;
			}
			bool flag7 = num9 >= fTHeartsList._size;
			num4 = num3;
			num6 = num5;
			obj14 = 1;
			num10 = 1.0712385E+09f;
			num11 = num7;
			num12 = 146685952;
			enumerator3 = enumerator2;
			flag5 = flag4;
			obj13 = obj12;
			num = num9;
			nint num14;
			if (!flag7)
			{
				nint num13 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v52 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
					object obj16 = (nint)0 & (nint)1;
					if (obj16 != null)
					{
						goto IL_0fd3;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
					object obj17 = (nint)0 & (nint)1;
					bool flag8 = obj17 == null;
					object obj18 = !flag8;
					if (obj18 != null)
					{
						goto IL_0fd3;
					}
				}
				_ = 1;
				num14 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v62 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 != null)
				{
					goto IL_1008;
				}
				goto IL_1118;
			}
			goto IL_1354;
			IL_1008:
			ProfilerMarker k_SetArraySizesMarker = TextMeshProUGUI.k_SetArraySizesMarker;
			bool flag10 = (object)TextMeshProUGUI.k_SetArraySizesMarker == null;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				num4 = num3;
				num6 = num5;
				obj14 = 1;
				num10 = 1.0712385E+09f;
				num11 = num7;
				obj15 = 146685952;
				enumerator3 = enumerator2;
				flag5 = flag4;
				obj13 = obj12;
				num = num9;
				break;
			}
			goto IL_119c;
			IL_0fd3:
			nint num15 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X0_v72 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
			bool flag11 = (nint)0 == 0;
			num14 = num15;
			if (!flag11)
			{
				goto IL_1008;
			}
			goto IL_1118;
			IL_119c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v39 (Unity.Profiling.ProfilerMarker)+30]");
			object obj21 = (nint)0 & (nint)1;
			bool flag12 = obj21 == null;
			object obj22 = !flag12;
			if (obj22 == null)
			{
				bool flag13 = FTHeartsList == null;
				num4 = num3;
				num6 = num5;
				obj14 = 1;
				num10 = 1.0712385E+09f;
				num11 = num7;
				obj15 = 146685952;
				enumerator3 = enumerator2;
				flag5 = flag4;
				obj13 = obj12;
				num = num9;
				if (flag13)
				{
					break;
				}
				flag5 = (byte)(int)obj10 != 0;
				object obj23 = ((List<object>)(object)FTHeartsList).get_Item(num9);
				bool flag14 = obj23 == null;
				num4 = num3;
				num6 = num5;
				obj14 = 1;
				num10 = 1.0712385E+09f;
				num11 = num7;
				obj15 = 146685952;
				enumerator3 = enumerator2;
				func = (Func<object, bool>)num9;
				obj13 = obj12;
				num = num9;
				if (flag14)
				{
					break;
				}
				RectTransform rectTransform = ((Graphic)obj23).rectTransform;
				object obj24 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v41+E4]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v41+E4]");
				bool flag15 = (nint)0 == 0;
				object obj25 = !flag15;
				Transform rect = rectTransform;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num7 = 1.06032006E+09f;
					rect = rectTransform;
				}
				AnimationExtensions.AnimHeartGain(rect, 0, num7);
				num3 = 1.0;
				num5 = 1.0712385E+09f;
				enumerator2 = (List<object>.Enumerator)num7;
				func = null;
				flag4 = false;
			}
			num9++;
			bool flag16 = num9 >= ((int*)num16)->m_value;
			num4 = num3;
			num6 = num5;
			obj14 = 1;
			num10 = 1.0712385E+09f;
			num11 = num7;
			num12 = 146685952;
			enumerator3 = enumerator2;
			flag5 = flag4;
			obj13 = obj12;
			num = num9;
			if (!flag16)
			{
				continue;
			}
			goto IL_1354;
			IL_1118:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			k_SetArraySizesMarker = TextMeshProUGUI.k_SetArraySizesMarker;
			bool flag17 = (object)TextMeshProUGUI.k_SetArraySizesMarker == null;
			num4 = num3;
			num6 = num5;
			obj14 = 1;
			num10 = 1.0712385E+09f;
			num11 = num7;
			obj15 = 146685952;
			enumerator3 = enumerator2;
			flag5 = flag4;
			obj13 = obj12;
			num = num9;
			if (flag17)
			{
				break;
			}
			goto IL_119c;
		}
		goto IL_15ed;
		IL_1646:
		bool flag18 = (nint)func != 1;
		NullReferenceException ex2;
		NullReferenceException ex = ex2;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj26 = (nint)0 + (nint)2120;
			func = (Func<object, bool>)obj26;
			enumerator4.Dispose();
			object obj27 = default(object);
			bool flag19 = obj27 == null;
			enumerator5 = (List<object>.Enumerator)obj27;
			enumerator = enumerator4;
			if (flag19)
			{
				goto IL_066f;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator5 = (List<object>.Enumerator)obj27;
			ex = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_15fb:
		ex2 = new NullReferenceException();
		enumerator4 = enumerator;
		goto IL_1646;
		IL_00ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BF]");
		object obj28 = (nint)0 & (nint)1;
		bool flag20 = obj28 == null;
		component2 = component;
		obj6 = obj5;
		if (!flag20)
		{
			goto IL_00ee;
		}
		goto IL_0483;
		IL_0483:
		_ = 1;
		object obj29 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v174+E4]");
		bool flag21 = (nint)0 == 0;
		object obj30 = !flag21;
		component = component2;
		obj5 = obj6;
		object obj31 = obj29;
		if (obj30 != null)
		{
			goto IL_0133;
		}
		goto IL_04d9;
		IL_00ee:
		obj29 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v174+E4]");
		bool flag22 = (nint)0 == 0;
		obj31 = obj29;
		component2 = component;
		obj6 = obj5;
		if (!flag22)
		{
			goto IL_0133;
		}
		goto IL_04d9;
		IL_04d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj32 = obj2;
		TextMeshProUGUI textMeshProUGUI2 = (TextMeshProUGUI)(typeof(UsageHint) + 72);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v121+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v98+14]");
		bool flag23 = (nint)0 == 2;
		textMeshProUGUI = textMeshProUGUI2;
		if (flag23)
		{
			goto IL_0187;
		}
		goto IL_053c;
		IL_0133:
		textMeshProUGUI2 = (TextMeshProUGUI)(typeof(UsageHint) + 72);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v174+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v111+14]");
		bool flag24 = (nint)0 != 2;
		textMeshProUGUI = textMeshProUGUI2;
		if (!flag24)
		{
			goto IL_0187;
		}
		goto IL_053c;
		IL_053c:
		nint num17 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v104 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
		int num18;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj35 = (nint)0 & (nint)1;
			bool flag25 = obj35 == null;
			num18 = 146685952;
			num = 146685952;
			if (!flag25)
			{
				goto IL_05ae;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj36 = (nint)0 & (nint)1;
			bool flag26 = obj36 == null;
			object obj37 = !flag26;
			num18 = 146685952;
			num = 146685952;
			if (obj37 != null)
			{
				goto IL_05ae;
			}
		}
		_ = 1;
		nint num19 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v107 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
		bool flag27 = (nint)0 == 0;
		object obj38 = !flag27;
		num18 = num;
		if (obj38 != null)
		{
			goto IL_05eb;
		}
		goto IL_1517;
		IL_1354:
		textMeshProUGUI = counter;
		string text = ((int*)num16)->ToString();
		bool flag28 = (object)counter == null;
		obj15 = num12;
		func = null;
		if (!flag28)
		{
			nint num20 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v33 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v33 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			flag5 = false;
			counter.text = text;
			bool flag29 = ((int*)num16)->m_value == 0;
			object obj39 = !flag29;
			if (obj39 != null)
			{
				return;
			}
			bool flag30 = (object)Heart == null;
			obj15 = num12;
			func = (Func<object, bool>)(object)text;
			if (!flag30)
			{
				GameObject gameObject = Heart.gameObject;
				bool flag31 = (object)gameObject == null;
				obj15 = num12;
				func = null;
				if (!flag31)
				{
					gameObject.SetActive(value: false);
					return;
				}
			}
		}
		goto IL_15ed;
		IL_07a5:
		int num21 = UnityEngine.Random.Range(0, 2);
		num2 = ((int*)num16)->m_value;
		bool flag32 = ((int*)num16)->m_value >= num;
		num8 = 2;
		flag5 = false;
		float num22;
		object obj41;
		object obj42 = default(object);
		bool flag35;
		object obj43;
		object obj40;
		if (!flag32)
		{
			num11 = 0f + 872f;
			object obj14 = typeof(SqlSingle[]) + 3912;
			num10 = 1f;
			func = (Func<object, bool>)2;
			flag5 = false;
			while (true)
			{
				List<Image> fTHeartsList2 = FTHeartsList;
				bool flag33 = FTHeartsList == null;
				obj15 = num21;
				obj40 = 146685952;
				if (flag33)
				{
					break;
				}
				bool flag34 = num2 >= fTHeartsList2._size;
				num22 = num10;
				obj41 = obj42;
				num8 = (int)func;
				flag35 = flag5;
				obj43 = obj13;
				nint num24;
				if (!flag34)
				{
					nint num23 = (nint)textMeshProUGUI;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X0_v75 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
						object obj44 = (nint)0 & (nint)1;
						if (obj44 != null)
						{
							goto IL_09a6;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
						object obj45 = (nint)0 & (nint)1;
						bool flag36 = obj45 == null;
						object obj46 = !flag36;
						if (obj46 != null)
						{
							goto IL_09a6;
						}
					}
					num24 = (nint)textMeshProUGUI;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X0_v88 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
					bool flag37 = (nint)0 == 0;
					object obj47 = !flag37;
					if (obj47 != null)
					{
						goto IL_09db;
					}
					goto IL_0aa8;
				}
				goto IL_0d01;
				IL_09db:
				ProfilerMarker k_SetArraySizesMarker2 = TextMeshProUGUI.k_SetArraySizesMarker;
				bool flag38 = (object)TextMeshProUGUI.k_SetArraySizesMarker == null;
				object obj48 = !flag38;
				if (obj48 == null)
				{
					obj15 = num21;
					obj40 = 146685952;
					break;
				}
				goto IL_0aea;
				IL_09a6:
				nint num25 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X0_v98 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
				bool flag39 = (nint)0 == 0;
				num24 = num25;
				if (!flag39)
				{
					goto IL_09db;
				}
				goto IL_0aa8;
				IL_0aea:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X8_v61 (Unity.Profiling.ProfilerMarker)+30]");
				object obj49 = (nint)0 & (nint)1;
				bool flag40 = obj49 == null;
				object obj50 = !flag40;
				if (obj50 == null)
				{
					bool flag41 = FTHeartsList == null;
					obj15 = num21;
					obj40 = 146685952;
					if (flag41)
					{
						break;
					}
					flag5 = (byte)(int)((float*)(nint)num11)->m_value != 0;
					object obj51 = ((List<object>)(object)FTHeartsList).get_Item(num2);
					bool flag42 = obj51 == null;
					obj15 = num21;
					func = (Func<object, bool>)num2;
					obj40 = 146685952;
					if (flag42)
					{
						break;
					}
					GameObject gameObject2 = ((Component)obj51).gameObject;
					bool flag43 = (object)gameObject2 == null;
					obj15 = num21;
					func = null;
					obj40 = 146685952;
					if (flag43)
					{
						break;
					}
					gameObject2.SetActive(value: true);
					bool flag44 = FTHeartsList == null;
					obj15 = num21;
					func = (Func<object, bool>)1;
					flag5 = false;
					obj40 = 146685952;
					if (flag44)
					{
						break;
					}
					flag5 = (byte)(int)((float*)(nint)num11)->m_value != 0;
					object obj52 = ((List<object>)(object)FTHeartsList).get_Item(num2);
					bool flag45 = obj52 == null;
					obj15 = num21;
					func = (Func<object, bool>)num2;
					obj40 = 146685952;
					if (flag45)
					{
						break;
					}
					RectTransform rectTransform2 = ((Graphic)obj52).rectTransform;
					object obj53 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v63+E4]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v63+E4]");
					bool flag46 = (nint)0 == 0;
					object obj54 = !flag46;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num10 = 1f;
					}
					AnimationExtensions.AnimLoseHeart(rectTransform2, num21);
					obj42 = 0;
					func = (Func<object, bool>)num21;
					flag5 = false;
				}
				num2++;
				bool flag47 = num == num2;
				num22 = num10;
				obj41 = obj42;
				num8 = (int)func;
				flag35 = flag5;
				obj43 = obj13;
				if (!flag47)
				{
					continue;
				}
				goto IL_0d01;
				IL_0aa8:
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				k_SetArraySizesMarker2 = TextMeshProUGUI.k_SetArraySizesMarker;
				bool flag48 = (object)TextMeshProUGUI.k_SetArraySizesMarker == null;
				obj15 = num21;
				obj40 = 146685952;
				if (flag48)
				{
					break;
				}
				goto IL_0aea;
			}
			goto IL_15ed;
		}
		goto IL_1832;
		IL_066f:
		bool flag49 = ((int*)num16)->m_value < 1;
		num12 = (int)obj15;
		if (flag49)
		{
			goto IL_07a5;
		}
		obj15 = (nint)0 + (nint)872;
		int num26 = 0;
		while (true)
		{
			List<object> fTHeartsList3 = (List<object>)(object)FTHeartsList;
			if (FTHeartsList == null)
			{
				break;
			}
			bool flag50 = num26 >= fTHeartsList3._size;
			num12 = (int)obj15;
			if (!flag50)
			{
				flag5 = (byte)(int)obj15 != 0;
				object obj55 = ((List<object>)(object)FTHeartsList).get_Item(num26);
				bool flag51 = obj55 == null;
				func = (Func<object, bool>)num26;
				if (flag51)
				{
					break;
				}
				GameObject gameObject3 = ((Component)obj55).gameObject;
				bool flag52 = (object)gameObject3 == null;
				func = null;
				if (flag52)
				{
					break;
				}
				gameObject3.SetActive(value: true);
				num26++;
				bool flag53 = num26 < ((int*)num16)->m_value;
				num12 = (int)obj15;
				func = (Func<object, bool>)1;
				flag5 = false;
				if (flag53)
				{
					continue;
				}
			}
			goto IL_07a5;
		}
		goto IL_15ed;
		IL_05ae:
		nint num27 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v118 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
		bool flag54 = (nint)0 == 0;
		num19 = num27;
		num = num18;
		if (!flag54)
		{
			goto IL_05eb;
		}
		goto IL_1517;
		IL_1517:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ProfilerMarker k_SetArraySizesMarker3 = TextMeshProUGUI.k_SetArraySizesMarker;
		bool flag55 = (object)TextMeshProUGUI.k_SetArraySizesMarker == null;
		IntPtr intPtr = default(IntPtr);
		func = (Func<object, bool>)(nint)intPtr;
		if (!flag55)
		{
			goto IL_1550;
		}
		goto IL_15ed;
		IL_05eb:
		k_SetArraySizesMarker3 = TextMeshProUGUI.k_SetArraySizesMarker;
		bool flag56 = (object)TextMeshProUGUI.k_SetArraySizesMarker == null;
		object obj56 = !flag56;
		if (obj56 != null)
		{
			goto IL_1550;
		}
		func = (Func<object, bool>)(nint)intPtr;
		num = num18;
		goto IL_15ed;
		IL_1550:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v82 (Unity.Profiling.ProfilerMarker)+2C]");
		num = 0;
		obj40 = typeof(DebugUI.BitField) + 2224;
		List<Image> fTHeartsList4 = FTHeartsList;
		object obj57 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v1+E4]");
		bool flag57 = (nint)0 == 0;
		object obj58 = !flag57;
		IEnumerable<object> source = FTHeartsList;
		object obj59;
		int num28;
		object obj60;
		if (obj58 == null)
		{
			obj59 = obj40;
			obj60 = obj57;
			textMeshProUGUI2 = textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v82 (Unity.Profiling.ProfilerMarker)+2C]");
			num28 = 0;
			goto IL_0211;
		}
		goto IL_16f0;
		IL_15ed:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_15fb;
		IL_0d01:
		num2 = ((int*)num16)->m_value;
		num10 = num22;
		num12 = num21;
		obj42 = obj41;
		flag5 = flag35;
		obj13 = obj43;
		obj40 = 146685952;
		goto IL_1832;
		IL_0187:
		obj59 = typeof(DebugUI.BitField) + 2224;
		fTHeartsList4 = FTHeartsList;
		obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v169+E4]");
		bool flag58 = (nint)0 == 0;
		object obj61 = !flag58;
		num28 = 0;
		source = FTHeartsList;
		obj40 = obj59;
		obj57 = obj60;
		textMeshProUGUI = textMeshProUGUI2;
		num = 0;
		if (obj61 == null)
		{
			goto IL_0211;
		}
		goto IL_16f0;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj57 = obj59;
		source = fTHeartsList4;
		obj40 = obj59;
		textMeshProUGUI = textMeshProUGUI2;
		num = num28;
		goto IL_16f0;
		IL_16f0:
		num11 = 0f + 3552f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v1+B8]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v13+8]");
		Func<object, bool> func2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v13+8]");
		bool flag59 = (nint)0 == 0;
		object obj63 = !flag59;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v1+E4]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v1+E4]");
			bool flag60 = (nint)0 == 0;
			object obj64 = !flag60;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj65 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v19+B8]");
				obj62 = 0;
			}
			obj15 = obj62;
			object obj66 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj67 = (nint)0 + (nint)3680;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj62, (IntPtr)obj67);
			object obj68 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v18+B8]");
			object obj69 = (nint)0 + (nint)8;
			obj69 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj42 = 0;
			func2 = func3;
		}
		flag5 = (byte)(int)((float*)(nint)num11)->m_value != 0;
		int num29 = Enumerable.Count(source, func2);
		num16 = this + 144;
		if (num29 == ((int*)num16)->m_value)
		{
			return;
		}
		bool flag61 = FTHeartsList == null;
		func = func2;
		if (!flag61)
		{
			List<object>.Enumerator enumerator6 = ((List<object>)(object)FTHeartsList).GetEnumerator();
			object obj70 = (nint)0 + (nint)2128;
			Component component3 = default(Component);
			while (true)
			{
				func = (Func<object, bool>)obj70;
				if (!enumerator.MoveNext())
				{
					break;
				}
				bool flag62 = (object)component3 == null;
				enumerator3 = enumerator5;
				enumerator5 = (List<object>.Enumerator)0;
				enumerator = (List<object>.Enumerator)0;
				if (flag62)
				{
					goto IL_15fb;
				}
				GameObject gameObject4 = component3.gameObject;
				if ((object)gameObject4 != null)
				{
					gameObject4.SetActive(value: false);
					flag5 = false;
					continue;
				}
				goto IL_1611;
			}
			object obj71 = (nint)0 + (nint)2120;
			func = (Func<object, bool>)obj71;
			enumerator.Dispose();
			enumerator3 = enumerator5;
			enumerator5 = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			goto IL_066f;
		}
		goto IL_15ed;
		IL_1611:
		ex2 = new NullReferenceException();
		enumerator3 = (List<object>.Enumerator)0;
		enumerator5 = (List<object>.Enumerator)0;
		func = null;
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_1646;
	}

	protected unsafe virtual void InitProgressBreadCrumps()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_1026: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_0efa: Expected O, but got F4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected I4, but got Unknown
		//IL_0091: Expected I, but got O
		//IL_00b1: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_020f: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02c2: Expected O, but got I4
		//IL_02d3: Expected I4, but got O
		//IL_0254: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_0f83: Expected O, but got I
		//IL_0f8b: Expected I4, but got O
		//IL_0fb3: Expected F4, but got O
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0305: Expected O, but got I
		//IL_030d: Expected I, but got O
		//IL_03b5: Expected I, but got O
		//IL_03c1: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_0403: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_01d0: Expected I4, but got O
		//IL_0470: Expected I4, but got O
		//IL_033e: Expected O, but got I
		//IL_035e: Expected O, but got I
		//IL_0380: Expected O, but got I4
		//IL_05e9: Expected O, but got I
		//IL_044b: Expected O, but got I4
		//IL_0775: Expected O, but got I
		//IL_04bc: Expected O, but got I4
		//IL_04c4: Expected I4, but got O
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected O, but got Unknown
		//IL_105e: Expected O, but got I
		//IL_1070: Expected I, but got O
		//IL_1078: Expected I, but got O
		//IL_108e: Expected O, but got I
		//IL_10a9: Expected F4, but got O
		//IL_10ba: Expected O, but got I4
		//IL_095f: Expected O, but got I
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_097b: Expected I4, but got O
		//IL_0e89: Expected F4, but got I4
		//IL_0e92: Expected O, but got I4
		//IL_0e9a: Expected O, but got I4
		//IL_0ea3: Expected O, but got I4
		//IL_04ee: Expected O, but got I
		//IL_10cf: Expected I4, but got O
		//IL_0662: Expected I4, but got O
		//IL_057c: Expected O, but got I
		//IL_0584: Expected I4, but got O
		//IL_059e: Expected F4, but got O
		//IL_05a7: Expected O, but got I4
		//IL_0513: Expected F4, but got O
		//IL_051c: Expected O, but got I4
		//IL_0b0e: Expected O, but got I
		//IL_0b28: Expected O, but got I4
		//IL_0a1f: Expected O, but got I
		//IL_0893: Expected I4, but got O
		//IL_0ba8: Expected O, but got I
		//IL_0bb8: Expected O, but got I
		//IL_0bd8: Expected F4, but got I4
		//IL_0be1: Expected O, but got I4
		//IL_0be9: Expected O, but got I4
		//IL_0bf2: Expected O, but got I4
		//IL_0b6b: Expected O, but got I4
		//IL_0f22: Expected O, but got I4
		//IL_0a86: Expected O, but got I
		//IL_0a96: Expected O, but got I
		//IL_0ab8: Expected O, but got I4
		//IL_08dc: Expected native int or pointer, but got F4
		//IL_0917: Expected O, but got I4
		//IL_0c16: Expected O, but got I
		//IL_0d66: Expected F4, but got I4
		//IL_0d6f: Expected O, but got I4
		//IL_0d77: Expected O, but got I4
		//IL_0d80: Expected O, but got I4
		//IL_0acf: Expected F4, but got I4
		//IL_0ad8: Expected O, but got I4
		//IL_0ae0: Expected O, but got I4
		//IL_0ae9: Expected O, but got I4
		//IL_0c4d: Expected F4, but got I4
		//IL_0c56: Expected O, but got I4
		//IL_0c5e: Expected O, but got I4
		//IL_0c67: Expected O, but got I4
		//IL_0d96: Expected I4, but got O
		//IL_0dc1: Expected F4, but got I4
		//IL_0dca: Expected O, but got I4
		//IL_0dd2: Expected O, but got I4
		//IL_0ddb: Expected O, but got I4
		//IL_0c7d: Expected I4, but got O
		//IL_0ca8: Expected F4, but got I4
		//IL_0cb1: Expected O, but got I4
		//IL_0cb9: Expected O, but got I4
		//IL_0cc2: Expected O, but got I4
		//IL_0e38: Expected O, but got I4
		//IL_119b: Expected F4, but got I4
		//IL_0d1f: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		RankUI rankUI = FTAwardRank;
		int num = FTLevel;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRank playerRank = PlayerRank.FastTrackClaimAward(num, FTStageFixedUI);
		bool flag2 = (object)rankUI == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		bool flag3 = false;
		int num2 = FTStageFixedUI;
		int num4 = default(int);
		object obj4;
		int value2;
		int num5;
		if (!flag2)
		{
			num = typeof(UsageHint) + 72;
			nint num3 = (nint)rankUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v44 (Il2CppClass<RankUI>)+1A8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v44 (Il2CppClass<RankUI>)+1B0]");
			obj4 = 0;
			rankUI.SetRank(playerRank);
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v69 (System.Int32)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					goto IL_012a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj6 = (nint)0 & (nint)1;
				bool flag4 = obj6 == null;
				object obj7 = !flag4;
				if (obj7 != null)
				{
					goto IL_012a;
				}
			}
			_ = 1;
			value2 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v103 (System.Int32)+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			num5 = value2;
			if (obj8 != null)
			{
				goto IL_0165;
			}
			goto IL_026a;
		}
		goto IL_0ed3;
		IL_05ac:
		int num6 = FTRoundsWon;
		bool flag6 = FTRoundsWon < 1;
		bool flag7 = (byte)num2 != 0;
		if (flag6)
		{
			goto IL_074c;
		}
		object obj9 = (nint)0 + (nint)872;
		int num7 = 0;
		int num8 = num4;
		bool flag8 = flag3;
		int fTRoundsWon = FTRoundsWon;
		while (true)
		{
			List<object> fTRoundsBreadCrumps = (List<object>)(object)FTRoundsBreadCrumps;
			bool flag9 = FTRoundsBreadCrumps == null;
			num4 = num8;
			flag3 = flag8;
			if (flag9)
			{
				break;
			}
			num4 = fTRoundsBreadCrumps._size;
			bool flag10 = num7 >= fTRoundsBreadCrumps._size;
			flag3 = flag8;
			flag7 = (byte)num2 != 0;
			num6 = fTRoundsWon;
			if (!flag10)
			{
				flag3 = (byte)(int)obj9 != 0;
				object obj10 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
				bool flag11 = obj10 == null;
				num2 = num7;
				if (flag11)
				{
					break;
				}
				GameObject gameObject = ((Component)obj10).gameObject;
				bool flag12 = (object)gameObject == null;
				num2 = 0;
				if (flag12)
				{
					break;
				}
				gameObject.SetActive(value: true);
				num7++;
				num6 = FTRoundsWon;
				bool flag13 = num7 < FTRoundsWon;
				flag3 = false;
				flag7 = true;
				num8 = fTRoundsBreadCrumps._size;
				flag8 = false;
				num2 = 1;
				fTRoundsWon = FTRoundsWon;
				if (flag13)
				{
					continue;
				}
			}
			goto IL_074c;
		}
		goto IL_0ed3;
		IL_0419:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v84 (Il2CppClass<UnityEngine.RectTransform>)+E4]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v84 (Il2CppClass<UnityEngine.RectTransform>)+E4]");
		bool flag14 = (nint)0 == 0;
		object obj11 = !flag14;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3688;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)RectTransform.reapplyDrivenProperties, (IntPtr)obj13);
		RectTransform rectTransform;
		nint num9 = (nint)rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v63 (Il2CppClass<UnityEngine.RectTransform>)+B8]");
		object obj14 = (nint)0 + (nint)16;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		float num10 = (float)RectTransform.reapplyDrivenProperties;
		object obj16;
		object obj15 = obj16;
		obj4 = 0;
		Func<object, bool> func2 = func;
		goto IL_0468;
		IL_0eff:
		NullReferenceException ex = new NullReferenceException();
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator2 = enumerator3;
		List<object>.Enumerator enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		num2 = 0;
		goto IL_0f36;
		IL_0ed3:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ee1;
		IL_0ee1:
		ex = new NullReferenceException();
		enumerator2 = enumerator;
		float num11 = default(float);
		enumerator4 = (List<object>.Enumerator)num11;
		goto IL_0f36;
		IL_0468:
		flag3 = (byte)(int)obj15 != 0;
		int num12 = Enumerable.Count(FTRoundsBreadCrumps, func2);
		if (num12 == FTRoundsWon)
		{
			return;
		}
		bool flag15 = FTRoundsBreadCrumps == null;
		enumerator = (List<object>.Enumerator)0;
		num2 = (int)func2;
		if (!flag15)
		{
			List<object>.Enumerator enumerator5 = ((List<object>)(object)FTRoundsBreadCrumps).GetEnumerator();
			object obj17 = (nint)0 + (nint)2128;
			Component component = default(Component);
			while (true)
			{
				num2 = (int)obj17;
				if (!enumerator.MoveNext())
				{
					break;
				}
				bool flag16 = (object)component == null;
				enumerator = enumerator3;
				num11 = (float)enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				if (flag16)
				{
					goto IL_0ee1;
				}
				GameObject gameObject2 = component.gameObject;
				if ((object)gameObject2 != null)
				{
					gameObject2.SetActive(value: false);
					flag3 = false;
					continue;
				}
				goto IL_0eff;
			}
			object obj18 = (nint)0 + (nint)2120;
			num2 = (int)obj18;
			enumerator.Dispose();
			enumerator = enumerator3;
			num11 = (float)enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			goto IL_05ac;
		}
		goto IL_0ed3;
		IL_012a:
		value2 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v103 (System.Int32)+E4]");
		bool flag17 = (nint)0 == 0;
		num5 = value2;
		if (!flag17)
		{
			goto IL_0165;
		}
		goto IL_026a;
		IL_026a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int value3 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v96 (System.Int32)+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v69+8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v69+8]");
		bool flag18 = (nint)0 == 0;
		enumerator = (List<object>.Enumerator)0;
		flag3 = false;
		num2 = (int)playerRank;
		if (!flag18)
		{
			goto IL_02e1;
		}
		goto IL_0ed3;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v103 (System.Int32)+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v76+8]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v76+8]");
		bool flag19 = (nint)0 == 0;
		object obj22 = !flag19;
		if (obj22 != null)
		{
			goto IL_02e1;
		}
		enumerator = (List<object>.Enumerator)0;
		flag3 = false;
		num2 = (int)playerRank;
		goto IL_0ed3;
		IL_02e1:
		rectTransform = (RectTransform)(typeof(DebugUI.BitField) + 2224);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v46+28]");
		rankUI = (RankUI)0;
		nint num13 = (nint)rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v71 (Il2CppClass<UnityEngine.RectTransform>)+E4]");
		if ((nint)0 != 0)
		{
			obj15 = (nint)0 + (nint)3552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v71 (Il2CppClass<UnityEngine.RectTransform>)+B8]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v67 (Il2CppStaticFields<UnityEngine.RectTransform>)+10]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v67 (Il2CppStaticFields<UnityEngine.RectTransform>)+10]");
			bool flag20 = (nint)0 == 0;
			object obj23 = !flag20;
			if (obj23 == null)
			{
				obj16 = obj15;
				nint num15 = num13;
				goto IL_0419;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num15 = (nint)rectTransform;
			obj16 = (nint)0 + (nint)3552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v84 (Il2CppClass<UnityEngine.RectTransform>)+B8]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v66 (Il2CppStaticFields<UnityEngine.RectTransform>)+10]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v66 (Il2CppStaticFields<UnityEngine.RectTransform>)+10]");
			bool flag21 = (nint)0 == 0;
			object obj24 = !flag21;
			obj15 = obj16;
			if (obj24 == null)
			{
				goto IL_0419;
			}
		}
		goto IL_0468;
		IL_1132:
		if ((nint)rankUI >= num6)
		{
			return;
		}
		object obj25 = (nint)0 + (nint)872;
		object obj26 = typeof(SqlSingle[]) + 3912;
		int num17 = (int)rankUI;
		num2 = (flag7 ? 1 : 0);
		while (true)
		{
			List<Image> fTRoundsBreadCrumps2 = FTRoundsBreadCrumps;
			bool flag22 = FTRoundsBreadCrumps == null;
			num10 = 1.06032006E+09f;
			obj15 = 1;
			rankUI = (RankUI)num17;
			rectTransform = (RectTransform)1071238496;
			if (flag22)
			{
				break;
			}
			if (num17 >= fTRoundsBreadCrumps2._size)
			{
				return;
			}
			int value4 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X0_v28 (System.Int32)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj27 = (nint)0 & (nint)1;
				if (obj27 != null)
				{
					goto IL_0a3c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj28 = (nint)0 & (nint)1;
				bool flag23 = obj28 == null;
				object obj29 = !flag23;
				if (obj29 != null)
				{
					goto IL_0a3c;
				}
			}
			_ = 1;
			int value5 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v51 (System.Int32)+E4]");
			bool flag24 = (nint)0 == 0;
			object obj30 = !flag24;
			int num18 = value5;
			if (obj30 != null)
			{
				goto IL_0a76;
			}
			goto IL_0b81;
			IL_0a76:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v51 (System.Int32)+B8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X8_v32+8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X8_v32+8]");
			bool flag25 = (nint)0 == 0;
			object obj33 = !flag25;
			if (obj33 == null)
			{
				num10 = 1.06032006E+09f;
				obj15 = 1;
				rankUI = (RankUI)num17;
				rectTransform = (RectTransform)1071238496;
				break;
			}
			goto IL_0c00;
			IL_0a3c:
			value5 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v51 (System.Int32)+E4]");
			bool flag26 = (nint)0 == 0;
			num18 = value5;
			if (!flag26)
			{
				goto IL_0a76;
			}
			goto IL_0b81;
			IL_0c00:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v19+31]");
			object obj34 = (nint)0 & (nint)1;
			if (obj34 != null)
			{
				bool flag27 = FTRoundsBreadCrumps == null;
				num10 = 1.06032006E+09f;
				obj15 = 1;
				rankUI = (RankUI)num17;
				rectTransform = (RectTransform)1071238496;
				if (flag27)
				{
					break;
				}
				flag3 = (byte)(int)obj25 != 0;
				object obj35 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num17);
				bool flag28 = obj35 == null;
				num10 = 1.06032006E+09f;
				obj15 = 1;
				rankUI = (RankUI)num17;
				rectTransform = (RectTransform)1071238496;
				num2 = num17;
				if (flag28)
				{
					break;
				}
				RectTransform rectTransform2 = ((Graphic)obj35).rectTransform;
				object obj36 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v23+E4]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v23+E4]");
				bool flag29 = (nint)0 == 0;
				object obj37 = !flag29;
				Transform rect = rectTransform2;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					rect = rectTransform2;
				}
				AnimationExtensions.AnimEmphasise(rect, num17);
				num17++;
				bool flag30 = num17 < FTRoundsWon;
				flag3 = false;
				num2 = num17;
				if (!flag30)
				{
					return;
				}
				continue;
			}
			bool flag31 = FTRoundsBreadCrumps == null;
			num10 = 1.06032006E+09f;
			obj15 = 1;
			rankUI = (RankUI)num17;
			rectTransform = (RectTransform)1071238496;
			if (flag31)
			{
				break;
			}
			flag3 = (byte)(int)obj25 != 0;
			object obj38 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num17);
			bool flag32 = obj38 == null;
			num10 = 1.06032006E+09f;
			obj15 = 1;
			rankUI = (RankUI)num17;
			rectTransform = (RectTransform)1071238496;
			num2 = num17;
			if (flag32)
			{
				break;
			}
			RectTransform rectTransform3 = ((Graphic)obj38).rectTransform;
			object obj39 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v21+E4]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v21+E4]");
			bool flag33 = (nint)0 == 0;
			object obj40 = !flag33;
			Transform rect2 = rectTransform3;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				rect2 = rectTransform3;
			}
			AnimationExtensions.AnimHeartGain(rect2, num17);
			num17++;
			bool flag34 = num17 >= FTRoundsWon;
			num11 = 1.06032006E+09f;
			flag3 = false;
			num2 = num17;
			if (flag34)
			{
				return;
			}
			continue;
			IL_0b81:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int value6 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v45 (System.Int32)+B8]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X8_v26+8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X8_v26+8]");
			bool flag35 = (nint)0 == 0;
			num10 = 1.06032006E+09f;
			obj15 = 1;
			rankUI = (RankUI)num17;
			rectTransform = (RectTransform)1071238496;
			if (flag35)
			{
				break;
			}
			goto IL_0c00;
		}
		goto IL_0ed3;
		IL_0f36:
		bool flag36 = num2 != 1;
		NullReferenceException ex3 = ex;
		if (!flag36)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj42 = (nint)0 + (nint)2120;
			num2 = (int)obj42;
			enumerator2.Dispose();
			object obj43 = default(object);
			bool flag37 = obj43 == null;
			enumerator = enumerator2;
			num11 = (float)enumerator4;
			enumerator3 = (List<object>.Enumerator)obj43;
			if (flag37)
			{
				goto IL_05ac;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj43;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_074c:
		if ((nint)rankUI >= 1)
		{
			object obj44 = (nint)0 + (nint)872;
			num10 = (float)typeof(SqlSingle[]) + 3912f;
			int num19 = 0;
			num2 = (flag7 ? 1 : 0);
			while (true)
			{
				List<object> fTRoundsBreadCrumps3 = (List<object>)(object)FTRoundsBreadCrumps;
				if (FTRoundsBreadCrumps == null)
				{
					break;
				}
				num4 = fTRoundsBreadCrumps3._size;
				num6 = FTRoundsWon;
				bool flag38 = num19 >= fTRoundsBreadCrumps3._size;
				flag7 = (byte)num2 != 0;
				if (!flag38)
				{
					bool flag39 = num19 >= FTRoundsWon;
					flag7 = (byte)num2 != 0;
					if (!flag39)
					{
						flag3 = (byte)(int)obj44 != 0;
						object obj45 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num19);
						bool flag40 = obj45 == null;
						num2 = num19;
						if (flag40)
						{
							break;
						}
						RectTransform rectTransform4 = ((Graphic)obj45).rectTransform;
						float value7 = ((float*)(nint)num10)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v39 (System.Single)+E4]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v39 (System.Single)+E4]");
						bool flag41 = (nint)0 == 0;
						object obj46 = !flag41;
						Transform rect3 = rectTransform4;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							rect3 = rectTransform4;
						}
						AnimationExtensions.AnimEmphasise(rect3, num19);
						flag3 = false;
						flag7 = (byte)num19 != 0;
					}
					num19++;
					bool flag42 = (nint)rankUI == num19;
					num2 = (flag7 ? 1 : 0);
					if (!flag42)
					{
						continue;
					}
					num6 = FTRoundsWon;
				}
				goto IL_1132;
			}
			goto IL_0ed3;
		}
		goto IL_1132;
	}
}
