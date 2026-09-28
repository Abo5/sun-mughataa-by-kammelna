using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.Device;

public class InMemoryCacheAssetLoader : IAssetLoader
{
	private class CachedAssetModel
	{
		private readonly string <AssetId>k__BackingField;

		private readonly DateTime <Timestamp>k__BackingField;

		private readonly object <AssetData>k__BackingField;

		public string AssetId => <AssetId>k__BackingField;

		public DateTime Timestamp => <Timestamp>k__BackingField;

		public object AssetData => <AssetData>k__BackingField;

		public CachedAssetModel(string assetId, object assetData, DateTime timestamp)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = assetId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 32;
			obj2 = assetData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private sealed class <>c__DisplayClass7_0<T> where T : class
	{
		public AssetLoadingModel<T> asset;

		internal bool <LoadAsset>b__0(CachedAssetModel pair)
		{
			//IL_0074: Expected I4, but got O
			if (pair != null)
			{
				AssetLoadingModel<T> assetLoadingModel = asset;
				if (asset != null)
				{
					return pair.<AssetId>k__BackingField == assetLoadingModel.<AssetId>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public string assetId;

		internal bool <DeleteAsset>b__0(CachedAssetModel pair)
		{
			//IL_0048: Expected I4, but got O
			if (pair != null)
			{
				return pair.<AssetId>k__BackingField == assetId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <LoadAsset>d__7<T> : IEnumerator<object>, IEnumerator, IDisposable where T : class
	{
		private int <>1__state;

		private object <>2__current;

		public AssetLoadingModel<T> asset;

		public InMemoryCacheAssetLoader <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadAsset>d__7(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0024: Expected I4, but got I8
			//IL_003a: Expected O, but got I
			//IL_0050: Expected O, but got I
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0078: Expected O, but got I4
			//IL_0495: Expected I4, but got O
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_0160: Expected O, but got I
			//IL_01d6: Expected O, but got I
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Expected O, but got Unknown
			//IL_039e: Expected O, but got I4
			//IL_04c5: Expected O, but got I
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected O, but got Unknown
			//IL_02f5: Expected O, but got I
			//IL_02f5: Expected O, but got I
			//IL_03d1: Expected O, but got I
			//IL_03e7: Expected O, but got I
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Expected O, but got Unknown
			//IL_040f: Expected O, but got I4
			//IL_0314: Expected O, but got I4
			//IL_031d: Expected O, but got I4
			//IL_032d: Expected O, but got I
			//IL_0259: Expected O, but got I
			//IL_0259: Expected O, but got I
			//IL_0271: Expected O, but got I4
			//IL_0281: Expected O, but got I
			//IL_0482: Expected O, but got I4
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Expected O, but got Unknown
			//IL_0458: Expected O, but got I4
			InMemoryCacheAssetLoader inMemoryCacheAssetLoader;
			object obj10;
			if (<>1__state == 0)
			{
				inMemoryCacheAssetLoader = <>4__this;
				<>1__state = -1;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6 (Il2CppRgctx<InMemoryCacheAssetLoader+<LoadAsset>d__7`1>)+8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6 (Il2CppRgctx<InMemoryCacheAssetLoader+<LoadAsset>d__7`1>)+8]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31F0500");
				object obj5 = default(object);
				if (obj5 != null)
				{
					object obj6 = obj5 + 16;
					obj6 = asset;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (<>4__this != null)
					{
						object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 440;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v15 (Il2CppRgctx<InMemoryCacheAssetLoader+<LoadAsset>d__7`1>)+20]");
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor(obj5, (IntPtr)0);
						object obj8 = (nint)0 + (nint)1472;
						object obj9 = obj8;
						obj10 = Enumerable.FirstOrDefault(inMemoryCacheAssetLoader.<LoadedAssets>k__BackingField, func);
						if (obj10 == null)
						{
							goto IL_0005;
						}
						object obj11 = obj6;
						if (obj6 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v19+28]");
							object obj12 = (nint)0 & (nint)1;
							bool flag2 = obj12 == null;
							Func<object, bool> func2 = func;
							if (!flag2)
							{
								object obj13 = typeof(DataRelation) + 712;
								object obj14 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v31+E4]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v12 (System.Object)+18]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v19+30]");
									bool flag3 = (DateTime)num4 < (DateTime)0;
									bool flag4 = !flag3;
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v19+30]");
									func2 = (Func<object, bool>)0;
									if (!flag4)
									{
										goto IL_028f;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v12 (System.Object)+18]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v19+30]");
									bool flag5 = (DateTime)num5 < (DateTime)0;
									bool flag6 = !flag5;
									object obj15 = !flag6;
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v19+30]");
									func2 = (Func<object, bool>)0;
									if (obj15 != null)
									{
										goto IL_028f;
									}
								}
								obj11 = obj6;
								if (obj6 == null)
								{
									goto IL_0487;
								}
							}
							object obj16 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v22+E4]");
							bool flag7 = (nint)0 == 0;
							object obj18 = !flag7;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v19+20]");
							FileUtils.UpdateLastAccessTime((string)0);
							if (obj6 != null)
							{
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v24 (Il2CppRgctx<InMemoryCacheAssetLoader+<LoadAsset>d__7`1>)+38]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v24 (Il2CppRgctx<InMemoryCacheAssetLoader+<LoadAsset>d__7`1>)+38]");
								object obj20 = (nint)0 + (nint)309;
								object obj21 = obj20 & 1;
								bool flag8 = obj21 == null;
								object obj22 = !flag8;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
									object obj23 = default(object);
									obj19 = obj23;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v12 (System.Object)+20]");
								object obj26;
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									object obj24 = default(object);
									bool flag9 = obj24 == null;
									object obj25 = !flag9;
									obj26 = obj24;
									if (obj25 == null)
									{
										throw new InvalidCastException();
									}
								}
								else
								{
									obj26 = 0;
								}
								object obj27 = obj6 + 72;
								obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return false;
							}
						}
					}
				}
				goto IL_0487;
			}
			goto IL_0005;
			IL_028f:
			if (inMemoryCacheAssetLoader.<LoadedAssets>k__BackingField != null)
			{
				bool flag10 = ((List<object>)(object)inMemoryCacheAssetLoader.<LoadedAssets>k__BackingField).Remove(obj10);
				return false;
			}
			goto IL_0487;
			IL_0487:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0005:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private readonly int _maxInMemoryAsset;

	private readonly List<CachedAssetModel> <LoadedAssets>k__BackingField;

	public bool IsLocalOnly => true;

	private List<CachedAssetModel> LoadedAssets => <LoadedAssets>k__BackingField;

	public InMemoryCacheAssetLoader(int maxInMemoryAsset = 200)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0067: Expected I, but got O
		object obj = typeof(List<Tween>) + 936;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1848;
		object obj3 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 24;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		_maxInMemoryAsset = maxInMemoryAsset;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityEngine.Application.LowMemoryCallback lowMemoryCallback = default(UnityEngine.Application.LowMemoryCallback);
		lowMemoryCallback..ctor(this, (IntPtr)obj3);
		UnityEngine.Device.Application.lowMemory += lowMemoryCallback;
	}

	public IEnumerator LoadAsset<T>(AssetLoadingModel<T> asset) where T : class
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b9: Expected I4, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00dc: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<LoadAsset>d__7<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<LoadAsset>d__7<T> <LoadAsset>d__ = (<LoadAsset>d__7<T>)(enumerator + 40);
			<LoadAsset>d__ = (<LoadAsset>d__7<T>)(object)this;
			<LoadAsset>d__..ctor((int)this);
			<LoadAsset>d__7<T> <LoadAsset>d__2 = (<LoadAsset>d__7<T>)(enumerator + 32);
			<LoadAsset>d__2 = (<LoadAsset>d__7<T>)(object)asset;
			<LoadAsset>d__2..ctor((int)asset);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public void CacheLoadedAsset<T>(AssetLoadingModel<T> asset) where T : class
	{
		//IL_0048: Expected I4, but got O
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		List<object> list = (List<object>)(object)<LoadedAssets>k__BackingField;
		bool flag = list._size <= _maxInMemoryAsset;
		int num = (int)asset;
		if (!flag)
		{
			object obj = (nint)0 + (nint)2776;
			list.RemoveAt(0);
			list = (List<object>)(object)<LoadedAssets>k__BackingField;
			num = 0;
		}
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string <AssetId>k__BackingField = asset.<AssetId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [asset @ X1 (AssetLoadingModel`1<T>)+48]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [asset @ X1 (AssetLoadingModel`1<T>)+30]");
		CachedAssetModel cachedAssetModel = default(CachedAssetModel);
		cachedAssetModel..ctor(<AssetId>k__BackingField, num2, (DateTime)0);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj4 = items + list._size;
			object obj5 = obj4 + 32;
			obj5 = cachedAssetModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)cachedAssetModel);
		}
	}

	public void DeleteAsset(string assetId, string localAssetPath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 440;
		object obj4 = (nint)0 + (nint)48;
		object obj5 = obj2 + 16;
		obj5 = assetId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj6 = Enumerable.FirstOrDefault(<LoadedAssets>k__BackingField, func);
		if (obj6 != null)
		{
			bool flag = ((List<object>)(object)<LoadedAssets>k__BackingField).Remove(obj6);
		}
	}

	public void ResetEnvironment()
	{
		List<CachedAssetModel> list = <LoadedAssets>k__BackingField;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
	}

	private void OnLowMemory()
	{
		List<CachedAssetModel> list = <LoadedAssets>k__BackingField;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
	}
}
