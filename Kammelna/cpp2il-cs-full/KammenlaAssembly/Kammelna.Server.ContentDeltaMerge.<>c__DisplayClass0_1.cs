using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Server.Coordinator.Models;

namespace Kammelna.Server;

public static class ContentDeltaMerge
{
	private sealed class <>c__DisplayClass0_0<TModel, TId> where TId : IEquatable<TId>
	{
		public Func<TModel, TId> idOf;

		public ContentDeltaModel<TModel, TId> delta;

		internal bool <Merge>b__0(TModel m)
		{
			//IL_00a8: Expected I4, but got O
			ContentDeltaModel<TModel, TId> contentDeltaModel = delta;
			if (delta != null)
			{
				Func<TModel, TId> func = idOf;
				if (idOf != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ X9_v2 (System.Func`2<TModel, TId>)+18] (should have been resolved before IL gen)");
					int item = default(int);
					if (contentDeltaModel.<RemovedIds>k__BackingField != null)
					{
						return ((List<int>)(object)contentDeltaModel.<RemovedIds>k__BackingField).Contains(item);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass0_1<TModel, TId> where TId : IEquatable<TId>
	{
		public TModel upsert;

		public <>c__DisplayClass0_0<TModel, TId> CS$<>8__locals1;

		internal bool <Merge>b__1(TModel m)
		{
			//IL_00e9: Expected I4, but got O
			<>c__DisplayClass0_0<TModel, TId> cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null)
			{
				Func<TModel, TId> idOf = cS$<>8__locals.idOf;
				if (cS$<>8__locals.idOf != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ X8_v3 (System.Func`2<TModel, TId>)+18] (should have been resolved before IL gen)");
					<>c__DisplayClass0_0<TModel, TId> cS$<>8__locals2 = CS$<>8__locals1;
					if (CS$<>8__locals1 != null)
					{
						Func<TModel, TId> idOf2 = cS$<>8__locals2.idOf;
						if (cS$<>8__locals2.idOf != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ X8_v5 (System.Func`2<TModel, TId>)+18] (should have been resolved before IL gen)");
							int num = default(int);
							int obj = default(int);
							return num.Equals(obj);
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public unsafe static void Merge<TModel, TId>(List<TModel> target, ContentDeltaModel<TModel, TId> delta, Func<TModel, TId> idOf) where TId : IEquatable<TId>
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_003d: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_0067: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_00b0: Expected O, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_024a: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_0746: Expected O, but got I
		//IL_030f: Expected O, but got I
		//IL_0661: Expected O, but got Ref
		//IL_0672: Expected O, but got I4
		//IL_0693: Expected O, but got I4
		//IL_069c: Expected O, but got I4
		//IL_079c: Expected O, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07c4: Expected O, but got I4
		//IL_0a05: Expected O, but got I
		//IL_0a28: Expected O, but got I4
		//IL_0382: Expected O, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I4
		//IL_0836: Expected O, but got I
		//IL_06a9: Expected I, but got O
		//IL_08c0: Expected O, but got I
		//IL_0925: Expected O, but got Ref
		//IL_0936: Expected O, but got I4
		//IL_0957: Expected O, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0453: Expected O, but got I
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_047b: Expected O, but got I4
		//IL_08d4: Expected O, but got I
		//IL_0508: Expected I4, but got I8
		//IL_0916: Expected O, but got I4
		//IL_058b: Expected O, but got I4
		//IL_05ab: Expected O, but got I4
		//IL_063d: Expected O, but got I
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_0617: Expected I, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		nint num = 0;
		object obj3 = 0;
		object obj4 = 0;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		nint num2 = 0;
		object obj5 = 0;
		object obj6 = 0;
		enumerator = (List<object>.Enumerator)0;
		object obj8;
		ContentDeltaModel<TModel, TId> contentDeltaModel3 = default(ContentDeltaModel<TModel, TId>);
		Func<TModel, TId> func2 = default(Func<TModel, TId>);
		ContentDeltaModel<TModel, TId> contentDeltaModel;
		object obj9;
		ContentDeltaModel<TModel, TId> contentDeltaModel2;
		Func<TModel, TId> func;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass0_0<TModel, TId> <>c__DisplayClass0_ = default(<>c__DisplayClass0_0<TModel, TId>);
			<>c__DisplayClass0_..ctor();
			bool flag2 = <>c__DisplayClass0_ == null;
			object obj7 = !flag2;
			obj8 = <>c__DisplayClass0_;
			if (obj7 != null)
			{
				goto IL_01fd;
			}
			contentDeltaModel = (ContentDeltaModel<TModel, TId>)0;
			obj9 = <>c__DisplayClass0_;
			obj5 = obj3;
			obj6 = obj4;
			contentDeltaModel2 = contentDeltaModel3;
			func = func2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass0_0<TModel, TId> <>c__DisplayClass0_2 = default(<>c__DisplayClass0_0<TModel, TId>);
			<>c__DisplayClass0_2..ctor();
			bool flag3 = <>c__DisplayClass0_2 == null;
			obj8 = <>c__DisplayClass0_2;
			obj3 = obj5;
			obj4 = obj6;
			contentDeltaModel = (ContentDeltaModel<TModel, TId>)0;
			obj9 = <>c__DisplayClass0_2;
			contentDeltaModel2 = contentDeltaModel3;
			func = func2;
			if (!flag3)
			{
				goto IL_01fd;
			}
		}
		goto IL_09e4;
		IL_09e4:
		throw new NullReferenceException();
		IL_01fd:
		object obj10 = obj8 + 16;
		obj10 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func = (Func<TModel, TId>)(obj8 + 24);
		func = (Func<TModel, TId>)(object)contentDeltaModel3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = (nint)func;
		bool flag4 = func == null;
		contentDeltaModel = contentDeltaModel3;
		obj9 = obj8;
		obj5 = obj3;
		obj6 = obj4;
		contentDeltaModel2 = contentDeltaModel3;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v8 (Il2CppClass<System.Func`2<TModel, TId>>)+10]");
			bool flag5 = (nint)0 == 0;
			object obj12 = default(object);
			object obj11 = obj12;
			int size = default(int);
			int num4 = size;
			TModel[] items = default(TModel[]);
			TModel[] array = items;
			Func<TModel, TId> func3 = func2;
			Predicate<object> predicate2 = default(Predicate<object>);
			Predicate<object> predicate = predicate2;
			nint num5 = default(nint);
			IntPtr intPtr = num5;
			object obj14 = default(object);
			object obj13 = obj14;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator2 = enumerator3;
			ContentDeltaModel<TModel, TId> contentDeltaModel4 = contentDeltaModel3;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v8 (Il2CppClass<System.Func`2<TModel, TId>>)+10]");
				List<object>.Enumerator enumerator4 = ((List<object>)0).GetEnumerator();
				object obj15 = func2;
				contentDeltaModel2 = contentDeltaModel3;
				object obj19 = default(object);
				object obj21 = default(object);
				Predicate<object> predicate3 = default(Predicate<object>);
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				while (enumerator.MoveNext())
				{
					object obj16 = (nint)0 + (nint)309;
					object obj17 = obj16 & 1;
					bool flag6 = obj17 == null;
					object obj18 = !flag6;
					nint num6 = 0;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					((<>c__DisplayClass0_1<TModel, TId>)obj19)..ctor();
					if (obj19 != null)
					{
						object obj20 = obj19 + 24;
						obj20 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						contentDeltaModel2 = (ContentDeltaModel<TModel, TId>)(obj19 + 16);
						contentDeltaModel2 = (ContentDeltaModel<TModel, TId>)obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj22 = (nint)0 + (nint)309;
						object obj23 = obj22 & 1;
						bool flag7 = obj23 == null;
						object obj24 = !flag7;
						nint num7 = 0;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						predicate3..ctor(obj19, (IntPtr)(nint)__ldftn(<>c__DisplayClass0_1<TModel, TId>.<Merge>b__1));
						if (target != null)
						{
							int num8 = ((List<object>)(object)target).FindIndex(predicate3);
							obj15 = contentDeltaModel2;
							if ((int)(num8 & 0x80000000L) == 0)
							{
								((List<object>)(object)target).set_Item(num8, (object)contentDeltaModel2);
								predicate2 = predicate3;
								num5 = 0;
								continue;
							}
							int version = target._version + 1;
							target._version = version;
							items = target._items;
							if (target._items != null)
							{
								size = target._size;
								obj12 = items.Length;
								bool flag8 = target._size < items.Length;
								object obj25 = !flag8;
								if (obj25 == null)
								{
									int size2 = target._size + 1;
									target._size = size2;
									object obj26 = target._items + target._size;
									Predicate<TModel> predicate4 = (Predicate<TModel>)(obj26 + 32);
									predicate4 = (Predicate<TModel>)obj15;
									predicate4..ctor(obj15, (IntPtr)obj15);
									predicate2 = predicate3;
									num5 = 0;
								}
								else
								{
									((List<object>)(object)target).AddWithResize((object)contentDeltaModel2);
									obj15 = 0;
									predicate2 = predicate3;
									num5 = 0;
								}
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							func2 = (Func<TModel, TId>)(object)contentDeltaModel2;
							predicate2 = predicate3;
							num5 = 0;
							contentDeltaModel = (ContentDeltaModel<TModel, TId>)num8;
						}
						else
						{
							NullReferenceException ex2 = new NullReferenceException();
							func2 = (Func<TModel, TId>)0;
							predicate2 = predicate3;
							num5 = 0;
							contentDeltaModel = (ContentDeltaModel<TModel, TId>)obj19;
						}
					}
					else
					{
						NullReferenceException ex3 = new NullReferenceException();
						func2 = (Func<TModel, TId>)obj15;
						contentDeltaModel = (ContentDeltaModel<TModel, TId>)0;
					}
					obj14 = (object)(&enumerator);
					enumerator3 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					obj9 = obj8;
					obj5 = obj21;
					obj6 = obj4;
					enumerator = (List<object>.Enumerator)0;
					goto IL_09e4;
				}
				func2 = (Func<TModel, TId>)obj15;
				obj14 = (object)(&enumerator);
				enumerator3 = enumerator5;
				enumerator5 = (List<object>.Enumerator)0;
				obj9 = obj8;
				obj5 = obj21;
				obj6 = obj4;
				List<object>.Enumerator enumerator6 = (List<object>.Enumerator)0;
				object obj27 = 0;
				object obj29 = default(object);
				while (true)
				{
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v4 (Il2CppMethodRgctx<Kammelna.Server.ContentDeltaMerge::Merge>)+A0]");
					contentDeltaModel = (ContentDeltaModel<TModel, TId>)0;
					enumerator6.Dispose();
					bool flag9 = obj27 == null;
					object obj28 = !flag9;
					enumerator = enumerator6;
					if (obj28 != null)
					{
						OutOfMemoryException ex4 = new OutOfMemoryException();
						if ((nint)contentDeltaModel == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj27 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							enumerator5 = (List<object>.Enumerator)obj29;
							enumerator6 = enumerator;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CB9FE4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
				}
				num3 = (nint)func;
				bool flag10 = func == null;
				obj11 = obj12;
				num4 = size;
				array = items;
				func3 = func2;
				predicate = predicate2;
				intPtr = num5;
				obj13 = obj14;
				enumerator2 = enumerator3;
				obj8 = obj9;
				obj3 = obj5;
				obj4 = obj6;
				enumerator = enumerator6;
				contentDeltaModel4 = contentDeltaModel2;
				enumerator = enumerator6;
				if (flag10)
				{
					goto IL_09e4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v8 (Il2CppClass<System.Func`2<TModel, TId>>)+18]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v8 (Il2CppClass<System.Func`2<TModel, TId>>)+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v9+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			object obj31 = (nint)0 + (nint)309;
			object obj32 = obj31 & 1;
			bool flag11 = obj32 == null;
			object obj33 = !flag11;
			nint num10 = 0;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate5 = default(Predicate<object>);
			predicate5..ctor(obj8, (IntPtr)(nint)__ldftn(<>c__DisplayClass0_0<TModel, TId>.<Merge>b__0));
			bool flag12 = target == null;
			obj12 = obj11;
			size = num4;
			items = array;
			func2 = (Func<TModel, TId>)0;
			predicate2 = predicate;
			num5 = 0;
			obj14 = obj13;
			enumerator3 = enumerator2;
			contentDeltaModel = (ContentDeltaModel<TModel, TId>)obj8;
			obj9 = obj8;
			obj5 = obj3;
			obj6 = obj4;
			contentDeltaModel2 = contentDeltaModel4;
			func = (Func<TModel, TId>)(object)predicate5;
			if (!flag12)
			{
				int num11 = ((List<object>)(object)target).RemoveAll(predicate5);
				return;
			}
		}
		goto IL_09e4;
	}

	public static bool HasChanges<TModel, TId>(ContentDeltaModel<TModel, TId> delta)
	{
		//IL_0159: Expected I4, but got O
		//IL_0133: Expected O, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected I4, but got Unknown
		if (delta != null)
		{
			List<TModel> <Upserts>k__BackingField = delta.<Upserts>k__BackingField;
			if (delta.<Upserts>k__BackingField != null && <Upserts>k__BackingField._size > 0)
			{
				return true;
			}
			List<TId> <RemovedIds>k__BackingField = delta.<RemovedIds>k__BackingField;
			if (delta.<RemovedIds>k__BackingField != null)
			{
				bool flag = <RemovedIds>k__BackingField._size < 0;
				bool flag2 = <RemovedIds>k__BackingField._size == 0;
				int num = <RemovedIds>k__BackingField._size ^ <RemovedIds>k__BackingField._size;
				int num2 = <RemovedIds>k__BackingField._size & num;
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
}
