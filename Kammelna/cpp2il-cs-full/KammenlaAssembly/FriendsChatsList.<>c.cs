using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;

public class FriendsChatsList : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, bool> <>9__5_0;

		public static Func<PrivateMessageModel, long> <>9__5_2;

		public static Func<FriendProfile, long> <>9__5_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <UpdateUI>b__5_0(FriendProfile profile)
		{
			//IL_00d3: Expected I4, but got O
			//IL_00ad: Expected O, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected I4, but got Unknown
			if (profile != null)
			{
				List<PrivateMessageModel> messages = profile.Messages;
				if (profile.Messages != null)
				{
					bool flag = messages._size < 0;
					bool flag2 = messages._size == 0;
					int num = messages._size ^ messages._size;
					int num2 = messages._size & num;
					bool flag3 = num2 < 0;
					bool flag4 = flag == flag3;
					object obj = !flag2;
					return (byte)((flag4 & obj) ? 1 : 0) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal long <UpdateUI>b__5_1(FriendProfile profile)
		{
			//IL_0199: Expected I8, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I
			//IL_00dd: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_010f: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected O, but got Unknown
			//IL_01e0: Expected O, but got I
			//IL_01f1: Expected I, but got O
			//IL_020f: Expected O, but got I
			//IL_0177: Expected O, but got I
			object obj;
			object obj4;
			object obj6;
			object obj3;
			Func<object, long> func;
			if (profile != null)
			{
				obj = typeof(DebugUI.BitField) + 3176;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)1880;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+10]");
					func = (Func<object, long>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+10]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_0125;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)1880;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+10]");
					func = (Func<object, long>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+10]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_0125;
					}
				}
				goto IL_017c;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
			IL_017c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAABC");
			long result = default(long);
			return result;
			IL_0125:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)744;
			Func<object, long> func2 = default(Func<object, long>);
			func2..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v11+B8]");
			object obj13 = (nint)0 + (nint)16;
			obj13 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			func = func2;
			goto IL_017c;
		}

		internal long <UpdateUI>b__5_2(PrivateMessageModel message)
		{
			//IL_0035: Expected I8, but got O
			if (message != null)
			{
				return message.timestamp;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	private FriendsChatsListView list;

	private GameObject placeholder;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00a4: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2680;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		this.list.SetData((IEnumerable<FriendProfile>)list);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
		UpdateUI();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2680;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnFriendListUpdated -= action;
	}

	private void OnFriendListUpdated()
	{
		UpdateUI();
	}

	private void UpdateUI()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_0112: Expected O, but got I
		//IL_0122: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_01fd: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_021d: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_047c: Expected O, but got I
		//IL_048c: Expected O, but got I
		//IL_04ae: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_040c: Expected O, but got I
		//IL_041d: Expected I, but got O
		//IL_043b: Expected O, but got I
		//IL_03ae: Expected O, but got I4
		//IL_0336: Expected O, but got I4
		//IL_02af: Expected O, but got I
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04e6: Expected O, but got I
		//IL_04f7: Expected I, but got O
		//IL_0515: Expected O, but got I
		//IL_0366: Expected O, but got I
		placeholder.SetActive(value: false);
		Transform transform = base.transform;
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = typeof(DebugUI.BitField) + 3176;
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v8+B8]");
		object obj5 = 0;
		transform.localScale = (Vector3)0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v8+E4]");
		IEnumerable<FriendProfile> enumerable;
		IEnumerable<FriendProfile> enumerable2;
		object obj7;
		if ((nint)0 != 0)
		{
			IEnumerable<FriendProfile> friendsList = FriendsManager.FriendsList;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			enumerable = friendsList;
			object obj8 = obj7;
			enumerable2 = friendsList;
			if (!flag)
			{
				goto IL_0106;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<FriendProfile> friendsList2 = FriendsManager.FriendsList;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			enumerable = friendsList2;
			object obj8 = obj7;
			enumerable2 = friendsList2;
			if (obj9 != null)
			{
				goto IL_0106;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj2;
		object obj10 = (nint)0 + (nint)3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v30+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v25+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v25+8]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		object obj13 = obj10;
		enumerable = enumerable2;
		if (obj12 == null)
		{
			goto IL_025d;
		}
		goto IL_02b4;
		IL_025d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v30+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v31+B8]");
			obj11 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)728;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj11, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v30+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = obj10;
		predicate = func;
		enumerable = enumerable2;
		goto IL_02b4;
		IL_02b4:
		IEnumerable<object> source = Enumerable.Where(enumerable, predicate);
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v16+18]");
		Func<object, long> keySelector = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v16+18]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v22+B8]");
				obj22 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)736;
			Func<object, long> func2 = default(Func<object, long>);
			func2..ctor(obj22, (IntPtr)obj27);
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v21+B8]");
			object obj29 = (nint)0 + (nint)24;
			obj29 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func2;
		}
		IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(source, keySelector);
		List<object> list = Enumerable.ToList(source2);
		bool flag8 = list._size == 0;
		object obj30 = !flag8;
		if (obj30 == null)
		{
			placeholder.SetActive(value: true);
		}
		this.list.SetData((IEnumerable<FriendProfile>)list);
		return;
		IL_0106:
		obj13 = (nint)0 + (nint)3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v30+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v25+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v25+8]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			obj10 = obj13;
			enumerable2 = enumerable;
			goto IL_025d;
		}
		goto IL_02b4;
	}

	private void ShowPlaceHolder()
	{
		placeholder.SetActive(value: true);
	}

	private void HidePlaceholder()
	{
		placeholder.SetActive(value: false);
	}
}
