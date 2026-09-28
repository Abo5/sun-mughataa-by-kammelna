using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public abstract class EqualityCondition<T> : ICondition where T : IComparable
{
	public EqualityOperator op;

	public T Value;

	public virtual string Name
	{
		get
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_0071: Expected O, but got I
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00a0: Expected O, but got I
			//IL_00df: Expected O, but got I4
			if (this != null)
			{
				Type type = GetType();
				if ((object)type != null)
				{
					string name = type.Name;
					if (name != null)
					{
						object oldValue = "Complete" + 208;
						object newValue = (nint)0 + (nint)2000;
						object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
						object pattern = "&action=sign-up" + 2472;
						object replacement = (nint)0 + (nint)3288;
						string input = name.Replace((string)oldValue, (string)newValue);
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+E4]");
						bool flag = (nint)0 == 0;
						object obj3 = !flag;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						return Regex.Replace(input, (string)pattern, (string)replacement);
					}
				}
			}
			return (string)(object)new NullReferenceException();
		}
	}

	protected abstract T ActualValue { get; }

	public bool Satisfied
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Expected I, but got O
			object obj = "SERVICE_DISABLED" + 1608;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ X8_v3 (Il2CppClass<UI.Conditions.EqualityCondition`1<T>>)+1D8] (should have been resolved before IL gen)");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D2FA7C");
			bool result = default(bool);
			return result;
		}
	}

	public event Action OnConditionChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 16;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 16;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public virtual void Setup(GameObject gm)
	{
	}

	public virtual void Teardown()
	{
	}

	protected void TriggerValueChange()
	{
		Actions.SafeInvoke(this.OnConditionChanged);
	}
}
