using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class MassWinnersPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<MassWinnersStrip> <>9__5_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Populate>b__5_0(MassWinnersStrip s)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = s.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public MassEventWinner winner;

		internal bool <Populate>b__1(MassEventPrizeViewModel p)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (p != null)
			{
				MassEventWinner massEventWinner = winner;
				if (winner != null)
				{
					object obj = p.<Place>k__BackingField - massEventWinner.<Place>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private MassWinnersStrip prefab;

	private Transform layout;

	private GameObject NoWinnersYet;

	private int stripCap;

	private List<MassWinnersStrip> strips;

	public void Populate(List<MassEventWinner> winners, IEnumerable<MassEventPrizeViewModel> prizes, long eventId)
	{
		//IL_000c: Expected O, but got I
		//IL_07bb: Expected I4, but got O
		//IL_07e2: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_074b: Expected O, but got I
		//IL_0753: Expected I4, but got O
		//IL_0212: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_025d: Expected I4, but got O
		//IL_017f: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_0838: Expected O, but got I
		//IL_0849: Expected I, but got O
		//IL_0867: Expected O, but got I
		//IL_02c2: Expected I4, but got O
		//IL_01ce: Expected I8, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01e8: Expected I8, but got I4
		//IL_01f8: Expected I4, but got O
		//IL_01af: Expected O, but got I
		//IL_031b: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_02f5: Expected I8, but got I4
		//IL_0346: Expected O, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0370: Expected O, but got I4
		//IL_06b4: Expected O, but got I4
		//IL_06f1: Expected O, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_0471: Expected O, but got I
		//IL_0482: Expected I, but got O
		//IL_0493: Expected O, but got I
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04e2: Expected O, but got I4
		//IL_050b: Expected O, but got I
		//IL_0513: Expected I8, but got O
		//IL_06da: Expected I4, but got O
		//IL_069e: Expected I4, but got O
		//IL_0584: Expected O, but got I
		//IL_05fb: Expected O, but got I4
		//IL_0385: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_0668: Expected I4, but got O
		object obj = (nint)0 + (nint)2680;
		bool flag = (byte)(int)obj != 0;
		bool flag2 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)winners);
		bool flag3 = (object)NoWinnersYet == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		long num = eventId;
		IEnumerable<MassEventPrizeViewModel> enumerable = prizes;
		Action<object> action;
		long num2;
		if (!flag3)
		{
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3208;
			NoWinnersYet.SetActive(flag2);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v54+E4]");
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v54+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v44+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v44+8]");
				if ((nint)0 != 0)
				{
					goto IL_00a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v54+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v44+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v44+8]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 != null)
				{
					goto IL_00a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v54+E4]");
			bool flag5 = (nint)0 == 0;
			object obj6 = !flag5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v50+B8]");
				obj4 = 0;
			}
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)1064;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj4, (IntPtr)obj9);
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v49+B8]");
			object obj11 = (nint)0 + (nint)8;
			obj11 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag6 = strips == null;
			num2 = 0L;
			action = action2;
			enumerator = (List<object>.Enumerator)0;
			num = 0L;
			enumerable = (IEnumerable<MassEventPrizeViewModel>)obj9;
			flag = (byte)(int)action2 != 0;
			if (!flag6)
			{
				goto IL_0206;
			}
		}
		goto IL_0800;
		IL_0800:
		NullReferenceException ex = new NullReferenceException();
		bool flag7 = !flag;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj12 = (nint)0 + (nint)3296;
			flag = (byte)(int)obj12 != 0;
			enumerator.Dispose();
			object obj13 = default(object);
			if (obj13 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237294");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00a6:
		bool flag8 = strips == null;
		object obj14 = !flag8;
		num2 = eventId;
		if (obj14 != null)
		{
			goto IL_0206;
		}
		enumerator = (List<object>.Enumerator)0;
		num = eventId;
		enumerable = null;
		flag = flag2;
		goto IL_0800;
		IL_0206:
		object obj15 = (nint)0 + (nint)3848;
		enumerable = (IEnumerable<MassEventPrizeViewModel>)obj15;
		((List<object>)(object)strips).ForEach(action);
		List<MassWinnersStrip> list = strips;
		bool flag9 = strips == null;
		enumerator = (List<object>.Enumerator)0;
		num = num2;
		flag = (byte)(int)action != 0;
		if (!flag9)
		{
			int num3 = list._size;
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			bool flag10 = list._size < 1;
			flag = (byte)(int)action != 0;
			if (!flag10)
			{
				Array.Clear(list._items, 0, list._size);
				num2 = 0L;
				flag = false;
			}
			bool flag11 = winners == null;
			enumerator = (List<object>.Enumerator)0;
			num = num2;
			enumerable = (IEnumerable<MassEventPrizeViewModel>)num3;
			if (!flag11)
			{
				object obj16 = (nint)0 + (nint)3304;
				object obj17 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3216;
				List<object>.Enumerator enumerator3 = ((List<object>)(object)winners).GetEnumerator();
				object obj18 = 0;
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				object obj19 = default(object);
				object obj21 = default(object);
				Func<object, bool> func = default(Func<object, bool>);
				MassWinnersStrip massWinnersStrip = default(MassWinnersStrip);
				while (true)
				{
					if (enumerator4.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj19..ctor();
						if (obj19 == null)
						{
							NullReferenceException ex3 = new NullReferenceException();
							enumerable = (IEnumerable<MassEventPrizeViewModel>)num3;
							flag = false;
							break;
						}
						object obj20 = obj19 + 16;
						obj20 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if ((nint)obj18 != stripCap)
						{
							object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2360;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj23 = (nint)0 + (nint)1072;
							func..ctor(obj19, (IntPtr)obj23);
							object obj24 = (nint)0 + (nint)1008;
							object obj25 = Enumerable.FirstOrDefault(prizes, func);
							object obj26 = typeof(MemberAchievementClanFeedData) + 2976;
							object obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v40+E4]");
							bool flag12 = (nint)0 == 0;
							object obj28 = !flag12;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj29 = (nint)0 + (nint)976;
							num2 = (long)obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
							if ((object)massWinnersStrip != null)
							{
								massWinnersStrip.Populate((MassEventWinner)obj20, (MassEventPrizeViewModel)obj25, eventId);
								List<object> list2 = (List<object>)(object)strips;
								if (strips != null)
								{
									object obj30 = (nint)0 + (nint)3832;
									object obj31 = obj30;
									int version2 = list2._version + 1;
									list2._version = version2;
									object[] items = list2._items;
									if (list2._items != null)
									{
										bool flag13 = list2._size < items.Length;
										object obj32 = !flag13;
										if (obj32 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v38+20]");
											object obj33 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v41+C0]");
											object obj34 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v42+70]");
											num3 = 0;
											((List<object>)(object)strips).AddWithResize((object)massWinnersStrip);
										}
										else
										{
											int size = list2._size + 1;
											list2._size = size;
											object obj35 = list2._items + list2._size;
											object obj36 = obj35 + 32;
											obj36 = massWinnersStrip;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											num3 = (int)obj25;
										}
										obj18++;
										num2 = eventId;
										continue;
									}
								}
								NullReferenceException ex4 = new NullReferenceException();
								num2 = eventId;
								enumerable = (IEnumerable<MassEventPrizeViewModel>)obj25;
								flag = (byte)(int)obj20 != 0;
							}
							else
							{
								NullReferenceException ex5 = new NullReferenceException();
								enumerable = null;
								flag = (byte)(int)layout != 0;
							}
							break;
						}
					}
					enumerator4.Dispose();
					return;
				}
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				enumerator = enumerator2;
				enumerator2 = (List<object>.Enumerator)0;
				num = num2;
			}
		}
		goto IL_0800;
	}

	public MassWinnersPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2240;
		stripCap = 100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
