using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Coordinator.Models;
using Server.Models;

namespace Kammelna.Server;

public class ListDeltaApplier<TModel, TId> : ContentApplier, IDeltaSyncApplier where TId : IEquatable<TId>
{
	private sealed class <>c__DisplayClass10_0
	{
		public Action<bool> onDone;

		public long cursor;

		public CachedModel<List<TModel>> cache;

		public ListDeltaApplier<TModel, TId> <>4__this;

		internal void <FetchSince>b__0(KammelnaResponseModel<ContentDeltaModel<TModel, TId>> response)
		{
			//IL_00e6: Expected O, but got I4
			//IL_022a: Expected O, but got I
			//IL_023a: Expected O, but got I
			//IL_024a: Expected O, but got I
			//IL_0101: Expected O, but got I
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_015b: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0214: Expected O, but got I4
			//IL_01d7: Expected O, but got I
			if (((KammelnaResponseModel<object>)(object)response).Succeeded && response.<Model>k__BackingField != null)
			{
				if (cursor != 0)
				{
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328BCEC");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v25 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2+<>c__DisplayClass10_0>)+50]");
					ContentDeltaModel<TModel, TId> contentDeltaModel = (ContentDeltaModel<TModel, TId>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D391C4");
					ContentDeltaModel<TModel, TId> <Model>k__BackingField = response.<Model>k__BackingField;
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v21 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2+<>c__DisplayClass10_0>)+30]");
					ContentDeltaModel<TModel, TId> <Model>k__BackingField = (ContentDeltaModel<TModel, TId>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328BDF8");
					ContentDeltaModel<TModel, TId> contentDeltaModel = response.<Model>k__BackingField;
				}
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				nint num4 = 0;
				((CachedModel<object>)(object)cache).LastUpdate = now;
				object obj4 = default(object);
				if (obj4 != null)
				{
					ListDeltaApplier<TModel, TId> listDeltaApplier = <>4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v18 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+30]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v18 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ X8_v19+18] (should have been resolved before IL gen)");
					}
				}
				goto IL_0254;
			}
			Action<bool> action = onDone;
			if (onDone != null)
			{
				object obj6 = 0;
				goto IL_021a;
			}
			return;
			IL_0254:
			action = onDone;
			if (onDone != null)
			{
				object obj6 = 1;
				goto IL_021a;
			}
			return;
			IL_021a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6 (System.Action`1<System.Boolean>)+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6 (System.Action`1<System.Boolean>)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6 (System.Action`1<System.Boolean>)+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_0254;
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public ContentDeltaModel<TModel, TId> delta;

		public ListDeltaApplier<TModel, TId> <>4__this;

		internal List<TModel> <Merge>b__0(List<TModel> current)
		{
			//IL_001c: Expected O, but got I
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0109: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			nint num = 0;
			IntPtr intPtr = num;
			object obj = num + 309;
			List<object> result;
			if (current != null)
			{
				object obj2 = obj & 1;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor((IEnumerable<object>)current);
				ListDeltaApplier<TModel, TId> listDeltaApplier = <>4__this;
				bool flag2 = <>4__this == null;
				result = list;
				if (!flag2)
				{
					goto IL_00cc;
				}
			}
			else
			{
				object obj4 = obj & 1;
				bool flag3 = obj4 == null;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list2 = default(List<object>);
				list2..ctor();
				ListDeltaApplier<TModel, TId> listDeltaApplier = <>4__this;
				bool flag4 = <>4__this == null;
				object obj6 = !flag4;
				result = list2;
				if (obj6 != null)
				{
					goto IL_00cc;
				}
			}
			return (List<TModel>)(object)new NullReferenceException();
			IL_00cc:
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D393E0");
			return (List<TModel>)(object)result;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public ContentDeltaModel<TModel, TId> delta;

		public bool changed;

		internal List<TModel> <Replace>b__0(List<TModel> current)
		{
			//IL_0116: Expected O, but got I
			//IL_012c: Expected O, but got I
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			//IL_0191: Expected O, but got I
			//IL_01b9: Expected O, but got I4
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			ContentDeltaModel<TModel, TId> contentDeltaModel = delta;
			object obj;
			if (delta != null)
			{
				obj = contentDeltaModel.<Upserts>k__BackingField;
				List<TModel> result;
				if (contentDeltaModel.<Upserts>k__BackingField != null)
				{
					bool flag = current == null;
					List<TModel> list = current;
					result = contentDeltaModel.<Upserts>k__BackingField;
					if (!flag)
					{
						goto IL_0066;
					}
				}
				else
				{
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2+<>c__DisplayClass12_0>)+18]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2+<>c__DisplayClass12_0>)+18]");
					object obj3 = (nint)0 + (nint)309;
					object obj4 = obj3 & 1;
					bool flag2 = obj4 == null;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v10 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2+<>c__DisplayClass12_0>)+20]");
					List<TModel> list = (List<TModel>)0;
					List<object> list2 = default(List<object>);
					list2..ctor();
					bool flag3 = current == null;
					object obj6 = !flag3;
					obj = list2;
					result = (List<TModel>)(object)list2;
					if (obj6 != null)
					{
						goto IL_0066;
					}
				}
				changed = true;
				return result;
			}
			return (List<TModel>)(object)new NullReferenceException();
			IL_0066:
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = JsonConvert.SerializeObject(current);
			string text2 = JsonConvert.SerializeObject(obj);
			bool flag5 = text != text2;
			changed = flag5;
			return (List<TModel>)obj;
		}
	}

	private readonly Func<string> _sincePath;

	private readonly Func<CachedModel<List<TModel>>> _cacheOf;

	private readonly Func<TModel, TId> _idOf;

	private readonly Action _onApplied;

	private readonly Action _onChanged;

	public ICachedModel Cache
	{
		get
		{
			//IL_0010: Expected O, but got I
			//IL_0045: Expected O, but got I
			//IL_0055: Expected O, but got I
			//IL_0065: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			return (ICachedModel)new NullReferenceException();
		}
	}

	public ListDeltaApplier(string wireKey, Func<string> sincePath, Func<CachedModel<List<TModel>>> cacheOf, Func<TModel, TId> idOf, Action onApplied = null, Action onChanged = null)
		: base(wireKey)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		object obj = this + 24;
		obj = sincePath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = cacheOf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 40;
		obj3 = idOf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 48;
		obj4 = onApplied;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 56;
		obj5 = onChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void ApplyChanged()
	{
		//IL_0010: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
		}
		base.ApplyChanged();
	}

	public override void ApplyDelta(string payloadJson)
	{
		//IL_022e: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ X8_v3+18] (should have been resolved before IL gen)");
		nint num = 0;
		CachedModel<object> cachedModel = default(CachedModel<object>);
		object model = cachedModel.Model;
		if (model == null)
		{
			return;
		}
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v8+E4]");
		object obj4 = default(object);
		if ((nint)0 != 0)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
			if (obj4 == null)
			{
				return;
			}
		}
		bool flag2 = cachedModel.IsValid();
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328BCEC");
		if (flag2)
		{
			object obj6 = typeof(DataRelation) + 712;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			cachedModel.LastUpdate = now;
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D391C4");
		object obj9 = default(object);
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+30]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+30]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v96 @ X8_v18+18] (should have been resolved before IL gen)");
			}
		}
	}

	public void FetchSince(long cursor, Action<bool> onDone)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0143: Expected O, but got I4
		//IL_02b4: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+68]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D30C4");
		object obj6 = default(object);
		object obj5 = obj6 + 16;
		obj5 = onDone;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj6 + 40;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+20]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ X8_v8+18] (should have been resolved before IL gen)");
		object obj9 = obj6 + 32;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object model = ((CachedModel<object>)obj9).Model;
		bool flag2 = model == null;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.ListDeltaApplier`2<TModel, TId>)+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X8_v11+18] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v13 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+78]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v13 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+78]");
		object obj14 = (nint)0 + (nint)309;
		object obj15 = obj14 & 1;
		bool flag3 = obj15 == null;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4492B9C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v19 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+90]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v19 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+90]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag4 = obj19 == null;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v23 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+88]");
		Action<object> action = default(Action<object>);
		action..ctor(obj6, (IntPtr)0);
		IWebRequest<object> request = default(IWebRequest<object>);
		KammelnaRequests.Send(request, action);
	}

	private void Merge(CachedModel<List<TModel>> cache, ContentDeltaModel<TModel, TId> delta)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_01a2: Expected I8, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+B0]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D5050");
		object obj6 = default(object);
		object obj5 = obj6 + 16;
		obj5 = delta;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj6 + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+C8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+C8]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag2 = obj10 == null;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v13 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+C0]");
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj6, (IntPtr)0);
		((CachedModel<object>)(object)cache).Mutate(func);
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v16+20]");
		((CachedModel<object>)(object)cache).ServerCursor = 0L;
	}

	private static bool Replace(CachedModel<List<TModel>> cache, ContentDeltaModel<TModel, TId> delta)
	{
		//IL_000c: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_019a: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0063: Expected O, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_01dd: Expected O, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_0722: Expected I4, but got O
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0449: Expected O, but got I
		//IL_0459: Expected O, but got I
		//IL_046f: Expected O, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_0497: Expected O, but got I4
		//IL_04a7: Expected O, but got I
		//IL_0351: Expected O, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0381: Expected O, but got I4
		//IL_02ea: Expected O, but got I
		//IL_0300: Expected O, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_032d: Expected O, but got I
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0567: Expected O, but got I4
		//IL_03c1: Expected O, but got I
		//IL_03d1: Expected O, but got I
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_04da: Expected O, but got I
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_05ec: Expected O, but got I
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_0614: Expected O, but got I4
		//IL_0675: Expected O, but got I
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06a5: Expected O, but got I4
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_074a: Expected O, but got I4
		//IL_0707: Expected I8, but got I
		//IL_06cf: Expected O, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		if (obj2 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v47 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+F0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v47 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+F0]");
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag = obj5 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v47 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+F0]");
			object obj6 = 0;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v45+C0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v39+F0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v39+F0]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag2 = obj9 == null;
			object obj10 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v39+F0]");
			object obj6 = 0;
			if (obj10 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		object obj15 = default(object);
		object obj14 = obj15;
		object obj16 = obj15;
		nint num2 = 0;
		if (obj13 != null)
		{
			goto IL_00f5;
		}
		goto IL_0229;
		IL_03ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj17 = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v32+C0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v28+100]");
		nint num3 = 0;
		object obj19 = obj17 & 1;
		bool flag4 = obj19 == null;
		nint num4 = 0;
		if (flag4)
		{
			goto IL_058d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v28+100]");
		nint method = 0;
		Func<object, object> func2;
		Func<object, object> func = func2;
		goto IL_05ac;
		IL_0529:
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+100]");
		num3 = 0;
		object obj21;
		object obj20 = obj21 & 1;
		bool flag5 = obj20 == null;
		object obj22 = !flag5;
		func2 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+100]");
		method = 0;
		if (obj22 == null)
		{
			goto IL_058d;
		}
		goto IL_05ac;
		IL_033b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)309;
		obj21 = obj23;
		object obj24 = obj23 & 1;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		nint num6 = 0;
		Func<object, object> func3 = default(Func<object, object>);
		func2 = func3;
		num4 = 0;
		func = func3;
		if (obj25 == null)
		{
			goto IL_03ab;
		}
		goto IL_0529;
		IL_009e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag7 = obj27 == null;
		object obj28 = default(object);
		obj14 = obj28;
		obj16 = obj28;
		num2 = 0;
		if (!flag7)
		{
			goto IL_00f5;
		}
		goto IL_0229;
		IL_0229:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v39+C0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D638C");
		bool flag8 = obj16 == null;
		obj14 = obj16;
		if (!flag8)
		{
			goto IL_0277;
		}
		goto IL_0714;
		IL_00f5:
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D638C");
		bool flag9 = obj14 == null;
		object obj30 = !flag9;
		if (obj30 != null)
		{
			goto IL_0277;
		}
		goto IL_0714;
		IL_0277:
		object obj31 = obj14 + 16;
		obj31 = delta;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		if (obj33 != null)
		{
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v31 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+C8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v31 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+C8]");
			object obj35 = (nint)0 + (nint)309;
			object obj36 = obj35 & 1;
			bool flag10 = obj36 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v31 (Il2CppRgctx<Kammelna.Server.ListDeltaApplier`2>)+C8]");
			object obj37 = 0;
			if (!flag10)
			{
				goto IL_033b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v29+C0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v23+C8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v23+C8]");
			object obj39 = (nint)0 + (nint)309;
			object obj40 = obj39 & 1;
			bool flag11 = obj40 == null;
			object obj41 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v23+C8]");
			object obj37 = 0;
			if (obj41 != null)
			{
				goto IL_033b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)309;
		obj21 = obj42;
		object obj43 = obj42 & 1;
		bool flag12 = obj43 == null;
		num6 = 0;
		Func<object, object> func4 = default(Func<object, object>);
		func2 = func4;
		num4 = 0;
		func = func4;
		if (flag12)
		{
			goto IL_03ab;
		}
		goto IL_0529;
		IL_05ac:
		nint num9 = 0;
		func..ctor(obj14, (IntPtr)method);
		if (cache != null)
		{
			object obj44 = (nint)0 + (nint)309;
			object obj45 = obj44 & 1;
			bool flag13 = obj45 == null;
			object obj46 = !flag13;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			nint num10 = 0;
			((CachedModel<object>)(object)cache).Mutate(func);
			object obj47 = obj31;
			if (obj31 != null)
			{
				object obj48 = (nint)0 + (nint)309;
				object obj49 = obj48;
				object obj50 = obj48 & 1;
				bool flag14 = obj50 == null;
				object obj51 = !flag14;
				nint num11 = 0;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj52 = (nint)0 + (nint)309;
					obj49 = obj52;
					num11 = 0;
				}
				object obj53 = obj49 & 1;
				bool flag15 = obj53 == null;
				object obj54 = !flag15;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X22_v4+20]");
				((CachedModel<object>)(object)cache).ServerCursor = 0L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v2 (System.Object)+18]");
				return false;
			}
		}
		goto IL_0714;
		IL_0714:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_058d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		method = num3;
		func = func2;
		goto IL_05ac;
	}
}
