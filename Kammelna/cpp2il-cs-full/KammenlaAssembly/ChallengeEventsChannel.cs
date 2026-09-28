using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public class ChallengeEventsChannel : ScriptableObject
{
	private Action<FriendlyChallengeData> m_OnChallengeActivity;

	private Action<FriendlyChallengeInviteModel> m_OnChallengeInviteReceived;

	private Action<FriendlyChallengeInviteError> m_OnInviteError;

	private Action<FriendlyChallengeResponseError> m_OnResponseError;

	private Action<int> m_OnChallengeCreateStarted;

	private Action<FriendlyChallengeEntryModel[]> m_OnChallengeDataReceived;

	private Action<bool> m_OnChallengeCancelled;

	private Action m_OnChallengeWithdrawn;

	public event Action<FriendlyChallengeData> OnChallengeActivity
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2032;
			object obj2 = this + 24;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2032;
			object obj2 = this + 24;
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

	public event Action<FriendlyChallengeInviteModel> OnChallengeInviteReceived
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2048;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2048;
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

	public event Action<FriendlyChallengeInviteError> OnInviteError
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2040;
			object obj2 = this + 40;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2040;
			object obj2 = this + 40;
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

	public event Action<FriendlyChallengeResponseError> OnResponseError
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2056;
			object obj2 = this + 48;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2056;
			object obj2 = this + 48;
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

	public event Action<int> OnChallengeCreateStarted
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj2 = this + 56;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj2 = this + 56;
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

	public event Action<FriendlyChallengeEntryModel[]> OnChallengeDataReceived
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 960;
			object obj2 = this + 64;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 960;
			object obj2 = this + 64;
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

	public event Action<bool> OnChallengeCancelled
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = this + 72;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = this + 72;
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

	public event Action OnChallengeWithdrawn
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 80;
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
			object obj2 = this + 80;
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

	public void TriggerChallengeActivity(FriendlyChallengeData data)
	{
		Actions.SafeInvoke((Action<object>)this.OnChallengeActivity, data);
	}

	public void TriggerInviteError(FriendlyChallengeInviteError error)
	{
		Actions.SafeInvoke((Action<System.Int32Enum>)(object)this.OnInviteError, (System.Int32Enum)error);
	}

	public void TriggerResponseEError(FriendlyChallengeResponseError error)
	{
		Actions.SafeInvoke((Action<System.Int32Enum>)(object)this.OnResponseError, (System.Int32Enum)error);
	}

	public void TriggerChallengeDataReceived(FriendlyChallengeEntryModel[] data)
	{
		Actions.SafeInvoke((Action<object>)this.OnChallengeDataReceived, data);
	}

	public void TriggerOnInviteReceived(FriendlyChallengeInviteModel inviteModel)
	{
		Actions.SafeInvoke((Action<object>)this.OnChallengeInviteReceived, inviteModel);
	}

	public void TriggerOnChallengeCreateStarted(int userID)
	{
		int arg = default(int);
		Actions.SafeInvoke(this.OnChallengeCreateStarted, arg);
	}

	public void TriggerChallengeCancelled(bool success)
	{
		bool arg = default(bool);
		Actions.SafeInvoke(this.OnChallengeCancelled, arg);
	}

	public void TriggerChallengeWithdrawn()
	{
		Actions.SafeInvoke(this.OnChallengeWithdrawn);
	}
}
