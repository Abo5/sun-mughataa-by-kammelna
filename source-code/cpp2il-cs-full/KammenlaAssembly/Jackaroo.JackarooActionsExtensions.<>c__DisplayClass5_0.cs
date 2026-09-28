using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Jackaroo;

internal static class JackarooActionsExtensions
{
	private sealed class <>c__DisplayClass2_0
	{
		public JackarooActions firstAction;

		internal bool <AllSameAction>b__0(JackarooMove move)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - firstAction;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public JackarooMarble marble1;

		internal bool <AllSameMarble1>b__0(JackarooMove move)
		{
			//IL_0053: Expected I4, but got O
			if (move != null)
			{
				object obj = (object)move.<Marble1>k__BackingField - (object)marble1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public int move1;

		internal bool <AllSameSplit1Move>b__0(JackarooMove move)
		{
			//IL_0060: Expected I4, but got O
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			if (move != null)
			{
				(int, int) jackarooMoveFromSplit = JackarooRules.GetJackarooMoveFromSplit(move.<Action>k__BackingField);
				object obj = move1 - jackarooMoveFromSplit;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public JackarooActions @this;

		internal bool <ToList>b__0(JackarooActions action)
		{
			//IL_000b: Expected O, but got I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0032: Expected O, but got I4
			object obj = ~this.@this;
			object obj2 = action & obj;
			bool flag = obj2 == null;
			object obj3 = !flag;
			bool flag2 = obj3 != null || action == JackarooActions.NONE;
			return !flag2;
		}
	}

	public static JackarooServerActions ToJackarooServerAction(JackarooActions action)
	{
		//IL_003a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0461: Expected O, but got I4
		//IL_047b: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04fe: Expected O, but got I
		JackarooServerActions result;
		if (action > JackarooActions.MOVE_SPLIT_5_2)
		{
			bool flag = action < JackarooActions.BURN_MY_CARD;
			object obj = !flag;
			object obj2 = action - 16384;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				bool flag3 = action < JackarooActions.BURN_OTHER_CARD_RANDOM;
				object obj5 = !flag3;
				object obj6 = action - 65536;
				bool flag4 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag4;
				if (obj8 == null)
				{
					if (action == JackarooActions.PLANT)
					{
						return JackarooServerActions.PLANT;
					}
					if (action == JackarooActions.STEAL)
					{
						result = JackarooServerActions.STEAL;
						goto IL_051f;
					}
				}
				else
				{
					switch (action)
					{
					case JackarooActions.BURN_OTHER_CARD_RANDOM:
						return JackarooServerActions.BURN_OTHER_CARD_RANDOM;
					case JackarooActions.BURN_OTHER_CARD:
						return JackarooServerActions.BURN_OTHER_CARD;
					}
				}
			}
			else
			{
				bool flag5 = action < JackarooActions.MOVE_SPLIT_7_0;
				object obj9 = !flag5;
				object obj10 = action - 4096;
				bool flag6 = obj10 == null;
				object obj11 = ~obj9;
				object obj12 = obj11 | flag6;
				if (obj12 == null)
				{
					switch (action)
					{
					case JackarooActions.BURN_MY_CARD:
						return JackarooServerActions.BURN_MY_CARD;
					case JackarooActions.SWAP:
						return JackarooServerActions.SWAP;
					}
				}
				else
				{
					switch (action)
					{
					case JackarooActions.MOVE_SPLIT_7_0:
						return JackarooServerActions.MOVE_SPLIT_7_0;
					case JackarooActions.MOVE_SPLIT_6_1:
						return JackarooServerActions.MOVE_SPLIT_6_1;
					}
				}
			}
		}
		else if (action > JackarooActions.MOVE_SPLIT_1_6)
		{
			bool flag7 = action < JackarooActions.MOVE_SPLIT_3_4;
			object obj13 = !flag7;
			object obj14 = action - 256;
			bool flag8 = obj14 == null;
			object obj15 = ~obj13;
			object obj16 = obj15 | flag8;
			if (obj16 == null)
			{
				switch (action)
				{
				case JackarooActions.MOVE_SPLIT_5_2:
					return JackarooServerActions.MOVE_SPLIT_5_2;
				case JackarooActions.MOVE_SPLIT_4_3:
					return JackarooServerActions.MOVE_SPLIT_4_3;
				}
			}
			else
			{
				switch (action)
				{
				case JackarooActions.MOVE_SPLIT_3_4:
					return JackarooServerActions.MOVE_SPLIT_3_4;
				case JackarooActions.MOVE_SPLIT_2_5:
					return JackarooServerActions.MOVE_SPLIT_2_5;
				}
			}
		}
		else if (action > JackarooActions.MOVE_CHOICE_1)
		{
			switch (action)
			{
			case JackarooActions.MOVE_SPLIT_1_6:
				return JackarooServerActions.MOVE_SPLIT_1_6;
			case JackarooActions.MOVE_CHOICE_11:
				return JackarooServerActions.MOVE_CHOICE_11;
			}
		}
		else if (action > (JackarooActions)3)
		{
			switch (action)
			{
			case JackarooActions.MOVE_CHOICE_1:
				return JackarooServerActions.MOVE_CHOICE_1;
			case JackarooActions.MOVE_ANY:
				return JackarooServerActions.MOVE_ANY;
			case JackarooActions.MOVE_EAT_PATH:
				return JackarooServerActions.MOVE_EAT_PATH;
			}
		}
		else
		{
			object obj17 = action - 1;
			bool flag9 = (nint)obj17 < 2;
			object obj18 = !flag9;
			object obj19 = ~obj18;
			result = (JackarooServerActions)action;
			if (obj19 != null)
			{
				goto IL_051f;
			}
		}
		object obj20 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = "___# Content push apply failed [{0}]: {1}" + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		ex..ctor(paramName);
		object obj22 = (nint)0 + (nint)328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_051f:
		return result;
	}

	public static JackarooActions ToJackarooAction(JackarooServerActions action)
	{
		//IL_001a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0037: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_00c5: Expected I4, but got O
		bool flag = action < (JackarooServerActions)19;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 119877632 + 732;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v2+action @ X0 (Jackaroo.JackarooServerActions)*4]");
			return JackarooActions.NONE;
		}
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		ex..ctor(paramName);
		object obj5 = (nint)0 + (nint)320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (JackarooActions)ex2;
	}

