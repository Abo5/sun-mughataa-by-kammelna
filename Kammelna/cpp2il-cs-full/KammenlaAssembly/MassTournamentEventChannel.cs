using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

public class MassTournamentEventChannel : ScriptableObject
{
	private readonly OneShotEvent<MassTournamentServerConnector> <ReadyState>k__BackingField;

	private Action<MassTournamentPlayerState> m_OnMassPlayerStateChanged;

	private Action m_OnStagesButtonClicked;

	public OneShotEvent<MassTournamentServerConnector> ReadyState => <ReadyState>k__BackingField;

	public event Action<MassTournamentPlayerState> OnMassPlayerStateChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action OnStagesButtonClicked
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
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
			object obj2 = this + 40;
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

	public void TriggerPlayerStateChanged(MassTournamentPlayerState playerState)
	{
		Actions.SafeInvoke((Action<object>)this.OnMassPlayerStateChanged, playerState);
	}

	public void TriggerStagesButtonClicked()
	{
		Actions.SafeInvoke(this.OnStagesButtonClicked);
	}

	public void Clear()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39979B0");
	}

	public MassTournamentEventChannel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 2928;
		object obj2 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997628");
		object obj3 = this + 24;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
