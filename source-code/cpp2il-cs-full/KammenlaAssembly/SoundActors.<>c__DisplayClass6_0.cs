using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Spine;
using UnityEngine;

public class SoundActors : ScriptableObject
{
	[Serializable]
	public class ActorsGroup
	{
		public string name;

		public List<SoundActor> actors;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ActorsGroup, IEnumerable<SoundActor>> <>9__5_0;

		public static Func<ActorsGroup, IEnumerable<SoundActor>> <>9__9_0;

		public static Func<SoundActor, int> <>9__9_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal IEnumerable<SoundActor> <GetActor>b__5_0(ActorsGroup group)
		{
			if (group != null)
			{
				return group.actors;
			}
			return (IEnumerable<SoundActor>)new NullReferenceException();
		}

		internal IEnumerable<SoundActor> <ValidateGroups>b__9_0(ActorsGroup group)
		{
			if (group != null)
			{
				return group.actors;
			}
			return (IEnumerable<SoundActor>)new NullReferenceException();
		}

		internal int <ValidateGroups>b__9_1(SoundActor actor)
		{
			//IL_0035: Expected I4, but got O
			if ((object)actor != null)
			{
				return actor.id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public string actorName;

		internal bool <GetActor>b__1(SoundActor actor)
		{
			//IL_0048: Expected I4, but got O
			if ((object)actor != null)
			{
				return actor.displayName == actorName;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public int id;

		public Func<SoundActor, bool> <>9__1;

		internal bool <GetUniqueOfSameGroup>b__0(ActorsGroup group)
		{
			//IL_00c8: Expected I4, but got O
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0033: Expected O, but got I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_006b: Expected O, but got I
			//IL_0079: Expected I, but got O
			if (group != null)
			{
				object obj = this + 24;
				Func<object, bool> predicate = (Func<object, bool>)obj;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3296;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj4 = (nint)0 + (nint)520;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj4);
					<>9__1 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				return Enumerable.Any(group.actors, predicate);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetUniqueOfSameGroup>b__1(SoundActor actor)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if ((object)actor != null)
			{
				object obj = actor.id - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private List<ActorsGroup> actorsGroups;

	public static string ResourcesPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			object format = "setMimeType" + 3312;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			return string.Format((string)format, arg);
		}
	}

	public IReadOnlyList<ActorsGroup> ActorsGroups => actorsGroups;

	public SoundActor GetActor(string actorName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_0221: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_0253: Expected O, but got I4
		//IL_0126: Expected I, but got O
		//IL_00be: Expected O, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		//IL_029c: Expected I, but got O
		//IL_02ba: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_019d: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(SkeletonBinary.SkeletonInput) + 544;
			object obj4 = obj2 + 16;
			obj4 = actorName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
			}
			object obj7 = (nint)0 + (nint)384;
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3296;
			object obj9 = (nint)0 + (nint)504;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v11+8]");
			Func<object, IEnumerable<object>> selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v11+8]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v17+B8]");
					obj10 = 0;
				}
				object obj14 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = (nint)0 + (nint)480;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj10, (IntPtr)obj15);
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v16+B8]");
				object obj17 = (nint)0 + (nint)8;
				obj17 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = (Func<object, IEnumerable<object>>)func;
			}
			IEnumerable<object> source = Enumerable.SelectMany(actorsGroups, selector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj2, (IntPtr)obj9);
			SoundActor soundActor = (SoundActor)Enumerable.FirstOrDefault(source, func2);
			if ((object)soundActor != null)
			{
				return soundActor;
			}
			object obj18 = Enumerable.First((IEnumerable<object>)actorsGroups);
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v19 (System.Object)+18]");
				return (SoundActor)Enumerable.First((IEnumerable<object>)0);
			}
		}
		return (SoundActor)(object)new NullReferenceException();
	}

	public SoundActor GetUniqueOfSameGroup(int id, IEnumerable<SoundActor> playerSounds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		//IL_008c: Expected O, but got I4
		//IL_00de: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 552;
			object obj4 = (nint)0 + (nint)512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj5 = Enumerable.FirstOrDefault(actorsGroups, func);
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj5 = Enumerable.First((IEnumerable<object>)actorsGroups);
				if (obj5 == null)
				{
					goto IL_00f9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v10 (System.Object)+18]");
			IEnumerable<object> source = Enumerable.Except((IEnumerable<object>)0, playerSounds);
			return (SoundActor)Enumerable.FirstOrDefault(source);
		}
		goto IL_00f9;
		IL_00f9:
		return (SoundActor)(object)new NullReferenceException();
	}

	public SoundActor GetRandom()
	{
		//IL_0018: Expected O, but got I
		object obj = Enumerable.First((IEnumerable<object>)actorsGroups);
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+18]");
			return (SoundActor)ArraysExtensions.Random((IList<object>)0);
		}
		return (SoundActor)(object)new NullReferenceException();
	}

	private bool ValidateGroups()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_0284: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_043a: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_046c: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03ca: Expected O, but got I
		//IL_03db: Expected I, but got O
		//IL_03f9: Expected O, but got I
		//IL_03a0: Expected I4, but got O
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04a4: Expected O, but got I
		//IL_04b5: Expected I, but got O
		//IL_04d3: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_034c: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_037e: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D31]");
		object obj3 = (nint)0 & (nint)1;
		List<ActorsGroup> list;
		List<ActorsGroup> list2;
		object obj4;
		if (obj3 != null)
		{
			list = actorsGroups;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = actorsGroups;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = actorsGroups;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = actorsGroups;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)384;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+10]");
		Func<object, IEnumerable<object>> selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = list2;
		object obj10 = obj7;
		IEnumerable<object> source = list2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v24+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)488;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v23+B8]");
		object obj16 = (nint)0 + (nint)16;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		selector = (Func<object, IEnumerable<object>>)func;
		source = enumerable;
		goto IL_0249;
		IL_0249:
		IEnumerable<object> source2 = Enumerable.SelectMany(source, selector);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v9+18]");
		Func<object, int> selector2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v9+18]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v15+B8]");
				obj19 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)496;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj19, (IntPtr)obj24);
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v14+B8]");
			object obj26 = (nint)0 + (nint)24;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector2 = func2;
		}
		IEnumerable<int> source3 = Enumerable.Select(source2, selector2);
		List<int> list3 = Enumerable.ToList(source3);
		if (list3 != null)
		{
			object obj27 = (nint)0 + (nint)3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DBE104");
			IEnumerable<int> source4 = default(IEnumerable<int>);
			int num = Enumerable.Count(source4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj28 = -num;
			return obj28 == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0099:
		obj10 = (nint)0 + (nint)384;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+10]");
		selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+10]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		source = list;
		if (obj29 == null)
		{
			obj7 = obj10;
			enumerable = list;
			goto IL_01f2;
		}
		goto IL_0249;
	}
}
