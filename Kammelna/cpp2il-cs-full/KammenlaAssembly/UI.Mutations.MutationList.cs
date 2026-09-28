using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.TextCore;

namespace UI.Mutations;

[Serializable]
public class MutationList : IMutation
{
	private List<IMutation> mutations;

	public void Setup(GameObject gm)
	{
		//IL_0226: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_006d: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		bool flag = mutations == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		GameObject gameObject = default(GameObject);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1720;
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj = (nint)0 + (nint)1712;
			List<object>.Enumerator enumerator = ((List<object>)(object)mutations).GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj4 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj5 = 0;
			gameObject = (GameObject)obj2;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)gameObject != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			gameObject = (GameObject)obj;
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj5 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B2B0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void Teardown()
	{
		//IL_022c: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0242: Expected I, but got O
		//IL_01cd: Expected I, but got O
		//IL_006d: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		bool flag = mutations == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1720;
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj = (nint)0 + (nint)1712;
			List<object>.Enumerator enumerator = ((List<object>)(object)mutations).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj4 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj5 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj5 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B2B0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void PerformMutation()
	{
		//IL_022c: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0242: Expected I, but got O
		//IL_01cd: Expected I, but got O
		//IL_006d: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		bool flag = mutations == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1720;
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj = (nint)0 + (nint)1712;
			List<object>.Enumerator enumerator = ((List<object>)(object)mutations).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj4 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj5 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj5 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B2B0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void UndoMutation()
	{
		//IL_022c: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0242: Expected I, but got O
		//IL_01cd: Expected I, but got O
		//IL_006d: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		bool flag = mutations == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1720;
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj = (nint)0 + (nint)1712;
			List<object>.Enumerator enumerator = ((List<object>)(object)mutations).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj4 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj5 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj5 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B2B0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public MutationList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
