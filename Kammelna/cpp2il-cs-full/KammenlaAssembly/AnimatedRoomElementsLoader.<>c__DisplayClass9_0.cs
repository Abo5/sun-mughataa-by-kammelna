using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class AnimatedRoomElementsLoader
{
	private sealed class <>c__DisplayClass9_0
	{
		public int elementIndex;

		public AnimatedRoomElementsLoader <>4__this;

		internal void <BuildLoadQueue>b__0()
		{
			<>4__this.LoadImage(elementIndex);
		}

		internal void <BuildLoadQueue>b__1()
		{
			<>4__this.LoadAudio(elementIndex);
		}

		internal void <BuildLoadQueue>b__2()
		{
			<>4__this.LoadSpineAnimation(elementIndex);
		}

		internal void <BuildLoadQueue>b__3()
		{
			<>4__this.LoadSpineAtlas(elementIndex);
		}
	}

	private readonly int _itemID;

	private readonly UnityEngine.Object _owner;

	private readonly Queue<Action> _loadQueue;

	private AnimatedRoomDataModel _model;

	private bool _fired;

	private Action<AnimatedRoomDataModel> _callback;

	public AnimatedRoomElementsLoader(int itemID, UnityEngine.Object owner)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Queue<object> queue = default(Queue<object>);
		queue..ctor();
		object obj2 = this + 32;
		obj2 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj3 = this + 24;
		obj3 = owner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Load(Action<AnimatedRoomDataModel> callback)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_012b: Expected O, but got I
		//IL_0139: Expected I, but got O
		object obj = this + 56;
		if (obj != null)
		{
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj3 = "Added Tournament Prizes And Features" + 1632;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			KLogger.LogWarning(obj3);
			return;
		}
		Action<AnimatedRoomDataModel> action = default(Action<AnimatedRoomDataModel>);
		obj = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = typeof(Queue<string>) + 864;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = (nint)0 + (nint)2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1848;
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj11);
		StringCacher stringCacher = default(StringCacher);
		stringCacher.LoadItemAnimationData(_itemID, _owner, action2);
	}

	private void OnRoomDataLoaded(string json)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7905]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(json);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_009a;
		}
		goto IL_0120;
		IL_009a:
		FireOnce(null);
		return;
		IL_0120:
		object obj6 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3021E4C");
		object obj7 = default(object);
		JsonUtility.FromJsonOverwrite(json, obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3 (System.Object)+38]");
		object obj8 = 0;
		object obj9 = typeof(SqlSingle[]) + 3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X22_v4+18]");
		AnimatedRoomDataModel animatedRoomDataModel = default(AnimatedRoomDataModel);
		animatedRoomDataModel..ctor(0);
		object obj10 = animatedRoomDataModel + 16;
		obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = this + 40;
		obj11 = animatedRoomDataModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		BuildLoadQueue((AnimatedRoomDataInfo)obj7);
		DequeueNext();
		return;
		IL_0074:
		if (StringsExtensions.IsNullOrEmpty(json))
		{
			goto IL_009a;
		}
		goto IL_0120;
	}

	private void BuildLoadQueue(AnimatedRoomDataInfo roomInfo)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_003a: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_013e: Expected I, but got O
		//IL_0172: Expected I, but got O
		//IL_017f: Expected I, but got O
		//IL_01c0: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_021d: Expected O, but got I
		//IL_022e: Expected I, but got O
		//IL_025d: Expected O, but got I
		//IL_026e: Expected I, but got O
		//IL_028a: Expected O, but got I4
		//IL_0050: Expected I, but got O
		//IL_0068: Expected O, but got I4
		AnimatedRoomDataModel model = _model;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)872;
		object obj3 = (nint)0 + (nint)3528;
		object obj4 = 32;
		object obj5 = 0;
		object obj7 = default(object);
		Action action = default(Action);
		Action action2 = default(Action);
		Action action3 = default(Action);
		Action action4 = default(Action);
		while (true)
		{
			int elementCount = model.ElementCount;
			if ((nint)obj5 >= elementCount)
			{
				return;
			}
			object obj6 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj7..ctor();
			object obj8 = obj7 + 24;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)3520;
			action..ctor(obj7, (IntPtr)obj9);
			((Queue<object>)(object)_loadQueue).Enqueue((object)action);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor(obj7, (IntPtr)obj3);
			nint num = (nint)obj2;
			((Queue<object>)(object)_loadQueue).Enqueue((object)action2);
			AnimatedRoomElementInfo[] elements = roomInfo.Elements;
			bool flag = (nint)obj5 < elements.Length;
			object obj10 = !flag;
			if (obj10 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v10 (AnimatedRoomElementInfo[])+v146 @ X27_v5]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			object obj12 = 0;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)3536;
				action3..ctor(obj7, (IntPtr)obj13);
				((Queue<object>)(object)_loadQueue).Enqueue((object)action3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)3544;
				action4..ctor(obj7, (IntPtr)obj14);
				bool flag3 = _loadQueue == null;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					throw new NullReferenceException();
				}
				num = (nint)obj2;
				((Queue<object>)(object)_loadQueue).Enqueue((object)action4);
				obj12 = 0;
			}
			obj4 += 96;
			obj5++;
			model = _model;
		}
		throw new IndexOutOfRangeException();
	}

	private void DequeueNext()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0133: Expected O, but got I
		if (_fired)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			if (_owner == null)
			{
				goto IL_0072;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = _owner == null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_0072;
			}
		}
		Queue<object> loadQueue = (Queue<object>)(object)_loadQueue;
		if (loadQueue._size != 0)
		{
			object obj4 = loadQueue.Dequeue();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10 (System.Object)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10 (System.Object)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10 (System.Object)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X2_v2 (should have been resolved before IL gen)");
		}
		bool flag3 = _model.IsValid();
		bool flag4 = !flag3;
		AnimatedRoomDataModel result = null;
		if (!flag4)
		{
			result = _model;
		}
		FireOnce(result);
		return;
		IL_0072:
		FireOnce(null);
	}

	private void LoadImage(int elementIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 760;
		object obj2 = (nint)0 + (nint)2040;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 688;
		object obj4 = (nint)0 + (nint)1824;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, int> action = default(Action<object, int>);
		action..ctor((object)this, (IntPtr)obj4);
		ImageCacher imageCacher = default(ImageCacher);
		imageCacher.LoadAnimatedRoomImage(_itemID, elementIndex, _owner, action);
	}

	private void LoadAudio(int elementIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 704;
		object obj2 = (nint)0 + (nint)1920;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 224;
		object obj4 = (nint)0 + (nint)1816;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, int> action = default(Action<object, int>);
		action..ctor((object)this, (IntPtr)obj4);
		AudioCacher audioCacher = default(AudioCacher);
		audioCacher.LoadRoomElementAudio(_itemID, elementIndex, _owner, action);
	}

	private void LoadSpineAnimation(int elementIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 864;
		object obj2 = (nint)0 + (nint)2232;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 744;
		object obj4 = (nint)0 + (nint)1832;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, int> action = default(Action<object, int>);
		action..ctor((object)this, (IntPtr)obj4);
		StringCacher stringCacher = default(StringCacher);
		stringCacher.LoadRoomAnimationData(_itemID, elementIndex, StringCacher.RoomElementDataType.RoomSpineAnimation, _owner, action);
	}

	private void LoadSpineAtlas(int elementIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 864;
		object obj2 = (nint)0 + (nint)2232;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 744;
		object obj4 = (nint)0 + (nint)1840;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, int> action = default(Action<object, int>);
		action..ctor((object)this, (IntPtr)obj4);
		StringCacher stringCacher = default(StringCacher);
		stringCacher.LoadRoomAnimationData(_itemID, elementIndex, StringCacher.RoomElementDataType.RoomSpineAtlas, _owner, action);
	}

	private void FireOnce(AnimatedRoomDataModel result)
	{
		//IL_02c5: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_005b: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		//IL_032c: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_0142: Expected I, but got O
		//IL_014c: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_00eb: Expected I, but got O
		//IL_016f: Expected O, but got I
		//IL_0103: Expected I, but got O
		//IL_01ac: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		bool flag = !_fired;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		_fired = true;
		Action<AnimatedRoomDataModel> callback = _callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7 (System.Action`1<AnimatedRoomDataModel>)+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ X8_v7 (System.Action`1<AnimatedRoomDataModel>)+18] (should have been resolved before IL gen)");
		object obj2 = 0;
		AnimatedRoomDataModel animatedRoomDataModel2 = default(AnimatedRoomDataModel);
		AnimatedRoomDataModel animatedRoomDataModel = animatedRoomDataModel2;
		object obj4 = default(object);
		object obj3 = obj4;
		UnityEngine.Object obj5 = (UnityEngine.Object)152989696;
		object obj6 = 0;
		IntPtr intPtr = default(IntPtr);
		object obj15 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ stack_-38_v3+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ stack_-38_v3+28]");
			nint num2;
			UnityEngine.Object obj10;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v10+10]");
				obj5 = (UnityEngine.Object)0;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v10+10]");
					bool flag2 = (UnityEngine.Object)0 != null;
					bool flag3 = !flag2;
					object obj9 = !flag3;
					num2 = unchecked((nint)null);
					obj10 = null;
					if (obj9 != null)
					{
						goto IL_015f;
					}
					num = unchecked((nint)null);
					animatedRoomDataModel = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v10+10]");
					bool flag4 = (UnityEngine.Object)0 != null;
					bool flag5 = !flag4;
					num2 = unchecked((nint)null);
					obj10 = null;
					num = unchecked((nint)null);
					animatedRoomDataModel = null;
					if (!flag5)
					{
						goto IL_015f;
					}
				}
			}
			goto IL_020e;
			IL_020e:
			bool flag6 = obj6 == null;
			object obj11 = !flag6;
			obj2 = 0;
			obj5 = (UnityEngine.Object)152989696;
			if (obj11 == null)
			{
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			num2 = intPtr;
			animatedRoomDataModel = animatedRoomDataModel2;
			obj3 = obj4;
			goto IL_0249;
			IL_015f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ stack_-38_v3+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ stack_-38_v3+28]");
			bool flag7 = (nint)0 == 0;
			animatedRoomDataModel = (AnimatedRoomDataModel)(object)obj10;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v14+10]");
				obj5 = (UnityEngine.Object)0;
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v7+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(obj5);
				num = num2;
				animatedRoomDataModel = null;
				goto IL_020e;
			}
			goto IL_0249;
			IL_0249:
			NullReferenceException ex2 = new NullReferenceException();
			if ((nint)animatedRoomDataModel != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj6 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = num2;
			obj2 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A98C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void <LoadImage>b__11_0(Sprite sprite, int index)
	{
		//IL_01d6: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		object obj = index + 1;
		if (obj == null)
		{
			goto IL_0077;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = sprite == null;
			bool flag2 = !flag;
			int num = 0;
			if (!flag2)
			{
				goto IL_0077;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = sprite == null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			int num = 0;
			if (obj4 != null)
			{
				goto IL_0077;
			}
		}
		AnimatedRoomDataModel model = _model;
		if (_model != null && (object)sprite != null)
		{
			Texture2D[] <Images>k__BackingField = model.<Images>k__BackingField;
			Texture2D texture = sprite.texture;
			if (model.<Images>k__BackingField != null)
			{
				bool flag5 = index < <Images>k__BackingField.Length;
				object obj5 = !flag5;
				if (obj5 == null)
				{
					object obj6 = model.<Images>k__BackingField + index;
					object obj7 = obj6 + 32;
					obj7 = texture;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					DequeueNext();
					return;
				}
				goto IL_01c1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c1;
		IL_0077:
		FireOnce(null);
		return;
		IL_01c1:
		throw new IndexOutOfRangeException();
	}

	private void <LoadAudio>b__12_0(AudioClip clip, int index)
	{
		//IL_01ab: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_013c: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		object obj = index + 1;
		if (obj == null)
		{
			goto IL_0082;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clip != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			object obj5 = 0;
			if (obj4 == null)
			{
				goto IL_0082;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clip != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			if (flag4)
			{
				goto IL_0082;
			}
		}
		AnimatedRoomDataModel model = _model;
		if (_model != null)
		{
			AudioClip[] <Audios>k__BackingField = model.<Audios>k__BackingField;
			if (model.<Audios>k__BackingField != null)
			{
				bool flag5 = index < <Audios>k__BackingField.Length;
				object obj6 = !flag5;
				if (obj6 == null)
				{
					object obj7 = model.<Audios>k__BackingField + index;
					object obj8 = obj7 + 32;
					obj8 = clip;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					DequeueNext();
					return;
				}
				goto IL_0196;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0196;
		IL_0196:
		throw new IndexOutOfRangeException();
		IL_0082:
		DequeueNext();
	}

	private void <LoadSpineAnimation>b__13_0(string data, int index)
	{
		//IL_000e: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		object obj = index + 1;
		if (obj != null)
		{
			AnimatedRoomDataModel model = _model;
			if (_model != null)
			{
				string[] <SpineSkeletonTexts>k__BackingField = model.<SpineSkeletonTexts>k__BackingField;
				if (model.<SpineSkeletonTexts>k__BackingField != null)
				{
					bool flag = index < <SpineSkeletonTexts>k__BackingField.Length;
					object obj2 = !flag;
					if (obj2 == null)
					{
						object obj3 = model.<SpineSkeletonTexts>k__BackingField + index;
						object obj4 = obj3 + 32;
						obj4 = data;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						DequeueNext();
						return;
					}
					goto IL_0100;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0100;
		}
		FireOnce(null);
		return;
		IL_0100:
		throw new IndexOutOfRangeException();
	}

	private void <LoadSpineAtlas>b__14_0(string data, int index)
	{
		//IL_000e: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		object obj = index + 1;
		if (obj != null)
		{
			AnimatedRoomDataModel model = _model;
			if (_model != null)
			{
				string[] <SpineAtlasTexts>k__BackingField = model.<SpineAtlasTexts>k__BackingField;
				if (model.<SpineAtlasTexts>k__BackingField != null)
				{
					bool flag = index < <SpineAtlasTexts>k__BackingField.Length;
					object obj2 = !flag;
					if (obj2 == null)
					{
						object obj3 = model.<SpineAtlasTexts>k__BackingField + index;
						object obj4 = obj3 + 32;
						obj4 = data;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						DequeueNext();
						return;
					}
					goto IL_0100;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0100;
		}
		FireOnce(null);
		return;
		IL_0100:
		throw new IndexOutOfRangeException();
	}
}