	public static bool AllSameAction(List<JackarooMove> @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010e: Expected I4, but got O
		//IL_0050: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e4: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (@this != null)
		{
			if (@this._size == 1)
			{
				return true;
			}
			object obj3 = (nint)0 + (nint)2360;
			object obj4 = ((List<object>)(object)@this).get_Item(0);
			if (obj4 != null && obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Object)+18]");
				_ = 0;
				object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)1424;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj6);
				return Enumerable.All(@this, func);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool AllSameMarble1(List<JackarooMove> @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012e: Expected I4, but got O
		//IL_0050: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I
		//IL_0104: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (@this != null)
		{
			if (@this._size == 1)
			{
				return true;
			}
			object obj3 = (nint)0 + (nint)2360;
			object obj4 = ((List<object>)(object)@this).get_Item(0);
			if (obj4 != null && obj2 != null)
			{
				object obj5 = obj2 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Object)+20]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)1432;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj7);
				return Enumerable.All(@this, func);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool AllSameSplit1Move(List<JackarooMove> @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_011b: Expected I4, but got O
		//IL_0050: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_00f1: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (@this != null)
		{
			if (@this._size == 1)
			{
				return true;
			}
			object obj3 = (nint)0 + (nint)2360;
			object obj4 = ((List<object>)(object)@this).get_Item(0);
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7 (System.Object)+18]");
				(int, int) jackarooMoveFromSplit = JackarooRules.GetJackarooMoveFromSplit(JackarooActions.NONE);
				if (obj2 != null)
				{
					object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj6 = (nint)0 + (nint)1440;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj6);
					return Enumerable.All(@this, func);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static List<JackarooActions> ToList(JackarooActions @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0041: Expected O, but got I4
		//IL_0051: Expected O, but got I
		//IL_0073: Expected O, but got I4
		//IL_009c: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_012b: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object handle = typeof(IAsyncEnumerable<>) + 1120;
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X26_v2+E0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)3072;
			object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2064;
			object obj8 = (nint)0 + (nint)1448;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X26_v2+98]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Array values = Enum.GetValues(typeFromHandle);
			IEnumerable<System.Int32Enum> source = Enumerable.Cast<System.Int32Enum>(values);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
			func..ctor(obj2, (IntPtr)obj8);
			IEnumerable<System.Int32Enum> source2 = Enumerable.Where(source, func);
			return (List<JackarooActions>)(object)Enumerable.ToList(source2);
		}
		return (List<JackarooActions>)(object)new NullReferenceException();
	}
}
