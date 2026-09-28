# الفهرس العالمي للعناوين — أرشيف «كملنا»

> **هذا الملف للوكلاء الآليّين قبل البشر.** كل عنوان ذُكر في أي فصل من الأرشيف، مربوطًا
> باسم الدالّة من `source-code/il2cpp-dump/script.json.gz` وبالملفات التي توثّقه.
>
> مُولَّد آليًّا — لا يُحرَّر يدويًّا.

## كيف تستعمله

* **معك عنوان وتريد معناه** → ابحث عن `0x…` في العمود الأول.
* **معك اسم دالّة وتريد أين وُثّقت** → ابحث عن الاسم في العمود الثاني، ثم افتح الملفات في العمود الأخير.
* `+0xNN` في عمود النوع يعني أن العنوان **داخل** الدالّة لا نقطة دخولها.
* `data/other` = جدول ثابت أو سلسلة أو ميتاداتا، لا دالّة.
* **عنوان يظهر تحته أكثر من أرشيف = حقيقة تحقّقت مرّتين** من مصدرين مستقلّين.

## الإحصاء

| البند | العدد |
|---|---|
| عناوين فريدة موثّقة | **4459** |
| منها نقاط دخول دوالّ مطابقة | **3203** |
| مواضع داخل دوالّ | 1138 |
| جداول/بيانات | 118 |

| الأرشيف | عناوين |
|---|---|
| [بلوت](baloot-spec/README.md) | 2044 |
| [جكارو](jackaroo-spec/README.md) | 1133 |
| [اقتصاد](economy-spec/README.md) | 414 |
| [واجهة](ui-spec/README.md) | 387 |
| [اجتماعي](social-spec/README.md) | 359 |
| [إعادة](replay-spec/README.md) | 329 |
| [بيانات](data-spec/README.md) | 246 |
| [ردهة](lobby-spec/README.md) | 237 |
| [طرنيب](tarneeb-spec/README.md) | 188 |
| [تفضيلات](prefs-spec/README.md) | 107 |
| [صوتيّة](voice-spec/README.md) | 78 |
| [هوية](identity-spec/README.md) | 74 |
| [تعريب](l10n-spec/README.md) | 59 |
| [أنماط](modes-spec/README.md) | 43 |
| [مصادقة](auth-spec/README.md) | 35 |
| [تجميليات](cosmetics-spec/README.md) | 34 |
| [إعلانات](ads-spec/README.md) | 30 |
| [إعدادات](config-spec/README.md) | 29 |
| [إشعارات](notifications-spec/README.md) | 25 |
| [صوت](sound-spec/README.md) | 25 |
| [توقّعات](predictions-spec/README.md) | 17 |
| [صدارة](leaderboards-spec/README.md) | 7 |

## الجدول

| العنوان | الدالّة | النوع | موثَّق في |
|---|---|---|---|
| `0x060C000` | `—` | data/other | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x0800000` | `—` | data/other | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x0A24000` | `—` | data/other | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x0AAA5D0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x0AAA5E8` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x0AAA650` | `—` | data/other | [إعدادات](config-spec/01-RemoteConfig.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x0ABC448` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x0ABC4D8` | `—` | data/other | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x0ABC538` | `—` | data/other | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x0ABC550` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/README.md) |
| `0x0ABC580` | `—` | data/other | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x0ABC5A8` | `—` | data/other | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/README.md) |
| `0x0AC174C` | `—` | data/other | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x0B0D070` | `—` | data/other | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x1900064` | `—` | data/other | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x210C200` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x2700000` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) · [اجتماعي](social-spec/04-نظام-الإحالة.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x281ACA4` | `DG.Tweening.DOTween::Init` | inside (+0x654) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x281D80C` | `DG.Tweening.Sequence::Setup` | inside (+0x4C) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x2863BBC` | `DG.Tweening.Core.TweenManager::Update` | inside (+0xBC) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x28EEBA4` | `Firebase.FirebaseApp::CheckAndFixDependenciesAsync` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x29EAF0C` | `System.Array::InternalArray__ICollection_Contains<TutorialError>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2A668D4` | `System.Array::InternalArray__IEnumerable_GetEnumerator<TutorialError>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2AE0474` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::FilterList<__Il2CppFullySharedGenericType>` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x2B17EBC` | `System.Array::InternalArray__IndexOf<TutorialError>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2B6BF5C` | `System.Array::InternalArray__get_Item<TutorialError>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2BBEB4C` | `System.Array::InternalArray__set_Item<TutorialError>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2C97010` | `ArraysExtensions::GetPowerSet<ProjectsUtility.Project<Int32Enum>>` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x2C97AD0` | `ArraysExtensions::IsNullOrEmpty<object>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x2C9897C` | `ArraysExtensions::MaxBy<ProjectsUtility.Project<Int32Enum>>` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x2C9A7CC` | `ArraysExtensions::Shuffle<object>` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x2D21984` | `CheatingCatchPopup::InitializeCheatingBoxes<object>` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2D2F6B4` | `UI.Conditions.ComparisonOperatorExtensions::Apply<Int32Enum>` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x2D31A5C` | `UnityEngine.Component::GetComponents<object>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x2D391C4` | `Kammelna.Server.ContentDeltaMerge::HasChanges<object, int>` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x2D393E0` | `Kammelna.Server.ContentDeltaMerge::Merge<object, int>` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2D394F8` | `Kammelna.Server.ContentDeltaMerge::Merge<object, int>` | inside (+0x118) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2D395C4` | `Kammelna.Server.ContentDeltaMerge::Merge<object, int>` | inside (+0x1E4) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2D39638` | `Kammelna.Server.ContentDeltaMerge::Merge<object, int>` | inside (+0x258) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2D396CC` | `Kammelna.Server.ContentDeltaMerge::Merge<object, int>` | inside (+0x2EC) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2D70D14` | `EnumExtensions::AddFlag<__Il2CppFullySharedGenericStructType>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2D710E0` | `EnumExtensions::RemoveFlag<__Il2CppFullySharedGenericStructType>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2D712E8` | `EnumExtensions::ToEnum<Int32Enum>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2D714F0` | `EnumExtensions::ToEnum<__Il2CppFullySharedGenericStructType>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2D71784` | `EnumExtensions::ToggleFlag<__Il2CppFullySharedGenericStructType>` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x2D72A08` | `EnumMethods::TryFromFriendlyName<Int32Enum>` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x2D774F4` | `System.Linq.Enumerable::All<object>` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x2DC3054` | `System.Linq.Enumerable::First<object>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x2DC57DC` | `System.Linq.Enumerable::FirstOrDefault<object>` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x2DEB694` | `System.Linq.Enumerable::Where<ValueTuple<object, object>>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x2E03FA4` | `FileUtils::LoadObject<object>` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x2E34714` | `Features.GameReplay.GameReplayCardData::SwapTeamsToCardOrder<int>` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x2E34D5C` | `Features.GameReplay.GameReplayCardData::ToCardOrder<int>` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x2E352B8` | `Features.GameReplay.GameReplayManager::SetGameReplayController<object>` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x2E354B8` | `Features.GameReplay.GameReplayUtils::GetFirstInstance<int>` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x2E724DC` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E72558` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0x7C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E7255C` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0x80) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E72560` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0x84) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E72564` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0x88) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E72578` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0x9C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E7257C` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0xA0) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E72584` | `InMemoryCacheAssetLoader::CacheLoadedAsset<object>` | inside (+0xA8) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x2E8F19C` | `JackarooRoomListView::SetRooms<object>` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x2EE9D50` | `UnityEngine.Object::Instantiate<object>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x2F81144` | `Prefs::GetData<object>` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x2F812BC` | `Prefs::GetEnum<Int32Enum>` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x2F81418` | `Prefs::SetData<object>` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x2F81564` | `Prefs::SetEnum<Int32Enum>` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x301E1A4` | `Kammelna.Server.SFS::LoadRoomsList<object>` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x301EA80` | `SFSExtensions::Get<Int32Enum>` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x302115C` | `SaveLoadUtils::LoadItems<object>` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021410` | `SaveLoadUtils::LoadItemsWeb<object>` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021614` | `SaveLoadUtils::Save<object>` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021694` | `SaveLoadUtils::Save<object>` | inside (+0x80) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x30216A4` | `SaveLoadUtils::Save<object>` | inside (+0x90) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x30216E4` | `SaveLoadUtils::Save<object>` | inside (+0xD0) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021708` | `SaveLoadUtils::Save<object>` | inside (+0xF4) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021724` | `SaveLoadUtils::Save<object>` | inside (+0x110) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x302173C` | `SaveLoadUtils::Save<object>` | inside (+0x128) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021760` | `SaveLoadUtils::Save<object>` | inside (+0x14C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x3021794` | `SaveLoadUtils::Save<object>` | inside (+0x180) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x30217F0` | `SaveLoadUtils::Save<object>` | inside (+0x1DC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x303347C` | `System.String::Join<int>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x3044EA4` | `System.Threading.Tasks.Task::WhenAll<bool>` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x304E70C` | `TournamentAddonListExtensions::HasAddonOfType<object>` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x3107644` | `Kammelna.Server.WebRequests.WebRequestExtensions::ApplyDecorators<object>` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x31479D0` | `AnimatedItemDataAsset::CreateMarblePrefabItem<object>` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x31B2CC8` | `CardsOrganizer.<>c<object>::.cctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x31B2E2C` | `CardsOrganizer.<>c<object>::<GetCardSpacingForBottomRow>b__17_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x31B2E58` | `CardsOrganizer.<>c<object>::<GetCardRotationForBottomRow>b__18_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x31B2E84` | `CardsOrganizer.<>c<object>::<ReorganizeCards>b__19_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x31B2EB0` | `CardsOrganizer.<>c<object>::<ReorganizeCards>b__19_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x31B2EDC` | `CardsOrganizer.<>c<object>::<ReorganizeCards>b__19_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x31B3224` | `Server.Models.ClientFilterProjection.<>c<object>::<BuildFilter>b__5_0` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x31D2624` | `Kammelna.Server.ContentDeltaMerge.<>c__DisplayClass0_0<object, int>::<Merge>b__0` | inside (+0x54) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D2C04` | `Kammelna.Server.ContentDeltaMerge.<>c__DisplayClass0_1<object, int>::<Merge>b__1` | inside (+0x74) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D30CC` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3108` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x3C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3120` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x54) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3128` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x5C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D312C` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x60) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3130` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x64) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3150` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x84) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3164` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x98) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3174` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0xA8) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D317C` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0xB0) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3190` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0xC4) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D31E4` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, int>::<FetchSince>b__0` | inside (+0x118) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3304` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, long>::<FetchSince>b__0` | inside (+0xC4) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3478` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<object, object>::<FetchSince>b__0` | inside (+0xC4) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D3528` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::<FetchSince>b__0` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D35B4` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass10_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::<FetchSince>b__0` | inside (+0x8C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D6404` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass12_0<object, int>::<Replace>b__0` | inside (+0x70) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D6414` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass12_0<object, int>::<Replace>b__0` | inside (+0x80) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D6424` | `Kammelna.Server.ListDeltaApplier.<>c__DisplayClass12_0<object, int>::<Replace>b__0` | inside (+0x90) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x31D71A8` | `ArraysExtensions.<>c__DisplayClass14_0<KeyValuePair<Int32Enum, int>>::<MaxBy>b__0` | inside (+0xE8) | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x31D72C4` | `ArraysExtensions.<>c__DisplayClass14_0<ProjectsUtility.Project<Int32Enum>>::<MaxBy>b__0` | inside (+0xFC) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x31DB2E4` | `SaveLoadUtils.<>c__DisplayClass1_0<object>::<LoadItems>b__0` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DB404` | `SaveLoadUtils.<>c__DisplayClass1_0<object>::<LoadItems>b__0` | inside (+0x120) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DB464` | `SaveLoadUtils.<>c__DisplayClass1_0<object>::<LoadItems>b__0` | inside (+0x180) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DB50C` | `SaveLoadUtils.<>c__DisplayClass1_0<object>::<LoadItems>b__0` | inside (+0x228) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DBA4C` | `SaveLoadUtils.<>c__DisplayClass1_1<object>::<LoadItems>b__1` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DBAB8` | `SaveLoadUtils.<>c__DisplayClass1_1<object>::<LoadItems>b__1` | inside (+0x6C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DBAF8` | `SaveLoadUtils.<>c__DisplayClass1_1<object>::<LoadItems>b__1` | inside (+0xAC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DBB24` | `SaveLoadUtils.<>c__DisplayClass1_1<object>::<LoadItems>b__1` | inside (+0xD8) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DBB94` | `SaveLoadUtils.<>c__DisplayClass1_1<object>::<LoadItems>b__1` | inside (+0x148) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DBD04` | `SaveLoadUtils.<>c__DisplayClass1_1<object>::<LoadItems>b__1` | inside (+0x2B8) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x31DF1F0` | `Kammelna.Server.SFS.<>c__DisplayClass329_0<object>::<LoadRoomsList>b__0` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x31EEC7C` | `Server.Models.ClientFilterProjection.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::<FilterList>b__0` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x328B910` | `Kammelna.Server.ListDeltaApplier<object, int>::.ctor` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328B9A4` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyChanged` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328B9C0` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyChanged` | inside (+0x1C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328B9C4` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BA14` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x50) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BA28` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x64) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BA40` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x7C) | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BA6C` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0xA8) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BA8C` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0xC8) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BAA4` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0xE0) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BAC4` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x100) | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BAC8` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x104) | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BB14` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x150) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BB18` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x154) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BB1C` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x158) | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x328BB40` | `Kammelna.Server.ListDeltaApplier<object, int>::ApplyDelta` | inside (+0x17C) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BC1C` | `Kammelna.Server.ListDeltaApplier<object, int>::FetchSince` | inside (+0xC0) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BC20` | `Kammelna.Server.ListDeltaApplier<object, int>::FetchSince` | inside (+0xC4) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BC24` | `Kammelna.Server.ListDeltaApplier<object, int>::FetchSince` | inside (+0xC8) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BC28` | `Kammelna.Server.ListDeltaApplier<object, int>::FetchSince` | inside (+0xCC) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BCEC` | `Kammelna.Server.ListDeltaApplier<object, int>::Merge` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BDF0` | `Kammelna.Server.ListDeltaApplier<object, int>::Merge` | inside (+0x104) | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x328BDF8` | `Kammelna.Server.ListDeltaApplier<object, int>::Replace` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x329941C` | `ListView.ListViewController<object, object, int>::get_data` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x32996EC` | `ListView.ListViewController<object, object, int>::Awake` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299774` | `ListView.ListViewController<object, object, int>::Awake` | inside (+0x88) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x32997A4` | `ListView.ListViewController<object, object, int>::Awake` | inside (+0xB8) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299A28` | `ListView.ListViewController<object, object, int>::UpdateItems` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299AEC` | `ListView.ListViewController<object, object, int>::UpdateItems` | inside (+0xC4) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299BFC` | `ListView.ListViewController<object, object, int>::Recycle` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299C34` | `ListView.ListViewController<object, object, int>::Recycle` | inside (+0x38) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299DC8` | `ListView.ListViewController<object, object, int>::RecycleItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299E2C` | `ListView.ListViewController<object, object, int>::RecycleItem` | inside (+0x64) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299E4C` | `ListView.ListViewController<object, object, int>::RecycleItem` | inside (+0x84) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3299EE0` | `ListView.ListViewController<object, object, int>::UpdateVisibleItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A298` | `ListView.ListViewController<object, object, int>::GetNewItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A3C4` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x12C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A42C` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x194) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A444` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x1AC) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A554` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x2BC) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A568` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x2D0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A76C` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x4D4) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A778` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x4E0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329A804` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x56C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329AA60` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x7C8) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329AB78` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x8E0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329AB7C` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x8E4) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329AB80` | `ListView.ListViewController<object, object, int>::GetNewItem` | inside (+0x8E8) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329ACFC` | `ListView.ListViewController<ReferralRewardHolder, object, int>::get_data` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x329F3EC` | `ListView.ListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::GetNewItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x33FC6D0` | `System.Collections.Generic.List<int>::Contains` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x3464528` | `System.Collections.Generic.List<object>::AddWithResize` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) · [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x3464A18` | `System.Collections.Generic.List<object>::Contains` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x3465664` | `System.Collections.Generic.List<object>::IndexOf` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x3466310` | `System.Collections.Generic.List<object>::RemoveAll` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x357B0EC` | `System.Collections.Generic.List<Vector2>::.ctor` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x371E4CC` | `MonthlyTrophyUISubSetter<object>::GetTrophyAsset` | method | [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x38B6A14` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::get_listHeight` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B6A40` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::set_data` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B70C4` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::GetRowRecursive` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B7A6C` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::RecycleRecursively` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B7F30` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::UpdateNestedItems` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B8714` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::RecycleChildren` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B8DD8` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::ScrollToIndex` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B9580` | `ListView.NestedListViewController<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::ToggleExpanded` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38B98E4` | `ListView.NestedListViewItemData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::get_children` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x38C293C` | `System.Nullable<Color>::get_Value` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x38C8F74` | `System.Nullable<long>::.ctor` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x39C364C` | `PooledObjectList<object>::GetPooledObject` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x39D8724` | `ProjectsUtility<Int32Enum>::GetBestProjectCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D9118` | `ProjectsUtility<Int32Enum>::ProjectsValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D94A8` | `ProjectsUtility<Int32Enum>::MutuallyExclusive` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D9578` | `ProjectsUtility<Int32Enum>::MutuallyExclusive` | inside (+0xD0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D9588` | `ProjectsUtility<Int32Enum>::MutuallyExclusive` | inside (+0xE0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D958C` | `ProjectsUtility<Int32Enum>::MutuallyExclusive` | inside (+0xE4) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D98A4` | `ProjectsUtility<Int32Enum>::CheckProject` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39D99D8` | `ProjectsUtility<Int32Enum>::CheckRankSequence` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DA2D4` | `ProjectsUtility<Int32Enum>::CheckRankSequence` | inside (+0x8FC) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DA2E8` | `ProjectsUtility<Int32Enum>::CheckRankSequence` | inside (+0x910) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DA2EC` | `ProjectsUtility<Int32Enum>::CheckRankSequence` | inside (+0x914) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DA318` | `ProjectsUtility<Int32Enum>::CheckRankSequence` | inside (+0x940) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DA328` | `ProjectsUtility<Int32Enum>::CheckRankSequence` | inside (+0x950) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DAA40` | `ProjectsUtility<Int32Enum>::CheckSuitsGroup` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DB214` | `ProjectsUtility<__Il2CppFullySharedGenericStructType>::GetBestProjectCards` | method | [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DC5AC` | `ProjectsUtility<__Il2CppFullySharedGenericStructType>::MutuallyExclusive` | method | [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DCB88` | `ProjectsUtility<__Il2CppFullySharedGenericStructType>::CheckRankSequence` | method | [بلوت](baloot-spec/refs/address-index.md) |
| `0x39DDC10` | `ProjectsUtility<__Il2CppFullySharedGenericStructType>::CheckSuitsGroup` | method | [بلوت](baloot-spec/refs/address-index.md) |
| `0x3E23740` | `BaseDropMenu<object>::SetupItems` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x3E240F4` | `BaseDropMenu<object>::Hide` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x3EB52A0` | `Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator<bool>::HandleAuthenticationFailed` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) · [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x3EB54AC` | `Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator<bool>::InitializeAuthHeader` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) · [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x3FBDD40` | `UiListView<object, object>::get_listHeight` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBDD90` | `UiListView<object, object>::set_data` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE358` | `UiListView<object, object>::Awake` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE428` | `UiListView<object, object>::Start` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE468` | `UiListView<object, object>::Start` | inside (+0x40) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE46C` | `UiListView<object, object>::Start` | inside (+0x44) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE524` | `UiListView<object, object>::Start` | inside (+0xFC) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE528` | `UiListView<object, object>::Start` | inside (+0x100) | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE590` | `UiListView<object, object>::SetTemplateSizes` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE764` | `UiListView<object, object>::TemplateSize` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE878` | `UiListView<object, object>::ComputeConditions` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE8CC` | `UiListView<object, object>::ComputeConditions` | inside (+0x54) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE948` | `UiListView<object, object>::ComputeConditions` | inside (+0xD0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE96C` | `UiListView<object, object>::ComputeConditions` | inside (+0xF4) | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE9A0` | `UiListView<object, object>::ComputeConditions` | inside (+0x128) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBE9AC` | `UiListView<object, object>::ComputeConditions` | inside (+0x134) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEA64` | `UiListView<object, object>::ComputeConditions` | inside (+0x1EC) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEAD4` | `UiListView<object, object>::ComputeListHeight` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEB50` | `UiListView<object, object>::ComputeListHeight` | inside (+0x7C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEC2C` | `UiListView<object, object>::ComputeListHeight` | inside (+0x158) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEC48` | `UiListView<object, object>::ComputeListHeight` | inside (+0x174) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBECB0` | `UiListView<object, object>::UpdateItems` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEDA8` | `UiListView<object, object>::UpdateItems` | inside (+0xF8) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEE0C` | `UiListView<object, object>::UpdateItems` | inside (+0x15C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBEFE8` | `UiListView<object, object>::UpdateItems` | inside (+0x338) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF000` | `UiListView<object, object>::UpdateItems` | inside (+0x350) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF02C` | `UiListView<object, object>::UpdateItems` | inside (+0x37C) | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF040` | `UiListView<object, object>::UpdateItems` | inside (+0x390) | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF0D4` | `UiListView<object, object>::UpdateItems` | inside (+0x424) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF0DC` | `UiListView<object, object>::UpdateItems` | inside (+0x42C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF0EC` | `UiListView<object, object>::UpdateItems` | inside (+0x43C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF1D0` | `UiListView<object, object>::UpdateItems` | inside (+0x520) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF1E8` | `UiListView<object, object>::UpdateItems` | inside (+0x538) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF258` | `UiListView<object, object>::UpdateItems` | inside (+0x5A8) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF2CC` | `UiListView<object, object>::UpdateItems` | inside (+0x61C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF41C` | `UiListView<object, object>::UpdateItems` | inside (+0x76C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF53C` | `UiListView<object, object>::UpdateItems` | inside (+0x88C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF758` | `UiListView<object, object>::UpdateItems` | inside (+0xAA8) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF960` | `UiListView<object, object>::UpdateItems` | inside (+0xCB0) | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF984` | `UiListView<object, object>::UpdateItems` | inside (+0xCD4) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBF9BC` | `UiListView<object, object>::UpdateItems` | inside (+0xD0C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBFA04` | `UiListView<object, object>::PositionAtContentEnd` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBFA60` | `UiListView<object, object>::PositionAtContentEnd` | inside (+0x5C) | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBFAF8` | `UiListView<object, object>::PinnedEntryOffset` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBFDAC` | `UiListView<object, object>::UpdateItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FBFE88` | `UiListView<object, object>::Recycle` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC004C` | `UiListView<object, object>::UpdateVisibleItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0200` | `UiListView<object, object>::GetNewItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0468` | `UiListView<object, object>::GetNewItem` | inside (+0x268) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC06F4` | `UiListView<object, object>::GetNewItem` | inside (+0x4F4) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0714` | `UiListView<object, object>::GetNewItem` | inside (+0x514) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0B6C` | `UiListView<object, object>::GetObjectSize` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC0C40` | `UiListView<object, object>::OnScrollEnded` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0E80` | `UiListView<object, object>::AnimateScrollTo` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0FB8` | `UiListView<object, object>::AnimateScrollTo` | inside (+0x138) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC0FE8` | `UiListView<object, object>::AnimateScrollTo` | inside (+0x168) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1018` | `UiListView<object, object>::AnimateScrollTo` | inside (+0x198) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1064` | `UiListView<object, object>::AnimateCenteredScrollTo` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1390` | `UiListView<object, object>::PinnedScrollInset` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC142C` | `UiListView<object, object>::AnimateScroll` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC1658` | `UiListView<object, object>::SetPinned` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1828` | `UiListView<object, object>::ClearPinned` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC18B0` | `UiListView<object, object>::OnPinnedChanged` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC1C70` | `UiListView<object, object>::TryGetTemplatePrefab` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC1D70` | `UiListView<object, object>::KeepPinnedDatumInList` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1D78` | `UiListView<object, object>::UsesClonedHeader` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1D80` | `UiListView<object, object>::OnPinnedCloneReady` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1D84` | `UiListView<object, object>::OnPinnedCloneShown` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1D88` | `UiListView<object, object>::ResolveCloneSource` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC1D90` | `UiListView<object, object>::EnsurePinnedClone` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC273C` | `UiListView<object, object>::DestroyPinnedClone` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC2850` | `UiListView<object, object>::TogglePin` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC29C4` | `UiListView<object, object>::TryGetPinnedDatum` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC2BBC` | `UiListView<object, object>::GetPinnedHeight` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC2BC0` | `UiListView<object, object>::GetPinnedTopOffset` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC2BC8` | `UiListView<object, object>::IsIndexOnScreen` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC2FE0` | `UiListView<object, object>::RemoveItemAt` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC3058` | `UiListView<object, object>::RemoveItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC3440` | `UiListView<object, object>::CollapseAfterExit` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC36D4` | `UiListView<object, object>::DetachTrackedItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC3AC4` | `UiListView<object, object>::RecycleDetachedItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC3C4C` | `UiListView<object, object>::PlayExitAnimation` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FC4000` | `UiListView<object, object>::ResetItemVisualState` | method | [واجهة](ui-spec/01-إطار-القوائم.md) |
| `0x3FC46F8` | `UiListView<ReferralRewardHolder, object>::get_listHeight` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x3FFE000` | `UnityEngine.UIElements.BaseField<object>::set_value` | inside (+0x128) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4000000` | `UnityEngine.UIElements.BaseField<object>::OnViewDataReady` | inside (+0x114) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x401737C` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::get_listHeight` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401743C` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::set_data` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x40180B8` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::Awake` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x4018194` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::Start` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401848C` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::SetTemplateSizes` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x40187A0` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::TemplateSize` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x40188F0` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::ComputeConditions` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x4018CD0` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::ComputeListHeight` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x4018FBC` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::UpdateItems` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401A690` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::PositionAtContentEnd` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401A7D4` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::PinnedEntryOffset` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401AAEC` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::UpdateItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401ABD8` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::Recycle` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401AEB4` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::UpdateVisibleItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401B1E4` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::GetNewItem` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401BEB8` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::OnScrollEnded` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401C128` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::AnimateScrollTo` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401C2C0` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::AnimateCenteredScrollTo` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401C65C` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::PinnedScrollInset` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401CA48` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::SetPinned` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401CD80` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::ClearPinned` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401D560` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::EnsurePinnedClone` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401EC08` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::IsIndexOnScreen` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401F2E0` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::RemoveItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x401FF84` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::DetachTrackedItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x40209BC` | `UiListView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::PlayExitAnimation` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x4021A20` | `System.Threading.Channels.SingleConsumerUnboundedChannel.UnboundedChannelReader<object>::.ctor` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x402A118` | `UnityEngine.Events.UnityEvent<int>::AddListener` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x402E7BC` | `UnityEngine.Events.UnityEvent<Color, object>::AddListener` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x402EE8C` | `UnityEngine.Events.UnityEvent<Int32Enum, int>::AddListener` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x402F54C` | `UnityEngine.Events.UnityEvent<Vector2, object>::AddListener` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x429227C` | `Kammelna.Server.WebRequests.BaseWebRequest<object>::Setup` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x4292824` | `Kammelna.Server.WebRequests.BaseWebRequest<object>::GenerateQueryString` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) · [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x437FDF8` | `Server.Models.CachedModel<object>::get_Path` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x437FEC0` | `Server.Models.CachedModel<object>::get_Key` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x4380134` | `Server.Models.CachedModel<object>::set_ServerCursor` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x4380188` | `Server.Models.CachedModel<object>::get_Model` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x43801D8` | `Server.Models.CachedModel<object>::get_RawModel` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x4380300` | `Server.Models.CachedModel<object>::set_RawModel` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x4380474` | `Server.Models.CachedModel<object>::IsValid` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x4381194` | `Server.Models.CachedModel<__Il2CppFullySharedGenericType>::get_RawModel` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x438321C` | `Kammelna.Server.WebRequests.Cache.CachedRequestDecorator<object>::Setup` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x438341C` | `Kammelna.Server.WebRequests.Cache.CachedRequestDecorator<object>::InitializeETagHeader` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x4388FAC` | `CardsOrganizer<object>::get_CardHeightPixelDifference` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4389010` | `CardsOrganizer<object>::get_AllowMyTurnHandAnimation` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x43890B0` | `CardsOrganizer<object>::get_AllowVibration` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4389120` | `CardsOrganizer<object>::GetCardSpacingForBottomRow` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4389310` | `CardsOrganizer<object>::GetCardRotationForBottomRow` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4389544` | `CardsOrganizer<object>::ReorganizeCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4389E04` | `CardsOrganizer<object>::HighlightMyTurnToPlay` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x438A0FC` | `CardsOrganizer<object>::.ctor` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x439C4A0` | `Server.Models.ClientFilterProjection<bool>::BuildFilter` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439CF00` | `Server.Models.ClientFilterProjection<int>::BuildFilter` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439D964` | `Server.Models.ClientFilterProjection<long>::BuildFilter` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439E3CC` | `Server.Models.ClientFilterProjection<object>::BuildFilter` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439EB68` | `Server.Models.ClientFilterProjection<object>::.ctor` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439EB78` | `Server.Models.ClientFilterProjection<object>::.cctor` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439EC74` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::Project` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F020` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F0A8` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x88) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F0D0` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0xB0) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F0EC` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0xCC) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F234` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x214) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F2AC` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x28C) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F2D4` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x2B4) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F334` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x314) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F660` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x640) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F6B4` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x694) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F714` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x6F4) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x439F758` | `Server.Models.ClientFilterProjection<__Il2CppFullySharedGenericType>::BuildFilter` | inside (+0x738) | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x4492A48` | `Kammelna.Server.WebRequests.ContentSinceRequest<object, int>::get_Method` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) · [بيانات](data-spec/01-طبقة-البيانات.md) · [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) · [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x4492BEC` | `Kammelna.Server.WebRequests.ContentSinceRequest<object, long>::get_Method` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x4492D90` | `Kammelna.Server.WebRequests.ContentSinceRequest<object, object>::get_Method` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x4492F34` | `Kammelna.Server.WebRequests.ContentSinceRequest<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>::get_Method` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x449C860` | `Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator.<Execute>d__8<bool>::MoveNext` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x449CEA8` | `Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator.<Execute>d__8<bool>::MoveNext` | inside (+0x648) | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x449F0C8` | `ArraysExtensions.<GetCycledRange>d__29<object>::MoveNext` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x45A36D8` | `InMemoryCacheAssetLoader.<LoadAsset>d__7<object>::MoveNext` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x45A4058` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A4224` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | inside (+0x1CC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A4338` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | inside (+0x2E0) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A4444` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | inside (+0x3EC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A452C` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | inside (+0x4D4) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A4564` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | inside (+0x50C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A474C` | `SaveLoadUtils.<LoadItems>d__1<object>::MoveNext` | inside (+0x6F4) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A5128` | `SaveLoadUtils.<LoadItemsWeb>d__0<object>::MoveNext` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x45A8D88` | `Kammelna.Server.WebRequests.Cache.CachedRequestDecorator.<Materialize>d__6<object>::MoveNext` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x45B68AC` | `ArraysExtensions.<Rotate>d__5<object>::MoveNext` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x477EC20` | `System.Array.EmptyInternalEnumerator<TutorialError>::.cctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4C930B4` | `System.Array.InternalEnumerator<TutorialError>::get_Current` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4CC6128` | `ItemPicker<object>::.ctor` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x4D14DB0` | `KammelnaResponseModel<object>::get_ErrorMessage` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x4D14E40` | `KammelnaResponseModel<object>::get_Succeeded` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x4D14E50` | `KammelnaResponseModel<object>::get_CachedModelUpdated` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x4EA922C` | `LocalizationText::set_Language` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA92FC` | `LocalizationText::CreateContent` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA98BC` | `LocalizationText::.cctor` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA9A5C` | `LocalizationText::GetText` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA9B98` | `LocalizationText::GetText` | inside (+0x13C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x4EA9C8C` | `LocalizationText::GetText` | inside (+0x230) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA9CA4` | `LocalizationText::get_Content` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA9DAC` | `LocalizationText::GetText` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA9EF0` | `LocalizationText::Exists` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EA9FF0` | `LocalizationText::<GetText>g__SafeFormat|7_0` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAA17C` | `LocalizationText::GetOrdinalText` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAA3C4` | `LocalizationText::SetLanguage` | inside (+0x44) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAA3FC` | `LocalizationText::SetLanguage` | inside (+0x7C) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAA400` | `LocalizationText::ParseSection` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAA700` | `LocalizationText::ParseSection` | inside (+0x300) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAAA0C` | `LocalizationText::ParseSection` | inside (+0x60C) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAAAD0` | `LocalizationText::ParseSection` | inside (+0x6D0) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAAE20` | `EnumExtensions::GetFriendlyName` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EAAF88` | `LocalizationText::AddContent` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAB600` | `LocalizationUtil::Localize` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAB688` | `LocalizationUtil::Localize` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAB714` | `LocalizationUtil::Localize` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAB950` | `LocalizationUtil::LocalizeOrdinal` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAB9DC` | `LocalizationUtil::LocalizeAndFix` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EABBC4` | `LocalizationUtil::ShouldFixArabic` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EABDA8` | `LocalizationUtil::FixArabicMultipleLines` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAC058` | `LocalizationUtil::FixArabicHelper` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAC228` | `LocalizationUtil::FixTag` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAC42C` | `LocalizationUtil::IsArabicFixed` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAC5AC` | `LocalizationUtil::IsArabicFixed` | inside (+0x180) | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAC5B0` | `LocalizationUtil::DateRangeMessage` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAC8E4` | `LocalizationUtil::FormatDateTime` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EACE70` | `LocalizationUtil::.cctor` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAD4E0` | `LocalizationUtil.<>c::<IsArabicFixed>b__13_0` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EAFE5C` | `ScenesEnumExtensions::IsEqual` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EAFF78` | `RoutingManager::Route` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x4EB228C` | `ScenesEnumExtensions::GetName` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EB2528` | `ScenesEnumExtensions::GetSceneEnum` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EB7320` | `AudioCacher::GetItemPath` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4EB739C` | `AudioCacher::GetRoomElementPath` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4EB7E24` | `SoundActors::get_ResourcesPath` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4EB82E8` | `SoundActors::ValidateGroups` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4EB96A4` | `SoundManager::IsChannelMuted` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4EB9BA8` | `CoroutineDummy::WaitForSeconds` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4EBB350` | `CanvasLayerExtensions::GetCanvas` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x4EBB5A4` | `PrefabInitializer::InitializePrefab` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x4EBB724` | `PrefabInitializer::Initialize` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4EBBD84` | `CompressUtil::Compress` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBBE54` | `CompressUtil::CompressToString` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBBEF8` | `CompressUtil::Compress` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBBF6C` | `CompressUtil::Compress` | inside (+0x74) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBBF8C` | `CompressUtil::Compress` | inside (+0x94) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBBFF4` | `CompressUtil::Compress` | inside (+0xFC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBC01C` | `CompressUtil::Compress` | inside (+0x124) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBC044` | `CompressUtil::Compress` | inside (+0x14C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBC424` | `CompressUtil::Decompress` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBC47C` | `CompressUtil::Decompress` | inside (+0x58) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBC4FC` | `CompressUtil::Decompress` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBCA3C` | `CoroutineDummy::get_Instance` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EBE1CC` | `AnimationExtensions::AnimPulsing` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EBE710` | `AnimationExtensions::AnimLoseHeart` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EBFA0C` | `AnimationExtensions::DONumber` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EBFE80` | `AnimationExtensions::DONumber` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EC0314` | `AnimationExtensions::DOStamp` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EC12CC` | `AnimationExtensions.<>c__DisplayClass16_0::<DOStamp>b__0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EC1B2C` | `ColorExtension::ToPackedRgba` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x4EC1B48` | `ColorExtension::FromPackedRgba` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x4EC1C30` | `FloatExtensions::Map` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C34` | `FloatExtensions::Map` | inside (+0x4) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C38` | `FloatExtensions::Map` | inside (+0x8) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C3C` | `FloatExtensions::Map` | inside (+0xC) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C40` | `FloatExtensions::Map` | inside (+0x10) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C44` | `FloatExtensions::Map` | inside (+0x14) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C48` | `FloatExtensions::Map` | inside (+0x18) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C4C` | `FloatExtensions::Map` | inside (+0x1C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1C50` | `FloatExtensions::Map` | inside (+0x20) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x4EC1D7C` | `IntegerExtensions::GetRotatedNextIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x4EC4D3C` | `SFSExtensions::Get` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC5124` | `SFSExtensions::Get` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC532C` | `SFSExtensions::Get` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC55F8` | `SFSExtensions::Get` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC58AC` | `SFSExtensions::Get` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC63B8` | `SFSExtensions::Get` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC6754` | `SFSExtensions::GetCommand` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x4EC6858` | `SFSExtensions::GetResponseParams` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x4EC80B4` | `SFSExtensions::Put` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4EC8170` | `SFSExtensions::Put` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4EC8470` | `SFSExtensions::Put` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4EC9704` | `SFSKammelnaRoomExtensions::GetTeamScore` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC9980` | `SFSKammelnaRoomExtensions::GetPlayersInfo` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x4EC9B3C` | `SFSKammelnaRoomExtensions::GetGameType` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC9BB0` | `SFSKammelnaRoomExtensions::IsPrivate` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC9CA8` | `SFSKammelnaRoomExtensions::GetPassword` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC9DA0` | `SFSKammelnaRoomExtensions::GetPinMessage` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC9E98` | `SFSKammelnaRoomExtensions::IsChatEnabled` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4EC9F90` | `SFSKammelnaRoomExtensions::IsCheatingAllowed` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA088` | `SFSKammelnaRoomExtensions::GetTimeoutInterval` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA180` | `SFSKammelnaRoomExtensions::GetGameID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA278` | `SFSKammelnaRoomExtensions::GetRoomThemeID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA370` | `SFSKammelnaRoomExtensions::GetCardbackID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4ECA468` | `SFSKammelnaRoomExtensions::HasTheme` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA484` | `SFSKammelnaRoomExtensions::GetRankLimit` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA57C` | `SFSKammelnaRoomExtensions::QualifyRankLimit` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECA5C0` | `SFSKammelnaRoomExtensions::GetHighestRankInRoom` | method | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x4ECA8A4` | `SFSKammelnaRoomExtensions::GetLowestRankInRoom` | method | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x4ECAB88` | `SFSKammelnaRoomExtensions::GetAverageRank` | method | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x4ECAFC8` | `SFSKammelnaRoomExtensions::GetAverageRank` | inside (+0x440) | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x4ECAFE0` | `SFSKammelnaRoomExtensions::GetAverageRank` | inside (+0x458) | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x4ECB0B0` | `SFSKammelnaRoomExtensions::IsJoinable` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB1FC` | `SFSKammelnaRoomExtensions::IsClanMember` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB24C` | `SFSKammelnaRoomExtensions::GetClanId` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB344` | `SFSKammelnaRoomExtensions::GetJoinableSeats` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB588` | `SFSKammelnaRoomExtensions::GetFirstJoinableSeatIndex` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB658` | `SFSKammelnaRoomExtensions::GetFirstJoinableSeatForTeam` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB730` | `SFSKammelnaRoomExtensions::GetOriginalOwnerId` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB828` | `SFSKammelnaRoomExtensions::GetTournamentPassword` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECB920` | `SFSKammelnaRoomExtensions::GetRoomOwnerId` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECBA18` | `SFSKammelnaRoomExtensions::IsLobby` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECBB20` | `SFSKammelnaRoomExtensions::IsOffline` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x4ECBBE4` | `SFSKammelnaRoomExtensions::IsVoiceChatEnabled` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4ECBCDC` | `SFSKammelnaRoomExtensions::IsVoiceChatEnabledForSpectators` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4ECBDD4` | `SFSKammelnaRoomExtensions::GetTutorialType` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECBE48` | `SFSKammelnaRoomExtensions::GetIsReplay` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x4ECBF4C` | `SFSKammelnaRoomExtensions::GetPlayersVoices` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4ECC0DC` | `SFSKammelnaRoomExtensions::GetRoomMessage` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC1D4` | `SFSKammelnaRoomExtensions::GetRoomSportTeamID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC2CC` | `SFSKammelnaRoomExtensions::GetRoomAdCampaignID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC3C4` | `SFSKammelnaRoomExtensions::GetPlayerIndexByUser` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC448` | `SFSKammelnaRoomExtensions::GetPlayerTeamIndex` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC4C4` | `SFSKammelnaRoomExtensions::IsSuppressUserList` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC574` | `SFSKammelnaRoomExtensions::GetOnlineUsersCount` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECC72C` | `SFSKammelnaRoomExtensions::GetJackarooCustomRules` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [جكارو](jackaroo-spec/04-القواعد-المخصصة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x4ECC824` | `SFSKammelnaRoomExtensions::IsTournamentHub` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ECC974` | `SFSKammelnaRoomExtensions::GetTournamentInfo` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ECCB18` | `SFSKammelnaRoomExtensions::GetTournamentStatus` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECCC08` | `SFSKammelnaRoomExtensions::GetTournamentCurrentRound` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ECCD00` | `SFSKammelnaRoomExtensions::GetTournamentRoundTimer` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECCDFC` | `SFSKammelnaRoomExtensions::GetActiveTournamentsCount` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECCEF4` | `SFSKammelnaRoomExtensions::GetTournamentParticipantsCount` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECCFEC` | `SFSKammelnaRoomExtensions::GetTournamentQueue` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [ردهة](lobby-spec/03-البطولات.md) |
| `0x4ECD270` | `SFSKammelnaRoomExtensions::CanTournamentParticipantsChooseTeam` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECD368` | `SFSKammelnaRoomExtensions::IsTournamentTeamsShuffled` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECD460` | `SFSKammelnaRoomExtensions::IsTournamentWatchersChatEnabled` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECD558` | `SFSKammelnaRoomExtensions::HasCaptcha` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECD62C` | `SFSKammelnaRoomExtensions::GetCaptchaPath` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECD974` | `SFSKammelnaRoomExtensions::GetTournamentMatches` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECDD60` | `SFSKammelnaRoomExtensions::GetParentMatches` | inside (+0x4) | [ردهة](lobby-spec/03-البطولات.md) |
| `0x4ECE15C` | `SFSKammelnaRoomExtensions::IsMassTournament` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECE2FC` | `SFSKammelnaRoomExtensions::GetMassTournamentInfo` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECE4A0` | `SFSKammelnaRoomExtensions::GetMassMaxStageDelay` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECE5EC` | `SFSKammelnaRoomExtensions::GetMassActiveStage` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECE6E4` | `SFSKammelnaRoomExtensions::GetMassActivePlayWindow` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECE89C` | `SFSKammelnaRoomExtensions::GetMassActiveStagePointsToPass` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECE994` | `SFSKammelnaRoomExtensions::GetMassActiveClusterStartTime` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECEA90` | `SFSKammelnaRoomExtensions::GetFriendlyChallengeLevel` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECEB88` | `SFSKammelnaRoomExtensions::GetActiveBombInfo` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4ECF070` | `SFSKammelnaUserExtensions::GetUserName` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF0E4` | `SFSKammelnaUserExtensions::IsNew` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF144` | `SFSKammelnaUserExtensions::IsSubscribed` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x4ECF1F0` | `SFSKammelnaUserExtensions::IsVerified` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x4ECF250` | `SFSKammelnaUserExtensions::IsSubscribedUsingDate` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF47C` | `SFSKammelnaUserExtensions::GetDbId` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF530` | `SFSKammelnaUserExtensions::GetIntDbId` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ECF630` | `SFSKammelnaUserExtensions::IsTV` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF734` | `SFSKammelnaUserExtensions::GetRank` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF814` | `SFSKammelnaUserExtensions::GetUserPermissions` | method | [هوية](identity-spec/02-الإحصائيات-والملف.md) · [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4ECF874` | `SFSKammelnaUserExtensions::Can` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ECF8E4` | `SFSKammelnaUserExtensions::GetTitle` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF958` | `SFSKammelnaUserExtensions::GetTitleLevel` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECF9B8` | `SFSKammelnaUserExtensions::GetChatInk` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4ECFA2C` | `SFSKammelnaUserExtensions::HasTrophyCelebration` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECFA8C` | `SFSKammelnaUserExtensions::HasAvatar` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECFBA8` | `SFSKammelnaUserExtensions::GetRegistrationDate` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECFC0C` | `SFSKammelnaUserExtensions::GetPlayingCondition` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECFDA0` | `SFSKammelnaUserExtensions::GetMiniGameTrials` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECFE00` | `SFSKammelnaUserExtensions::GetWinningStreak` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ECFE60` | `SFSKammelnaUserExtensions::GetMuteStatus` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4ECFED4` | `SFSKammelnaUserExtensions::GetMutedUntil` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4ECFFCC` | `SFSKammelnaUserExtensions::GetTournamentPoints` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ED002C` | `SFSKammelnaUserExtensions::GetMonthlyTournamentEligibility` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x4ED00A0` | `SFSKammelnaUserExtensions::GetTournamentJoiningDiscount` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ED0100` | `SFSKammelnaUserExtensions::GetAllTickets` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ED0420` | `SFSKammelnaUserExtensions::GetTournamentTickets` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x4ED0450` | `SFSKammelnaUserExtensions::GetLikes` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4ED04B0` | `SFSKammelnaUserExtensions::GetAchievementCount` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x4ED0510` | `SFSKammelnaUserExtensions::IsVoiceMuted` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4ED0570` | `SFSKammelnaUserExtensions::GetClanId` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4ED0598` | `SFSKammelnaUserExtensions::GetClanMembership` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [اجتماعي](social-spec/01-المعمارية-والدردشة.md) · [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4ED07DC` | `SFSKammelnaUserExtensions::GetAces` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4ED083C` | `SFSKammelnaUserExtensions::GetActiveRoomThemeID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x4ED089C` | `SFSKammelnaUserExtensions::GetActiveCardbackID` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x4ED08FC` | `SFSKammelnaUserExtensions::GetActivePatternID` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x4ED095C` | `SFSKammelnaUserExtensions::GetFeaturedSlot` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x4ED0DCC` | `SFSKammelnaUserExtensions::HasPaidRoomTheme` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) |
| `0x4ED0E2C` | `SFSKammelnaUserExtensions::GetFTLevel` | method | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/sfs-variables.md) · [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED0E8C` | `SFSKammelnaUserExtensions::GetFTStage` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED0EEC` | `SFSKammelnaUserExtensions::GetFTTopStage` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED0F4C` | `SFSKammelnaUserExtensions::GetFTRoundsWon` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED0FAC` | `SFSKammelnaUserExtensions::GetFTRoundsLost` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED100C` | `SFSKammelnaUserExtensions::GetNumberOfFTStarted` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED106C` | `SFSKammelnaUserExtensions::GetNumberOfFTWon` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED10CC` | `SFSKammelnaUserExtensions::GetFTTicketsOwned` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED112C` | `SFSKammelnaUserExtensions::GetFTNextTicketTime` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED1190` | `SFSKammelnaUserExtensions::GetFTMaximumTicketsAllowed` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED11F0` | `SFSKammelnaUserExtensions::GetFTHearts` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4ED2978` | `TextMeshProExtensions::Localize` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4ED2A90` | `TextMeshProExtensions::FixArabic` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4ED2B50` | `TextMeshProExtensions::Localize` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4ED2CBC` | `TextMeshProExtensions::LocalizeArguments` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4ED2F34` | `TextMeshProExtensions::LocalizeOrdinal` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4ED34D0` | `TextMeshProExtensions::SetPriceText` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ED3788` | `TextMeshProExtensions::Localize` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4ED42E4` | `UIExtensions::LoadItemImage` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4ED9D1C` | `UIExtensions::TweenShowBlur` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x4EDA010` | `UIExtensions::TweenHideBlur` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x4EDA1EC` | `UIExtensions::TweenHideBlur` | inside (+0x1DC) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x4EDABBC` | `UIExtensions::AttachToCanvas` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x4EDB884` | `UIExtensions::SetTimeout` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x4EDFBC4` | `FileUtils::ReadFiles` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EDFC44` | `FileUtils::ReadFiles` | inside (+0x80) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE028C` | `FileUtils::GetDirectorySize` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x4EE03EC` | `FileUtils::CleanFolder` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x4EE0C18` | `GamesFlagExtensions::MatchesCurrentGame` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4EE1008` | `ImageCacher::GetItemPath` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4EE10C8` | `ImageCacher::GetAchievementPath` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x4EE114C` | `ImageCacher::GetRoomElementPath` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4EE1C90` | `ImageCacher::GetRemoteImagePath` | method | [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x4EE4D4C` | `KUtil::GetPlatform` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4EE4E84` | `KUtil::GetSpeedIndexValue` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4EE6F58` | `OneShotEvent::CallWhenReady` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x4EE714C` | `SaveLoadUtils::Delete` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE71B0` | `SaveLoadUtils::Delete` | inside (+0x64) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE71C0` | `SaveLoadUtils::Delete` | inside (+0x74) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE71E4` | `SaveLoadUtils::Delete` | inside (+0x98) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE7298` | `SaveLoadUtils::Delete` | inside (+0x14C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE72C8` | `SaveLoadUtils::Delete` | inside (+0x17C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x4EE8B78` | `StringCacher::GetItemPath` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4EE8BF4` | `StringCacher::GetItemPath` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4EE9520` | `StringUtil::IsTashkeel` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EE9814` | `StringUtil::IsAllowedChatCharacter` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4EE9A0C` | `StringUtil::RemoveSurrogate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4EE9A9C` | `StringUtil::RemoveSurrogate` | inside (+0x90) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4EE9B5C` | `StringUtil::SanitizeChatMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4EEA878` | `StringUtil::Tag` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEAA08` | `StringUtil::Tag` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEABF0` | `StringUtil::Bold` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEAC94` | `StringUtil::NoBreak` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEAD38` | `StringUtil::Underline` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEADDC` | `StringUtil::Font` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEAEA0` | `StringUtil::Size` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEAF3C` | `StringUtil::Color` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEB124` | `StringUtil::Sprite` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEB2FC` | `StringUtil::AbbreviateNumber` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EEB7B0` | `StringUtil.<>c::<IsTashkeel>b__9_0` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x4EF3598` | `SfsConnectionManager::ForceDisconnectAndSwitchServer` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x4EF4C20` | `SfsConnectionManager::TimeoutCallback` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x4EF58B4` | `TutorialOnboarding::Start` | method | [إعلانات](ads-spec/02-الدروس-التعليمية.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EF5BF0` | `TutorialOnboarding::AnimationAwake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EF5E50` | `TutorialOnboarding::AnimationStart` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EF6400` | `TutorialOnboarding::AnimationExit` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EF6634` | `TutorialOnboarding::TabletSwitchPopup` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4EFA92C` | `MassTournamentServerConnector::GetActiveStageId` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFB4DC` | `MassTournamentServerConnector::GetActiveStage` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFCB70` | `MassTournamentServerConnector::GetActivePlayWindow` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFCC38` | `MassTournamentServerConnector::GetUpcomingStage` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFCCE8` | `MassTournamentBottomBar::GetUserInitialDelay` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFCE6C` | `MassTournamentBottomBar::ShowMassParticipationPopup` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFE9B4` | `MassTournamentManager::LoadMassEvents` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4EFF75C` | `MassTournamentPlayerState::FromSfsObject` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F00360` | `MassTournamentServerConnector::RegisterInTournament` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F00B2C` | `MassTournamentServerConnector::Init` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F011D0` | `MassTournamentServerConnector::ListenToRoomVariables` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F01440` | `MassTournamentServerConnector::ExtractMassId` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F01580` | `MassTournamentServerConnector::HandleRegistrationCode` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F01740` | `MassTournamentServerConnector::GetActiveTournaments` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F01B9C` | `MassTournamentServerConnector::RequestRoomsList` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F01E4C` | `MassTournamentServerConnector::OnRoomChanged` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F0240C` | `MassTournamentServerConnector::GetMassTournamentPointsToPass` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F024AC` | `MassTournamentServerConnector::GetActivePlayWindowId` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F0254C` | `MassTournamentServerConnector::IsWaitingToStart` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F02830` | `MassTournamentServerConnector::LoadPlayerState` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F02914` | `MassTournamentServerConnector::IsFinalStage` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F02938` | `MassTournamentServerConnector::PlayNow` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F02DC0` | `MassTournamentServerConnector::<PlayNow>b__44_0` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x4F0F4F0` | `UserListComparer::GetRankValue` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x4F111B8` | `FriendsManager::RemoveFriend` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F11C64` | `FriendsManager::UnblockUser` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F11EAC` | `FriendsManager::BlockUser` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F1B18C` | `FriendsManager::UpdateFriendsList` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F1C6C8` | `FriendsManager::GetUnreadMessages` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x4F1CB80` | `FriendsManager::ForceAddFriend` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F1CC70` | `FriendsManager::AcceptRequest` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F1CD60` | `FriendsManager::SendAddRequest` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x4F23DCC` | `JackarooWhatsNewPopupUI::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4F25A34` | `LeaderBoardPerformance::InitializeAllProgresses` | method | [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x4F2A15C` | `JsonLeaderboardSource::Load` | method | [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x4F2BABC` | `SfsLeaderboardSource::Load` | method | [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x4F2FE14` | `Menu::OnCreateVoiceRoomClick` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4F30A94` | `RankedPlayManager::PlayRanked` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x4F31308` | `MenuAdsHandler::ShowAd` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x4F31798` | `MenuAdsHandler::OnAdClosed` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x4F38C08` | `NotificationItem::OnPrimaryButtonClick` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x4F40460` | `RankedPlayManager.<>c__DisplayClass36_0::<PlayRanked>g__PayToSkipAds|0` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x4F40B00` | `RankedPlayManager.<>c__DisplayClass36_0::<PlayRanked>b__1` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x4F410F4` | `SlideAnimationHelper::HideImmediate` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F41284` | `SlideAnimationHelper::SlideOut` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x4F4128C` | `SlideAnimationHelper::SlideIn` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F4131C` | `SlideAnimationHelper::SlideIn` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F416F8` | `SlideAnimationHelper::SlideOut` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F418F0` | `SlideAnimationHelper::GetSlideUpDistance` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F41A0C` | `SlideAnimationHelper::GetSlideDownDistance` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F41B2C` | `SlideAnimationHelper::ShowImmediate` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F43A38` | `MiniGame::SendStart` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F43D00` | `MiniGame::SendMove` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F43F64` | `MiniGame::SendClaim` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F44024` | `MiniGame::SendCleanup` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F44C10` | `MiniGame::ShowError` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F452E0` | `MiniGameCard::OnStatusChange` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F453CC` | `MiniGameCard::CardInHand` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F45490` | `MiniGameCard::CardPreparedForDiscard` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F45598` | `MiniGameCard::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F45668` | `MiniGameCard::OnPointerDown` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F45728` | `MiniGameCard::OnPointerEnter` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F464A0` | `MiniGameInfo::get_CanNotPlayMiniGameOnWeb` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F46590` | `MiniGameInfo::get_DelayIsActive` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F46920` | `MiniGameInfo::get_SecondsTillNextMiniGameTrial` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F46CD4` | `MiniGameControls::OnGameStart` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F471F8` | `MiniGameInfo::get_MiniGameRemainingTrials` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F479E0` | `MiniGameVisuals::get_ShouldWatchAd` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F48C18` | `MiniGameHand::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F49024` | `MiniGameHand::CardSelected` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F494DC` | `MiniGameHand::ReturnRewardCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F498DC` | `MiniGameHand::AnimateDrawCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F4A90C` | `MiniGameHand::HighlightRewards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F4B2E0` | `MiniGameVisuals::PlayRewardSound` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F4B414` | `MiniGameHand::OnGameStart` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F4B5CC` | `MiniGameHand::OnMoveSent` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F4BB24` | `MiniGameHand::SendMove` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F4C450` | `MiniGameInfo::get_MiniGameNextTrialTime` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F50750` | `MiniGameRewardsHandler::RequestRewards` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F526FC` | `MiniGameVisuals::RewardedVideoOrder` | method | [أنماط](modes-spec/02-مشروع-اليوم.md) |
| `0x4F56954` | `PlayerProfilesHandler::AiProfileModel` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x4F59988` | `MatchPredictionsUI::SubmitPrediction` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F59A8C` | `MatchPredictionsUI::SubmitPrediction` | inside (+0x104) | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F5B84C` | `PredictAndWinCard::AnimateToMyPredictions` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F5CBCC` | `PredictAndWinCard::AssignWinnerOrDrawTags` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F5D4DC` | `PredictAndWinCard::GetRewardText` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F5E400` | `PredictAndWinHelpPopup::Start` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4F601AC` | `PredictAndWinRewardPopup::Populate` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F61AFC` | `PredictAndWinTweetPreview::GenerateTweetText` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x4F6B7D8` | `ReferralCenter::Awake` | inside (+0x12C) | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6B9B0` | `ReferralHandler::CallWhenReady` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6BC58` | `ReferralCenter::Initialize` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6BEC0` | `ReferralHandler::get_SuccessfulReferrals` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C258` | `ReferralCenter::ShareGame` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C314` | `ReferralCenter::ShareGame` | inside (+0xBC) | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C3CC` | `ReferralHandler::GetReferralLink` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C3F0` | `ReferralHandler::GetReferralLink` | inside (+0x24) | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C87C` | `ReferralCenter::Back` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C914` | `ReferralCenter::ClaimAll` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6C9D8` | `ReferralHandler::ClaimAllRewards` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6D6E4` | `ReferralHandler::CheckReferrals` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6D900` | `ReferralHandler::ProcessReferral` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6DD0C` | `ReferralHandler::CheckHistoryForRewards` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6E344` | `ReferralHandler::CheckClaimableReward` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6E52C` | `ReferralHandler::OnReferralReportResponse` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6E8A4` | `ReferralHandler::ClearReferralPreferences` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6E95C` | `ReferralHandler::ClaimReward` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6EA3C` | `ReferralHandler::IsClaimable` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6F318` | `ReferralRewardItem::Populate` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6F760` | `ReferralRewardItem::SetupClaimButton` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6FC80` | `ReferralSuccessPopup::Start` | inside (+0xA4) | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F6FCA0` | `ReferralSuccessPopup::ShowReferralRewards` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70758` | `ReferralSuccessPopup::GetSprite` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F7098C` | `UserReferralModel::get_id` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F7099C` | `UserReferralModel::get_isNew` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709AC` | `UserReferralModel::get_rewardType` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709BC` | `UserReferralModel::get_rewardAmount` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709D4` | `UserReferralRewardModel::get_rewardID` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709DC` | `UserReferralRewardModel::set_rewardID` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709E4` | `UserReferralRewardModel::get_name` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709EC` | `UserReferralRewardModel::set_name` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709F4` | `UserReferralRewardModel::get_aces` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F709FC` | `UserReferralRewardModel::set_aces` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A04` | `UserReferralRewardModel::get_subscriptionDays` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A0C` | `UserReferralRewardModel::set_subscriptionDays` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A14` | `UserReferralRewardModel::get_itemID` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A1C` | `UserReferralRewardModel::set_itemID` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A24` | `UserReferralRewardModel::get_referralsNeeded` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A2C` | `UserReferralRewardModel::set_referralsNeeded` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A34` | `UserReferralRewardModel::get_isClaimed` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70A44` | `UserReferralRewardModel::.ctor` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4F70C44` | `GameSoundManager::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F70F54` | `GameSoundManager::InitPooledAudioSources` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F71310` | `GameSoundManager::SetSoundActors` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F71534` | `GameSoundManager::<SetSoundActors>g__AssignSound|17_0` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F71660` | `GameSoundManager::GetMyVoiceId` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F71718` | `GameSoundManager::PlaySounds` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F71910` | `GameSoundManager::PlaySounds` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F720A8` | `GameSoundManager::GetAudioClip` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F722C0` | `GameSoundManager::OnVoiceActorsChanged` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F72344` | `GameSoundManager::OnVoiceActorsChanged` | inside (+0x84) | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F72438` | `GameSoundManager::OnGameInitialized` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4F72534` | `GameSoundManager::PlayClipWithExtras` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F72D00` | `GiftNotification::.ctor` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4F74584` | `GiftsController::Send` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4F75A8C` | `GiftsController.<>c__DisplayClass46_0::<Send>b__3` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4F76B84` | `GiftUIElement::LoadPreviewImage` | inside (+0xE0) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4F78E88` | `BaseBannerAd::Start` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x4F7AF04` | `TutorialTopbar::SetTutorialTitle` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7AFF4` | `TutorialUiControl::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7B0E4` | `TutorialUiControl::ShowEndTutorial` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7B63C` | `TutorialUiControl::RestartInteractiveTutorial` | method | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x4F7D188` | `PlayerControl::ReportPhotoRequest` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D220` | `PlayerControl::ReportPhotoRequest` | inside (+0x98) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D224` | `PlayerControl::ReportPhotoRequest` | inside (+0x9C) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D22C` | `PlayerControl::ReportPhotoRequest` | inside (+0xA4) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D230` | `PlayerControl::ReportPhotoRequest` | inside (+0xA8) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D23C` | `PlayerControl::ReportPhotoRequest` | inside (+0xB4) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D248` | `PlayerControl::ReportPhotoRequest` | inside (+0xC0) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D24C` | `PlayerControl::ReportPhotoRequest` | inside (+0xC4) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) · [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D270` | `PlayerControl::ReportPhotoRequest` | inside (+0xE8) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7D290` | `PlayerControl::ReportPhotoRequest` | inside (+0x108) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x4F7EB44` | `SportTeamRoomTheme::SetRoomTheme` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4F7EFA8` | `SportTeamsUtil::CallWhenReady` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x4F7F764` | `AllowTeammateUi::Awake` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7F8BC` | `AllowTeammateUi::OnGameStatusUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7FBE8` | `AllowTeammateUi::Hide` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7FCA0` | `AllowTeammateUi::Accept` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F7FD70` | `AllowTeammateUi::Refuse` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F80160` | `BalootBiddingButtons::get_isAshkalAvailable` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F80244` | `BalootBiddingButtons::Awake` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F80F28` | `BalootBiddingButtons::FillBiddingButtonsDictionary` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F81050` | `BalootBiddingButtons::Clear` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F81144` | `BalootBiddingButtons::HideContainer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8128C` | `BalootBiddingButtons::getStateButtons` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F81CFC` | `BalootBiddingButtons::ShowPredetermineBid` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F81EC4` | `BiddingButtons::get_allowBiddingPredetermination` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F82054` | `BalootBiddingButtons::ShowBid` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8230C` | `BalootBiddingButtons::HandleBiddingButtons` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F824A8` | `BalootBiddingButtons::UpdateShowBid` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8274C` | `BalootBiddingButtons::isDefaultBidString` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F828DC` | `BalootBiddingButtons::isDefaultState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F82960` | `BalootBiddingButtons::SubmitPredetermineBid` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F82A14` | `BalootBiddingButtons::PredetermineBid` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F82AB8` | `BalootBiddingButtons::SubmitBid` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F83374` | `BalootBiddingButtons::UpdateStateButtons` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F835AC` | `BalootBiddingButtons::MitigateMissClicks` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F837BC` | `BalootBiddingButtons::<Awake>b__37_0` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4F83990` | `BiddingButtons::onButtonClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F83AE8` | `BiddingButtons::GameStateUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F83C1C` | `KashoButton::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F83D78` | `KashoButton::Submit` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F83E24` | `KashoButton::HideButton` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F83ECC` | `KashoButton::OnGameStateUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F83F54` | `KashoButton::ShowButton` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F84088` | `TarneebBiddingButtons::get_tGame` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F84104` | `TarneebBiddingButtons::Awake` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F84C08` | `TarneebBiddingButtons::getStateButtons` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F84D58` | `TarneebBiddingButtons::ShowPredetermineBid` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F84F5C` | `TarneebBiddingButtons::ShowBid` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F85008` | `TarneebBiddingButtons::UpdateShowBid` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F85130` | `TarneebBiddingButtons::UpdateHideBid` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F8515C` | `TarneebBiddingButtons::SubmitPredetermineBid` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F851E8` | `TarneebBiddingButtons::isValidBid` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F8550C` | `TarneebBiddingButtons::PredetermineBid` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F855B0` | `TarneebBiddingButtons::SubmitBid` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/README.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F85A68` | `TarneebBiddingButtons::BidValue` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F85CB0` | `TarneebBiddingButtons::UpdateStateButtons` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F861D0` | `TarneebBiddingButtons::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F861D8` | `TarneebBiddingButtons::<Awake>b__20_0` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4F862D0` | `TarneebBiddingButtons::<getStateButtons>b__21_0` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F86400` | `TarneebBiddingButtons::<ShowPredetermineBid>b__22_0` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4F86720` | `CardsRevealer::ShowCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F86978` | `CardsRevealer::HideGracefully` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F86AD0` | `CardsRevealer::HideCardsAnimation` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F86E80` | `CardsRevealer::OrganizeCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F87508` | `CardsRevealer::ShowCardsHelper` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8A2D4` | `BaseCheatingBox::add_OnCardClicked` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8A388` | `BaseCheatingBox::remove_OnCardClicked` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8A43C` | `BaseCheatingBox::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8A4EC` | `BaseCheatingBox::Populate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8A75C` | `BaseCheatingBox::Highlight` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8A924` | `BaseCheatingBox::HighlightTutorialCheatingCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8AA9C` | `CatchButtons::FillCatchButtonsDictionary` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8AB74` | `CatchButtons::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8AE88` | `CatchButtons::Clear` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8AFCC` | `CatchButtons::OnGameStateUpdated` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8B168` | `CatchButtons::HandleCatchButtons` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8B304` | `CatchButtons::UpdateHokomButtons` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8B374` | `CatchButtons::OpenCardsOnClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8B37C` | `CatchButtons::SendCatch` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8B4B8` | `CatchButtons::WrongSawaOnClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8B510` | `CatchButtons::WrongEkkaOnClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8B614` | `CatchButtons::OnSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8B8C0` | `CheatingCatchPopup::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8BB2C` | `CheatingCatchPopup::Clear` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8BE38` | `CheatingCatchPopup::HandleTutorialState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8BF48` | `CheatingCatchPopup::CatchTypeButtonChanged` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8C06C` | `CheatingCatchPopup::UpdateSubmitButton` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8C16C` | `CheatingCatchPopup::UpdateCatcherTip` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8C6A4` | `CheatingCatchPopup::GetCheatMode` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8C984` | `CheatingCatchPopup::OnCheating` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8CC50` | `CheatingCatchPopup::ShowCheatingBoard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8D120` | `CheatingCatchPopup::ShowCheatingBoard` | inside (+0x4D0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8D49C` | `CheatingCatchPopup::ShowCheatingResult` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8D874` | `CheatingCatchPopup::OnCardClicked` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8DC90` | `LiveCatchingInfo::SendCheatingData` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8DF98` | `CheatingCatchPopup::HighlightTutorialCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8E854` | `EatingBox::SetupBox` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8E950` | `LiveCatchingInfo::.ctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8EB2C` | `PlayerCheatingBox::SetupBox` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8ECB4` | `PlayerCheatingBox::Populate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8EDA4` | `SawaButtons::get_canAffordSpecialSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F8EE5C` | `SawaButtons::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F1E8` | `SawaButtons::OnDestroy` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F2CC` | `SawaButtons::OnGameStateUpdated` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F41C` | `SawaButtons::UpdateMessage` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F540` | `SawaButtons::DontShowAgainToggleChanged` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F614` | `SawaButtons::Submit` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F6F8` | `SawaButtons::SendSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8F9AC` | `SawaButtons::ToggleSawaPanel` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8FCDC` | `SawaCatchPopup::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F8FE28` | `SawaCatchPopup::OnCheating` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F90200` | `SawaCatchPopup::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F91464` | `GameCard::HighlightForDiscard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9155C` | `GameCard::SetStatus` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F91564` | `GameCard::OnStatusChange` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F916A8` | `GameCard::CardDimmed` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F91750` | `GameCard::CardInHand` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F91834` | `GameCard::CardPrepared` | method | [بلوت](baloot-spec/08-الأنيميشن-الكامل.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F91980` | `GameCard::CardPreparedForClick` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F91B18` | `GameCard::CardPreplay` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F91BA8` | `GameCard::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F91C54` | `GameCard::SetSprite` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F91D14` | `GameCard::RefreshCardStatus` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F91D18` | `GameCard::SetSortingOrder` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F91EB0` | `GameCard::SetSpecialPlayPrice` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F91FC0` | `GameCard::AnimateCardState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F9215C` | `GameCard::get_GetYOffSet` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F92258` | `GameCard::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/colors-palette.md) |
| `0x4F930D4` | `GameStateUI::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9327C` | `GameStateUI::OnGameStateUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9347C` | `GameStateUI::ShouldAcceptNext` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F93530` | `GameStateUI::ShowAcceptNext` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F93634` | `GameStateUI::AcceptNext` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x4F93714` | `GameStateUI::ShowAcceptNextAfterDelay` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F95EF4` | `GiftsShowcase.GiftQueueItem::.ctor` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4F97488` | `Hand::get_CanAffordSpecialPlay` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F97540` | `Hand::get_SwipeOffset` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F97694` | `Hand::Awake` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F979E8` | `Hand::RefreshSpecialPlayPrice` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F97B18` | `Hand::Update` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F97B88` | `Hand::OnMouseButton` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F98100` | `Hand::CanClickGoThrough` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F983F0` | `Hand::ReturnCardsToHandExcept` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9855C` | `Hand::OnMouseButtonUp` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F98674` | `Hand::OnTouchUp` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x4F98744` | `Hand::RegisterEventListeners` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F988D0` | `Hand::UnRegisterEventListeners` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F98B7C` | `Hand::ResetFlipCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F98D3C` | `Hand::DoPendingAction` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F98FA8` | `Hand::ShowHandCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F990C8` | `Hand::ShowActualHandCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F99A4C` | `Hand::ShowHandCardsBacks` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F99B1C` | `Hand::AnimateFlipCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F99CF4` | `Hand::UpdateCardsHash` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F99EB0` | `Hand::PlayItsMyTurnVibration` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F99F9C` | `Hand::AnimateFlipCardsToTheirBack` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9A14C` | `Hand::CardClicked` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9A56C` | `Hand::DoPlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9A78C` | `Hand::UpdatePriceTag` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9B124` | `KGameUiControls::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9B1EC` | `KGameUiControls::RegisterEvents` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9B438` | `KGameUiControls::OnDestroy` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9B50C` | `KGameUiControls::OnGameStateUpdated` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9B65C` | `KGameUiControls::OnMatchMakerEvent` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x4F9B6A8` | `KGameUiControls::HideLoader` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9B830` | `KGameUiControls::OnButtonExitClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9BA54` | `KGameUiControls::Init` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9BB1C` | `KGameUiControls::SetGameToLoading` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9BE38` | `KGameUiControls::ShowLoader` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9C030` | `KGameUiControls::ShowOfflineUi` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9C900` | `LeaveRoomPopup::TryFindGame` | inside (+0x2C) | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x4F9CD10` | `PerspectiveToggler::<Awake>b__9_0` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4F9D94C` | `ProjectButtons::Awake` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9DBE0` | `ProjectButtons::ResetProjects` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9DD94` | `ProjectButtons::OnGameStateUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9DF68` | `ProjectButtons::Hide` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9DFE8` | `ProjectButtons::UpdateLabels` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9E150` | `ProjectButtons::ToggleProjectsPanel` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9E260` | `ProjectButtons::Show` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9E308` | `ProjectButtons::OnProjectButtonClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9E5A0` | `ProjectButtons::GetTotalProjects` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4F9E5FC` | `ProjectButtons::ShowProjectsError` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9E700` | `ProjectButtons::GetProjects` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4F9F080` | `RoomThemeUi::RoomThemeChanged` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x4F9F83C` | `BalootRoundBoardPopup::get_MyTeamIndex` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4F9F88C` | `BalootRoundBoardPopup::ShowRoundBoard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FA11C8` | `BalootRoundBoardPopup::ShowPopup` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FA124C` | `BalootRoundBoardPopup::ResetAnimationComponent` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FA12BC` | `BalootRoundBoardPopup::ShowAnimationPanel` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FA1338` | `BalootRoundBoardPopup::ShowOutroAnimation` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FA13C4` | `BalootRoundBoardPopup::MyTeamIsWinner` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FA1444` | `BalootRoundBoardPopup::ShowAnimation` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FA14E4` | `BalootRoundBoardPopup::.ctor` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FA264C` | `EndGameAchievementItem::Populate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FA2700` | `EndGameAchievementItem::LoadCurrentLevelImage` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FA2910` | `EndGameAchievementItem.<>c__DisplayClass16_0::<LoadCurrentLevelImage>b__0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FA4FAC` | `GameEndPopup::OnGameEnd` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FA6348` | `GameEndPopup::EnableButtons` | inside (+0x2E0) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x4FA78B4` | `JackarooScoreGameEndWidget::get_JackarooGame` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FA79A0` | `JackarooScoreGameEndWidget::get_GameVisual` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FA7A8C` | `JackarooScoreGameEndWidget::PopulateScore` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FA7C84` | `JackarooScoreGameEndWidget::InitProgressIndicators` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FA7E9C` | `JackarooScoreGameEndWidget::Populate` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FA7F64` | `JackarooScoreGameEndWidget::PopulateAvatars` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FA80E0` | `JackarooScoreGameEndWidget::SetResultColors` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FAB2B8` | `PointsAndRankGameEndWidget::get_IsFriendly` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAB3FC` | `PointsAndRankGameEndWidget::PrepareAnimation` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAB6B8` | `PointsAndRankGameEndWidget::InitializeEarnedPoints` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAB8D4` | `PointsAndRankGameEndWidget::InitializeBlueProgressPosition` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAB9A0` | `PointsAndRankGameEndWidget::InitializeStreak` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FABB64` | `PointsAndRankGameEndWidget::AnimatePointsSlider` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FABF3C` | `PointsAndRankGameEndWidget::AnimatedPopulate` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAC13C` | `PointsAndRankGameEndWidget::ShouldShow` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAC2D4` | `PointsAndRankGameEndWidget::StartAnimation` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAC4FC` | `PointsAndRankGameEndWidget::StartAnimation2` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FACE74` | `PointsAndRankGameEndWidget::StartAnimation2Point1` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAD090` | `PointsAndRankGameEndWidget::ShowRankingAnimation` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FAD430` | `PointsAndRankGameEndWidget::AnimateWinningStreak` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FADD60` | `PointsAndRankGameEndWidget::.cctor` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x4FB005C` | `StatisticsPopup::ShowStatisticsPopup` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB0304` | `StatisticsAndHighlightsGameEndWidget::ShouldShow` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB3424` | `JackarooResultRibbonGameEndWidget::PrepareAnimation` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FB349C` | `JackarooResultRibbonGameEndWidget::Populate` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FB351C` | `JackarooResultRibbonGameEndWidget::AnimatedPopulate` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FB46F8` | `StatisticsPopup::get_ShowSubscriptionWall` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB4868` | `StatisticsPopup::SetStatisticsStrips` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB4FC0` | `StatisticStrip::SetUp` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB5300` | `StatisticsPopup::get_StatisticShownToday` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB5B44` | `StatisticStrip::SetUpPlayers` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB5C58` | `StatisticStrip::SetHighestStatColor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB61E4` | `TarneebRoundBoardPopup::ShowRoundBoard` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FB6B10` | `TarneebRoundBoardPopup::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FB7D74` | `UiCard::set_Index` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB7D88` | `BalootPlayingButtons::Start` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB8250` | `BalootPlayingButtons::HideContainer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB8304` | `BalootPlayingButtons::RefreshFireSawaPrice` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FB836C` | `BalootPlayingButtons::OnDestroy` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB84F0` | `BalootPlayingButtons::OnGameStateUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB8538` | `BalootPlayingButtons::HandleTutorialState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB8688` | `BalootPlayingButtons::UpdateButtons` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB8A00` | `BalootPlayingButtons::ShakeProjectsButton` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB8B54` | `BalootPlayingButtons::<Start>b__10_0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB8C1C` | `BalootUserbox::get_player` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FB8C98` | `BalootUserbox::get_game` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FB8D14` | `BalootUserbox::Awake` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB9070` | `Userbox::Awake` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB9444` | `BalootUserbox::OnRoundStart` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB9578` | `BalootUserbox::OnRoundStart` | inside (+0x134) | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4FB95D8` | `BalootUserbox::HideKasho` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB9734` | `BalootUserbox::HideSawa` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FB9890` | `Userbox::ShowGameBubble` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB9AD0` | `BalootUserbox::OnGameStatusUpdate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FB9D80` | `Userbox::OnGameStatusUpdate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x4FB9E70` | `BalootUserbox::SetBidInfo` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBA174` | `BalootUserbox::GetGameExtraModeText` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBA2B0` | `BalootUserbox::SetDouble` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBA4AC` | `BalootUserbox::SetProjects` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBA694` | `BalootUserbox::OnPlayerDidLastAction` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBA91C` | `BalootUserbox::OnPlayerDidLastAction` | inside (+0x288) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x4FBA938` | `BalootUserbox::OnPlayerDidLastAction` | inside (+0x2A4) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x4FBAD5C` | `BalootUserbox::OnPlayerDidLastAction` | inside (+0x6C8) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x4FBB07C` | `BalootUserbox::OnPlayerDidLastAction` | inside (+0x9E8) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x4FBB098` | `BalootUserbox::OnPlayerDidLastAction` | inside (+0xA04) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x4FBB0D0` | `Userbox::OnPlayerDidLastAction` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBB314` | `BalootUserbox::<OnPlayerDidLastAction>g__FireCardRevealSound|29_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBB580` | `BalootUserbox::ShowSawa` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBB658` | `BalootUserbox::ShowKasho` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBB730` | `BalootUserbox::.ctor` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FBB7F8` | `BalootUserbox::<OnPlayerDidLastAction>b__29_1` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FBB8D8` | `BalootUserbox::<SetProjects>b__36_0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBBA48` | `BalootUserbox::<SetProjects>b__36_1` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x4FBBA8C` | `TarneebPlayingButtons::Start` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBBC14` | `TarneebPlayingButtons::OnGameStateUpdated` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBBC18` | `TarneebPlayingButtons::UpdateButtons` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBBD20` | `TarneebPlayingButtons::ShowSawaButton` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBBDD8` | `TarneebPlayingButtons::HideSawaButton` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBBE78` | `TarneebPlayingButtons::ShowSawaPanel` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBBE94` | `TarneebPlayingButtons::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBBE9C` | `TarneebUserbox::get_player` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBBF18` | `TarneebUserbox::get_game` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBBF94` | `TarneebUserbox::Awake` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBC07C` | `TarneebUserbox::OnGameStatusUpdate` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBC384` | `TarneebUserbox::SetBidInfo` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBC628` | `TarneebUserbox::UpdateEatingCount` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBC818` | `TarneebUserbox::OnPlayerDidLastAction` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBCA1C` | `TarneebUserbox::OnPlayerDidLastAction` | inside (+0x204) | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x4FBCB84` | `TarneebUserbox::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBCB94` | `TarneebUserbox::<SetBidInfo>b__12_0` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x4FBCBC4` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x4FBCCB4` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0xF0) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCB8` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0xF4) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCBC` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0xF8) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCC0` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0xFC) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCC4` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x100) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCC8` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x104) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCCC` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x108) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCD0` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x10C) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCD4` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x110) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCD8` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x114) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCE0` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x11C) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBCCE4` | `TarneebUserbox.<>c__DisplayClass13_0::<UpdateEatingCount>b__0` | inside (+0x120) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x4FBD120` | `Userbox::OnGameInitialized` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBD490` | `Userbox::RegisterEventListeners` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBD960` | `Userbox::UnRegisterEventListeners` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBDF38` | `Userbox::FixDirection` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBECA4` | `Userbox::OnThisUserChanged` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBEDB0` | `Userbox::OnDestroy` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBEFEC` | `Userbox::ShowPlayerTurnIndicator` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBF0E0` | `Userbox::HidePlayerTurnIndicator` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBF1B4` | `Userbox::StartTimer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBF420` | `Userbox::SetDealer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBF5C4` | `Userbox::RefreshShownCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBF850` | `Userbox::RefreshUser` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBFA14` | `Userbox::RefreshCardBack` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FBFB9C` | `Userbox::RefreshVoiceUI` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FBFF4C` | `Userbox::OnSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC01D8` | `Userbox::OnNewVoiceChatUpdate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4FC0298` | `Userbox::StartVoiceAnimation` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x4FC060C` | `Userbox::GetUserBoxDirection` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC0748` | `Userbox::ReorganizeCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x4FC0A8C` | `Userbox::ResetDefaultCardBacks` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC0E70` | `Userbox::ProcessBubbleMessage` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC1454` | `Userbox::DimUserbox` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC15C4` | `Userbox::UnDimUserbox` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC193C` | `Userbox::OnSitHereButtonClick` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC19FC` | `Userbox::CanJoinGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC1A98` | `Userbox::OpenGiftBoxForPlayer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x4FC3750` | `ServerFetcher::Start` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x4FC3E3C` | `ServerFetcher::CheckAndPrepareServers` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x4FC47B8` | `ServerFetcher::<GoToLogin>g__Login|29_2` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x4FC6B84` | `KSettings::OnRoute` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FC6C4C` | `KSettings::OnRoute` | inside (+0xC8) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x4FC6C60` | `KSettings::OnRoute` | inside (+0xDC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x4FC6D24` | `KSettings::ScrollAndShake` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FC71B4` | `PrivacyPolicy::ToggleAnalyticsAgreement` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCBEB4` | `SettingReplaysSection::ReplayButtonWarningOnClick` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x4FCBF54` | `SettingsGameSection::Start` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC310` | `SettingsGameSection::ConfirmSawaToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC398` | `SettingsGameSection::CardDimmingToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC420` | `SettingsGameSection::BiddingPredeterminationChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC4A8` | `SettingsGameSection::AllowDifferentCardElevationChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC530` | `SettingsGameSection::AllowMyTurnHandAnimationChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC5B8` | `SettingsGameSection::AllowVibrationChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCC640` | `SettingsGameSection::ShowJackarooTipsChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCD244` | `SettingSoundActorToggle::ToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCD608` | `SettingsSoundSection::GameSoundToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCD820` | `SettingsSoundSection::ActorsToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCD8C8` | `SettingsSoundSection::ChatSoundToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCD970` | `SettingsSoundSection::SFXSoundToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCDA18` | `SettingsSoundSection::MusicToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FCDF44` | `SettingsTabletToggle::ToggleChanged` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FD14A0` | `BuyCardPopup::SelectDefault` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD163C` | `BuyCardPopup::AddTabs` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD1A0C` | `BuyCardPopup::InitializeCards` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD1D28` | `BuyCardPopup::SelectItem` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD1F0C` | `BuyCardPopup::FixDuplicateLabels` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2038` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x12C) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD22A4` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x398) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD22CC` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x3C0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD22E8` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x3DC) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2454` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x548) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2460` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x554) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2474` | `BuyCardPopup::FixDuplicateLabels` | inside (+0x568) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2650` | `BuyCardPopup::RepositionCards` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD27EC` | `BuyCardPopup::UpdateButtons` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2878` | `BuyCardPopup::ShowStatus` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD28F4` | `BuyCardPopup::ShowActivate` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2970` | `BuyCardPopup::ShowBuy` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2BA8` | `BuyCardPopup::RefreshPrice` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2D40` | `BuyCardPopup::BuySelected` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD2F30` | `BuyCardPopup::BuySelected` | inside (+0x1F0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3058` | `BuyCardPopup::BuySelected` | inside (+0x318) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD30AC` | `BuyCardPopup::ActivateSelected` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD30F0` | `BuyCardPopup::ActivateSelected` | inside (+0x44) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3144` | `BuyCardPopup::ActivateSelected` | inside (+0x98) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD314C` | `BuyCardPopup::OnSwipe` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD35F0` | `BuyCardPopup::<ActivateSelected>b__41_0` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3654` | `BuyCardPopup::<ActivateSelected>b__41_0` | inside (+0x64) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3668` | `BuyCardPopup::<ActivateSelected>b__41_0` | inside (+0x78) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3684` | `BuyCardPopup::<ActivateSelected>b__41_0` | inside (+0x94) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3698` | `BuyCardPopup::<ActivateSelected>b__41_0` | inside (+0xA8) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD379C` | `BuyCardPopup.<>c::<FixDuplicateLabels>b__39_0` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD380C` | `BuyCardPopup.<>c::<FixDuplicateLabels>b__39_0` | inside (+0x70) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD3848` | `BuyCardPopup.<>c::<FixDuplicateLabels>b__39_1` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD38A0` | `BuyCardPopup.<>c::<FixDuplicateLabels>b__39_2` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FD4F48` | `CurrencyToSubscriptionUi::CoinsInputEndEdit` | inside (+0x7C) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD5084` | `CurrencyToSubscriptionUi::CoinsInputEndEdit` | inside (+0x1B8) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8C90` | `CurrencyTransferUi::UpdateTransactionInfo` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8EA4` | `CurrencyTransferUi::UpdateTransactionInfo` | inside (+0x214) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8EE8` | `CurrencyTransferUi::UpdateTransactionInfo` | inside (+0x258) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8EF0` | `CurrencyTransferUi::UpdateTransactionInfo` | inside (+0x260) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8EF4` | `CurrencyTransferUi::UpdateTransactionInfo` | inside (+0x264) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8EF8` | `CurrencyTransferUi::UpdateTransactionInfo` | inside (+0x268) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD8EFC` | `CurrencyTransferUi::UpdateTransactionInfo` | inside (+0x26C) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD9118` | `CurrencyTransferUi::RefreshFeesUi` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FD9248` | `CurrencyTransferUi::RefreshFeesUi` | inside (+0x130) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FDE0E0` | `CommonJackarooSlide::Show` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE1C4` | `CommonJackarooSlide::DisplayTextBottomUp` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE2D8` | `CommonJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE3AC` | `CommonJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE44C` | `FriendsChatsJackarooSlide::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE584` | `FriendsChatsJackarooSlide::ClearText` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE600` | `FriendsChatsJackarooSlide::OnShow` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDE880` | `FriendsChatsJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDEA94` | `FriendsChatsJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDED24` | `GameRulesJackarooSlide::OnShow` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDF23C` | `GameRulesJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDF508` | `GameRulesJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDF828` | `NoAdsJackarooSlide::OnShow` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDFA40` | `NoAdsJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDFC14` | `NoAdsJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDFD78` | `OtherFeaturesJackarooSlide::OnShow` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FDFEF0` | `OtherFeaturesJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE0030` | `OtherFeaturesJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE0154` | `OtherFeaturesJackarooSlide::<Hide>b__5_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE0248` | `OwnSessionJackarooSlide::OnShow` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE049C` | `OwnSessionJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE0658` | `OwnSessionJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE079C` | `SingleSubscriptionJackarooSlide::OnShow` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE0C44` | `SingleSubscriptionJackarooSlide::Hide` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE10D0` | `SingleSubscriptionJackarooSlide::SetHidden` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE11C0` | `SingleSubscriptionJackarooSlide::<Hide>b__10_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x4FE7B58` | `StoreCardGroup::Populate` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FE7B5C` | `StoreRoomThemesGroup::Populate` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FE7FCC` | `StoreRoomThemesGroup::Populate` | inside (+0x470) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FE8184` | `StoreHomePageGroup::Populate` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8564` | `StoreHomePageGroup::Populate` | inside (+0x3E0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8568` | `StoreHomePageGroup::Populate` | inside (+0x3E4) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8570` | `StoreHomePageGroup::Populate` | inside (+0x3EC) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8578` | `StoreHomePageGroup::Populate` | inside (+0x3F4) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8580` | `StoreHomePageGroup::Populate` | inside (+0x3FC) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8588` | `StoreHomePageGroup::Populate` | inside (+0x404) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE85B8` | `StoreHomePageGroup::Populate` | inside (+0x434) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE85BC` | `StoreHomePageGroup::Populate` | inside (+0x438) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE86C8` | `StoreHomePageGroup::Populate` | inside (+0x544) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE871C` | `StoreHomePageGroup::Populate` | inside (+0x598) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8730` | `StoreHomePageGroup::Populate` | inside (+0x5AC) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE874C` | `StoreHomePageGroup::Populate` | inside (+0x5C8) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8858` | `StoreHomePageGroup::Populate` | inside (+0x6D4) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE88AC` | `StoreHomePageGroup::Populate` | inside (+0x728) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE88B4` | `StoreHomePageGroup::Populate` | inside (+0x730) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE88BC` | `StoreHomePageGroup::Populate` | inside (+0x738) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8920` | `StoreHomePageGroup::Populate` | inside (+0x79C) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8974` | `StoreHomePageGroup::Populate` | inside (+0x7F0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8A24` | `StoreHomePageGroup::Populate` | inside (+0x8A0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8A78` | `StoreHomePageGroup::Populate` | inside (+0x8F4) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8AA8` | `StoreHomePageGroup::Populate` | inside (+0x924) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8AAC` | `StoreHomePageGroup::Populate` | inside (+0x928) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8B30` | `StoreHomePageGroup::Populate` | inside (+0x9AC) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8BC8` | `StoreHomePageGroup::Populate` | inside (+0xA44) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8C98` | `StoreHomePageGroup::Populate` | inside (+0xB14) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8D80` | `StoreHomePageGroup::Populate` | inside (+0xBFC) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8E34` | `StoreHomePageGroup::Populate` | inside (+0xCB0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE8F04` | `StoreHomePageGroup::Populate` | inside (+0xD80) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE9088` | `StoreHomePageGroup::Populate` | inside (+0xF04) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE90F0` | `StoreHomePageGroup::Populate` | inside (+0xF6C) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE91AC` | `StoreHomePageGroup::Populate` | inside (+0x1028) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE9420` | `StoreHomePageGroup::Populate` | inside (+0x129C) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE94C8` | `StoreHomePageGroup::Populate` | inside (+0x1344) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE954C` | `StoreHomePageGroup::Populate` | inside (+0x13C8) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE9568` | `StoreHomePageGroup::Populate` | inside (+0x13E4) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE9674` | `StoreHomePageGroup::Populate` | inside (+0x14F0) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE98C8` | `StoreHomePageGroup::Populate` | inside (+0x1744) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FE98E0` | `StoreHomePageGroup::Populate` | inside (+0x175C) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FEA7B0` | `Store::AssignStoreModels` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEA7E8` | `Store::AssignStoreModels` | inside (+0x38) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEA89C` | `Store::AssignStoreModels` | inside (+0xEC) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEAAEC` | `Store::AssignStoreModels` | inside (+0x33C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEAB2C` | `Store::AssignStoreModels` | inside (+0x37C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEAB74` | `Store::AssignStoreModels` | inside (+0x3C4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEAB84` | `Store::AssignStoreModels` | inside (+0x3D4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEABE4` | `Store::AssembleStoreInfo` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEAF6C` | `Store::BuyFTTicket` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x4FEB2D4` | `Store::GetStoreItem` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) · [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x4FEBE48` | `Store.<>c::<AssignStoreModels>b__56_0` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEBE60` | `Store.<>c::<AssignStoreModels>b__56_1` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEBF10` | `Store.<>c::<AssignStoreModels>b__56_2` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FED594` | `StoreBundleItemUI::PopulateProduct` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FED744` | `StoreBundleItemUI::PopulateProduct` | inside (+0x1B0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FED768` | `StoreBundleItemUI::PopulateProduct` | inside (+0x1D4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FED784` | `StoreBundleItemUI::PopulateProduct` | inside (+0x1F0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FED7A0` | `StoreBundleItemUI::PopulateProduct` | inside (+0x20C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FED85C` | `StoreBundleItemUI::PopulateProduct` | inside (+0x2C8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEDA28` | `StoreBundleItemUI::PopulateProduct` | inside (+0x494) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEDA88` | `StoreBundleItemUI::PopulateProduct` | inside (+0x4F4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEDB8C` | `StoreBundleItemUI::PopulateProduct` | inside (+0x5F8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEDBF4` | `StoreBundleItemUI::PopulateProduct` | inside (+0x660) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEEEF4` | `StoreCardGroup::SetData` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF0BC` | `StoreCardGroup::SetData` | inside (+0x1C8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF14C` | `StoreCardGroup::SetData` | inside (+0x258) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF320` | `StoreCardGroup::SetData` | inside (+0x42C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF348` | `StoreCardGroup::SetData` | inside (+0x454) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF35C` | `StoreCardGroup::SetData` | inside (+0x468) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF3CC` | `StoreCardGroup::SetData` | inside (+0x4D8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF440` | `StoreCardGroup::SetData` | inside (+0x54C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF508` | `StoreCardGroup::SetData` | inside (+0x614) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF50C` | `StoreCardGroup::SetData` | inside (+0x618) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF510` | `StoreCardGroup::SetData` | inside (+0x61C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF514` | `StoreCardGroup::SetData` | inside (+0x620) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF518` | `StoreCardGroup::SetData` | inside (+0x624) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF51C` | `StoreCardGroup::SetData` | inside (+0x628) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF520` | `StoreCardGroup::SetData` | inside (+0x62C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEF8C8` | `StoreCardGroup::SetData` | inside (+0x9D4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEFA64` | `StoreCardGroup::SetData` | inside (+0xB70) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FEFFD4` | `StoreItem::get_IsActiveAndNotAd` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF0F9C` | `StoreOwnedItem::get_IsActiveItem` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF1E7C` | `StoreProductUi::PopulateProduct` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF2034` | `StoreProductUi::PopulateProduct` | inside (+0x1B8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF207C` | `StoreProductUi::PopulateProduct` | inside (+0x200) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF2144` | `StoreProductUi::PopulateProduct` | inside (+0x2C8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF2158` | `StoreProductUi::PopulateProduct` | inside (+0x2DC) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF220C` | `StoreProductUi::PopulateProduct` | inside (+0x390) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF2290` | `StoreProductUi::PopulateProduct` | inside (+0x414) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF233C` | `StoreProductUi::PopulateProduct` | inside (+0x4C0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF23C0` | `StoreProductUi::PopulateProduct` | inside (+0x544) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF24B4` | `StoreProductUi::PopulateProduct` | inside (+0x638) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF2544` | `StoreProductUi::PopulateProduct` | inside (+0x6C8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF255C` | `StoreProductUi::PopulateProduct` | inside (+0x6E0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF2C84` | `StoreHomePageGroup::InitTitle` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF2D14` | `StoreHomePageGroup::InitBannerItem` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF2DA8` | `StoreHomePageGroup::InitBannerList` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF2E3C` | `StoreHomePageGroup::InitUniqueItem` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF2EC0` | `StoreHomePageGroup::InitBundle` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF2FEC` | `StoreHomePageGroup::InitCardItems` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF3080` | `StoreHomePageGroup::InitRoomItem` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF319C` | `StoreHomePageGroup::InitGoldenCards` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF328C` | `StoreHomePageGroup::InitSubscription` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF33A8` | `StoreHomePageGroup::InitPatternItem` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF34FC` | `StoreHomePageGroup.<>c::<Populate>b__0_0` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF3554` | `StoreHomePageGroup.<>c::<Populate>b__0_6` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF3584` | `StoreHomePageGroup.<>c__DisplayClass0_0::<Populate>b__2` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF369C` | `StoreHomePageGroup.<>c__DisplayClass0_0::<Populate>b__7` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF38FC` | `StoreHomePageGroup.<>c__DisplayClass0_1::<Populate>b__1` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF396C` | `StoreHomePageGroup.<>c__DisplayClass0_1::<Populate>b__3` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF39DC` | `StoreHomePageGroup.<>c__DisplayClass0_1::<Populate>b__5` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF3A84` | `StoreHomePageGroup.<>c__DisplayClass0_1::<Populate>b__8` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x4FF3B6C` | `StoreDataHolder::SetTemplate` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF3FB4` | `StoreItem::GetCategory` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF47D8` | `StorePricing::EffectivePrice` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x4FF5238` | `StoreOwnedItem::.ctor` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FF68E0` | `StorePatternsGroup::Populate` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF6A00` | `StorePatternsGroup::Populate` | inside (+0x120) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF6ACC` | `StorePatternsGroup::Populate` | inside (+0x1EC) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF6CAC` | `StorePricing::DiscountAmount` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) · [اقتصاد](economy-spec/README.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x4FF6DAC` | `StorePricing::DiscountAmount` | inside (+0x100) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6DC4` | `StorePricing::DiscountAmount` | inside (+0x118) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6DE8` | `StorePricing::DiscountAmount` | inside (+0x13C) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6DF4` | `StorePricing::DiscountAmount` | inside (+0x148) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6DFC` | `StorePricing::DiscountAmount` | inside (+0x150) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E10` | `StorePricing::DiscountAmount` | inside (+0x164) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E1C` | `StorePricing::DiscountAmount` | inside (+0x170) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E20` | `StorePricing::DiscountAmount` | inside (+0x174) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E24` | `StorePricing::DiscountAmount` | inside (+0x178) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E40` | `StorePricing::DiscountAmount` | inside (+0x194) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E44` | `StorePricing::DiscountAmount` | inside (+0x198) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E48` | `StorePricing::DiscountAmount` | inside (+0x19C) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E50` | `StorePricing::DiscountAmount` | inside (+0x1A4) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6E54` | `StorePricing::DiscountAmount` | inside (+0x1A8) | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6EA0` | `StorePricing::TotalPrice` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x4FF6ED4` | `StorePricing::BindPricingSources` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FF76F0` | `StoreProductUi::UpdateDiscountTag` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF8600` | `StoreRoomItem::PopulateStoreItem` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF871C` | `StoreRoomItem::PopulateStoreItem` | inside (+0x11C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF872C` | `StoreRoomItem::PopulateStoreItem` | inside (+0x12C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF8760` | `StoreRoomItem::PopulateStoreItem` | inside (+0x160) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF8778` | `StoreRoomItem::PopulateStoreItem` | inside (+0x178) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF87D8` | `StoreRoomItem::PopulateStoreItem` | inside (+0x1D8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF886C` | `StoreRoomItem::PopulateStoreItem` | inside (+0x26C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF88B4` | `StoreRoomItem::PopulateStoreItem` | inside (+0x2B4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF8920` | `StoreRoomItem::PopulateStoreItem` | inside (+0x320) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF99B8` | `StoreRoomThemesGroup.<>c::<Populate>b__0_0` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x4FF9B04` | `StoreUtil::GetAvailableItems` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x4FFBCC0` | `TipManager::RequestLoadingTip` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x4FFBED8` | `TipManager::GetValidTip` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x4FFCE20` | `PlayerPrefsGame::get_Suffix` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFCEDC` | `PlayerPrefsGame::GetString` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFCF60` | `Prefs::GetString` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFCFCC` | `PlayerPrefsGame::SetString` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD050` | `Prefs::SetString` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD0BC` | `PlayerPrefsGame::HasKey` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD138` | `Prefs::HasKey` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD19C` | `PlayerPrefsGame::GetDate` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD21C` | `Prefs::GetDate` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD284` | `PlayerPrefsGame::SetDate` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD304` | `Prefs::SetDate` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD36C` | `PlayerPrefsScope::get_Suffix` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x4FFD3B0` | `PlayerPrefsScope::Key` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001910` | `Prefs::GetInt` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x500197C` | `Prefs::SetInt` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50019E8` | `Prefs::GetFloat` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001A5C` | `Prefs::SetFloat` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001AD0` | `Prefs::DeleteKey` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001B34` | `Prefs::DeleteAll` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001B3C` | `Prefs::Save` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001B44` | `Prefs::GetBool` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001BBC` | `Prefs::SetBool` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001C24` | `Prefs::GetLong` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001CB4` | `Prefs::SetLong` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001D44` | `Prefs::GetVector2` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5001EA8` | `Prefs::GetVector3` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5002038` | `Prefs::GetColor` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x5004930` | `CardsSprites::GetFor` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5004A24` | `CardsSprites::GetFor` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5006234` | `TournamentSprites::GetTheme` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50094FC` | `AchievementClaimPopup::Enqueue` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x5009720` | `AchievementClaimPopup::EnqueueInstance` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x5009AC0` | `AchievementClaimPopup::PreparePopSequence` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x5009CE0` | `AchievementClaimPopup::KillPopSequence` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x5009DD0` | `AchievementClaimPopup::ShowNext` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x5009F98` | `AchievementClaimPopup::UpdateQueueCounter` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x500A0F8` | `AchievementClaimPopup::SwapTo` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x500A480` | `AchievementClaimPopup::Bind` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x500AD5C` | `AchievementClaimPopup::OnAction` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x500AEB4` | `AchievementClaimPopup::CloseOrNext` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x500B2B8` | `AchievementClaimPopup::<OnAction>b__30_0` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x500EDB0` | `AchievementsManager::OnLogin` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x501060C` | `GameAchievementViewModel::ToString` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x50157A4` | `AnimatedItemController::ResetChanges` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5015B28` | `AnimatedItemController::GetDefaultCardMaterial` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5016694` | `AnimatedItemController::NormalizeHardcodedGiftKey` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5016880` | `AnimatedItemController::GetGameAction` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x5016AFC` | `AnimatedItemController::CreateCustomPlayAnimation` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5016D30` | `AnimatedItemController::CreateCustomMarbleAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x50176AC` | `AnimatedItemController::OnEmoteReceived` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x50179CC` | `AnimatedItemController::NotifyEmotePlaybackCompleted` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5017F24` | `AnimatedItemController::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x501E420` | `BracketUnit::GetNextMatch` | inside (+0x14) | [ردهة](lobby-spec/03-البطولات.md) |
| `0x501E478` | `BracketUnit::GetNextMatch` | inside (+0x6C) | [ردهة](lobby-spec/03-البطولات.md) · [ردهة](lobby-spec/README.md) |
| `0x50208D4` | `MatchData::.ctor` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5020B18` | `MatchData::GetPlayersFromSfsObject` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5023D90` | `FeaturesBottomSheet::get_AddonConfig` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5023E18` | `FeaturesBottomSheet::get_TitleConfig` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5023F44` | `FeaturesBottomSheet::GetAddonPrice` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5024074` | `FeaturesBottomSheet::get_GetSelectedAddonsPrice` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5024144` | `FeaturesBottomSheet::get_CardBackId` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x50242D0` | `FeaturesBottomSheet::get_RoomThemeAddon` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x50243B0` | `FeaturesBottomSheet::Awake` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5024980` | `FeaturesBottomSheet::PopulateAvailableAddons` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5024E10` | `FeaturesBottomSheet::PopulateSelectedAddons` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5025210` | `FeaturesBottomSheet::PopulateSelectors` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x502CD58` | `TournamentAddonCreationModel::.ctor` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x502CE90` | `TournamentAddonCreationModel::.ctor` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x502CEDC` | `TournamentAddonCreationModel::.ctor` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x502DBA0` | `TitleRestrictionTournamentAddon::IsEligible` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x502E070` | `VoiceChatTournamentAddon::get_Priority` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x502E510` | `TournamentPrizeEditView::GetValidationModel` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x502F704` | `TournamentPrizeEditView.ValidationModel::get_IsValid` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x502F714` | `TournamentPrizeEditView.ValidationModel::get_ValidationErrorMessage` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5031128` | `GiftBombData::.ctor` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5035110` | `MonthlyTournamentEligibilityExtensions::ToTournamentSubType` | method | [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x50351A0` | `MonthlyTournamentEligibilityExtensions::IsOverQualified` | method | [صدارة](leaderboards-spec/01-لوحات-الصدارة-والمواسم.md) |
| `0x5035250` | `TournamentName::Initialize` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50384EC` | `SfsTournamentConnector::SetSeat` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x503882C` | `SfsTournamentConnector::CanJoin` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5039538` | `SfsTournamentConnector::OnLogout` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x503C064` | `TournamentButtons::UpdateVisibility` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503C318` | `TournamentButtons::UpdateInteractivity` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503CA8C` | `TournamentCardRoomThemeSetter::Initialize` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503CC58` | `TournamentCardRoomThemeSetter::resetUI` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503D970` | `TournamentEligibilityIndicator::Initialize` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503DDC4` | `TournamentInfoIcons::Initialize` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503EF24` | `TournamentRequirementInfo::Initialize` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x503FEB0` | `TournamentStrip::ResetUI` | inside (+0x2A0) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5041850` | `TournamentStrip::PopulateVisualData` | inside (+0x7F8) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5041B9C` | `TournamentStrip::UpdateTitleRestriction` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5041E38` | `TournamentTime::Initialize` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5041F98` | `TournamentStrip::IsTournamentHidden` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5043C80` | `QueuePlayer::FromSfsObject` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x50470B4` | `TournamentInviteManager::HandleResponse` | inside (+0x580) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x504748C` | `TournamentInviteManager::PlayerSelected` | inside (+0x2D0) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5047FA0` | `TournamentInviteManager::SendInvite` | inside (+0xE8) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5047FFC` | `TournamentInviteManager::SendCommandHelper` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5048DA0` | `TournamentInviteManager::MarkRejected` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5048F14` | `TournamentInviteManager::ClearInvites` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x504955C` | `TournamentInviteManager.<>c__DisplayClass28_0::<SendCancel>g__Callback|0` | inside (+0x12C) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50498C4` | `TournamentInviteManager.<>c__DisplayClass34_0::<QueueUpdated>b__0` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50498F4` | `TournamentInviteManager.<>c__DisplayClass34_0::<QueueUpdated>b__1` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5049948` | `TournamentInviteManager.<>c__DisplayClass34_0::<QueueUpdated>b__2` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5049978` | `TournamentInviteManager.<>c__DisplayClass34_1::<QueueUpdated>b__3` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50499B8` | `TournamentInviteManager.<>c__DisplayClass34_1::<QueueUpdated>b__4` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50499F8` | `TournamentInviteManager.<>c__DisplayClass34_1::<QueueUpdated>b__5` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5049A38` | `TournamentInviteManager.<>c__DisplayClass34_2::<QueueUpdated>b__6` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5049A94` | `TournamentInviteManager.<>c__DisplayClass34_2::<QueueUpdated>b__7` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x504B2BC` | `TournamentQueueController::OnExtensionResponse` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504BF04` | `TournamentQueueController::SendSeatTeamRequest` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504C064` | `TournamentQueueController::SendSwapRequest` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504C1C0` | `TournamentQueueController::SendSeatPlayerRequest` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504CC64` | `TournamentQueueController::SendUnseat` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504CD58` | `TournamentQueueController::AllowParticipantsChanged` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504CE4C` | `TournamentQueueController::ShuffleTeamsChanged` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504CF40` | `TournamentQueueController::FillTeams` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504CFE0` | `TournamentQueueController::ResetTeams` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504D080` | `TournamentQueueController::Teamup` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x504F8C8` | `TournamentChatControl::PinMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x504FAD0` | `TournamentCreationPopup::GetCreatorBalance` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x504FDCC` | `TournamentCreationPopup::get_StartTime` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x504FFF8` | `TournamentCreationPopup::get_BestOf` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5050020` | `TournamentCreationPopup::get_FinalBestOf` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5050230` | `TournamentCreationPopup::Start` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050638` | `TournamentCreationPopup::ClearInput` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5050AE8` | `TournamentCreationPopup::OnDestroy` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050BE4` | `TournamentCreationPopup::OnStartTimeChanged` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050DCC` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x1E8) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050E2C` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x248) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050F34` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x350) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050F54` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x370) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5050F64` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x380) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50510B4` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x4D0) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50512A0` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x6BC) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50512B0` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x6CC) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5051390` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x7AC) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50513AC` | `TournamentCreationPopup::OnStartTimeChanged` | inside (+0x7C8) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5051700` | `TournamentCreationPopup::OnTournamentTypeClicked` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5051808` | `TournamentCreationPopup::OnTournamentTypeClicked` | inside (+0x108) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5051B2C` | `TournamentCreationPopup::OnTournamentOptionsCancelClicked` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5051F04` | `TournamentCreationPopup::OnRoomsOptionsCancelClicked` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5052388` | `TournamentCreationPopup::OnConfigChanged` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50528E8` | `TournamentCreationPopup::CreateTournament` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5052BB8` | `TournamentCreationPopup::SendCreateTournament` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5052CCC` | `TournamentCreationPopup::SendCreateTournament` | inside (+0x114) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5052CF4` | `TournamentCreationPopup::SendCreateTournament` | inside (+0x13C) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5053074` | `TournamentCreationPopup::SendCreateTournament` | inside (+0x4BC) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x505324C` | `TournamentCreationPopup::TrackAnimatedRoomThemeAddon` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50533C8` | `TournamentCreationPopup::RefreshTournamentOptions` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5053814` | `TournamentCreationPopup::RefreshView` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5053BE4` | `TournamentCreationPopup::ValidName` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5053CC8` | `TournamentCreationPopup::ValidStartTime` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) · [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50540B4` | `TournamentCreationPopup::ValidatePassword` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x50541F4` | `TournamentCreationPopup::ValidPrize` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x505431C` | `TournamentCreationPopup::ValidateWithFeedback` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5054430` | `TournamentCreationPopup::ValidateWithFeedback` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5054588` | `TournamentCreationPopup::EnterRandomPassword` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5054630` | `TournamentCreationPopup::GetMinimumPrize` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5054B04` | `TournamentCreationPopup.<>c::<SendCreateTournament>b__116_0` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5054CF0` | `TournamentCreationPopup.<>c__DisplayClass116_0::<SendCreateTournament>b__1` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5055210` | `TournamentCreationPopup.<>c__DisplayClass131_0::<ValidPrize>b__0` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5055548` | `TournamentCreationPopup.<>c__DisplayClass96_0::<OnStartTimeChanged>b__0` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5055578` | `TournamentCreationPopup.<>c__DisplayClass99_0::<OnTournamentTypeClicked>g__Continue|0` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50555A8` | `TournamentCreationPopup.<>c__DisplayClass99_0::<OnTournamentTypeClicked>g__Back|1` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50556AC` | `TournamentData::get_TournamentAddonsVoiceChat` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x5055700` | `TournamentData::get_TournamentAddonsMessage` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5055E80` | `TournamentData::.ctor` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5056FDC` | `TournamentData::CanParticipate` | method | [ردهة](lobby-spec/03-البطولات.md) · [ردهة](lobby-spec/05-جدول-الأوامر.md) |
| `0x5059974` | `TournamentMath::GetFirstParentId` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5059980` | `TournamentMath::GetSecondParentId` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x505998C` | `TournamentMath::GetNextMatchId` | method | [ردهة](lobby-spec/03-البطولات.md) · [ردهة](lobby-spec/README.md) |
| `0x50599B0` | `TournamentMath::GetNumberOfRounds` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x505D2F0` | `TournamentUtil::GetTournamentRoundName` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x5064214` | `TournamentPopupUtil::ShowParticipationPopup` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50647AC` | `TournamentPopupUtil::ShowParticipationPopup` | inside (+0x598) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50647DC` | `TournamentPopupUtil::ShowParticipationPopup` | inside (+0x5C8) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5065194` | `TournamentPopupUtil::ShowParticipationPopup` | inside (+0xF80) | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x506CA70` | `TournamentViewPanel::UpdateRoundTimer` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x506EEE8` | `TournamentViewSfsConnector::CheckParticipationStatus` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x506F030` | `TournamentViewSfsConnector::ForceStart` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x506F168` | `TournamentViewSfsConnector::BanPlayer` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x506FD8C` | `Tutorial::SetupButtons` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5070000` | `Tutorial::ShowPage` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5070598` | `Tutorial::GetTutorialTransitionMessage` | method | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x50708AC` | `Tutorial.<>c__DisplayClass11_0::<SetupButtons>g__Call|0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5070B5C` | `Tutorial.<InitializeTutorialGamesUiIe>d__9::MoveNext` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50711CC` | `Tutorial.<Start>d__12::MoveNext` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5071444` | `TutorialErrorPanel::Start` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50715AC` | `TutorialErrorPanel::OnDestroy` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5071710` | `TutorialErrorPanel::Hide` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50717C8` | `TutorialErrorPanel::ShowErrorMessage` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x507193C` | `TutorialTipsAndErrors::SetupErrorMessage` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5071D14` | `TutorialTipsAndErrors::.cctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50728E8` | `TutorialTipsPanel::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5072A24` | `TutorialTipsPanel::SetUpAllText` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5074C30` | `AdInventory::GetAd` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5076DC4` | `AdsController::ShowRewardedAd` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x50776E0` | `AdsController::ShouldRewardBeGranted` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5077DC8` | `GoogleAdsManager::OnSceneLoaded` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5077F78` | `GoogleAdsManager::GetRewardedAdPlace` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5079110` | `GoogleAdsManager.AdUnitHolder::SetBannerAd` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x50795F4` | `GoogleAdsManager::AdLoaded` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5079820` | `GoogleAdsManager::AdFailedToLoad` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5079B2C` | `GoogleAdsManager::AdClosed` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x5079E48` | `IdfaPermission::Check` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x507A284` | `GoogleAdsManager.AdUnitHolder::SetRewardedAd` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x507A6F0` | `GoogleAdsManager.AdUnitHolder::SetInterstitialAd` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x507AB50` | `GoogleAdsManager.AdUnitHolder::FireAdLoaded` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x507AC00` | `GoogleAdsManager.AdUnitHolder::FireAdFailedToLoad` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x507AD0C` | `GoogleAdsManager.AdUnitHolder::FireUserEarnedReward` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x507F2A8` | `ChatHandler::get_CanSend` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x508040C` | `ChatHandler::SendChat` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x50812BC` | `ChatHandler::SanitizeGroupTag` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5081A48` | `ChatHandler::GetChatText` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x50824DC` | `ChatHandler::OnPublicMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5082678` | `ChatHandler::OnPublicMessage` | inside (+0x19C) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5082690` | `ChatHandler::OnPublicMessage` | inside (+0x1B4) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x50830A0` | `ChatHandler::OnJoinRoom` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x50831FC` | `ChatHandler::OnUserBlocked` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5083350` | `ChatHandler::OnUserBlocked` | inside (+0x154) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x508399C` | `ChatMessageData::GetInk` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5083AC4` | `ChatMessageData::.ctor` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5083B94` | `ChatMessageData::.ctor` | inside (+0xD0) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5083C1C` | `ChatMessageData::.ctor` | inside (+0x158) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5083E80` | `ChatMessageData::ToSFSObject` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x50846D8` | `DeepLinkingManager::OnDeepLinkActivated` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) · [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x5084DA8` | `DeepLinkingManager::TryHandleRoutingLink` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x50851D0` | `DeepLinkingManager::ParseQueryParams` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50854A4` | `DeepLinkingManager::DecodeInviteLink` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x5085600` | `DeepLinkingManager::HandleInvite` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x5087378` | `IAPController::add_OnIAPPurchaseComplete` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508741C` | `IAPController::remove_OnIAPPurchaseComplete` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50874C0` | `IAPController::add_OnIAPPurchaseFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087564` | `IAPController::remove_OnIAPPurchaseFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087608` | `IAPController::get_RecurringSubscriptions` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087660` | `IAPController::get_ConsumableSubscriptions` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50876B8` | `IAPController::get_GoldenCards` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087710` | `IAPController::get_SubscriptionsRecurringAndPromotion` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087768` | `IAPController::get_GoldenCardsIncludingHidden` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50877C0` | `IAPController::Start` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087A0C` | `IAPController::InitializePurchasing` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087AB4` | `IAPController::IsInitialized` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087B08` | `IAPController::BuildProductDefinitions` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5087D04` | `IAPController::InitializeStoreKitManager` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5088254` | `IAPController::IsStoreKitManagerInitialized` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50882A8` | `IAPController::CheckAppStoreIntroductoryOfferEligibility` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5088788` | `IAPController::InitializeGooglePlayBillingManager` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5088A94` | `IAPController::IsGooglePlayBillingManagerInitialized` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5088AE8` | `IAPController::OnPlayBillingManagerConnected` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5088F4C` | `IAPController::InitializeHuaweiIapManager` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5089470` | `IAPController::IsHuaweiIapManagerInitialized` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50894C4` | `IAPController::OnHuaweiIapManagerConnected` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50895B4` | `IAPController::FetchHuaweiProducts` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50899CC` | `IAPController::OnHuaweiPurchaseSucceeded` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5089C70` | `IAPController::OnHuaweiPurchaseSucceeded` | inside (+0x2A4) | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5089C78` | `IAPController::ListingFromHuaweiReceipt` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5089EC0` | `IAPController::SubmitReceipt` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508A118` | `IAPController::OnHuaweiPurchaseFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508A1F8` | `IAPController::OnHuaweiConsumeFinished` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508A2D4` | `IAPController::OnHuaweiOwnedPurchasesFetched` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508A808` | `IAPController::OnHuaweiIapManagerDisconnected` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508AA84` | `IAPController::OnProductsFetchFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508B03C` | `IAPController::OnPurchasePending` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508B0F0` | `IAPController::OnPurchasePending` | inside (+0xB4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508B28C` | `IAPController::OnPurchasePending` | inside (+0x250) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508B2FC` | `IAPController::OnPurchasePending` | inside (+0x2C0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508B308` | `IAPController::OnPurchaseFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508B594` | `IAPController::OnPurchaseFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508B6FC` | `IAPController::OnPurchaseFailed` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508B870` | `IAPController::InitiateBuyingProduct` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508B958` | `IAPController::InitiateBuyingProduct` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508BA80` | `IAPController::ShowPaymentMethods` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508BB24` | `IAPController::BuyProduct` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508C4A0` | `IAPController::InitiateBuyingOffer` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508C738` | `IAPController::GetProductWithOffer` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508C7A0` | `IAPController::PresentPlatformCodeRedeemSheet` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508CA70` | `IAPController::GetUnityProductMetadata` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508CD30` | `IAPController::ValidateReceipt` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508CF9C` | `IAPController::ValidateReceipt` | inside (+0x26C) | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508CFA4` | `IAPController::SubmitReceipt` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D2D0` | `IAPController::SubmitReceipt` | inside (+0x32C) | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508D400` | `IAPController::ExtractPayload` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508D4BC` | `IAPController::OnServerSuccess` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D5D4` | `IAPController::OnPurchaseCompleted` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508D868` | `IAPController::OnServerError` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D8BC` | `IAPController::OnServerError` | inside (+0x54) | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D8D8` | `IAPController::OnServerError` | inside (+0x70) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D90C` | `IAPController::OnServerError` | inside (+0xA4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D930` | `IAPController::OnServerError` | inside (+0xC8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D958` | `IAPController::OnServerError` | inside (+0xF0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508D978` | `IAPController::ShowUpdatedSubscriptionPopup` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508DD24` | `IAPController::ShowUpdatedAcesPopup` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508E09C` | `IAPController::TrackPurchase` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508E230` | `IAPController::TrackPurchase` | inside (+0x194) | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508E340` | `IAPController::TrackPurchase` | inside (+0x2A4) | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508EB40` | `IAPController.<>c::<BuildProductDefinitions>b__28_2` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508EBA0` | `SalesChannelsExtension::IsHuawei` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508EBB0` | `IAPController.<>c::<BuildProductDefinitions>b__28_4` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508F2D0` | `IAPController.<>c__DisplayClass54_0::<OnPurchasePending>b__0` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508F338` | `IAPController.<>c__DisplayClass54_0::<OnPurchasePending>b__1` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508F488` | `IAPController.<>c__DisplayClass64_0::<BuyProduct>b__0` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x508F860` | `IAPController.<InitializePurchasing>d__26::MoveNext` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FA70` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x210) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FA84` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x224) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FA98` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x238) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FAB4` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x254) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FAF4` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x294) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FB28` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x2C8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FB78` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x318) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FB88` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x328) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FC20` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x3C0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FC44` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x3E4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FCE4` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x484) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FD3C` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x4DC) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FD88` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x528) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FD94` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x534) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FDBC` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x55C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FE08` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x5A8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FE54` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x5F4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FEA0` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x640) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FEEC` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x68C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FF38` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x6D8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FF84` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x724) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x508FFD0` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x770) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x509001C` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x7BC) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5090040` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x7E0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5090058` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x7F8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50901AC` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x94C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5090238` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x9D8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5090250` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0x9F0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5090328` | `IAPController.<InitializePurchasing>d__26::MoveNext` | inside (+0xAC8) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x509094C` | `ProductStore::FilterRecurring` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5090DD0` | `ProductStore::FilterConsumable` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5091640` | `ProductStore::FilterSubscriptionsInStoreHomePage` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5091BD4` | `ProductStore::LoadProducts` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x509247C` | `ProductStore::GetConsumableVersion` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x509253C` | `ProductStore::GetConsumableVersion` | inside (+0xC0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5092540` | `ProductStore::GetConsumableVersion` | inside (+0xC4) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50925CC` | `ProductStore::GetConsumableVersion` | inside (+0x150) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50926F0` | `ProductStore::GetConsumableVersion` | inside (+0x274) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5092F94` | `ProductStore.<>c::<FilterSubscriptionsInStoreHomePage>b__26_4` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5092FB0` | `ProductStore.<>c::<FilterSubscriptionsInStoreHomePage>b__26_4` | inside (+0x1C) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5093150` | `ProductStore.<>c::<GetConsumableVersion>b__31_1` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5093458` | `ProductStore.<>c__DisplayClass31_0::<GetConsumableVersion>b__0` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50934B8` | `ProductStore.<>c__DisplayClass31_0::<GetConsumableVersion>b__0` | inside (+0x60) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x509568C` | `Notification::HasRouting` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x509570C` | `Notification::ComputeRoutingParam` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x5096CCC` | `NotificationsManager.NotificationView::IsDismissed` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x5097168` | `NotificationsManager::PassesForcedFiltersCheck` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x5098590` | `Config::get_ServerID` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x5098AB4` | `InMemoryCacheAssetLoader::ResetEnvironment` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x5098B28` | `InMemoryCacheAssetLoader::OnLowMemory` | method | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x5098C44` | `LocalUnityWebRequestAssetLoader::ValidateCachedFile` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x5099054` | `RemoteAssetsCacher::InitializeAssetLoaders` | inside (+0x140) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x5099254` | `Config::get_CachePath` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) · [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) · [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x509AE6C` | `RemoteConfig::get_Current` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x509BE50` | `Config::get_BackendURL` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) · [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x509C440` | `Config::get_FTServerForCurrentGame` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x509CB98` | `Config::get_Environment` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x509CE3C` | `Config::Initialize` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x509D05C` | `Config::ApplySavedDevelopmentHost` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x509D67C` | `Config::SetDevelopmentHost` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x509E57C` | `Config::Validate` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x509EFA8` | `Config::SetServerExtraConfigs` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x509F450` | `Config::.cctor` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x509F488` | `Config::.cctor` | inside (+0x38) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x509F498` | `Config::.cctor` | inside (+0x48) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x509FAA4` | `KammelnaConfigLoader::get_defaultBlobUrlFallback` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x509FB54` | `KammelnaConfigLoader::get_defaultSignalRServerUrl` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x50A07C8` | `KammelnaRequests::GetAuthTokens` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x50A0B84` | `KammelnaRequests::RefreshAuthTokens` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x50A2094` | `KammelnaRequests::SetItemAsDefault` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x50A2C74` | `KammelnaRequests::GetReferralsId` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50A2CF4` | `KammelnaRequests::GetReferralsHistory` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50A2D74` | `KammelnaRequests::SendReferralReport` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50A2E04` | `KammelnaRequests::SendClaimReward` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50A2E94` | `KammelnaRequests::GetReferralRewards` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50A3530` | `KammelnaRequests::FindFriend` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x50A35C0` | `KammelnaRequests::GetFriendInviteToken` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x50A3FEC` | `KammelnaRequests::CreateTournament` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x50A7BAC` | `MatchPredictionModel::GetValidScores` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A7C5C` | `MatchPredictionModel::<GetValidScores>g__GetFirstTo|84_0` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A7CF8` | `MatchPredictionModel::<GetValidScores>g__GetFirstTo|84_0` | inside (+0x9C) | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A7D00` | `MatchPredictionModel::<GetValidScores>g__GetFirstTo|84_0` | inside (+0xA4) | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A7D74` | `MatchPredictionModel::<GetValidScores>g__GetFirstTo|84_0` | inside (+0x118) | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A7DE4` | `MatchPredictionModel::<GetValidScores>g__GetFirstTo|84_0` | inside (+0x188) | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A7E78` | `MatchPredictionModel::<GetValidScores>g__NumberOfGames|84_1` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x50A82E4` | `SalesChannelsExtension::IsWebPurchasable` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50A831C` | `SalesChannelsExtension::IsStcPay` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50A8BC0` | `Bundle::GenerateTheme` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) · [اقتصاد](economy-spec/04-واجهة-المتجر.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x50A9A10` | `RemoteConfig::Initialize` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x50A9B8C` | `RemoteConfig::Refresh` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x50A9E54` | `RemoteConfig::Apply` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x50A9F5C` | `RemoteConfig::Fetch` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x50AA038` | `RemoteConfig::OnResponse` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x50AA204` | `RemoteConfig::.cctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x50AA46C` | `RoomCreator::CreateRoom` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x50AA62C` | `RoomCreator::GetRoomCreationPrice` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x50ABBC8` | `TournamentRequests::JoinTournament` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x50AD284` | `GameRoomData::.ctor` | inside (+0x2BC) | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50AD29C` | `GameRoomData::GenerateColorTheme` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50AD400` | `GameRoomData::GenerateColorTheme` | inside (+0x164) | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50AD6AC` | `PlayerInfo::get_IsHuman` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x50AD6BC` | `JackarooGameRoomData::.ctor` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x50AD900` | `PlayerInfo::.ctor` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x50AE304` | `PlayerInfo::ToSfsObject` | method | [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x50AED3C` | `PlayerProfileModel::.ctor` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x50AED7C` | `PlayerProfileModel::Update` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x50AFD7C` | `UserAchievementModel::get_isUnlocked` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B05D8` | `UserAchievementModel::.ctor` | method | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x50B0FA4` | `PlayerRank::GetRanksLimit` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B12EC` | `Preferences::get_CurrentGame` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) · [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B1354` | `PlayerRankExtensions::MinPointsToRank` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B1404` | `PlayerRank::.ctor` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B15B0` | `PlayerRank::CalculateRank` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B1A00` | `PlayerRank::GetTotalSubRank` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B1AB0` | `PlayerRank::FastTrackAward` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x50B1C9C` | `PlayerRank::FastTrackClaimAward` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x50B1DA8` | `PlayerRank::GetNearestFTAwardStage` | method | [هوية](identity-spec/02-الإحصائيات-والملف.md) · [هوية](identity-spec/04-المسار-السريع-والرتب.md) · [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x50B1E3C` | `PlayerRank::GetNearestFTAwardStage` | inside (+0x94) | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x50B1F34` | `PlayerRank::GetNearestFTAwardStage` | inside (+0x18C) | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x50B1FA8` | `PlayerRank::GetNearestFTAwardStage` | inside (+0x200) | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x50B1FD8` | `PlayerRank::.cctor` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B2288` | `PlayerRankExtensions::MaxPointsToRank` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50B23CC` | `Preferences::GetAndAssignDefaultActor` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) · [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x50B24C4` | `Preferences::set_SoundActor` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B251C` | `Preferences::get_HasPreferredGame` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2564` | `Preferences::set_CurrentGame` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B26D8` | `Preferences::get_SFXSound` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2724` | `Preferences::set_SFXSound` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B277C` | `Preferences::get_ChatSound` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B27C8` | `Preferences::set_ChatSound` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2820` | `Preferences::get_GameSound` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B286C` | `Preferences::set_GameSound` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2914` | `Preferences::get_BackgroundMusic` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2960` | `Preferences::set_BackgroundMusic` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B29B8` | `Preferences::get_SoundState` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x50B2AF8` | `Preferences::get_SoundActor` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2B90` | `Preferences::get_CardDimming` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2BDC` | `Preferences::set_CardDimming` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2C34` | `Preferences::get_ConfirmSawa` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2C80` | `Preferences::set_ConfirmSawa` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2CD8` | `Preferences::get_BiddingPredetermination` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2D24` | `Preferences::set_BiddingPredetermination` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2D7C` | `Preferences::get_EnablePowerSaving` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2DC8` | `Preferences::set_EnablePowerSaving` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2E20` | `Preferences::get_AllowDifferentCardElevation` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2E6C` | `Preferences::set_AllowDifferentCardElevation` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2EC4` | `Preferences::get_AllowMyTurnHandAnimation` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2F10` | `Preferences::set_AllowMyTurnHandAnimation` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2F68` | `Preferences::get_AllowVibration` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B2FB4` | `Preferences::set_AllowVibration` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B300C` | `Preferences::get_ShowJackarooTips` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B3058` | `Preferences::set_ShowJackarooTips` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B30B0` | `Preferences::get_IsPerspectiveTopDown` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B30FC` | `Preferences::set_IsPerspectiveTopDown` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B3154` | `Preferences::get_ForceTablet` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B31A0` | `Preferences::set_ForceTablet` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B31F8` | `Preferences::get_MultipleVoiceActors` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B3244` | `Preferences::set_MultipleVoiceActors` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B329C` | `Preferences::get_IgnoreWatchersChat` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B32E8` | `Preferences::set_IgnoreWatchersChat` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B3340` | `Preferences::get_JackarooPreferredCustomRulesIndex` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B338C` | `Preferences::set_JackarooPreferredCustomRulesIndex` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B33E4` | `Preferences::get_UsedReplayTrails` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B3430` | `Preferences::set_UsedReplayTrails` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x50B3848` | `RankedPlayConditionExtensions::CanWatchAds` | method | [إعلانات](ads-spec/01-الإعلانات.md) |
| `0x50B3B78` | `UserInfo::get_AppleHashedReceipt` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50B3C1C` | `UserInfo::get_IsEligibleForAppStoreIntroOffer` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x50B3D94` | `UserInfo::get_LastIntroEligibilityCheck` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x50B49F4` | `UserInfo::ClearAllCachedModels` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B56E0` | `UserInfo::get_ReferralToken` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B572C` | `UserInfo::set_ReferralToken` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B5784` | `UserInfo::get_ReferralLink` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B57D0` | `UserInfo::set_ReferralLink` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B5828` | `UserInfo::get_ReferringUserToken` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B5874` | `UserInfo::set_ReferringUserToken` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B58CC` | `UserInfo::get_ReferringUserName` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B5918` | `UserInfo::set_ReferringUserName` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x50B7B8C` | `VivoxManager::get_isConnected` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7B94` | `VivoxManager::set_isConnected` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7BF4` | `VivoxManager::get_AmIMuted` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7BFC` | `VivoxManager::set_AmIMuted` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7C04` | `VivoxManager::add_OnSpeakingInChat` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7CB8` | `VivoxManager::remove_OnSpeakingInChat` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7D6C` | `VivoxManager::add_OnMuteUpdate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7E20` | `VivoxManager::remove_OnMuteUpdate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7ED4` | `VivoxManager::add_OnConnectionUpdate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B7F88` | `VivoxManager::remove_OnConnectionUpdate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B803C` | `VivoxManager::get_IsSupportedPlatform` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B80FC` | `VivoxManager::get_isVoiceChatEnabled` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B81D4` | `VivoxManager::get_myDBId` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B8274` | `VivoxManager::Start` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B8884` | `VivoxManager::OnDestroy` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B8DD0` | `VivoxManager::DestroyVivox` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B94B8` | `VivoxManager::RefreshMyMuteStatus` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B94C0` | `VivoxManager::OnRoundStart` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B94C4` | `VivoxManager::RefreshConnection` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B95A4` | `VivoxManager::OnPlayerSwitchSeat` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B9664` | `VivoxManager::OnGameInitialized` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B9668` | `VivoxManager::StartNewCall` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B97B0` | `VivoxManager::BroadcastMuteStatusUpdate` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B981C` | `VivoxManager::ToggleMuteMyself` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B982C` | `VivoxManager::MuteMyself` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B9A24` | `VivoxManager::SanitizeAddress` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B9AD0` | `VivoxManager::InitVivox` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B9BE8` | `VivoxManager::LoginToVivox` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50B9F78` | `VivoxManager::JoinChannel` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BA128` | `VivoxManager::DestroySelf` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BA1F8` | `VivoxManager::ParticipantAddedToChannel` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BA318` | `VivoxManager::ParticipantRemovedFromChannel` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BA57C` | `VivoxManager::OnChannelJoined` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BA7C4` | `VivoxManager::OnUserLoggedIn` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BAA48` | `VivoxManager::<StartNewCall>b__35_0` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BADD8` | `VivoxManager.VivoxParticipantListener::.ctor` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BAEA4` | `VivoxManager.VivoxParticipantListener::OnParticipantAudioEnergyChanged` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BB224` | `VivoxManager.<RestartVivox>d__46::MoveNext` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BB4E0` | `VivoxMuteButton::RefreshUI` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BBB7C` | `VivoxMuteButton::ToggleMuteMyself` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BBBA0` | `VivoxMuteButton::RefreshUI` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BBBB4` | `VoiceChatToggler::Awake` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50BBD0C` | `VoiceChatToggler::RefreshVoiceChatButtons` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x50C5D30` | `AvatarData::op_Implicit` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x50C8E20` | `CardBackSetter::AssignCardBack` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x50C8F64` | `CardBackSetter::AssignCardBackHelper` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50C9188` | `CardBackSetter::AssignMaterial` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50C92E0` | `CardBackSetter::AssignEffect` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50C94B4` | `CardBackSetter::AssignImage` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50C9660` | `CardBackSetter::ShowCardsAnimated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50C9940` | `CardBackSetter::ShowCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50C9B28` | `CardBackSetter::Initialize` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50C9F34` | `CardBackSetter.<>c__DisplayClass17_0::<AssignImage>b__0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50CA3CC` | `ClanBadgeLayoutSelector::SetActiveAll` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x50CA798` | `ClanLogoSetter::SetClan` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x50CAB74` | `ClanLogoSetter::ClearClan` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x50CAC64` | `ClanLogoSetter::SetClanName` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x50CCFC4` | `PatternSetter::SetPattern` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x50CDB28` | `TitleSetter::Initialize` | method | [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x50D58E0` | `OnScreenBaseCamera::Resolve` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x50DB17C` | `GameEventsChannel::add_OnTutorialCardPreventedToPlay` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50DB230` | `GameEventsChannel::remove_OnTutorialCardPreventedToPlay` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x50DC1C8` | `GameEventsChannel::TriggerActivateFirMode` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x50E159C` | `GameEventsListener::Awake` | method | [واجهة](ui-spec/03-قناة-أحداث-اللعبة.md) |
| `0x50E2C74` | `GameEventsListener::OnDestroy` | method | [واجهة](ui-spec/03-قناة-أحداث-اللعبة.md) |
| `0x50F7348` | `TwinSlidedKDropMenu::SetupItems2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x50F7FBC` | `TwinSlidedKDropMenu::ResetClicks` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x50F827C` | `TwinSlidedKDropMenu::SetSelectedIndex2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x50FBCC4` | `BaseChatbox::Update` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x50FBD10` | `BaseChatbox::SendChat` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x50FE91C` | `ChatMessageOptions::OnMuteClick` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x50FF8AC` | `ChatMessageOptions::OnReportClick` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5103FE0` | `GiftBombCreationPopup::GetTotalCost` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5105194` | `GiftBombCreationPopup::GetNotSufficientAcesMessage` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5105474` | `GiftBombCreationPopup::GetMaximumAcesMessage` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x51058C4` | `GiftBombCreationPopup::GetNotSufficientSubsShardsMessage` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5105A50` | `GiftBombCreationPopup::GetMaximumSubsShardsMessage` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5105EA0` | `GiftBombCreationPopup::GetNotSufficientAcesShardsMessage` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x510602C` | `GiftBombCreationPopup::GetMaximumAcesShardsMessage` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5107058` | `GiftBombCreationPopup::SubmitTransaction` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5108E14` | `MessageReportUI::ReportCheating` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5109040` | `MessageReportUI::ReportBadChat` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5109048` | `MessageReportUI::ShowForMessage` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5109370` | `MessageReportUI::FakeReported` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x510A57C` | `PrivateChatBox::SfsOnAdminMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x510C048` | `PublicChatBox::<DisableChatRequest>g__SendVote|23_0` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x510C134` | `PublicChatBox::<DisableChatRequest>g__SendVote|23_0` | inside (+0xEC) | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x510C470` | `TopBarQuickReplies::BuyEmote` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5111F08` | `CreateGamePopup::get_isVoiceChat` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x511210C` | `CreateGamePopup::SetVoiceChat` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x5112AEC` | `CreateGamePopup::ValidateOptions` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5112EBC` | `JackarooCustomRules::TrackCreateGameCustomRules` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x51130D0` | `JackarooCustomRules::get_CurrentJackarooCustomRule` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5113370` | `CreateGamePopup::UpdateVoiceChatLabel` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x5113430` | `CreateGamePopup::UpdateVoiceChatNotAvailableOnWebGL` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x51147EC` | `DisconnectionPopup::OnTryConnectingClick` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x51181E8` | `HintsPopup::Awake` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x51183C8` | `HintsPopup::MatchMakingCancel` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x5118B90` | `JackarooCustomRules::get_SavingPath` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5118BEC` | `JackarooCustomRules::get_SavingPath` | inside (+0x5C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5118C28` | `JackarooCustomRules::get_SavingPath` | inside (+0x98) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5118C4C` | `JackarooCustomRules::get_SavingPath` | inside (+0xBC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5118CA8` | `JackarooCustomRules::get_CurrentJackarooCustomRuleSave` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5118D24` | `JackarooCustomRules::set_CurrentJackarooCustomRuleSave` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5118D90` | `JackarooCustomRules::get_CurrentJackarooCustomRuleName` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5118E80` | `JackarooCustomRules::get_CurrentJackarooCustomRuleIndex` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5118EF4` | `JackarooCustomRules::Init` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5118F98` | `JackarooCustomRules::Init` | inside (+0xA4) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5118F9C` | `JackarooCustomRules::Init` | inside (+0xA8) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x51190C8` | `JackarooCustomRules::Init` | inside (+0x1D4) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511913C` | `JackarooCustomRules::LoadItemsWeb` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x51191B4` | `JackarooCustomRules::LoadItems` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511928C` | `JackarooCustomRules::SetCurrentJackarooCustomRuleSave` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5119510` | `JackarooCustomRules::add_OnJackarooCustomRuleChanged` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5119624` | `JackarooCustomRules::remove_OnJackarooCustomRuleChanged` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x5119738` | `JackarooCustomRules::get_JackarooCustomRulesSaves` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51197E0` | `JackarooCustomRules::InitializeCurrentJackarooCustomRule` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119BD4` | `JackarooCustomRules::Save` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5119C38` | `JackarooCustomRules::Save` | inside (+0x64) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119C44` | `JackarooCustomRules::Save` | inside (+0x70) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119C70` | `JackarooCustomRules::Save` | inside (+0x9C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119CD8` | `JackarooCustomRules::Save` | inside (+0x104) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119CFC` | `JackarooCustomRules::Delete` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5119DAC` | `JackarooCustomRules::.cctor` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119E44` | `JackarooCustomRules::.cctor` | inside (+0x98) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119E88` | `JackarooCustomRules::.cctor` | inside (+0xDC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119E98` | `JackarooCustomRules::.cctor` | inside (+0xEC) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119EE4` | `JackarooCustomRules::.cctor` | inside (+0x138) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119FA8` | `JackarooCustomRules.<>c::<.cctor>b__32_0` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119FB8` | `JackarooCustomRules.<>c::<.cctor>b__32_0` | inside (+0x10) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x5119FE4` | `JackarooCustomRules.<LoadItems>d__25::MoveNext` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511A170` | `JackarooCustomRules.<LoadItems>d__25::MoveNext` | inside (+0x18C) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511A7CC` | `JackarooCustomRules.<LoadItemsWeb>d__26::MoveNext` | method | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511A854` | `JackarooCustomRules.<LoadItemsWeb>d__26::MoveNext` | inside (+0x88) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511A900` | `JackarooCustomRules.<LoadItemsWeb>d__26::MoveNext` | inside (+0x134) | [بيانات](data-spec/02-حفظ-الملفات-المحليّة.md) |
| `0x511A9BC` | `JackarooCustomRuleSaveEntry::Setup` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511AC00` | `JackarooCustomRuleSaveEntry::Deactivate` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511AC70` | `JackarooCustomRuleSaveEntry::Activate` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511AD20` | `JackarooCustomRuleSaveEntry::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511ADB4` | `JackarooCustomRuleSaveEntry::OnSwiping` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511B168` | `JackarooCustomRuleSaveEntry::OnSwipe` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511B258` | `JackarooCustomRuleSaveEntry::OnSwiped` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511B36C` | `JackarooCustomRuleSaveEntry::CancelSwipe` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511B55C` | `JackarooCustomRuleSaveEntry::GoToSnap` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511B710` | `JackarooCustomRuleSaveEntry::DeleteEntry` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511B9C4` | `JackarooCustomRuleSaveEntry::<DeleteEntry>b__60_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511BA28` | `JackarooCustomRuleSaveEntry::<DeleteEntry>b__60_1` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511BB2C` | `JackarooCustomRuleSaveEntry::<DeleteEntry>b__60_2` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511BC18` | `JackarooCustomRulesButton::OnButtonClicked` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511BD50` | `JackarooCustomRulesPopup::Start` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511C190` | `JackarooCustomRulesPopup::OnAddNewRulesClicked` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511C214` | `JackarooCustomRulesPopup::ResetRules` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511C358` | `JackarooCustomRulesPopup::OpenRulesPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511C374` | `JackarooCustomRulesPopup::OnSaveRulesButtonClicked` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511CB50` | `JackarooCustomRulesPopup::AddSaveEntry` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511CD50` | `JackarooCustomRulesPopup::CloseRulesPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511CF20` | `JackarooCustomRulesPopup::LoadRules` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511D0E0` | `JackarooCustomRulesPopup::LoadEntries` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511D62C` | `JackarooCustomRulesPopup::ActivateCallback` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511D8FC` | `JackarooCustomRulesPopup::EditCallback` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511D9AC` | `JackarooCustomRulesPopup::DoDeleteEntry` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511DB40` | `JackarooCustomRulesPopup::DisableSwipes` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511DC8C` | `JackarooCustomRulesPopup::EnableSwipes` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511DDD8` | `JackarooCustomRulesPopup::DeleteCallback` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511E124` | `JackarooCustomRulesPopup::ShowRulesPop` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511E2D4` | `JackarooCustomRulesPopup::HideRulesPop` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511E2F4` | `JackarooCustomRulesPopup::OnBlockerClicked` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511E334` | `JackarooCustomRulesPopup::RefreshContentFitters` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511E408` | `JackarooCustomRulesPopup::RefreshLayoutRecursive` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511E488` | `JackarooCustomRulesPopup::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511E514` | `JackarooCustomRulesPopup::<Start>b__17_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511E55C` | `JackarooCustomRulesPopup::<Start>b__17_1` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511E63C` | `JackarooCustomRulesPopup::<Start>b__17_2` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511E920` | `JackarooCustomRulesPreview::Setup` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511EA28` | `JackarooCustomRulesPreview::LoadRules` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511EC1C` | `JackarooCustomRuleUI::Initialize` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F0EC` | `JackarooCustomRulesSave::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511F1C0` | `JackarooCustomRulesSave::.ctor` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F2C4` | `JackarooCustomRulesExtensions::Serialize` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F330` | `JackarooCustomRulesExtensions::ToInt` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F4D0` | `JackarooCustomRulesText::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511F600` | `JackarooCustomRulesText::OnCustomRulesChange` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511F6A4` | `JackarooCustomRulesText::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x511F75C` | `JackarooCustomRuleUI::get_IsTwinRule` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F764` | `JackarooCustomRuleUI::get_DropMenu` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F76C` | `JackarooCustomRuleUI::get_TwinDropMenu` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F79C` | `JackarooCustomRuleUI::Reset` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F884` | `JackarooCustomRuleUI.<>c::<Initialize>b__23_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F88C` | `JackarooCustomRuleUI.<>c::<Initialize>b__23_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x511F894` | `JackarooCustomRuleUI.<>c__DisplayClass23_0::<Initialize>g__OnShow|1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5124B90` | `OnlyForSubscribersPopup::Show` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x512A5B0` | `PlayerProfileControls::Populate` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512B9FC` | `PlayerProfile::Populate` | inside (+0x284) | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512C398` | `PlayerProfile::PopulatePrivateInfo` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512C494` | `PlayerProfile::PopulatePrivateInfo` | inside (+0xFC) | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512CFC4` | `PlayerProfileControls::get_IsMyProfile` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512D060` | `PlayerProfileControls::get_BioDefault` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512DA74` | `PlayerProfileControls::Start` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512DCFC` | `PlayerProfileControls::ConfigChanged` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512DDA0` | `PlayerProfileControls::OnPlayerProfileLoaded` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512DDD0` | `PlayerProfileControls::Populate` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512E8D0` | `PlayerProfileControls::UpdateButtonsState` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512ED54` | `PlayerProfileControls::PopulateFromSFS` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512EF18` | `PlayerProfileControls::ThisIsMyProfile` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512F120` | `PlayerProfileControls::Add` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512F310` | `PlayerProfileControls::Report` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512F4B0` | `PlayerProfileControls::FakeReport` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512F5F8` | `PlayerProfileControls::GetReportChatRecord` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x512FB64` | `PopupButton::Neutral` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5130030` | `PlayerProfileControls::MuteAndZeroCurrency` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x5130464` | `PlayerProfileControls::OpenAdminPage` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x5135824` | `PopupUI::Awake` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5135A4C` | `PopupUI::Show` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5135DCC` | `PopupUI::ShowBlur` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5135F80` | `PopupUI::ShowBlurOnly` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5136400` | `PopupUI::HideBlur` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51366FC` | `PopupUI::PopFromCustomParent` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5136854` | `PopupUI::PopFromParent` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51369AC` | `PopupUI::ShrinkToParent` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5137F84` | `PopupButton::Positive` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5138B9C` | `AnimatedItemController.<>c__DisplayClass62_0::<CreateCustomMarbleAnimation>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5138E48` | `EmoteViewer::Reset` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x513992C` | `JackarooAnimatedItemController::get_JackarooCardVisualControls` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5139934` | `JackarooAnimatedItemController::set_JackarooCardVisualControls` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x513993C` | `JackarooAnimatedItemController::Start` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51399CC` | `JackarooAnimatedItemController::.ctor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5139A54` | `JackarooFireModeManager::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5139AF8` | `JackarooFireModeManager::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5139B94` | `JackarooFireModeManager::OnActivateFireMode` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5139C6C` | `JackarooFireModeManager::OnEnableFireModeButton` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5139CF4` | `JackarooFireModeManager::OnDisableFireModeButton` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5139D38` | `JackarooFireModeManager::MarkJackarooFireModeClicked` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5139DD4` | `JackarooFireModeManager::OnDismissibleClicked` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5139DD8` | `JackarooFireModeManager::OnMarbleDismissibleClicked` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5140CD0` | `EmoteViewer::PerformScaleAnimation` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5140F6C` | `EmoteViewer::PlayLoadingEmote` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x514103C` | `EmoteViewer::PlayEmote` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5141388` | `EmoteViewer::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5141C68` | `FakeDynamicShadowUI::UpdateShadow` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5142024` | `FakeDynamicShadowUI::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51421A0` | `AnimatedItemDataAsset::CheckMarbleItemReusable` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5144BF8` | `SpecialSawaAnimation::StartAnimation` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5145B9C` | `SpecialSawaAnimation::ModifyAllSortLayer` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5145D04` | `SpecialSawaAnimation::SetInitialPlacement` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5146118` | `SpecialSawaAnimation::SetShadows` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x514647C` | `SpecialSawaAnimation::GetUserBoxSideDirection` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x514654C` | `SpecialSawaAnimation::SetOnCompleteCallback` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5146668` | `SpecialSawaAnimation::ModifySortLayer` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5146710` | `SpecialSawaAnimation::OnCardGrounded` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5146BC4` | `SpecialSawaAnimation.<>c__DisplayClass39_1::<SetShadows>b__0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x514BD98` | `AnimatedRoomThemesController::RegisterThemeColors` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x514C57C` | `JackarooAnimatedRoomThemesController::OnCreateSpineRoomElement` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x514C7C0` | `JackarooAnimatedRoomThemesController::OnRoomThemeChanged` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x514C848` | `JackarooAnimatedRoomThemesController::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x514D8F8` | `FlashSaleUI::Route` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x514E8F0` | `GrandGameModesArea::OnButtonClick` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x514EDC4` | `PopupInput::From` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5158734` | `JackarooRoomCard::get_room` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x515883C` | `JackarooRoomCard::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5158950` | `JackarooRoomCard::Refresh` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51591DC` | `JackarooRoomCard::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x515928C` | `JackarooRoomCard::<Awake>b__9_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5159380` | `JackarooRoomDataHolder::get_Room` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51593FC` | `JackarooRoomDataHolder::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51594B0` | `JackarooRoomListView::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5159508` | `JackarooRoomsListUI::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x515958C` | `JackarooRoomsListUI::OnEnable` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5159624` | `JackarooRoomsListUI::FilteredRoomListUpdated` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51596E8` | `JackarooRoomsListUI::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5159774` | `JackarooRoomsListUI::ListUpdated` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x515983C` | `JackarooRoomsListUI::SetListView` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51598A4` | `JackarooRoomsListUI::SetNewListView` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5159948` | `JackarooRoomsListUI::SendRequestThrottled` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51599F4` | `JackarooRoomsListUI::.cctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5159FCC` | `RoomCard::ApplyDefaultThemeBorder` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x515A810` | `RoomCard::<RefreshRoomThemeBorder>b__18_0` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x515B700` | `RoomsFilterModel::ToSfsObject` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x515BE5C` | `RoomsListUI::.cctor` | inside (+0x58) | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x515C408` | `NotEnoughAcesPopup::ShowNotEnoughAces` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x515FCFC` | `RankSetter::SetRank` | method | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x51663DC` | `TextCountdownFormat::FormatDate` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x5167E08` | `MetricNumberFormatter::AssignValue` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x516A644` | `BaseToggler::ToggleManual` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x516A844` | `GlobalThemeColorProfile::.cctor` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516AA78` | `ThemeColorPalette::GetColor` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516AF5C` | `ThemeableGraphic::OnThemeUpdated` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516B054` | `ThemeableGraphic::SetValues` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516B1E4` | `ThemeProvider::get_ActiveProfile` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516B2BC` | `ThemeProvider::UpdateTheme` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) · [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x516C7A8` | `ThemeColorPaletteToggler::SetOriginal` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516C7D4` | `ThemeColorPaletteToggler::SetAlternative` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x516FBE8` | `Toast::Show` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x5173794` | `MaterialFloatPropertyController::Update` | method | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x51833B8` | `Server.Models.AppAnnouncementModel::IsActive` | inside (+0x19C) | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x5183E8C` | `Server.Models.CachedModels::GetServerLastUpdate` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x5184508` | `Server.Models.CachedModels::IsGameSpecific` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x51847DC` | `Server.Models.CachedModels::ClearLastUpdates` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x51852A0` | `Server.Models.ETagStorage::GetInstance` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x5185B80` | `Server.Models.FriendlyChallengeConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5185D24` | `Server.Models.GiftBombConfig::get_MinBombActiveSeconds` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5185D34` | `Server.Models.GiftBombConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5186978` | `Server.Models.RemoteConfigModel::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5186CAC` | `Server.Models.EconomyConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5186CD8` | `Server.Models.TournamentsSection::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5186DAC` | `Server.Models.PredictionsConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5186E74` | `Server.Models.VisualsConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5186ED8` | `Server.Models.ChatConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5186EE8` | `Server.Models.AutoClickersConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5186EF0` | `Server.Models.JackarooConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/README.md) |
| `0x5186F04` | `Server.Models.FastTrackConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x518768C` | `Server.Models.EconomyConfig::get_CreateVoiceRoomPrice` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x5187718` | `Server.Models.TournamentConfig::.ctor` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5187B1C` | `Server.Models.FastTrackConfig::get_MatchMakerTimerSeconds` | method | [هوية](identity-spec/04-المسار-السريع-والرتب.md) · [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x5188280` | `Server.Models.ClientFilter::Check` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x51885A0` | `Server.Models.FilterableClientModel::Current` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x51886F8` | `Server.Models.FilterableClientModel::ToQueryParams` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x5188904` | `Server.Models.FilterableClientModel::Equals` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x51889F0` | `Server.Models.FilterableClientModel::GetHashCode` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x5188A88` | `Server.Models.ClientFilterableExtensions::PassesFilters` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x518A484` | `Server.Models.TournamentConfig::RebuildLookups` | method | [إعدادات](config-spec/01-RemoteConfig.md) · [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x518A7C0` | `Server.Models.TournamentConfig::OnJsonDeserialized` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x518AB78` | `Server.Models.TournamentConfig::GetSize` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x518B078` | `Server.Models.TournamentEndGameReport::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [ردهة](lobby-spec/03-البطولات.md) |
| `0x51901BC` | `Server.Models.Products.ProductListingModel::get_isPromotionActive` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x519052C` | `Server.Models.Products.ProductViewModel::get_IsSubscription` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5190550` | `Server.Models.Products.ProductViewModel::get_IsCoins` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x51905EC` | `Server.Models.Products.ProductViewModel::.ctor` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5191FF8` | `DataTracking.DimensionsModel::.ctor` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x519240C` | `DataTracking.Tracker::Initialize` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) · [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x519248C` | `DataTracking.Tracker::Initialize` | inside (+0x80) | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51927B8` | `DataTracking.Tracker::PurchaseEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x5192C70` | `DataTracking.Tracker::DesignEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x5193270` | `DataTracking.Tracker::ResourceEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x5193EE0` | `DataTracking.Tracker::UserProfile` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x519400C` | `DataTracking.Tracker::UserProfile` | inside (+0x12C) | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51940C0` | `DataTracking.Tracker::UserProfile` | inside (+0x1E0) | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x5196040` | `DataTracking.TrackerLibrary::PreferenceVoiceActor` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x51960BC` | `DataTracking.TrackerLibrary::PreferenceMultiVoiceActor` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x51969C0` | `DataTracking.Tracker::UpdateDimensions` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x5196FA8` | `DataTracking.Tracker::SetActiveGame` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51975A0` | `DataTracking.Tracker::BuildItemId` | inside (+0x11C) | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5197998` | `DataTracking.TrackerLibrary::OnboardingTutorialScreenViewed` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x519C9A0` | `DataTracking.TrackerLibrary::GameKashoButtonClicked` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x519CA0C` | `DataTracking.TrackerLibrary::GameKashoButtonClicked` | inside (+0x6C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x519CEE0` | `DataTracking.TrackerLibrary::GameCardSlapClicked` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x519D008` | `DataTracking.TrackerLibrary::GameVoiceJoined` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x519E4F0` | `DataTracking.TrackerLibrary::FastTrackPopUpMisMatchWinWhenLose` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x519E57C` | `DataTracking.TrackerLibrary::FastTrackPopUpMisMatchLoseWhenWin` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x51A2E5C` | `DataTracking.TrackerLibrary.TrackerEvent::GetEventString` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A47C0` | `DataTracking.Strategies.AdjustStrategy::.ctor` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) · [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x51A4CB0` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::AdEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A522C` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::PurchaseEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A58B0` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::TrimValue` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A5930` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::DesignEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A5F04` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::SanitizeEventName` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A620C` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::ResourceEvent` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A6820` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::SetDimensions` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51A6A90` | `DataTracking.Strategies.FirebaseAnalyticsStrategy::.ctor` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) · [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x51A71D0` | `DataTracking.Strategies.GameAnalyticsStrategy::.ctor` | method | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x51AA4AC` | `UI.Conditions.ClanPermissionsCondition::Setup` | inside (+0xE8) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x51AC1E4` | `UI.Conditions.HasClanCondition::Setup` | inside (+0xBC) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x51AC79C` | `UI.Conditions.IsClanOwnerCondition::Setup` | inside (+0xBC) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x51AC9A8` | `UI.Conditions.JackarooCustomRulesEnabledCondition::get_ActualValue` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51ACA30` | `UI.Conditions.JackarooCustomRulesEnabledCondition::Setup` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51ACAE0` | `UI.Conditions.JackarooCustomRulesEnabledCondition::Teardown` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51AEBFC` | `UI.Popups.BlurLayersManager::get_IsBlurActive` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AECC0` | `UI.Popups.BlurLayersManager::add_OnPopupVisibilityChanged` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AED90` | `UI.Popups.BlurLayersManager::remove_OnPopupVisibilityChanged` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AEE60` | `UI.Popups.BlurLayersManager::OnAwake` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AEF38` | `UI.Popups.BlurLayersManager::Clear` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF000` | `UI.Popups.BlurLayersManager::Clear` | inside (+0xC8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF06C` | `UI.Popups.BlurLayersManager::Clear` | inside (+0x134) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF16C` | `UI.Popups.BlurLayersManager::Clear` | inside (+0x234) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF190` | `UI.Popups.BlurLayersManager::OnDestroy` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF240` | `UI.Popups.BlurLayersManager::AppendToLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF284` | `UI.Popups.BlurLayersManager::TopOccupiedLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF434` | `UI.Popups.BlurLayersManager::AddBlurLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF4B0` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x7C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF4B8` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x84) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF4D4` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0xA0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF4DC` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0xA8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF4E8` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0xB4) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF504` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0xD0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF50C` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0xD8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF51C` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0xE8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF560` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x12C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF568` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x134) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF588` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x154) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF5E0` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x1AC) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF5E8` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x1B4) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF5F4` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x1C0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF604` | `UI.Popups.BlurLayersManager::AddBlurLayer` | inside (+0x1D0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF630` | `UI.Popups.BlurLayersManager::PruneDestroyedPopups` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF8A0` | `UI.Popups.BlurLayersManager::NormalizeLayerDepths` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF990` | `UI.Popups.BlurLayersManager::NormalizeLayerDepths` | inside (+0xF0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AF9A4` | `UI.Popups.BlurLayersManager::NormalizeLayerDepths` | inside (+0x104) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFAC0` | `UI.Popups.BlurLayersManager::NormalizeLayerDepths` | inside (+0x220) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFB04` | `UI.Popups.BlurLayersManager::NormalizeLayerDepths` | inside (+0x264) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFCEC` | `UI.Popups.BlurLayersManager::FirstFreeLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFDAC` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFE3C` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x90) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFE48` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x9C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFE84` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0xD8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFED8` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x12C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFEEC` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x140) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFF1C` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x170) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFF58` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x1AC) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51AFFA8` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x1FC) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0000` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x254) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0040` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x294) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0050` | `UI.Popups.BlurLayersManager::CreateBlurLayer` | inside (+0x2A4) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B00DC` | `UI.Popups.BlurLayersManager::HighestLayerDepth` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B01F8` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B032C` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x134) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0378` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x180) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0384` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x18C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B03FC` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x204) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B04CC` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x2D4) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0590` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x398) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B05A0` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x3A8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0614` | `UI.Popups.BlurLayersManager::SyncUrpStackOrder` | inside (+0x41C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B066C` | `UI.Popups.BlurLayersManager::SyncBlurs` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B085C` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x1F0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B086C` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x200) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0924` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x2B8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B09A4` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x338) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B09FC` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x390) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0A44` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x3D8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0A50` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x3E4) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0A5C` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x3F0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0A70` | `UI.Popups.BlurLayersManager::SyncBlurs` | inside (+0x404) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0C48` | `UI.Popups.BlurLayersManager::RemoveBlurLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0D24` | `UI.Popups.BlurLayersManager::ShowBlur` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0DC4` | `UI.Popups.BlurLayersManager::HideBlur` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0E68` | `UI.Popups.BlurLayersManager::IsOnTopLayer` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0EA8` | `UI.Popups.BlurLayersManager::LayerBelow` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B0FCC` | `UI.Popups.BlurLayersManager::LayerBelow` | inside (+0x124) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1028` | `UI.Popups.BlurLayersManager::LayerBelow` | inside (+0x180) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B10FC` | `UI.Popups.BlurLayersManager::GetCameraBlur` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1138` | `UI.Popups.BlurLayersManager::GetCameraBlur` | inside (+0x3C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1164` | `UI.Popups.BlurLayersManager::GetCameraBlur` | inside (+0x68) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1188` | `UI.Popups.BlurLayersManager::GetCameraBlur` | inside (+0x8C) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B119C` | `UI.Popups.BlurLayersManager::GetCameraBlur` | inside (+0xA0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B11D4` | `UI.Popups.BlurLayersManager::GetCameraBlur` | inside (+0xD8) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1200` | `UI.Popups.BlurLayersManager::IsOccupied` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B145C` | `UI.Popups.BlurLayersManager::HasShownOccupant` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B14E0` | `UI.Popups.BlurLayersManager::HasShownOccupant` | inside (+0x84) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B164C` | `UI.Popups.BlurLayersManager::HasShownOccupant` | inside (+0x1F0) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1670` | `UI.Popups.BlurLayersManager::HasShownOccupant` | inside (+0x214) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B17D4` | `UI.Popups.BlurLayersManager::RegisterAsUrpOverlay` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1804` | `UI.Popups.BlurLayersManager::RegisterAsUrpOverlay` | inside (+0x30) | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1B04` | `UI.Popups.BlurLayersManager::IsBlurLayerCamera` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1C40` | `UI.Popups.BlurLayersManager::OnSceneLoaded` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1DE8` | `UI.Popups.BlurLayersManager.<>c::<RegisterAsUrpOverlay>b__28_0` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51B1E6C` | `UI.Popups.BlurLayersManager.<>c__DisplayClass29_0::<SyncUrpStackOrder>b__0` | method | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |
| `0x51BF520` | `CardDistribution.CardDistributor::CheckAndTriggerNextBatch` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C08A0` | `CardDistribution.CardDistributor::GetUserboxByRotatedIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/07-الأنيميشن-القيم-المسلسلة.md) |
| `0x51C0CF8` | `CardDistribution.CardDistributor.<>c__DisplayClass38_0::<GetUserboxByRotatedIndex>b__0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51C3CA4` | `CardDistribution.JackarooCardDistributor::ResolveMidGamePileState` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C3E40` | `CardDistribution.JackarooCardDistributor::ResolvePileStateFromHandSizes` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51C458C` | `Jackaroo.BurnOtherCardPanel::Awake` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C47D0` | `Jackaroo.BurnOtherCardPanel::Show` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4B78` | `Jackaroo.BurnOtherCardPanel::Dismiss` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4D24` | `Jackaroo.BurnOtherCardPanel::Hide` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4D28` | `Jackaroo.BurnOtherCardPanel::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51C4DB8` | `Jackaroo.BurnOtherCardPanel::<Awake>b__4_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4EA4` | `Jackaroo.BurnOtherCardPanel.<>c::<Awake>b__4_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4EF0` | `Jackaroo.BurnOtherCardPanel.<>c::<Awake>b__4_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4F20` | `Jackaroo.BurnOtherCardPanel.<>c__DisplayClass6_0::<Show>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4F60` | `Jackaroo.JackarooActionOptionUi::Reset` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C4F88` | `Jackaroo.JackarooActionOptionUi::Setup` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C50FC` | `Jackaroo.JackarooActionOptionUi::SetupDisabled` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C51B0` | `Jackaroo.JackarooActionOptionUi.<>c__DisplayClass4_0::<Setup>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C5208` | `Jackaroo.JackarooActionsExtensions::ToJackarooServerAction` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51C5440` | `Jackaroo.JackarooActionsExtensions::ToJackarooAction` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C54AC` | `Jackaroo.JackarooActionsExtensions::AllSameAction` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C55E0` | `Jackaroo.JackarooActionsExtensions::AllSameMarble1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C571C` | `Jackaroo.JackarooActionsExtensions::AllSameSplit1Move` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C5858` | `Jackaroo.JackarooActionsExtensions::ToList` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C59DC` | `Jackaroo.JackarooActionsExtensions.<>c__DisplayClass2_0::<AllSameAction>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C5A00` | `Jackaroo.JackarooActionsExtensions.<>c__DisplayClass3_0::<AllSameMarble1>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C5A24` | `Jackaroo.JackarooActionsExtensions.<>c__DisplayClass4_0::<AllSameSplit1Move>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C5A60` | `Jackaroo.JackarooActionsExtensions.<>c__DisplayClass5_0::<ToList>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C5A74` | `Jackaroo.JackarooAllowedRulesExtensions::GetActiveRulesStrings` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51C64EC` | `Jackaroo.JackarooAllowedRulesExtensions::GetActiveRuleString` | method | [جكارو](jackaroo-spec/04-القواعد-المخصصة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C6958` | `Jackaroo.JackarooAllowedRulesExtensions::GetActiveRulesIndices` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51C7458` | `Jackaroo.JackarooAllowedRulesExtensions::GetJackarooAllowedRulesString` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C8174` | `Jackaroo.JackarooAllowedRulesExtensions::HasRuleFlag` | method | [جكارو](jackaroo-spec/04-القواعد-المخصصة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C8190` | `Jackaroo.JackarooActionTipPanel::ShowActionTip` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C81CC` | `Jackaroo.JackarooActionTipPanel::HideActionTip` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51C8204` | `Jackaroo.JackarooBoard::GetAllowedJackarooMoves` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51C82E4` | `Jackaroo.JackarooBoard::GetAllowedJackarooMoves` | inside (+0xE0) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51C8380` | `Jackaroo.JackarooBoard::GetAllowedJackarooMoves` | inside (+0x17C) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51C8464` | `Jackaroo.JackarooBoard::AreAllMarblesInBases` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51C8684` | `Jackaroo.JackarooBoard::GetTeamMateIndex` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C8738` | `Jackaroo.JackarooBoard::.ctor` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C8C64` | `Jackaroo.JackarooBoard::InitializeBoard` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C8F8C` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C8FE4` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x58) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C8FE8` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x5C) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C8FEC` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x60) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C8FF0` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x64) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C8FF4` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x68) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C8FF8` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x6C) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C8FFC` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x70) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C9000` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x74) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C9004` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x78) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C9024` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0x98) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C9030` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0xA4) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C9034` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0xA8) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C9080` | `Jackaroo.JackarooBoard::CreateHomeAndBaseEntry` | inside (+0xF4) | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) |
| `0x51C90B8` | `Jackaroo.JackarooBoard::CreateNodeGroup` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C91CC` | `Jackaroo.JackarooBoard::ResetServerNodes` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C9380` | `Jackaroo.JackarooBoard::SetupMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C973C` | `Jackaroo.JackarooBoard::get_BasesNodes` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9790` | `Jackaroo.JackarooBoard::GetBaseNodes` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9808` | `Jackaroo.JackarooBoard::GetBaseStartIndex` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C9824` | `Jackaroo.JackarooBoard::get_GraveyardsNodes` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9878` | `Jackaroo.JackarooBoard::GetPlayerGraveyardNodes` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C98EC` | `Jackaroo.JackarooBoard::GetPlayerEntryIndex` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51C990C` | `Jackaroo.JackarooBoard::SetNodeAndMarble` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9954` | `Jackaroo.JackarooBoard::GetAllMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9B40` | `Jackaroo.JackarooBoard::GetAllPlantedMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9B94` | `Jackaroo.JackarooBoard::GetGraveyardMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9BF8` | `Jackaroo.JackarooBoard::GetGraveyardMarble` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9CA0` | `Jackaroo.JackarooBoard::Internal_GetGraveyardMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9D04` | `Jackaroo.JackarooBoard::GetPlantedMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9D68` | `Jackaroo.JackarooBoard::Internal_GetPlantedMarbles` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9DCC` | `Jackaroo.JackarooBoard::GetAllPlantedMarblesExcept` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51C9FB4` | `Jackaroo.JackarooBoard::SetNodeAndMarble` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51CA010` | `Jackaroo.JackarooBoard::GetNodeRelativeToServer` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CA06C` | `Jackaroo.JackarooBoard::SetBoardState` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CA0D0` | `Jackaroo.JackarooBoard::SetBoardState` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CA2F4` | `Jackaroo.JackarooBoard::MoveMarbleFromGraveyardListToPlantedList` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CA458` | `Jackaroo.JackarooBoard::GoToGraveyardImmediate` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51CA4B8` | `Jackaroo.JackarooBoard::MoveMarbleFromBoardToGraveyard` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CA720` | `Jackaroo.JackarooBoard::IsMarbleInLastBase` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51CA808` | `Jackaroo.JackarooBoard::GetLocalNode` | method | [جكارو](jackaroo-spec/13-اللوح-والأحجار-مفكوكة.md) |
| `0x51CA8CC` | `Jackaroo.JackarooBoard::PreviousLocalNode` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CA8D4` | `Jackaroo.JackarooBoard::GetLocalNode` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CA954` | `Jackaroo.JackarooBoard::IsMarbleAtHome` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CA9A4` | `Jackaroo.JackarooBoard::GetServerWalkingNodes` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CAAEC` | `Jackaroo.JackarooBoard::GetLocalWalkingNodes` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CABA0` | `Jackaroo.JackarooBoard::GetWalkingNodes` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CAD0C` | `Jackaroo.JackarooBoard::IsSameSide` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CAD5C` | `Jackaroo.JackarooBoard::GetWalkingNodesFromBase` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CAEA4` | `Jackaroo.JackarooBoard::IsEnteringBase` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CAF18` | `Jackaroo.JackarooBoard::GetWalkingNodesEnteringBase` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CB1DC` | `Jackaroo.JackarooBoardMono::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CB4C8` | `Jackaroo.JackarooBoardMono::InitializeGuardedMarblesPool` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CB6CC` | `Jackaroo.JackarooBoardMono::HideControlsWithDelay` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CB714` | `Jackaroo.JackarooBoardMono::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CB954` | `Jackaroo.JackarooBoardMono::ShowControls` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CB9B4` | `Jackaroo.JackarooBoardMono::SetBoardImage` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CBA94` | `Jackaroo.JackarooBoardMono::ResetJackarooBoardTheme` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CBB94` | `Jackaroo.JackarooBoardMono::OnPlayerDidLastAction` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CBD1C` | `Jackaroo.JackarooBoardMono::AddMarblesSnapShot` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CBE84` | `Jackaroo.JackarooBoardMono::AddToMovesQueue` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CBF70` | `Jackaroo.JackarooBoardMono::ToJackarooServerMove` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51CC130` | `Jackaroo.JackarooBoardMono::ToJackarooMove` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51CC1B8` | `Jackaroo.JackarooBoardMono::ToJackarooMove` | inside (+0x88) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51CC6D8` | `Jackaroo.JackarooBoardMono::GetTeamMateIndex` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CC75C` | `Jackaroo.JackarooBoardMono::PlayJackarooMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51CC81C` | `Jackaroo.JackarooBoardMono::PlayJackarooMove` | inside (+0xC0) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CC854` | `Jackaroo.JackarooBoardMono::HideHighlights` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51CC9F0` | `Jackaroo.JackarooBoardMono::HidePMarblesPriceTags` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CCB50` | `Jackaroo.JackarooBoardMono::HideControls` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CCB94` | `Jackaroo.JackarooBoardMono::OnPlayerSwitchSeat` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CCC70` | `Jackaroo.JackarooBoardMono::Initialize` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CCFC8` | `Jackaroo.JackarooBoardMono::OnCardGameEnd` | method | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51CD008` | `Jackaroo.JackarooBoardMono::PlayWinAnimations` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51CD6DC` | `Jackaroo.JackarooBoardMono::InitPerspective` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CD9C8` | `Jackaroo.JackarooBoardMono::OnGamePerspectiveChanged` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CDB9C` | `Jackaroo.JackarooBoardMono::OnGameStateUpdated` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CDE8C` | `Jackaroo.JackarooBoardMono::SetTurnIndicator` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CDF04` | `Jackaroo.JackarooBoardMono::SetupNodes` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CE174` | `Jackaroo.JackarooBoardMono::SetupMarbles` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CE598` | `Jackaroo.JackarooBoardMono::RotateAndMoveBoard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CE664` | `Jackaroo.JackarooBoardMono::FixBoardRotation` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CE794` | `Jackaroo.JackarooBoardMono::ResetMarbles` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CE9E0` | `Jackaroo.JackarooBoardMono::ApplyNodesTheme` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CEE3C` | `Jackaroo.JackarooBoardMono::ColorizeNodes` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CF530` | `Jackaroo.JackarooBoardMono::ColorizePlayerBases` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CF710` | `Jackaroo.JackarooBoardMono::ColorizeMarbles` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CFAB4` | `Jackaroo.JackarooBoardMono::UnblockAllBases` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CFAF8` | `Jackaroo.JackarooBoardMono::ResetWinAnimations` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51CFC28` | `Jackaroo.JackarooBoardMono::SetBoardState` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51CFFFC` | `Jackaroo.JackarooBoardMono::CheckMarbleBlocksBase` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D003C` | `Jackaroo.JackarooBoardMono::CheckMarbleBlocksBase` | inside (+0x40) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D0040` | `Jackaroo.JackarooBoardMono::CheckMarbleBlocksBase` | inside (+0x44) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D0044` | `Jackaroo.JackarooBoardMono::CheckMarbleBlocksBase` | inside (+0x48) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D0048` | `Jackaroo.JackarooBoardMono::CheckMarbleBlocksBase` | inside (+0x4C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D01A8` | `Jackaroo.JackarooBoardMono::InitializeRing` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D10C4` | `Jackaroo.JackarooBoardMono::InitializeBases` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D14A8` | `Jackaroo.JackarooBoardMono::InitializeGraveyards` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D1CBC` | `Jackaroo.JackarooBoardMono::SetupPlantReference` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D2160` | `Jackaroo.JackarooBoardMono::DoPlayJackarooMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D22A0` | `Jackaroo.JackarooBoardMono::DoPlayJackarooMove` | inside (+0x140) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D22E8` | `Jackaroo.JackarooBoardMono::DoPlayJackarooMove` | inside (+0x188) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D233C` | `Jackaroo.JackarooBoardMono::DoPlayJackarooMove` | inside (+0x1DC) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D2354` | `Jackaroo.JackarooBoardMono::DoPlayJackarooMove` | inside (+0x1F4) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D23A8` | `Jackaroo.JackarooBoardMono::HighlightMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D2438` | `Jackaroo.JackarooBoardMono::HideFirstNodesHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D25B8` | `Jackaroo.JackarooBoardMono::Plant` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D2AE4` | `Jackaroo.JackarooBoardMono::Move` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D2CCC` | `Jackaroo.JackarooBoardMono::Move` | inside (+0x1E8) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D2D30` | `Jackaroo.JackarooBoardMono::Move` | inside (+0x24C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D2F80` | `Jackaroo.JackarooBoardMono::Swap` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D307C` | `Jackaroo.JackarooBoardMono::CheckAndFixSyncedWithServer` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D3128` | `Jackaroo.JackarooBoardMono::DoCheckWithServer` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D3830` | `Jackaroo.JackarooBoardMono::get_MyPlayerIndex` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D389C` | `Jackaroo.JackarooBoardMono::MoveMarbleToGraveyard` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D3AA0` | `Jackaroo.JackarooBoardMono::get_MinDuration` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D3B28` | `Jackaroo.JackarooBoardMono::MoveMarble` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D3C74` | `Jackaroo.JackarooBoardMono::MoveMarble` | inside (+0x14C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D3FAC` | `Jackaroo.JackarooBoardMono::get_MaxDuration` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D4044` | `Jackaroo.JackarooBoardMono::get_TeamMateIndex` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D40A0` | `Jackaroo.JackarooBoardMono::IsMe` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D414C` | `Jackaroo.JackarooBoardMono::GetAllowedJackarooMoves` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D42E0` | `Jackaroo.JackarooBoardMono::GetAllowedJackarooMoves` | inside (+0x194) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D4328` | `Jackaroo.JackarooBoardMono::ClearGuardedMarbles` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D437C` | `Jackaroo.JackarooBoardMono::ReleasePooledGuardedMarbles` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D4444` | `Jackaroo.JackarooBoardMono::InitializeJackarooNodeMono` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D45B4` | `Jackaroo.JackarooBoardMono::GetPlayerOffset` | method | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51D4714` | `Jackaroo.JackarooBoardMono::MovesRunnerIe` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D47B8` | `Jackaroo.JackarooBoardMono::get_IsAnimating` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D47C0` | `Jackaroo.JackarooBoardMono::set_IsAnimating` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D47C8` | `Jackaroo.JackarooBoardMono::get_IsMovingToGraveyard` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D47D0` | `Jackaroo.JackarooBoardMono::set_IsMovingToGraveyard` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D47D8` | `Jackaroo.JackarooBoardMono::get_ShouldWait` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D485C` | `Jackaroo.JackarooBoardMono::GetDurationForNodes` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D4978` | `Jackaroo.JackarooBoardMono::GetUnblockBaseAction` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D4B6C` | `Jackaroo.JackarooMoveStep::.ctor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D4BF4` | `Jackaroo.JackarooBoardMono::HandleEatPathMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D503C` | `Jackaroo.JackarooBoardMono::OnPreMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D50B0` | `Jackaroo.JackarooBoardMono::HandleMarbleDeath` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5144` | `Jackaroo.JackarooBoardMono::HandleSplitMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5490` | `Jackaroo.JackarooBoardMono::HandleSingleMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5728` | `Jackaroo.JackarooBoardMono::CheckMarbleUnblockedBase` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5828` | `Jackaroo.JackarooBoardMono::CheckMarbleUnblockedBase` | inside (+0x100) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D58A8` | `Jackaroo.JackarooBoardMono::SwapSimultaneous` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5C18` | `Jackaroo.JackarooBoardMono::SwapSequential` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5E6C` | `Jackaroo.JackarooBoardMono::ShowMarbleDeathAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5F5C` | `Jackaroo.JackarooBoardMono::OnPostMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5F90` | `Jackaroo.JackarooBoardMono::OnDeath` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FD4` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/README.md) |
| `0x51D5FE4` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x10) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FE8` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x14) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FEC` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x18) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FF0` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x1C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FF4` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x20) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FF8` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x24) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D5FFC` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x28) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6000` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x2C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6018` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x44) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6020` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x4C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51D6024` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x50) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6030` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x5C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6040` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x6C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51D6044` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x70) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6048` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x74) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6058` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0x84) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6090` | `Jackaroo.JackarooBoardMono::CheckMarbleEntryEffect` | inside (+0xBC) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6104` | `Jackaroo.JackarooBoardMono::AllMarblesInBaseCelebrationIe` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51D61B0` | `Jackaroo.JackarooBoardMono::SetThemeAndApply` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D639C` | `Jackaroo.JackarooBoardMono::SetTheme` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D64BC` | `Jackaroo.JackarooBoardMono::SetTheme` | method | [جكارو](jackaroo-spec/15-الأنيميشن-ووقت-التشغيل-المرئي.md) |
| `0x51D6508` | `Jackaroo.JackarooBoardMono::SetThemeAndApply` | method | [جكارو](jackaroo-spec/15-الأنيميشن-ووقت-التشغيل-المرئي.md) |
| `0x51D6600` | `Jackaroo.JackarooBoardMono::ReapplyActiveHighlightStates` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D68F0` | `Jackaroo.JackarooBoardMono::ApplyNodeTheme` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D69E8` | `Jackaroo.JackarooBoardMono::HighlightMoves` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D6C00` | `Jackaroo.JackarooBoardMono::HighlightFirstNode` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6CC4` | `Jackaroo.JackarooBoardMono::HighlightNodesAndMarbles` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D6EF8` | `Jackaroo.JackarooBoardMono::HighlightGuardedMarbles` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D7078` | `Jackaroo.JackarooBoardMono::HighlightMove2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D70D4` | `Jackaroo.JackarooBoardMono::HighlightFirstNode2` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D7198` | `Jackaroo.JackarooBoardMono::HighlightNodesAndMarbles2` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D73A4` | `Jackaroo.JackarooBoardMono::HighlightNode` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D746C` | `Jackaroo.JackarooBoardMono::HighlightLastNode` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D758C` | `Jackaroo.JackarooBoardMono::HideNodesHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D76FC` | `Jackaroo.JackarooBoardMono::HighlightFirstNode` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51D77D8` | `Jackaroo.JackarooBoardMono::HideLastNodesHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D7988` | `Jackaroo.JackarooBoardMono::HideGuardedMarblesHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D7AC4` | `Jackaroo.JackarooBoardMono::AddGuardedMarble` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D7CC0` | `Jackaroo.JackarooBoardMono::HighlightGuardedMarbles` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D7E40` | `Jackaroo.JackarooBoardMono::BlockBase` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8038` | `Jackaroo.JackarooBoardMono::UnblockBase` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8364` | `Jackaroo.JackarooBoardMono::GetFirstWinnerIndex` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51D8498` | `Jackaroo.JackarooBoardMono::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D886C` | `Jackaroo.JackarooBoardMono::<DoCheckWithServer>b__46_1` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51D88D4` | `Jackaroo.JackarooBoardMono::<MoveMarbleToGraveyard>b__47_0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8960` | `Jackaroo.JackarooBoardMono.<>c::<Move>b__138_1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8978` | `Jackaroo.JackarooBoardMono.<>c::<HandleSplitMove>b__141_3` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8990` | `Jackaroo.JackarooBoardMono.<>c::<HandleSplitMove>b__141_1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D89A8` | `Jackaroo.JackarooBoardMono.<>c::<HandleSingleMove>b__142_1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D89C0` | `Jackaroo.JackarooBoardMono.<>c::<InitializeGuardedMarblesPool>b__192_0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8A34` | `Jackaroo.JackarooBoardMono.<>c::<InitializeGuardedMarblesPool>b__192_1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8AD8` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass137_0::<Plant>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8B1C` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass137_0::<Plant>b__1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8B5C` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass138_0::<Move>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8BC4` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass140_0::<HandleEatPathMove>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8C1C` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass141_0::<HandleSplitMove>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D8F9C` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass141_0::<HandleSplitMove>b__2` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9040` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass142_0::<HandleSingleMove>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D90E4` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass143_0::<MoveMarble>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D92D4` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass144_0::<SwapSimultaneous>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D92F4` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass144_0::<SwapSimultaneous>b__1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9348` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass145_0::<SwapSequential>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9530` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass145_0::<SwapSequential>b__1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9584` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass201_0::<GetUnblockBaseAction>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9780` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass24_0::<OnPlayerDidLastAction>b__0` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9880` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass24_0::<OnPlayerDidLastAction>b__0` | inside (+0x100) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D98F4` | `Jackaroo.JackarooBoardMono.<>c__DisplayClass27_0::<PlayJackarooMove>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D99D8` | `Jackaroo.JackarooBoardMono.<AllMarblesInBaseCelebrationIe>d__215::MoveNext` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51D9D68` | `Jackaroo.JackarooBoardMono.<MovesRunnerIe>d__116::MoveNext` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9E20` | `Jackaroo.JackarooBoardMono.<MovesRunnerIe>d__116::MoveNext` | inside (+0xB8) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9F00` | `Jackaroo.JackarooBoardMono.<MovesRunnerIe>d__116::MoveNext` | inside (+0x198) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51D9F0C` | `Jackaroo.JackarooBoardMono.<MovesRunnerIe>d__116::MoveNext` | inside (+0x1A4) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DA01C` | `Jackaroo.JackarooCardGameVisualControls::HideControls` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA078` | `Jackaroo.JackarooCardGameVisualControls::HideActionsOptionsPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA094` | `Jackaroo.JackarooCardGameVisualControls::HideBurnOtherCardPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA0AC` | `Jackaroo.JackarooCardGameVisualControls::HideActionTip` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA0D8` | `Jackaroo.JackarooCardGameVisualControls::ShowActionsOptionsPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA0F4` | `Jackaroo.JackarooCardGameVisualControls::ShowBurnOtherCardPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA10C` | `Jackaroo.JackarooCardGameVisualControls::ShowActionTipPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA14C` | `Jackaroo.JackarooCardGameVisualControls::ShowPickerPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA168` | `Jackaroo.JackarooCardGameVisualControls::HidePickerPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA184` | `Jackaroo.JackarooCardGameVisualControls::ShowTipsPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA1A0` | `Jackaroo.JackarooCardGameVisualControls::HideTipsPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DA1D4` | `Jackaroo.JackarooCardGameVisualControls::SetTheme` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA2B8` | `Jackaroo.JackarooCardGameVisualControls::SetThemeAndApply` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA3C4` | `Jackaroo.JackarooCardGameVisualControls::Init` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA594` | `Jackaroo.JackarooCardGameVisualControls::ClearBoardEffectsMask` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA6E0` | `Jackaroo.JackarooCardGameVisualControls::OnGameStateUpdated` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA7F4` | `Jackaroo.JackarooCardGameVisualControls::OnGameInitialized` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA88C` | `Jackaroo.JackarooCardGameVisualControls::PlayPlayersPlayedCard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DA948` | `Jackaroo.JackarooCardGameVisualControls::HandleOrderedPlayedCards` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DAB10` | `Jackaroo.JackarooCardGameVisualControls::HandleSinglePlayedCard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DAE50` | `Jackaroo.JackarooCardGameVisualControls::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DAFF4` | `Jackaroo.JackarooCardGameVisualControls::RemoveCards` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DB168` | `Jackaroo.JackarooCardGameVisualControls::AdjustOpponentCardStart` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DB428` | `Jackaroo.JackarooCardGameVisualControls::GetPlayerSlotIndex` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x51DB42C` | `Jackaroo.JackarooCardGameVisualControls::GetPlayerSlotIndex` | inside (+0x4) | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x51DB430` | `Jackaroo.JackarooCardGameVisualControls::PlayCard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DB4B8` | `Jackaroo.JackarooCardGameVisualControls::PlayCard` | inside (+0x88) | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x51DB4EC` | `Jackaroo.JackarooCardGameVisualControls::GetCardSprite` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DB550` | `Jackaroo.JackarooCardGameVisualControls::OnGamePerspectiveChanged` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DB820` | `Jackaroo.JackarooCardsMapper::get_AllowedRules` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DB86C` | `Jackaroo.JackarooCardsMapper::GetJackarooActions` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DB8FC` | `Jackaroo.JackarooCardsMapper::GetJackarooActions` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DB948` | `Jackaroo.JackarooCardsMapper::IsCustomRule` | method | [جكارو](jackaroo-spec/04-القواعد-المخصصة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DBC80` | `Jackaroo.JackarooCardsMapper::GetDefaultJackarooActions` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DBDBC` | `Jackaroo.JackarooCardUtils::.ctor` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DBE28` | `Jackaroo.JackarooCardUtils::get_AllJackarooCards` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DC050` | `Jackaroo.JackarooCardUtils::RandomJackarooCard` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DC1BC` | `Jackaroo.JackarooCardUtils::GetValue` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DC1D8` | `Jackaroo.JackarooCardUtils::.cctor` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DC380` | `Jackaroo.JackarooGame::get_IsNewLastAction` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DC414` | `Jackaroo.JackarooLastActionInfo::Equals` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DC4BC` | `Jackaroo.JackarooGame::ParseLastActionInfo` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DC608` | `Jackaroo.JackarooLastActionInfo::.ctor` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DC7B8` | `Jackaroo.JackarooGame::Init` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DCAFC` | `Jackaroo.JackarooGame::get_Team1P1Score` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DCB54` | `Jackaroo.JackarooGame::GetPlayerScore` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DCC88` | `Jackaroo.JackarooGame::get_Team1P2Score` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DCCEC` | `Jackaroo.JackarooGame::get_Team2P1Score` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DCD5C` | `Jackaroo.JackarooGame::get_Team2P2Score` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DCDCC` | `Jackaroo.JackarooGame::get_Team1P1` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DCE34` | `Jackaroo.JackarooGame::get_Team2P1` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DCE9C` | `Jackaroo.JackarooGame::get_Team1P2` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DCF04` | `Jackaroo.JackarooGame::get_Team2P2` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DCF6C` | `Jackaroo.JackarooGame::GetScores` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DD16C` | `Jackaroo.JackarooGame::UpdateGameState` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DD218` | `Jackaroo.JackarooGame::GetServerBoardMarbles` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DD3C0` | `Jackaroo.JackarooGame::OnPlayCard` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DD528` | `Jackaroo.JackarooGame::EndGame` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51DD5D8` | `Jackaroo.JackarooGame::SendToSfs` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51DD904` | `Jackaroo.JackarooGame::NeedsP2` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DD910` | `Jackaroo.JackarooGame::ThrowCard` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DDA48` | `Jackaroo.JackarooGame::get_GetNextToMyPlayer` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DDA74` | `Jackaroo.JackarooGame::GetNextPlayer` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DDB48` | `Jackaroo.JackarooGame::get_SpecialJackarooActions` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DDBC4` | `Jackaroo.JackarooGame::IsASplit` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DDBD0` | `Jackaroo.JackarooGame::ToGameActionId` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DDCE8` | `Jackaroo.JackarooGame::GetStoreItem` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DDD70` | `Jackaroo.JackarooGame::ToGameActionItemId` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51DDE88` | `Jackaroo.JackarooGame::GetStoreItem` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51DDF10` | `Jackaroo.JackarooGame::.ctor` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51DDF88` | `Jackaroo.JackarooGame::.cctor` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51DE01C` | `Jackaroo.JackarooGame::.cctor` | inside (+0x94) | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51DE030` | `Jackaroo.JackarooGame::.cctor` | inside (+0xA8) | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51DE068` | `Jackaroo.JackarooGameEndPopup::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DE27C` | `Jackaroo.JackarooGameEndPopup::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DE3C0` | `Jackaroo.JackarooGameSoundControls::get_jackarooGame` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DE448` | `Jackaroo.JackarooGameSoundControls::Init` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DE5BC` | `Jackaroo.JackarooGameSoundControls::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DE6DC` | `Jackaroo.JackarooGameSoundControls::OnRoundEnd` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DE91C` | `Jackaroo.JackarooGameSoundControls::PlayEndGameSound` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DEA44` | `Jackaroo.JackarooLastActionInfo::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DEA9C` | `Jackaroo.JackarooMarbleMono::ShowText` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DEB54` | `Jackaroo.JackarooMarbleMono::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DED50` | `Jackaroo.JackarooMarbleMono::OnGamePerspectiveChanged` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DEEA4` | `Jackaroo.JackarooMarbleMono::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DEF48` | `Jackaroo.JackarooMarbleMono::SetupSelect` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DF040` | `Jackaroo.JackarooMarbleMono::SelectMarble` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51DF064` | `Jackaroo.JackarooMarbleMono::Reset` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DF100` | `Jackaroo.JackarooMarbleMono::ResetLayer` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DF1DC` | `Jackaroo.JackarooMarbleMono::MoveImmediate` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF220` | `Jackaroo.JackarooNodeMono::get_Position` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF23C` | `Jackaroo.JackarooMarbleMono::Move` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF4FC` | `Jackaroo.JackarooMarbleMono::DoLocalMove` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF574` | `Jackaroo.JackarooMarbleMono::DoLocalJump` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF624` | `Jackaroo.JackarooMarbleMono::DoPunchScale` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF63C` | `Jackaroo.JackarooMarbleMono::Plant` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF9DC` | `Jackaroo.JackarooMarbleMono::DoLocalMoveY` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF9E4` | `Jackaroo.JackarooMarbleMono::Stop` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DF9F4` | `Jackaroo.JackarooMarbleMono::SetColor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51DFB3C` | `Jackaroo.JackarooMarbleMono::ShowGuardEffect` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFB8C` | `Jackaroo.JackarooMarbleMono::HideGuardEffect` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFBDC` | `Jackaroo.JackarooMarbleMono::ShowDeath` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFC40` | `Jackaroo.JackarooMarbleMono::HideDeath` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFCA4` | `Jackaroo.JackarooMarbleMono::PlantEffectIe` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFD48` | `Jackaroo.JackarooMarbleMono::ShowPlantEffect` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFDC8` | `Jackaroo.JackarooMarbleMono::PlayEntryEffect` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFDE8` | `Jackaroo.JackarooMarbleMono::PlayBurnAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51DFF64` | `Jackaroo.JackarooMarbleMono::PlaySmokeEffect2` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFF84` | `Jackaroo.JackarooMarbleMono::SetMoveTrailActiveState` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51DFFC0` | `Jackaroo.JackarooMarbleMono::ShowFireMode` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E0160` | `Jackaroo.JackarooMarbleMono::HideFireMode` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E01D0` | `Jackaroo.JackarooMarbleMono::.ctor` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51E0288` | `Jackaroo.JackarooMarbleMono::<PlayBurnAnimation>b__82_0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E0404` | `Jackaroo.JackarooMarbleMono::<PlayBurnAnimation>b__82_1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E0464` | `Jackaroo.JackarooMarbleMono.<PlantEffectIe>d__73::MoveNext` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E05E8` | `Jackaroo.JackarooMarble::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E0600` | `Jackaroo.JackarooMarble::.ctor` | inside (+0x18) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E067C` | `Jackaroo.JackarooMove::.ctor` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0720` | `Jackaroo.JackarooMove::.ctor` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E07C4` | `Jackaroo.JackarooMove::GetPlantMove` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0890` | `Jackaroo.JackarooMove::GetMove` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E095C` | `Jackaroo.JackarooMove::GetBurnCardsMoves` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0A7C` | `Jackaroo.JackarooMove::GetBurnCardMove` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0B38` | `Jackaroo.JackarooMove::GetNewSwapJackarooMove` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0C04` | `Jackaroo.JackarooMove::GetStealMove` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0CC0` | `Jackaroo.JackarooMove::GetNewSplitJackarooMove` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0E14` | `Jackaroo.JackarooServerMove::.ctor` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51E0EC0` | `Jackaroo.JackarooNodeMono::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E0F48` | `Jackaroo.JackarooNodeMono::SetColor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E0F78` | `Jackaroo.JackarooNodeMono::SetSelectedColor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E0FA8` | `Jackaroo.JackarooNodeMono::RestoreDefaultColor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E0FD8` | `Jackaroo.JackarooNodeMono::ShowHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E1004` | `Jackaroo.MarbleHighlight::ShowHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E1024` | `Jackaroo.JackarooNodeMono::HideHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E1078` | `Jackaroo.MarbleHighlight::HideHighlight` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E11E8` | `Jackaroo.JackarooNodeMono::StartHighlightAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E1214` | `Jackaroo.MarbleHighlight::StartHighlightAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E1234` | `Jackaroo.JackarooNodeMono::HideHighlightAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E127C` | `Jackaroo.MarbleHighlight::HideHighlightAnimation` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E12C0` | `Jackaroo.JackarooNodeMono::ShowBlocked` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E1354` | `Jackaroo.JackarooNodeMono::HideBlocked` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E13F4` | `Jackaroo.JackarooNode::SetType` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E142C` | `Jackaroo.JackarooOptionsPanel::Awake` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E160C` | `Jackaroo.JackarooOptionsPanel::ShowActionsOptions` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E1CCC` | `Jackaroo.JackarooOptionsPanel::Dismiss` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E1E78` | `Jackaroo.JackarooOptionsPanel::Hide` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E1E7C` | `Jackaroo.JackarooOptionsPanel::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E1F08` | `Jackaroo.JackarooOptionsPanel::<Awake>b__2_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E1FA0` | `Jackaroo.JackarooOptionsPanel::<Awake>b__2_1` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E20EC` | `Jackaroo.JackarooOptionsPanel.<>c__DisplayClass6_0::<ShowActionsOptions>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E2110` | `Jackaroo.JackarooOptionsPanel.<>c__DisplayClass6_0::<ShowActionsOptions>b__0` | inside (+0x24) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E2174` | `Jackaroo.JackarooRules::get_AllowedRules` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E21C0` | `Jackaroo.JackarooRules::set_AllowedRules` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E2218` | `Jackaroo.JackarooRules::.ctor` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E2630` | `Jackaroo.JackarooRules::GetNextPlayerIndex` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E2644` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E2648` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x4) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E264C` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x8) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E2650` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0xC) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E2654` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x10) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E265C` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x18) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E2668` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x24) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E266C` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x28) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E2670` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x2C) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E2674` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x30) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E2678` | `Jackaroo.JackarooRules::GetJackarooMoveFromCard` | inside (+0x34) | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) |
| `0x51E268C` | `Jackaroo.JackarooRules::GetAllowedJackarooMoves` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E2FFC` | `Jackaroo.JackarooRules::DoNextPlayerHasCards` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E30B4` | `Jackaroo.JackarooRules::GetAllowedPlantAction` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E3344` | `Jackaroo.JackarooRules::GetAllowedSwapAction` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E358C` | `Jackaroo.JackarooRules::GetAllowedSwapAction` | inside (+0x248) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E35D8` | `Jackaroo.JackarooRules::GetAllowedSwapAction` | inside (+0x294) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E3940` | `Jackaroo.JackarooRules::GetAllowedMoveAnyAction` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E3BB0` | `Jackaroo.JackarooRules::GetAllowedMoveAnyAction` | inside (+0x270) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E3BFC` | `Jackaroo.JackarooRules::GetAllowedMoveAnyAction` | inside (+0x2BC) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E3D34` | `Jackaroo.JackarooRules::GetAllowedMoveAction` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E4020` | `Jackaroo.JackarooRules::GetAllowedMoveReverseAction` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E434C` | `Jackaroo.JackarooRules::GetAllowedSplitMoveAction` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E4874` | `Jackaroo.JackarooRules::GetAllowedSplitMoveAction` | inside (+0x528) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51E4A14` | `Jackaroo.JackarooRules::GetAllowedSplitMoveAction` | inside (+0x6C8) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E4F68` | `Jackaroo.JackarooRules::IsBlockedByHome` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E4F80` | `Jackaroo.JackarooRules::IsBlockedByTwoMarbles` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E5060` | `Jackaroo.JackarooRules::GetAllowedMoveAction` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E51F0` | `Jackaroo.JackarooRules::GetJackarooMoveFromSplit` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E54B4` | `Jackaroo.JackarooRules::GetAllowedSplitMoveAction` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E55C0` | `Jackaroo.JackarooRules::IsSharedFinal7` | method | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E5634` | `Jackaroo.JackarooRules::IsSharedFinal7` | inside (+0x74) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51E5688` | `Jackaroo.JackarooRules::AreNodesWalkable` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E56DC` | `Jackaroo.JackarooRules::AreNodesWalkable` | inside (+0x54) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E56E0` | `Jackaroo.JackarooRules::AreNodesWalkable` | inside (+0x58) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E56E4` | `Jackaroo.JackarooRules::AreNodesWalkable` | inside (+0x5C) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E56E8` | `Jackaroo.JackarooRules::AreNodesWalkable` | inside (+0x60) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E56EC` | `Jackaroo.JackarooRules::AreNodesWalkable` | inside (+0x64) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E56F0` | `Jackaroo.JackarooRules::AreNodesWalkable` | inside (+0x68) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E57B0` | `Jackaroo.JackarooRules::AreNodesWalkableForMOVE_EAT_PATH` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E58F0` | `Jackaroo.JackarooRules::AreNodesWalkableForMOVE_EAT_PATH` | inside (+0x140) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5904` | `Jackaroo.JackarooRules::AreNodesWalkableForMOVE_EAT_PATH` | inside (+0x154) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E59B0` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5AA8` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0xF8) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5B88` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x1D8) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5B8C` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x1DC) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5BA0` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x1F0) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5BAC` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x1FC) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5C44` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x294) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5C74` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x2C4) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5D38` | `Jackaroo.JackarooRules::AreNodesWalkableForMove` | inside (+0x388) | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x51E5D4C` | `Jackaroo.JackarooRules::IsBlockedBySameColorMarble` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E5E08` | `Jackaroo.JackarooRules::IsBaseEntryBlocked` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E5F40` | `Jackaroo.JackarooRules::IsBlockedInBase` | method | [جكارو](jackaroo-spec/02-الحركة-والأكل.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51E5F60` | `Jackaroo.JackarooScores::SaveRoundScore` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E60FC` | `Jackaroo.JackarooRoundScore::Record` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E62A4` | `Jackaroo.JackarooThemeData::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6404` | `Jackaroo.JackarooThemeData::GetPlayerColor` | method | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x51E648C` | `Jackaroo.JackarooThemeData::GetPlayerMarbleSprite` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6510` | `Jackaroo.JackarooThemeDataExtensions::With` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6750` | `Jackaroo.JackarooThemeDataExtensions::With` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6C00` | `Jackaroo.JackarooTipPanel::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6DCC` | `Jackaroo.JackarooTipPanel::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6EC4` | `Jackaroo.JackarooTipPanel::ShowCardTipsPanel` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E6FB4` | `Jackaroo.JackarooTipPanel::GenerateActionTips` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E7338` | `Jackaroo.JackarooTipPanel::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E78C4` | `Jackaroo.JackarooTurnIndicator::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E798C` | `Jackaroo.JackarooTurnIndicator::SetTurn` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E7BD4` | `Jackaroo.JackarooZoomInPicker::Awake` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E7FA8` | `Jackaroo.JackarooZoomInPicker::OnDestroy` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E80A0` | `Jackaroo.JackarooZoomInPicker::ShowPickerPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8334` | `Jackaroo.JackarooZoomInPicker::ShowPickerPanel` | inside (+0x294) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E83C8` | `Jackaroo.JackarooZoomInPicker::AddPickerOption` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8888` | `Jackaroo.JackarooZoomInPicker::AddPickerOption` | inside (+0x4C0) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E88F0` | `Jackaroo.JackarooZoomInPicker::AddPickerOption` | inside (+0x528) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8978` | `Jackaroo.JackarooZoomInPickerOption::ShowFireMode` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8A50` | `Jackaroo.JackarooZoomInPickerOption::Setup` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8AD4` | `Jackaroo.JackarooZoomInPicker::Dismiss` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8B10` | `Jackaroo.JackarooZoomInPicker::HidePickerPanel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E8EFC` | `Jackaroo.JackarooZoomInPickerOption::HideFireMode` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x51E8F1C` | `Jackaroo.JackarooZoomInPicker::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E9018` | `Jackaroo.JackarooZoomInPicker::<Awake>b__14_0` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E958C` | `Jackaroo.JackarooZoomInPickerOption::SelectOption` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51E95B8` | `Jackaroo.MarbleHighlight::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E962C` | `Jackaroo.ShowConfettiAnimation::SetColor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E97F0` | `Jackaroo.ShowConfettiAnimation::PlayWin` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E9D50` | `Jackaroo.ShowConfettiAnimation::Reset` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51E9ED4` | `Jackaroo.ShowConfettiAnimation::PlayTest` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EA5BC` | `Jackaroo.JackarooGameUiControls::OnGameStateUpdated` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EA670` | `Jackaroo.JackarooScore::Start` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51EA7E8` | `Jackaroo.JackarooScore::OnDestroy` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51EA8E4` | `Jackaroo.JackarooScore::Init` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51EAB18` | `Jackaroo.JackarooScore::GetSprites` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51EAE94` | `Jackaroo.JackarooScore::PopulateAvatars` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51EB134` | `Jackaroo.JackarooScore::UpdateScores` | method | [جكارو](jackaroo-spec/14-النماذج-والحركات-والقواعد.md) |
| `0x51EB318` | `Jackaroo.JackarooRoundBoardPopup::ShowRoundBoard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EBC3C` | `Jackaroo.JackarooRoundBoardPopup::.ctor` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EBCC4` | `Jackaroo.JackarooPlayingButtons::Start` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EBE50` | `Jackaroo.JackarooPlayingButtons::UpdateButtons` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EBEDC` | `Jackaroo.JackarooPlayingButtons::UpdateButtons` | inside (+0x8C) | [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x51EBF58` | `Jackaroo.JackarooPlayingButtons::ShowSawaButton` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC010` | `Jackaroo.JackarooPlayingButtons::HideSawaButton` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC0D4` | `Jackaroo.JackarooUserbox::get_player` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC150` | `Jackaroo.JackarooUserbox::get_game` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC1CC` | `Jackaroo.JackarooUserbox::Awake` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC354` | `Jackaroo.JackarooUserbox::OnGameStatusUpdate` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x51EC368` | `Jackaroo.JackarooUserbox::OnGameStatusUpdate` | inside (+0x14) | [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x51EC3F0` | `Jackaroo.JackarooUserbox::OnPlayerDidLastAction` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC6BC` | `Jackaroo.JackarooUserbox::TryPlayThrownCard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EC858` | `Jackaroo.JackarooUserbox::TryPlayOutOfTime` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ECAC0` | `Jackaroo.JackarooUserbox::TryPlayBurnOtherCardRandom` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x51ECDD4` | `Jackaroo.JackarooUserbox::TryPlaySteal` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ED0E0` | `Jackaroo.JackarooUserbox::GetGameActionId` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ED1A8` | `Jackaroo.JackarooUserbox::PlayCard` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ED1F8` | `Jackaroo.JackarooUserbox::ClearActionState` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ED28C` | `Jackaroo.JackarooUserbox::ResolveGameAction` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ED41C` | `Jackaroo.JackarooUserbox::OnGamePerspectiveChanged` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51ED694` | `Jackaroo.JackarooUserbox::CanJoinGame` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x51EE5E8` | `KammelnaOffline.Tarneeb.TarneebAiLogic::PlayCard` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EE628` | `KammelnaOffline.Tarneeb.TarneebAiLogic::Bid` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EE668` | `KammelnaOffline.Tarneeb.TarneebAiLogic::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE678` | `KammelnaOffline.Tarneeb.TarneebBiddingManager::GetNextBidding` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EE6C0` | `KammelnaOffline.Tarneeb.TarneebBiddingManager::StartBidding` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EE728` | `KammelnaOffline.Tarneeb.TarneebBiddingManager::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE738` | `KammelnaOffline.Tarneeb.TarneebGameController::CreatePlayer` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE7A0` | `KammelnaOffline.Tarneeb.TarneebOfflinePlayer::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE7A8` | `KammelnaOffline.Tarneeb.TarneebGameController::CreateAiLogic` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE800` | `KammelnaOffline.Tarneeb.TarneebGameController::CreatePlayingManager` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE874` | `KammelnaOffline.Tarneeb.TarneebPlayingManager::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE8A8` | `KammelnaOffline.Tarneeb.TarneebGameController::CreateBiddingManager` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EE900` | `KammelnaOffline.Tarneeb.TarneebGameController::CardValue` | method | [طرنيب](tarneeb-spec/02-تدفق-اللعبة-والحالات.md) · [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x51EE918` | `KammelnaOffline.Tarneeb.TarneebGameController::OnStartRound` | method | [طرنيب](tarneeb-spec/02-تدفق-اللعبة-والحالات.md) · [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x51EECF0` | `KammelnaOffline.Tarneeb.TarneebGameController::GetOfflineValue` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x51EED08` | `KammelnaOffline.Tarneeb.TarneebGameController::IsGameOver` | method | [طرنيب](tarneeb-spec/04-اللعب-والنقاط.md) · [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x51EED2C` | `KammelnaOffline.Tarneeb.TarneebGameController::OnEndRound` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EED6C` | `KammelnaOffline.Tarneeb.TarneebGameController::GetEatingPlayer` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EEDAC` | `KammelnaOffline.Tarneeb.TarneebGameController::GetPlayableCards` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EEDEC` | `KammelnaOffline.Tarneeb.TarneebGameController::GetBiddingFromSfsParam` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EEE2C` | `KammelnaOffline.Tarneeb.TarneebGameController::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EEE9C` | `KammelnaOffline.Common.OfflineGameController::.ctor` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x51EEF0C` | `KammelnaOffline.Tarneeb.TarneebPlayingManager::StartPlaying` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EEF4C` | `KammelnaOffline.Tarneeb.TarneebPlayingManager::OnPlay` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EEF8C` | `KammelnaOffline.Tarneeb.TarneebPlayingManager::CopyCards` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x51EEFCC` | `KammelnaOffline.Tarneeb.TarneebPlayingManager::ClearPlayersVariables` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x51EF120` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51EFA68` | `KammelnaOffline.OfflineServer.OfflineRoom::SetPlayers` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F05A8` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F07CC` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F0990` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | inside (+0x1C4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F09A8` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | inside (+0x1DC) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F09E8` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | inside (+0x21C) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F0A04` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | inside (+0x238) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F0A08` | `KammelnaOffline.OfflineServer.OfflineRoom::.ctor` | inside (+0x23C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F1630` | `KammelnaOffline.OfflineServer.OfflineRoom::RemovePlayer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F3E1C` | `KammelnaOffline.OfflineServer.OfflineSmartFoxClient::GetGameController` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x51F42E4` | `KammelnaOffline.OfflineServer.OfflineSmartFoxClient::.ctor` | inside (+0xD0) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F57B0` | `KammelnaOffline.Common.OfflineGameController::OnGameUpdated` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F6144` | `KammelnaOffline.Common.OfflineGameController::EatCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F64C0` | `KammelnaOffline.Common.OfflineGameController::EatCard` | inside (+0x37C) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x51F65E8` | `KammelnaOffline.Common.OfflineGameController::ShowSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F6928` | `KammelnaOffline.Common.OfflineGameController::ShowKasho` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F6CAC` | `KammelnaOffline.Common.OfflineGameController::InitializeGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F6D1C` | `KammelnaOffline.Common.OfflineGameController::StartRound` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) · [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x51F6F0C` | `KammelnaOffline.Common.OfflineGameController::StartRound` | inside (+0x1F0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51F6F18` | `KammelnaOffline.Common.OfflineGameController::StartRound` | inside (+0x1FC) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x51F7560` | `KammelnaOffline.Common.OfflineGameController::AcceptNextMove` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F75DC` | `KammelnaOffline.Common.OfflineGameController::OnEndGame` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x51F76A0` | `KammelnaOffline.Common.OfflineGameController::PlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F7E04` | `KammelnaOffline.Common.OfflineGameController::CardsToInt` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x51F7F40` | `KammelnaOffline.Common.OfflineGameController::OnPlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F81F0` | `KammelnaOffline.Common.OfflineGameController::Bid` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F86B8` | `KammelnaOffline.Common.OfflineGameController::OnEndBidding` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x51F8A0C` | `KammelnaOffline.Common.OfflineGameController::OnEndBidding` | inside (+0x354) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x51F8CE0` | `KammelnaOffline.Common.OfflineGameController::SendRoundStart` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F8DE8` | `KammelnaOffline.Common.OfflineGameController::SendGameState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F8EF0` | `KammelnaOffline.Common.OfflineGameController::SendEndRound` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F8FF8` | `KammelnaOffline.Common.OfflineGameController::SendEndGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F9224` | `KammelnaOffline.Common.OfflineGameController::BuildRoundState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F9644` | `KammelnaOffline.Common.OfflineGameController::BuildRoundState` | inside (+0x420) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F9B40` | `KammelnaOffline.Common.OfflineGameController::CompareCards` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F9BA0` | `KammelnaOffline.Common.OfflineGameController::CatchCheating` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x51F9BE0` | `KammelnaOffline.Common.OfflineGameController::Play` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F9DC4` | `KammelnaOffline.Common.OfflineGameController::DoNextBidding` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51F9EA8` | `KammelnaOffline.Common.OfflineGameController::DoNextBidding` | inside (+0xE4) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA500` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FA7C4` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x2C4) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FA80C` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x30C) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA840` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x340) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA844` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x344) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA854` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x354) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA86C` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x36C) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FA880` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x380) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA968` | `KammelnaOffline.Baloot.BalootAiLogic::PlayCard` | inside (+0x468) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x51FA9A8` | `KammelnaOffline.Baloot.BalootAiLogic::GetTeammateIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FA9C4` | `KammelnaOffline.Baloot.BalootGameController::get_Players` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x51FAA34` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | method | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FAB3C` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x108) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FAB40` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x10C) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FAD00` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x2CC) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FAD10` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x2DC) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FAD24` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x2F0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FAD7C` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x348) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FB0AC` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0x678) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FB444` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0xA10) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FB530` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0xAFC) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FB61C` | `KammelnaOffline.Baloot.BalootUtils::PlayableCards` | inside (+0xBE8) | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) |
| `0x51FBB78` | `KammelnaOffline.Baloot.BalootAiLogic::GetEatingCards` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FBE50` | `KammelnaOffline.Baloot.BalootAiLogic::GetMinOfSuit` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FBEC0` | `KammelnaOffline.Baloot.BalootAiLogic::Bait` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x51FBF38` | `KammelnaOffline.Baloot.BalootAiLogic::Starve` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x51FBFB0` | `KammelnaOffline.Baloot.BalootAiLogic::GetMaxCard` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FC084` | `KammelnaOffline.Baloot.BalootUtils::GetSuitCards` | method | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FC17C` | `KammelnaOffline.Baloot.BalootAiLogic::GetMinCard` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FC250` | `KammelnaOffline.Baloot.BalootAiLogic::Bid` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FC460` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x51FC5A4` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x144) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5A8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x148) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5AC` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x14C) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5B0` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x150) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5B4` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x154) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5B8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x158) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5BC` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x15C) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5C0` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x160) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5C4` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x164) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5C8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x168) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5E8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x188) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC5F8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x198) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC628` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x1C8) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC644` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x1E4) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC660` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x200) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC67C` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x21C) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC698` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x238) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC6B4` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x254) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC6D0` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x270) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC6EC` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x28C) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC708` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x2A8) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC748` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x2E8) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC768` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x308) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC784` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x324) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC7A0` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x340) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC7E0` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x380) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC800` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x3A0) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC81C` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x3BC) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC838` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x3D8) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC878` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x418) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC894` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x434) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC8AC` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x44C) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC8DC` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x47C) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC8F8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x498) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC914` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x4B4) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC930` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x4D0) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC960` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x500) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC990` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x530) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC9C0` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x560) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC9DC` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x57C) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FC9F8` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x598) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FCA38` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x5D8) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FCA54` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x5F4) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FCA70` | `KammelnaOffline.Baloot.BalootBiddingOptions::GetBiddingOptionsFromState` | inside (+0x610) | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x51FCAB0` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuySun` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD060` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuySun` | inside (+0x5B0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD2FC` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuySun` | inside (+0x84C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD308` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuySun` | inside (+0x858) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD314` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuySun` | inside (+0x864) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD350` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuySun` | inside (+0x8A0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD428` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom1` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FD608` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom1` | inside (+0x1E0) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FD618` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom1` | inside (+0x1F0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FD638` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom1` | inside (+0x210) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FD720` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom2` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FDE68` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom2` | inside (+0x748) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FE160` | `KammelnaOffline.Baloot.BalootUtils::CheckIfAiCouldBuyHokom2` | inside (+0xA40) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FE31C` | `KammelnaOffline.Baloot.BalootAiLogic::GetAction` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FE40C` | `KammelnaOffline.Baloot.BalootAiLogic.<>c::<PlayCard>b__2_1` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FE490` | `KammelnaOffline.Baloot.BalootBiddingManager::get_FloorCardPlayer` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FE4F8` | `KammelnaOffline.Baloot.BalootBiddingManager::.ctor` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x51FE550` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FE8D8` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x388) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FEAEC` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x59C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FEAF0` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x5A0) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FEB90` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x640) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FEBE0` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x690) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FEBE4` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x694) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FED24` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x7D4) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FED28` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0x7D8) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FEFCC` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xA7C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FEFD4` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xA84) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FF02C` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xADC) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FF064` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xB14) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x51FF2C8` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xD78) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FF2E8` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xD98) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FF39C` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xE4C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FF3BC` | `KammelnaOffline.Baloot.BalootBiddingManager::GetNextBidding` | inside (+0xE6C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FF404` | `KammelnaOffline.Baloot.BalootBiddingManager::BiddingStates` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x51FF7C8` | `KammelnaOffline.Baloot.BalootBiddingManager::BiddingStates` | inside (+0x3C4) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FF89C` | `KammelnaOffline.Baloot.BalootBiddingManager::BiddingStates` | inside (+0x498) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FFFAC` | `KammelnaOffline.Baloot.BalootBiddingManager::SetBiddingResult` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x51FFFB8` | `KammelnaOffline.Baloot.BalootBiddingManager::StartBidding` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52000AC` | `KammelnaOffline.Baloot.BalootBiddingManager::Reset` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x520013C` | `KammelnaOffline.Baloot.BalootBiddingOptions::BiddingOptionFromSfsObject` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5200748` | `KammelnaOffline.Baloot.BalootGameController::get_PlayingManager` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52007C4` | `KammelnaOffline.Baloot.BalootGameController::get_BiddingManager` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x5200840` | `KammelnaOffline.Baloot.BalootGameController::CreatePlayer` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52008A4` | `KammelnaOffline.Baloot.BalootOfflinePlayer::.ctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5200934` | `KammelnaOffline.Baloot.BalootOfflinePlayer::.ctor` | inside (+0x90) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5200998` | `KammelnaOffline.Baloot.BalootGameController::CreateAiLogic` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x5200A0C` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5200D14` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x308) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x5200D18` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x30C) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x5200D1C` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x310) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x5200D20` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x314) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x5200D24` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x318) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x5200D28` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x31C) | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) |
| `0x5200EE0` | `KammelnaOffline.Baloot.BalootGameController::OnStartRound` | inside (+0x4D4) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x5200F1C` | `KammelnaOffline.Baloot.BalootGameController::CreateBiddingManager` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x5200FA8` | `KammelnaOffline.Baloot.BalootGameController::CreatePlayingManager` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x5201050` | `KammelnaOffline.Baloot.BalootGameController::OnEndBidding` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201104` | `KammelnaOffline.Baloot.BalootGameController::OnEndBidding` | inside (+0xB4) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5201130` | `KammelnaOffline.Baloot.BalootGameController::OnEndBidding` | inside (+0xE0) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x520115C` | `KammelnaOffline.Baloot.BalootGameController::OnEndBidding` | inside (+0x10C) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5201198` | `KammelnaOffline.Baloot.BalootGameController::OnEndBidding` | inside (+0x148) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5201204` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | method | [بلوت](baloot-spec/06-النقاط-والنتيجة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52013F0` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x1EC) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52013F8` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x1F4) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201404` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x200) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201408` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x204) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520140C` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x208) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201410` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x20C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520141C` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x218) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201420` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x21C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201424` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x220) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5201670` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0x46C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x5201DB0` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0xBAC) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5201E0C` | `KammelnaOffline.Baloot.BalootGameController::OnEndRound` | inside (+0xC08) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5201E74` | `KammelnaOffline.Baloot.BalootGameController::CalculateProjects` | method | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5202460` | `KammelnaOffline.Baloot.BalootUtils::WinnerTeam` | method | [بلوت](baloot-spec/06-النقاط-والنتيجة.md) |
| `0x52024AC` | `KammelnaOffline.Baloot.BalootUtils::BidSuccess` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x5202504` | `KammelnaOffline.Baloot.BalootGameController::AddKabboot` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5202508` | `KammelnaOffline.Baloot.BalootUtils::ProjectValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5202570` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | method | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520281C` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2AC) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202820` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2B0) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202830` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2C0) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202834` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2C4) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x520283C` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2CC) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202840` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2D0) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202844` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2D4) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202848` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2D8) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x520284C` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2DC) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202850` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2E0) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202854` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2E4) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202858` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x2E8) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x52028CC` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x35C) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x52028D4` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x364) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x52028D8` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x368) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202950` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x3E0) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202954` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x3E4) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x52029B0` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x440) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202A10` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x4A0) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5202B60` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x5F0) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5202B68` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x5F8) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5202EAC` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0x93C) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x52034A4` | `KammelnaOffline.Baloot.BalootGameController::OnPlayCard` | inside (+0xF34) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5203520` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckBaloot` | method | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5203998` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckBaloot` | inside (+0x478) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x52039B8` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckBaloot` | inside (+0x498) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5203B3C` | `KammelnaOffline.Baloot.BalootPlayingManager::UpdateDeclaredProjectsFirstMove` | method | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5204064` | `KammelnaOffline.Baloot.BalootPlayingManager::UpdateDeclaredProjectsFirstMove` | inside (+0x528) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x520406C` | `KammelnaOffline.Baloot.BalootPlayingManager::UpdateDeclaredProjectsFirstMove` | inside (+0x530) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5204080` | `KammelnaOffline.Baloot.BalootPlayingManager::UpdateDeclaredProjectsFirstMove` | inside (+0x544) | [بلوت](baloot-spec/04-المشاريع.md) |
| `0x5204374` | `KammelnaOffline.Baloot.BalootUtils::GetBestProjectTeam` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5204714` | `KammelnaOffline.Baloot.BalootPlayingManager::UpdateProjectSecondMove` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5204A5C` | `KammelnaOffline.Baloot.BalootGameController::CheckEkkah` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5204AC4` | `KammelnaOffline.Baloot.BalootGameController::CheckEkkah` | inside (+0x68) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5204C7C` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckEkkah` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5204DD8` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckEkkah` | inside (+0x15C) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5204DE4` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckEkkah` | inside (+0x168) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5204E6C` | `KammelnaOffline.Baloot.BalootPlayingManager::CheckEkkah` | inside (+0x1F0) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52051A0` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52052C8` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x128) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5205320` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x180) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5205378` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x1D8) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x52053D0` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x230) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x52053FC` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x25C) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x520541C` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x27C) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5205624` | `KammelnaOffline.Baloot.BalootGameController::OnEatCard` | inside (+0x484) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5205754` | `KammelnaOffline.Baloot.BalootUtils::CalculateEatingScore` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5205834` | `KammelnaOffline.Baloot.BalootGameController::GetEatingPlayer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520584C` | `KammelnaOffline.Baloot.BalootUtils::CheckWhoEats` | method | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5205FA4` | `KammelnaOffline.Baloot.BalootGameController::GetPlayableCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52060F8` | `KammelnaOffline.Baloot.BalootGameController::GetPlayableCards` | inside (+0x154) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5206244` | `KammelnaOffline.Baloot.BalootGameController::IsGameOver` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5206268` | `KammelnaOffline.Baloot.BalootGameController::OnBid` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520634C` | `KammelnaOffline.Baloot.BalootGameController::OnBid` | inside (+0xE4) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5206378` | `KammelnaOffline.Baloot.BalootGameController::OnBid` | inside (+0x110) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x52065A8` | `KammelnaOffline.Baloot.BalootGameController::OnBid` | inside (+0x340) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x52065D4` | `KammelnaOffline.Baloot.BalootGameController::GetBiddingFromSfsParam` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x5206618` | `KammelnaOffline.Baloot.BalootGameController::GetBiddingFromSfsParam` | inside (+0x44) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5206648` | `KammelnaOffline.Baloot.BalootGameController::BuildRoundState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52069A4` | `KammelnaOffline.Baloot.BalootGameController::BuildRoundState` | inside (+0x35C) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x52069AC` | `KammelnaOffline.Baloot.BalootGameController::BuildRoundState` | inside (+0x364) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x5206A60` | `KammelnaOffline.Baloot.BalootGameController::ShuffleCards` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5206B08` | `KammelnaOffline.Baloot.BalootGameController::CardDistributionFirstPhase` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5206D60` | `KammelnaOffline.Baloot.BalootGameController::CardDistributionSecondPhase` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52071B0` | `KammelnaOffline.Baloot.BalootGameController::CardValue` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x520722C` | `KammelnaOffline.Baloot.BalootGameController::GetOfflineValue` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52073E0` | `KammelnaOffline.Baloot.BalootGameController.<>c__DisplayClass34_0::<BuildRoundState>b__0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52074D8` | `KammelnaOffline.Baloot.BalootGameController.<>c__DisplayClass34_0::<BuildRoundState>b__1` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52075F0` | `KammelnaOffline.Baloot.BalootPlayingManager::StartPlaying` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52079E0` | `KammelnaOffline.Baloot.BalootPlayingManager::StartPlaying` | inside (+0x3F0) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5207AA0` | `KammelnaOffline.Baloot.BalootPlayingManager::OnPlay` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5207D58` | `KammelnaOffline.Baloot.BalootPlayingManager::OnPlay` | inside (+0x2B8) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x5207DB0` | `KammelnaOffline.Baloot.BalootPlayingManager::OnPlay` | inside (+0x310) | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x5207F10` | `KammelnaOffline.Baloot.BalootPlayingManager::OnPlay` | inside (+0x470) | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x5207F50` | `KammelnaOffline.Baloot.BalootUtils::GetBestProjects` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x5207FC4` | `KammelnaOffline.Baloot.BalootUtils::CheckProjects` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5208148` | `KammelnaOffline.Baloot.BalootUtils::CheckProjects` | inside (+0x184) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5208414` | `KammelnaOffline.Baloot.BalootUtils::CheckProjects` | inside (+0x450) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5208560` | `KammelnaOffline.Baloot.BalootUtils::CheckProjects` | inside (+0x59C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5208804` | `KammelnaOffline.Baloot.BalootPlayingManager::CopyCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5208904` | `KammelnaOffline.Baloot.BalootPlayingManager::ClearPlayersVariables` | method | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5208ACC` | `KammelnaOffline.Baloot.BalootUtils::CheckIfCardEats` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5208E88` | `KammelnaOffline.Baloot.BalootPlayingManager.<>c::<UpdateDeclaredProjectsFirstMove>b__4_2` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5209034` | `KammelnaOffline.Baloot.BalootUtils::CheckProject400` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52092D8` | `KammelnaOffline.Baloot.BalootUtils::CheckProject100` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5209374` | `KammelnaOffline.Baloot.BalootUtils::CheckProject50` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5209380` | `KammelnaOffline.Baloot.BalootUtils::CheckProjectSira` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520938C` | `KammelnaOffline.Baloot.BalootUtils::CheckProject100Sequence` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5209398` | `KammelnaOffline.Baloot.BalootUtils::CheckProject100SameRank` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5209744` | `KammelnaOffline.Baloot.BalootUtils::FindSequenceProject` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A394` | `KammelnaOffline.Baloot.BalootUtils::GetCardValueRank` | method | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A3F0` | `KammelnaOffline.Baloot.BalootUtils::GetCardValueForScores` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x520A438` | `KammelnaOffline.Baloot.BalootUtils::GetCardValueForScores` | inside (+0x48) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x520A468` | `KammelnaOffline.Baloot.BalootUtils::ContainsRank` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A5C0` | `KammelnaOffline.Baloot.BalootUtils.<>c::<CheckProject400>b__2_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A64C` | `KammelnaOffline.Baloot.BalootUtils.<>c::<CheckProject100SameRank>b__4_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A684` | `KammelnaOffline.Baloot.BalootUtils.<>c::<CheckProject100SameRank>b__4_2` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A8AC` | `KammelnaOffline.Baloot.BalootUtils.<>c__DisplayClass16_0::<CalculateEatingScore>b__0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x520A91C` | `KammelnaOffline.Baloot.BalootUtils.<>c__DisplayClass16_0::<CalculateEatingScore>b__0` | inside (+0x70) | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x520A9C8` | `KammelnaOffline.Baloot.Tutorial.BalootTutorialAiLogic::get__gameController` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x520AA44` | `KammelnaOffline.Baloot.Tutorial.BalootTutorialAiLogic::.ctor` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x520AA78` | `KammelnaOffline.Baloot.Tutorial.BalootTutorialAiLogic::PlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520ACD4` | `KammelnaOffline.Baloot.Tutorial.BalootTutorialAiLogic::Bid` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520AEE8` | `KammelnaOffline.Baloot.Tutorial.BalootTutorialAiLogic::GetAction` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520B028` | `KammelnaOffline.Baloot.Tutorial.TutorialCards::GetDistributionFirstPhase` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520B25C` | `KammelnaOffline.Baloot.Tutorial.TutorialCards::GetDistributionSecondPhase` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520B490` | `KammelnaOffline.Baloot.Tutorial.TutorialCards::GetFloor` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520B5D4` | `KammelnaOffline.Baloot.Tutorial.TutorialCards::GetHandSFSArray` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x520B698` | `KammelnaOffline.Baloot.Tutorial.TutorialCards::AddArrayCards` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x520B8E4` | `KammelnaOffline.Baloot.Tutorial.TutorialCards::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [بلوت](baloot-spec/refs/tutorial-lessons.md) |
| `0x521DA04` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::get_TutorialType` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DA0C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::get_LastTutorialGame` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x521DA58` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::set_LastTutorialGame` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x521DAB4` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::.ctor` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DB84` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CreateAiLogic` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DBEC` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::InitializeGame` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DC60` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::InitializeGame` | inside (+0x74) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DC6C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::InitializeGame` | inside (+0x80) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DC8C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::InitializeGame` | inside (+0xA0) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DCA8` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::InitializeGame` | inside (+0xBC) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DCB0` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::InitializeTutorialGame` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DD54` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::StartGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x521DF40` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::ResetTrackLogic` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521DFDC` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CardDistributionFirstPhase` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521E0C8` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CardsTutorialFirstPhase` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521E2A4` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CardDistributionSecondPhase` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521E3DC` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CardsTutorialSecPhase` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521E60C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CheckEkkah` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/tutorial-lessons.md) |
| `0x521E70C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CatchCheating` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x521ECB4` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::CatchCheating` | inside (+0x5A8) | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x521ED10` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::SetUpCheatingData` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x521F034` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::OnPlayCard` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F07C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::TrackPlayedCards` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F1E0` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::GetEatingsSFSArray` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x521F62C` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::GetHandSFSArray` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F6C8` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::AddArrayCards` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F824` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::AddArrayCards` | inside (+0x15C) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F848` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::AddArrayCards` | inside (+0x180) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F850` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::AddArrayCards` | inside (+0x188) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F898` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::AddArrayCards` | inside (+0x1D0) | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x521F914` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::SendGameState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x521FC00` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::GetWantedToPlayCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52203CC` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::OnEndRound` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x5220514` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::DiscardOfflineGame` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x5220518` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController::UpdateOfflineGameStats` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x52205B0` | `KammelnaOffline.Baloot.Tutorial.TutorialGameController.<>c::<AddArrayCards>b__30_0` | method | [بلوت](baloot-spec/17-محرّك-التعليم-مفكوكًا.md) |
| `0x5220860` | `KammelnaOffline.Baloot.Tutorial.TutorialTypeExtensions::IsCatchTutorial` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/tutorial-lessons.md) |
| `0x52208CC` | `Features.GameReplay.ReplayEventConverter::ReadJson` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220918` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0x4C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220960` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0x94) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220968` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0x9C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522096C` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0xA0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522097C` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0xB0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52209AC` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0xE0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52209C8` | `Features.GameReplay.ReplayEventConverter::ReadJson` | inside (+0xFC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220A24` | `Features.GameReplay.ReplayEvent::GetType` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220DF4` | `Features.GameReplay.ReplayEvent::GetType` | inside (+0x3D0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220E10` | `Features.GameReplay.ReplayEvent::Deserialize` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220E54` | `Features.GameReplay.ReplayEvent::Deserialize` | inside (+0x44) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220E70` | `Features.GameReplay.ReplayEvent::Deserialize` | inside (+0x60) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220F24` | `Features.GameReplay.CardConverter::WriteJson` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220F40` | `Features.GameReplay.CardConverter::WriteJson` | inside (+0x1C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220F50` | `Features.GameReplay.CardConverter::WriteJson` | inside (+0x2C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220F64` | `Features.GameReplay.CardConverter::WriteJson` | inside (+0x40) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5220F6C` | `Features.GameReplay.CardConverter::ReadJson` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522106C` | `Features.GameReplay.BoolConverter::WriteJson` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221074` | `Features.GameReplay.BoolConverter::WriteJson` | inside (+0x8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221088` | `Features.GameReplay.BoolConverter::WriteJson` | inside (+0x1C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221098` | `Features.GameReplay.BoolConverter::ReadJson` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221228` | `Features.GameReplay.BoolArrayConverter::ReadJson` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52213BC` | `Features.GameReplay.BoolArrayConverter::WriteJson` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522140C` | `Features.GameReplay.BoolArrayConverter::WriteJson` | inside (+0x50) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221458` | `Features.GameReplay.BoolArrayConverter::WriteJson` | inside (+0x9C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221498` | `Features.GameReplay.BoolArrayConverter::WriteJson` | inside (+0xDC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221544` | `Features.GameReplay.BoolArrayConverter.<>c::<ReadJson>b__2_0` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52216F4` | `Features.GameReplay.GameReplay::SetTeamsScore` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52219D8` | `Features.GameReplay.GameReplay::AddReplayEvent` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221A7C` | `Features.GameReplay.GameReplay::RemoveComments` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221C80` | `Features.GameReplay.GameReplay::.ctor` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221D14` | `Features.GameReplay.GameReplay::.ctor` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5221F0C` | `Features.GameReplay.GameReplay::.ctor` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52220AC` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x1A0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52220D4` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x1C8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52221E8` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x2DC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522222C` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x320) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522223C` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x330) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222270` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x364) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222284` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x378) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222294` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x388) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222338` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x42C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52223E8` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x4DC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222498` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x58C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222548` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x63C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52225F8` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x6EC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52226A8` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x79C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222758` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x84C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222778` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x86C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52227C4` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x8B8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52227E8` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x8DC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52227EC` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x8E0) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222828` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x91C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222850` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x944) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222860` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x954) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222870` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x964) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222880` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x974) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52228B0` | `Features.GameReplay.GameReplay::.ctor` | inside (+0x9A4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222900` | `Features.GameReplay.GameReplay::.ctor` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222BC0` | `Features.GameReplay.GameReplayExtensions::Serialize` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222C2C` | `Features.GameReplay.GameReplayUtils::IsAllowedVersion` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222CB0` | `Features.GameReplay.GameReplayController::.ctor` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222DA8` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0xF8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222DB0` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x100) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222DCC` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x11C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222DE4` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x134) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222E10` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x160) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222E3C` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x18C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222E90` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x1E0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222EEC` | `Features.GameReplay.GameReplayController::.ctor` | inside (+0x23C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5222FC0` | `Features.GameReplay.GameReplayController::get_Players` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5223040` | `Features.GameReplay.GameReplayController::ToggleSpeedMultiplier` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52232F4` | `Features.GameReplay.GameReplayController::TogglePause` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5223550` | `Features.GameReplay.GameReplayController::HandleChatMessages` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5223A8C` | `Features.GameReplay.GameReplayController::HandleJoinLeave` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5224378` | `Features.GameReplay.GameReplayController::SetAklasIndices` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52246B0` | `Features.GameReplay.GameReplayController::GoToNextAkla` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52249D4` | `Features.GameReplay.GameReplayController::GoToAkla` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5225720` | `Features.GameReplay.GameReplayController::RemoveAlreadyPlayedCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5225F0C` | `Features.GameReplay.GameReplayController::AddEmptyDeclaredProjects` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5226300` | `Features.GameReplay.GameReplayController::AddEmptyProjectsCards` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5226BD4` | `Features.GameReplay.GameReplayController::FastPlay` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5226FF4` | `Features.GameReplay.GameReplayController::OnChat` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5227160` | `Features.GameReplay.GameReplayController::OnGift` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522752C` | `Features.GameReplay.EventsExtensions::GetReplayEvents` | inside (+0x104) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5227BD4` | `Features.GameReplay.GameReplayController::BuildRoundState` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5227EE8` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x314) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5227F70` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x39C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5227FEC` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x418) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228074` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x4A0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228088` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x4B4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522809C` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x4C8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52280A8` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x4D4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228204` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x630) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228218` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x644) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522834C` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x778) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228400` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x82C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228470` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x89C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228478` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x8A4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522848C` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x8B8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52284A4` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x8D0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228748` | `Features.GameReplay.GameReplayController::Reset` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228760` | `Features.GameReplay.GameReplayController::ApplyWaraqEvent` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228BD4` | `Features.GameReplay.GameReplayController::OnBid` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228C8C` | `Features.GameReplay.GameReplayController::PrepareEndBidState` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5228F58` | `Features.GameReplay.GameReplayController::OnKashoIe` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5229010` | `Features.GameReplay.GameReplayController::OnSawaIe` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52290C8` | `Features.GameReplay.GameReplayController::OnComment` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52293A8` | `Features.GameReplay.GameReplayController::OnPlayCard` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5229684` | `Features.GameReplay.GameReplayController::OnDeclareProject` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522A470` | `Features.GameReplay.GameReplayController::PlayCard` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522A640` | `Features.GameReplay.GameReplayController::PlayCard` | inside (+0x1D0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522A664` | `Features.GameReplay.GameReplayController::PlayCard` | inside (+0x1F4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522A708` | `Features.GameReplay.GameReplayController::PlayCard` | inside (+0x298) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522AE34` | `Features.GameReplay.GameReplayController::OnEatCard` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B1A0` | `Features.GameReplay.GameReplayController::CatchCheating` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B2D0` | `Features.GameReplay.GameReplayController::CatchCheating` | inside (+0x130) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B58C` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B87C` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x2F0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B8B8` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x32C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B8C4` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x338) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522B8DC` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x350) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522BAA4` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x518) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522BC70` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x6E4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522BC8C` | `Features.GameReplay.GameReplayController::SetUpCheatingData` | inside (+0x700) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522C3D0` | `Features.GameReplay.GameReplayController::SendScoreEndRound` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522C7E0` | `Features.GameReplay.GameReplayController::TeamProjectToSfs` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522CC14` | `Features.GameReplay.GameReplayController::OnEndGameEvent` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522DBBC` | `Features.GameReplay.GameReplayController::get_BiddingManager` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522DDA4` | `Features.GameReplay.GameReplayController::BuildRoundState` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522DF50` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x1AC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522DF80` | `Features.GameReplay.GameReplayController::BuildRoundState` | inside (+0x1DC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x522E810` | `Features.GameReplay.GameReplayController::CreateAiLogic` | method | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) |
| `0x522E838` | `Features.GameReplay.GameReplayController::AcceptNextMove` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x522E8C4` | `Features.GameReplay.GameReplayController::GetBiddingFromSfsParam` | inside (+0x48) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5230C98` | `Features.GameReplay.RoundEvent::DeserializeObjects` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5230DB8` | `Features.GameReplay.ReplayEvent::DeserializeObjects` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5231190` | `Features.GameReplay.ReplayEvent::DeserializeObjects` | inside (+0x3D8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5231198` | `Features.GameReplay.ReplayEvent::DeserializeObjects` | inside (+0x3E0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5231588` | `Features.GameReplay.ReplayEvent::DeserializeObjects` | inside (+0x7D0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5232BFC` | `Features.GameReplay.EventsExtensions::GetReplayEventsRange` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5232FD8` | `Features.GameReplay.EventsExtensions::GetReplayEventsBefore` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233798` | `Features.GameReplay.GameReplayManager::Start` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233840` | `Features.GameReplay.GameReplayManager::Start` | inside (+0xA8) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233B50` | `Features.GameReplay.GameReplayManager::Start` | inside (+0x3B8) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233B54` | `Features.GameReplay.GameReplayManager::SaveAllowed` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233B74` | `Features.GameReplay.GameReplayManager::RegisterEvents` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233C28` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0xB4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233C90` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x11C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233D00` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x18C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233D70` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x1FC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233DE8` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x274) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233E78` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x304) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233EA0` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x32C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233EC8` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x354) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233F40` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x3CC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5233FB8` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x444) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5234030` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x4BC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52340B8` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x544) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52340E0` | `Features.GameReplay.GameReplayManager::RegisterEvents` | inside (+0x56C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235760` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235814` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0xB4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523587C` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x11C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52358EC` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x18C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523595C` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x1FC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52359D4` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x274) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235A64` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x304) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235A8C` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x32C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235AB4` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x354) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235B2C` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x3CC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235BA4` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x444) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235C1C` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x4BC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235CA4` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x544) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235CCC` | `Features.GameReplay.GameReplayManager::UnregisterEvents` | inside (+0x56C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5235F58` | `Features.GameReplay.GameReplayManager::OnUserVariableUpdate` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x52360F8` | `Features.GameReplay.GameReplayManager::SaveGameReplayGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x5236394` | `Features.GameReplay.GameReplayManager::SaveGameReplayGame` | inside (+0x29C) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x52363A4` | `Features.GameReplay.GameReplayManager::SaveGameReplayGame` | inside (+0x2AC) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x52363A8` | `Features.GameReplay.GameReplayManager::SaveGameReplayGame` | inside (+0x2B0) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x52364B4` | `Features.GameReplay.GameReplayManager::SaveGameReplayGame` | inside (+0x3BC) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x5236834` | `Features.GameReplay.GameReplayManager::OnRoundStart` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523693C` | `Features.GameReplay.GameReplayManager::OnRoundStart` | inside (+0x108) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5236A60` | `Features.GameReplay.GameReplayManager::OnRoundStart` | inside (+0x22C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5236B0C` | `Features.GameReplay.GameReplayManager::OnRoundStart` | inside (+0x2D8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5236BCC` | `Features.GameReplay.GameReplayManager::OnRoundStart` | inside (+0x398) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5236C0C` | `Features.GameReplay.GameReplayManager::OnRoundStart` | inside (+0x3D8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5236C18` | `Features.GameReplay.GameReplayManager::OnRoundStart` | inside (+0x3E4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5236CD8` | `Features.GameReplay.GameReplayManager::AddWatchersFromLobby` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523702C` | `Features.GameReplay.GameReplayManager::AddWaraqEvent` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52371C0` | `Features.GameReplay.GameReplayManager::GetScores` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523738C` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237594` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x208) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237600` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x274) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237810` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x484) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52378C0` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x534) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523791C` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x590) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237990` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x604) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52379E0` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x654) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237A14` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x688) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237A5C` | `Features.GameReplay.GameReplayManager::OnDidLastAction` | inside (+0x6D0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237AE4` | `Features.GameReplay.GameReplayManager::OnGiftSent` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237B8C` | `Features.GameReplay.GameReplayManager::OnSawa` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237C18` | `Features.GameReplay.GameReplayManager::OnKasho` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237CA4` | `Features.GameReplay.GameReplayManager::OnCheating` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237E34` | `Features.GameReplay.GameReplayManager::OnCheating` | inside (+0x190) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237E68` | `Features.GameReplay.GameReplayManager::OnPublicMessage` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5237FAC` | `Features.GameReplay.GameReplayManager::OnRoundEnd` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523800C` | `Features.GameReplay.GameReplayManager::OnRoundEnd` | inside (+0x60) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238174` | `Features.GameReplay.GameReplayManager::OnGameEnd` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238238` | `Features.GameReplay.GameReplayManager::OnGameEnd` | inside (+0xC4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52382E4` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52383B8` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | inside (+0xD4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52384AC` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | inside (+0x1C8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52385B0` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | inside (+0x2CC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52387B0` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | inside (+0x4CC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52388B8` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | inside (+0x5D4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238B68` | `Features.GameReplay.GameReplayManager::AddDealtCardEvent` | inside (+0x884) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238BAC` | `Features.GameReplay.GameReplayManager::OnCardGameEnd` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238D4C` | `Features.GameReplay.GameReplayManager::OnCardGameEnd` | inside (+0x1A0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238D58` | `Features.GameReplay.GameReplayManager::OnCardGameEnd` | inside (+0x1AC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238DE4` | `Features.GameReplay.GameReplayManager::OnCardGameEnd` | inside (+0x238) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238EC4` | `Features.GameReplay.GameReplayManager::OnCardGameEnd` | inside (+0x318) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5238F58` | `Features.GameReplay.GameReplayManager::OnUserLeaveRoom` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5239160` | `Features.GameReplay.GameReplayManager::AddJoinEvent` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523932C` | `Features.GameReplay.GameReplayManager::get_SavingPath` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52393C4` | `Features.GameReplay.GameReplayManager::get_SavingPath` | inside (+0x98) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52393E8` | `Features.GameReplay.GameReplayManager::get_SavingPath` | inside (+0xBC) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5239404` | `Features.GameReplay.GameReplayManager::get_SavingPath` | inside (+0xD8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5239860` | `Features.GameReplay.GameReplayManager::GoToReplay` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x5239A80` | `Features.GameReplay.GameReplayManager::SaveGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x5239C6C` | `Features.GameReplay.GameReplayManager::EditComment` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x5239EF8` | `Features.GameReplay.GameReplayManager::DeleteComment` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x523A15C` | `Features.GameReplay.GameReplayManager::AddComment` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x523A628` | `Features.GameReplay.GameReplayManager::GetAllSavedGames` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523A72C` | `Features.GameReplay.GameReplayManager::get_GameReplays` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523A7A8` | `Features.GameReplay.GameReplayManager::GetAllSavedGamesWeb` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x523A830` | `Features.GameReplay.GameReplayManager::DeleteGameReplay` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523A8F0` | `Features.GameReplay.GameReplayManager::Share` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x523AD74` | `Features.GameReplay.GameReplayManager::.cctor` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x523B8A8` | `Features.GameReplay.GameReplayManager.<GetAllSavedGames>d__108::MoveNext` | inside (+0x1C0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523BA5C` | `Features.GameReplay.GameReplayManager.<GetAllSavedGames>d__108::MoveNext` | inside (+0x374) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523BA88` | `Features.GameReplay.GameReplayManager.<GetAllSavedGames>d__108::MoveNext` | inside (+0x3A0) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523BEFC` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C0E8` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x1EC) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C110` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x214) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C14C` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x250) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C208` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x30C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C264` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x368) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C438` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x53C) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x523C4CC` | `Features.GameReplay.GameReplayManager.<GetAllSavedGamesWeb>d__112::MoveNext` | inside (+0x5D0) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243C0C` | `Features.GameReplay.GameReplayCardData::FromGameReplay` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243C74` | `Features.GameReplay.GameReplayCardData::FromGameReplay` | inside (+0x68) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243C7C` | `Features.GameReplay.GameReplayCardData::FromGameReplay` | inside (+0x70) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243CA0` | `Features.GameReplay.GameReplayCardData::BuildDisplayData` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243CD8` | `Features.GameReplay.GameReplayCardData::BuildDisplayData` | inside (+0x38) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243CE0` | `Features.GameReplay.GameReplayCardData::BuildDisplayData` | inside (+0x40) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243D94` | `Features.GameReplay.GameReplayCardData::BuildDisplayData` | inside (+0xF4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243E64` | `Features.GameReplay.GameReplayCardData::BuildDisplayData` | inside (+0x1C4) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243F48` | `Features.GameReplay.GameReplayCardData::BuildDisplayData` | inside (+0x2A8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5243F70` | `Features.GameReplay.GameReplayCardData::GenerateColorTheme` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x5244038` | `Features.GameReplay.GameReplayCardData::GenerateColorTheme` | inside (+0xC8) | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x52441B4` | `Features.GameReplay.GameReplayListUI::OnEnable` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x524542C` | `Features.GameReplay.GameReplayListUI.<GetGameReplays>d__9::MoveNext` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x524553C` | `Features.GameReplay.GameReplayListUI.<GetGameReplays>d__9::MoveNext` | inside (+0x110) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52455D4` | `Features.GameReplay.GameReplayListUI.<GetGameReplays>d__9::MoveNext` | inside (+0x1A8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52456F4` | `Features.GameReplay.GameReplayListUI.<GetGameReplays>d__9::MoveNext` | inside (+0x2C8) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x524589C` | `Features.GameReplay.GameReplayListUI.<GetGameReplays>d__9::MoveNext` | inside (+0x470) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x5245E10` | `Kammelna.Features.Clans.ClanUtils::GetClanChatTag` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5245E8C` | `Kammelna.Features.Clans.ClanUtils::IsClanChatTag` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x52465BC` | `Kammelna.Server.ContentApplier::ApplyChanged` | inside (+0x54) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x5246878` | `Kammelna.Server.ContentPushService::OnContentChangedReceived` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x5246910` | `Kammelna.Server.ContentPushService::OnContentChangedReceived` | inside (+0x98) | [بيانات](data-spec/05-محرّك-الدلتا-مفكوكًا.md) |
| `0x5246968` | `Kammelna.Server.ContentPushService::OnContentDeltaReceived` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x5246A6C` | `Kammelna.Server.ContentPushService::OnContentBlobReceived` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x5247838` | `Kammelna.Server.ContentPushService::BuildCatalog` | method | [بيانات](data-spec/01-طبقة-البيانات.md) · [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x52495BC` | `Kammelna.Server.ContentPushService::Apply` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x524A080` | `Kammelna.Server.ContentSyncService::EnsureFresh` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x524B5CC` | `Kammelna.Server.ContentSyncService::Fetch` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x524BB90` | `Kammelna.Server.ContentSyncService::CatchUpAll` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x524C0A8` | `Kammelna.Server.ContentSyncService::Rebaseline` | method | [بيانات](data-spec/01-طبقة-البيانات.md) |
| `0x5250590` | `Kammelna.Server.CoordinatorService::SendGameInvitations` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x5250824` | `Kammelna.Server.CoordinatorService::SendGameInvitations` | inside (+0x294) | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x525166C` | `Kammelna.Server.CoordinatorVariableBinder::DispatchUpdate` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x5251830` | `Kammelna.Server.CoordinatorVariableBinder::Bind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x5251968` | `Kammelna.Server.CoordinatorVariableBinder::BindInternal` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x5251DB0` | `Kammelna.Server.CoordinatorVariableBinder::Unbind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x52523C8` | `Kammelna.Server.CoordinatorVariableBinder::GetCurrent` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x52524E0` | `Kammelna.Server.CoordinatorVariableBinder::ClearCached` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x52527F0` | `Kammelna.Server.CoordinatorVariableBinder::DispatchAllForScope` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x5252BB4` | `Kammelna.Server.CoordinatorVariableBinder::ReWire` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x5252D38` | `Kammelna.Server.CoordinatorVariableBinder::ClearNulls` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x5253690` | `Kammelna.Server.CoordinatorVariableBinder::SafelyDispatchBindActions` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x5253BD0` | `Kammelna.Server.CoordinatorVariableBinder.<>c__DisplayClass9_0::<BindInternal>b__0` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x5253EDC` | `Kammelna.Server.SignalRWebSocketConnector::Connect` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5253FE0` | `Kammelna.Server.SignalRWebSocketConnector::Connect` | inside (+0x104) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5254590` | `Kammelna.Server.SignalRWebSocketConnector::SetHandlers` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x525B668` | `Kammelna.Server.SFS::ClanGameRooms` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x525CB04` | `Kammelna.Server.SFS::GoToReplay` | method | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) |
| `0x525D56C` | `Kammelna.Server.SFS::SFS_OnConnectionLost` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525DCA4` | `Kammelna.Server.SFS::SFS_OnLogout` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525E3B0` | `Kammelna.Server.SFS::SFS_OnLogin` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525EAF0` | `Kammelna.Server.SFS::SFS_OnExtensionResponse` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) · [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x525F0C4` | `Kammelna.Server.SFS::SFS_OnPublicMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x525FABC` | `Kammelna.Server.SFS::SFS_OnJoinRoom` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525FCA8` | `Kammelna.Server.SFS::SFS_OnJoinRoom` | inside (+0x1EC) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525FCD4` | `Kammelna.Server.SFS::SFS_OnJoinRoom` | inside (+0x218) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525FCDC` | `Kammelna.Server.SFS::SFS_OnJoinRoom` | inside (+0x220) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525FCF0` | `Kammelna.Server.SFS::SFS_OnJoinRoom` | inside (+0x234) | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x525FCFC` | `Kammelna.Server.SFS::SFS_OnJoinRoom` | inside (+0x240) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x52617C4` | `Kammelna.Server.SFS::SFS_OnAdminMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5261B2C` | `Kammelna.Server.SFS::SendRoomExtensionRequest` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [ردهة](lobby-spec/01-البروتوكول-والغرف.md) · [اجتماعي](social-spec/01-المعمارية-والدردشة.md) · [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5261CC8` | `Kammelna.Server.SFS::SendZoneExtensionRequest` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) · [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5261E08` | `Kammelna.Server.SFS::Login` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) · [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x5262214` | `Kammelna.Server.SFS::Logout` | method | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x5262410` | `Kammelna.Server.SFS::Logout` | inside (+0x1FC) | [اجتماعي](social-spec/04-نظام-الإحالة.md) |
| `0x526255C` | `Kammelna.Server.SFS::CreateRoom` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5262BFC` | `Kammelna.Server.SFS::JoinLobby` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5262F38` | `Kammelna.Server.SFS::JoinRoomGroup` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5262FD4` | `Kammelna.Server.SFS::JoinGameRoom` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x52630E8` | `Kammelna.Server.SFS::SendChatMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x52631C4` | `Kammelna.Server.SFS::SendChatMessage` | inside (+0xDC) | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x52631C8` | `Kammelna.Server.SFS::AnnounceBeggarBan` | method | [اجتماعي](social-spec/06-الملف-الشخصي.md) |
| `0x5263CDC` | `Kammelna.Server.SFS::SendPinMessage` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5263E64` | `Kammelna.Server.SFS::CheckIsOnline` | method | [اجتماعي](social-spec/02-الأصدقاء-والحضور.md) |
| `0x5264190` | `Kammelna.Server.SFS::JoinTournamentRoom` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x526425C` | `Kammelna.Server.SFS::JoinSpawnerTournament` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x52642D4` | `Kammelna.Server.SFS::SendTournamentRoomLoaded` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x526431C` | `Kammelna.Server.SFS::WatchTournamentMatch` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5264394` | `Kammelna.Server.SFS::SendLoadTournamentRequest` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x526440C` | `Kammelna.Server.SFS::ParticipateTournament` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x52649E4` | `Kammelna.Server.SFS::ForfeitTournament` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5264B5C` | `Kammelna.Server.SFS::GetMyTournaments` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5264C7C` | `Kammelna.Server.SFS::SendEnableTournamentWatchersChat` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5264CF4` | `Kammelna.Server.SFS::JoinMassTournamentRoom` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5264DC0` | `Kammelna.Server.SFS::ParticipateMassTournament` | method | [ردهة](lobby-spec/03-البطولات.md) |
| `0x5264F88` | `Kammelna.Server.SFS::GetMassWinnersList` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x52650BC` | `Kammelna.Server.SFS::GetMassTournamentStagesSummery` | method | [ردهة](lobby-spec/04-البطولات-الجماهيرية.md) |
| `0x52651F0` | `Kammelna.Server.SFS::SendClaimCurrencyBomb` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) · [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5265604` | `Kammelna.Server.SFS::GetRecentGiftBombs` | method | [اقتصاد](economy-spec/01-الاقتصاد-الكامل.md) |
| `0x52657A8` | `Kammelna.Server.SFS::SendChatPinnedAvatarParticle` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5265868` | `Kammelna.Server.SFS::SendFindMatch` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) · [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x526599C` | `Kammelna.Server.SFS::SendStopFindMatch` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) · [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x5265C54` | `Kammelna.Server.SFS::RankedMatch` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x5265CCC` | `Kammelna.Server.SFS::FriendlyMatch` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x5265D40` | `Kammelna.Server.SFS::SendControlChat` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5265E20` | `Kammelna.Server.SFS::SendChangeRoomName` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5265ECC` | `Kammelna.Server.SFS::SendDeleteRoom` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x5265F6C` | `Kammelna.Server.SFS::SendLockedRoomRequest` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) · [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x526602C` | `Kammelna.Server.SFS::SetVivoxMicStatus` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52660A4` | `Kammelna.Server.SFS::RefreshClanMembership` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x5268E7C` | `Kammelna.Server.SFS.<>c__DisplayClass371_0::<SendStopFindMatch>b__0` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x52692AC` | `Kammelna.Server.Authentication::SetToken` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x52695BC` | `Kammelna.Server.VariableBinder::GetBindID` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526969C` | `Kammelna.Server.VariableBinder::GetBindID` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526977C` | `Kammelna.Server.VariableBinder::.ctor` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x5269918` | `Kammelna.Server.VariableBinder::OnRoomVariableUpdate` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x52699F0` | `Kammelna.Server.VariableBinder::Bind` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x5269E68` | `Kammelna.Server.VariableBinder::Bind` | inside (+0x478) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x5269F90` | `Kammelna.Server.VariableBinder::Unbind` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526A5B0` | `Kammelna.Server.VariableBinder::DispatchUpdate` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526A648` | `Kammelna.Server.VariableBinder::DispatchUpdate` | inside (+0x98) | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526AA78` | `Kammelna.Server.VariableBinder::ClearNulls` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526AF14` | `Kammelna.Server.VariableBinder::ClearNulls` | inside (+0x49C) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526B28C` | `Kammelna.Server.VariableBinder::ClearNulls` | inside (+0x814) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526B3D0` | `Kammelna.Server.VariableBinder::SafelyDispatchBindActions` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526B4A8` | `Kammelna.Server.VariableBinder::SafelyDispatchBindActions` | inside (+0xD8) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526B5F0` | `Kammelna.Server.VariableBinder::DispatchAllBoundedVars` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526B66C` | `Kammelna.Server.VariableBinder::DispatchAllBoundedVars` | inside (+0x7C) | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526BA18` | `Kammelna.Server.VariableBinder::ReWire` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526BA5C` | `Kammelna.Server.VariableBinder::ReWire` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526BDA0` | `Kammelna.Server.VariableBinder::ReWire` | inside (+0x344) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526BDA4` | `Kammelna.Server.VariableBinder::ReWire` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526BE54` | `Kammelna.Server.VariableBinder.<>c::<ClearNulls>b__15_2` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526BEAC` | `Kammelna.Server.VariableBinder.<>c::<ClearNulls>b__15_2` | inside (+0x58) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526BEC4` | `Kammelna.Server.VariableBinder.<>c::<ClearNulls>b__15_0` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526BFF8` | `Kammelna.Server.VariableBinder.<>c::<ClearNulls>b__15_3` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C038` | `Kammelna.Server.VariableBinder.<>c::<ClearNulls>b__15_1` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C078` | `Kammelna.Server.VariableBinder.<>c__DisplayClass8_0::<Unbind>b__0` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526C198` | `Kammelna.Server.VariableBinder.<>c__DisplayClass9_0::<Bind>b__0` | inside (+0xA4) | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526C1DC` | `Kammelna.Server.BindAction::get_Owner` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526C1E4` | `Kammelna.Server.BindAction::set_Owner` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526C250` | `Kammelna.Server.VariableBinderExtensions::Bind` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) · [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C340` | `Kammelna.Server.VariableBinderExtensions::Bind` | inside (+0xF0) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526C360` | `Kammelna.Server.VariableBinderExtensions::Bind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C460` | `Kammelna.Server.VariableBinderExtensions::Bind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C598` | `Kammelna.Server.VariableBinderExtensions::Bind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C6CC` | `Kammelna.Server.VariableBinderExtensions::Bind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x526C7F0` | `Kammelna.Server.VariableBinderExtensions::Unbind` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) · [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x526DE74` | `Kammelna.Server.WebRequests.RefreshAuthTokenRequest::SegmentClaims` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x526E364` | `Kammelna.Server.WebRequests.RefreshAuthTokenRequest::DecodeBase64Url` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x52727CC` | `Kammelna.Server.WebRequests.ClientContext::GetRequestHeaders` | method | [مصادقة](auth-spec/01-الإقلاع-والمصادقة.md) |
| `0x527309C` | `Kammelna.Server.WebRequests.GetRemoteConfigRequest::get_EndPoint` | method | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x52730CC` | `Kammelna.Server.WebRequests.GetRemoteConfigRequest::get_EndPoint` | inside (+0x30) | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x52730F8` | `Kammelna.Server.WebRequests.GetRemoteConfigRequest::get_EndPoint` | inside (+0x5C) | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x5276F90` | `Kammelna.Server.WebRequests.SetDefaultItemRequest::get_Method` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5276F98` | `Kammelna.Server.WebRequests.SetDefaultItemRequest::get_EndPoint` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) · [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x5277000` | `Kammelna.Server.WebRequests.SetDefaultItemRequest::get_EndPoint` | inside (+0x68) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5277040` | `Kammelna.Server.WebRequests.SetDefaultItemRequest::get_EndPoint` | inside (+0xA8) | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x5277808` | `Kammelna.Server.WebRequests.GetPredictionSeasonRewardRequest::.ctor` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x52786D0` | `Kammelna.Server.WebRequests.ActivateCodeRequest::get_EndPoint` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x5279598` | `Kammelna.Server.WebRequests.BuyConsumableProductRequest::OnSuccess` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x52796E4` | `Kammelna.Server.WebRequests.BuySubscriptionRequest::OnSuccess` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x527A37C` | `Kammelna.Server.WebRequests.CreateTournamentRequest::OnSuccess` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x5281690` | `Managers.IAP.StoreKitManager::CanUseStoreKit2` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x52818A4` | `Managers.IAP.StoreKitManager::FetchReceipt` | method | [اقتصاد](economy-spec/03-المشتريات-داخل-التطبيق.md) |
| `0x5284B54` | `Util.DateTimeUtil::GetPartOfDay` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x5284F7C` | `Util.DateTimeUtil::GetDurationText` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x5285008` | `Util.DateTimeUtil::AmPmTime` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x528539C` | `Util.DateTimeUtil::GetAmountForUnit` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x52855F8` | `Util.DateTimeUtil::GetMonthName` | method | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x5294770` | `ClanVaultPanel::Initialize` | inside (+0x1A4) | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x52A2678` | `ClanChatBox::SyncClanGameCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52A4318` | `Util.NotificationPermissionUtils::get_FcmToken` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x52A45CC` | `Util.NotificationPermissionUtils::InitializeNotifications` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x52A4AC8` | `Util.NotificationPermissionUtils::HandleNewToken` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x52A4D00` | `Util.NotificationPermissionUtils::OnUserLoggedIn` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x52A5058` | `Util.NotificationPermissionUtils::OnMessageReceived` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x52A5128` | `Util.NotificationPermissionUtils::<OnMessageReceived>g__TrackNotificationOpened|21_0` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x52A5C70` | `Util.SfsObjectUtil::FromOneValue` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A62D4` | `Util.SfsRequestListener::SendZoneRequest` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x52A64D8` | `Util.SfsRequestListener::GenerateRequestId` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x52A653C` | `Util.SfsRequestListener::SendRoomRequest` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x52A6740` | `Util.SfsRequestListener::OnExtensionResponse` | method | [ردهة](lobby-spec/01-البروتوكول-والغرف.md) |
| `0x52A7618` | `Util.VivoxAuthUtil::vxGenerateLoginToken` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A76A8` | `Util.VivoxAuthUtil::vxGenerateToken` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A7A1C` | `Util.VivoxAuthUtil::vxGenerateJoinToken` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A7AA4` | `Util.VivoxAuthUtil::getSerial` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A7B98` | `Util.VivoxAuthUtil::Base64URLEncode` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A7CA8` | `Util.VivoxAuthUtil::SHA256Hash` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A7F74` | `Util.VivoxAuthUtil::.cctor` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x52A8B14` | `Util.TypeConvertors.UserFeedDataJsonConvertor::ReadJson` | method | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x52AA868` | `ClanChatBox.<>c__DisplayClass17_0::<SyncClanGameCards>b__1` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52ACE70` | `ClanEmblemLoader::RequestEmblem` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52AD020` | `ClanEmblemLoader::LoadMyClan` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52AD7E4` | `ClanEmblemLoader::OnEmblemTierActivated` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52ADDC8` | `ClanFeedListView::ShouldDisplay` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE0D4` | `ClanFeedListView::SortedInsertIndex` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE26C` | `ClanFeedListView::ReconcileServerFeed` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE3F8` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x18C) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE440` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x1D4) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE4DC` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x270) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE5A0` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x334) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE5A8` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x33C) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE5C0` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x354) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE5D4` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x368) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE5D8` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x36C) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE678` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x40C) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE6DC` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x470) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE6E4` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x478) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE700` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x494) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE7B0` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x544) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE7C0` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x554) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE860` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x5F4) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE864` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x5F8) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE8D0` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x664) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE954` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x6E8) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE96C` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x700) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE9A0` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x734) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE9B8` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x74C) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE9BC` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x750) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AE9C4` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x758) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AEA34` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x7C8) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AEA44` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x7D8) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AEA4C` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x7E0) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AEB64` | `ClanFeedListView::ReconcileServerFeed` | inside (+0x8F8) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AEEEC` | `ClanFeedListView::ApplyVaultSupportProgress` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AF8F4` | `ClanFeedListView::ServerTogglePin` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AFDF0` | `ClanFeedListView::TemplateKeepsWhenPinned` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52AFEA4` | `ClanFeedListView::TemplateUsesSeparatePrefab` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B0244` | `ClanFeedListView::NudgeIndex` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B0344` | `ClanFeedListView::MorphsInPlaceIndex` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B04F0` | `ClanFeedListView::KeepPinnedDatumInList` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B05EC` | `ClanFeedListView::GetPinnedTopOffset` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B0698` | `ClanFeedListView::GetPinnedHeight` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B1188` | `ClanFeedListView::MaybeRequestOlder` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B12DC` | `ClanFeedListView::OldestServerFeedId` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B164C` | `ClanFeedListView::OnOlderPageFailed` | inside (+0x24) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B1D40` | `ClanFeedListView.<>c__DisplayClass6_0::<ReconcileServerFeed>b__0` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B1DF0` | `ClanFeedListView.<>c__DisplayClass6_0::<ReconcileServerFeed>b__0` | inside (+0xB0) | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52B2D64` | `ClanFeedLoader::SyncClanGameCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52B4A90` | `ClanFeedLoader::AddLiveGameCard` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52B521C` | `ClanFeedLoader.<>c::<SyncClanGameCards>b__24_0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52B54D8` | `ClanFeedLoader.<>c__DisplayClass24_0::<SyncClanGameCards>b__1` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52BDB08` | `ClanPinnedTournament::ApplyRoomTheme` | inside (+0x94) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x52BDB50` | `ClanPinnedTournament::ApplyRoomTheme` | inside (+0xDC) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x52BE28C` | `ClanRequestsBadge::WatermarkKey` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x52C0490` | `CreateClanPopup::get_model` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52C0580` | `ClanLogoBuilder::LayersToModel` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52C1558` | `CreateClanPopup::ValidateFields` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x52C1834` | `ClanServerConnector::SendEditClan` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52C1E5C` | `ClanLogoBuilder::Close` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52C25C8` | `ClanLogoBuilder::ResetToDefault` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52C47BC` | `ClanServerConnector::ConnectToClan` | method | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x52C56A0` | `ClanServerConnector::NotifyActivityCreated` | method | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x52CA3F0` | `ClanLogoBuilder::get_HasUnsavedChanges` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CA8C8` | `ClanLogoBuilder::SetupMoveButton` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CACCC` | `ClanLogoBuilder::OnRemoteConfigChanged` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CAE20` | `ClanLogoBuilder::BuildEmblemColorPresets` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CB07C` | `ClanLogoBuilder::Update` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CB260` | `ClanLogoBuilder::SetLayerOrderInGroup` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CB604` | `ClanLogoBuilder::ApplyLayerSiblingOrder` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CBC94` | `ClanLogoBuilder::AddUndo` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CBE88` | `ClanLogoBuilder::Undo` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CC188` | `ClanLogoBuilder::BuildUndoActions` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CCA80` | `ClanLogoBuilder::ClearUndoHistory` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CCB58` | `ClanLogoBuilder::CaptureCleanSnapshots` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CCD18` | `ClanLogoBuilder::OnSizeSliderChanged` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CCD60` | `ClanLogoBuilder::ClampLayerWithinCircle` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CCE58` | `ClanLogoBuilder::UpdateMovementButtons` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CD15C` | `ClanLogoBuilder::InvertLayer` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CD830` | `ClanLogoBuilder::InstallCloseGuard` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CD9C8` | `ClanLogoBuilder::TryClose` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CDC9C` | `ClanLogoBuilder::Save` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CDD68` | `ClanLogoBuilder::HasMinimumLayers` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CDECC` | `ClanLogoBuilder::ApplyModel` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CE488` | `ClanLogoBuilder::UpdateBelowMinButtons` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CE664` | `ClanLogoBuilder::SetInteractionLocked` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CE724` | `ClanLogoBuilder::HasIconItems` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CE854` | `ClanLogoBuilder::GetEmblemColorPresets` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CE8F4` | `ClanLogoBuilder::CaptureSlotsAndDisableLayouts` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52CECF8` | `ClanLogoBuilder::SortEmptiesToEnd` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CF8D4` | `ClanLogoBuilder::ComputeHypotheticalDropOrder` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CFC28` | `ClanLogoBuilder::PreviewReorder` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52CFFBC` | `ClanLogoBuilder::FillDragGroupBuffer` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D0204` | `ClanLogoBuilder::GetEffectiveMaxMoveDistance` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D0394` | `ClanLogoBuilder::StartMoving` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D03D0` | `ClanLogoBuilder::StopMoving` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D04A0` | `ClanLogoBuilder::SetMovementButtonsInteractable` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D06A8` | `ClanLogoBuilder::ApplyModelToLayer` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D09B8` | `ClanLogoBuilder::<LayersToModel>b__70_2` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D0C4C` | `ClanLogoBuilder.LayerSnapshot::.ctor` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D1C58` | `IconLayer::SetRotation` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D1D40` | `IconLayer::SetScale` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D1E20` | `IconLayer::SetInverted` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D2008` | `IconLayer::SetPosition` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D20FC` | `ClanLogoBuilder.<Initialize>d__71::MoveNext` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D30B8` | `ClanLogoPreviewer::Initialize` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D35EC` | `ClanLogoElementCatalog::CallWhenLoaded` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D370C` | `ClanLogoElementCatalog::GetImage` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D3940` | `ClanLogoElementCatalog::Fetch` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D3D68` | `ClanLogoImageSelector::RefreshColorPalette` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D4504` | `ClanLogoImageSelector::PruneItemsThatFailToLoad` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D45BC` | `ClanLogoImageSelector::PickDefault` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D4818` | `ClanLogoImageSelector::PickItem` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D5C04` | `ClanLogoImageSelector::OpenSelector` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D6018` | `ClanLogoImageSelector::GetLogoElements` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D614C` | `ClanLogoImageSelector::ApplyColorToVisuals` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D6408` | `ClanLogoImageSelectorItem::SetColor` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52D69A0` | `ClanLogoImageSelector.<Initialize>d__30::MoveNext` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D75D0` | `ClanLogoImageSelectorItem::InitAsEmpty` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D7834` | `ClanLogoImageSelectorItem::Init` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D7B20` | `ColorSelector::Init` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D7F2C` | `ClanLogoImageSelector.<PruneItemsThatFailToLoad>d__32::MoveNext` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D8E20` | `ClanLogoPreviewer::GetRimHalfExtent` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D90D0` | `ClanLogoPreviewer::Initialize` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D97E4` | `ClanLogoPreviewer::Clear` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D9DC4` | `ClanLogoPreviewer::GetShineMaterial` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52D9F98` | `ClanLogoPreviewer::ApplyLayer` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52DA2A8` | `ClanLogoPreviewer::ApplySiblingOrder` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52DAAB4` | `ClanLogoPreviewer::BuildMinimum` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52DB360` | `ClanLogoRenderer::LoadLogo` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52DB364` | `ClanLogoRenderer::.ctor` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) · [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52DB368` | `ClanLogoRenderer::.ctor` | inside (+0x4) | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52DB36C` | `ClanLogoSelectorDragReorder::OnPointerDown` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52DB430` | `ClanLogoSelectorDragReorder::OnBeginDrag` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52DB704` | `ClanLogoSelectorDragReorder::OnDrag` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52DB988` | `ClanLogoSelectorDragReorder::OnEndDrag` | method | [اجتماعي](social-spec/05-محرر-شعار-العشيرة.md) |
| `0x52DC110` | `IconLayer::Reset` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x52DC594` | `ClanFeedEventDataHolder::get_IsLiveTournament` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52DC5A4` | `ClanFeedEventDataHolder::get_IsLiveGame` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52DC6D0` | `ClanFeedEventDataHolder::get_template` | method | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x52E4858` | `FastTrack::UpdateFTCloseSection` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x52E5F6C` | `FastTrack::MatchMe` | inside (+0x238) | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x52E635C` | `FastTrack::SendRequestClaim` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x52E6600` | `FastTrack::SendRequestNextStage` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x52E6C08` | `FastTrack::SendRequestRefreshTickets` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x52EADE8` | `FastTrackPopupManager::Show` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x52F6B04` | `GameReplayTabletTopbar::ExitGame` | inside (+0x58) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52F6CA0` | `GameReplayTopbar::ShowChat` | inside (+0x14) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52F6CEC` | `GameReplayTopbar::ExitGame` | inside (+0x44) | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52F6D00` | `GameReplayTopbar::ExitGame` | inside (+0x58) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52F73D4` | `GameReplayUiControl::ExitRoom` | inside (+0x58) | [إعادة](replay-spec/01-نظام-إعادة-اللعب.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52F7770` | `HokomOnEndRoundScriptableMethod::OnEndRound` | inside (+0x3C) | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x52F77F8` | `SunOnEndRoundScriptableMethod::OnEndRound` | inside (+0x3C) | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x52F7884` | `TutorialGame::GetAiOptions` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F79B0` | `TutorialGame::GetBalootBiddingOption` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F7B6C` | `TutorialGame::GetErrorMessage` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F7CF8` | `TutorialGame::OnEndRound` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F7DB4` | `TutorialGame::.ctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F81FC` | `TutorialGameAssetFetcher::GeTutorialGame` | method | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x52F831C` | `TutorialGameAssetFetcher::.cctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F8468` | `TutorialGameAssetFetcher.<GeTutorialGame>d__2::MoveNext` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F878C` | `TutorialGameAssetFetcher.<InitializeTutorials>d__3::MoveNext` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F8A80` | `AdvancedHokomButtonScriptableBehaviorLogic::RunLogic` | method | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x52F8B20` | `AdvancedSunButtonScriptableBehaviorLogic::RunLogic` | method | [إعلانات](ads-spec/02-الدروس-التعليمية.md) |
| `0x52F8BC0` | `BalootCardUtils::.ctor` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52F8C2C` | `BalootCardUtils::get_AllBalootCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F8E54` | `BalootCardUtils::RandomBalootCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F8FC0` | `BalootCardUtils::GetValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F90E8` | `BalootCardUtils::GetValue` | inside (+0x128) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F90EC` | `BalootCardUtils::GetValue` | inside (+0x12C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F90F0` | `BalootCardUtils::GetValue` | inside (+0x130) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F90F4` | `BalootCardUtils::GetValue` | inside (+0x134) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F90F8` | `BalootCardUtils::GetValue` | inside (+0x138) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F90FC` | `BalootCardUtils::GetValue` | inside (+0x13C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9100` | `BalootCardUtils::GetValue` | inside (+0x140) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9108` | `BalootCardUtils::GetValue` | inside (+0x148) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9148` | `BalootCardUtils::GetValue` | inside (+0x188) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9194` | `BalootCardUtils::GetValue` | inside (+0x1D4) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F91CC` | `BalootCardUtils::GetValue` | inside (+0x20C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F91E0` | `BalootCardUtils::GetValue` | inside (+0x220) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9204` | `Card::AsInt` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x52F9214` | `CardGameStage::get_IsBidding` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9248` | `BalootCardUtils::.cctor` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F9358` | `BalootCardUtils.<>c::<get_AllBalootCards>b__3_1` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52F93C4` | `BalootEndScores::.ctor` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52F943C` | `BalootEndScores::SetCardGameEndScores` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52F9774` | `CardGameEndScores::SetCardGameEndScores` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x52F9F64` | `BalootGame::add_OnEkkaDeclarationChanged` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52FA018` | `BalootGame::remove_OnEkkaDeclarationChanged` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52FA0CC` | `BalootGame::get_MyPlayer` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FA1B8` | `BalootGame::get_MyTeammate` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FA2A0` | `CardGame::get_MyTeammate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FA3B4` | `BalootGame::set_IsEkkaToBeDeclared` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52FA414` | `BalootGame::Init` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FA838` | `BalootPlayer::.ctor` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52FA8C4` | `BalootScores::.ctor` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FA958` | `BalootGame::UpdateGameState` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FAB98` | `CardGame::UpdateGameState` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FB00C` | `BalootGame::GameModeFromString` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FB0EC` | `BalootGame::ExtraGameModeFromString` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FB208` | `BalootGame::PlayCard` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FB614` | `BalootGame::ToggleEkkaDeclaration` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52FB674` | `BalootGame::EndGame` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FB750` | `CardGame::InvokeOnCardGameEnd` | method | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x52FB76C` | `CardGame::TrackEndGame` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FB8C8` | `BalootGame::SpecialPlayAllowed` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FB8F4` | `BalootGame::GetScores` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FB8FC` | `BalootGame::.ctor` | method | [بلوت](baloot-spec/19-المتحكّمات-والذكاء-والواجهات.md) |
| `0x52FBAC0` | `BalootProjectMethods::ServerValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FBB50` | `BalootGameModeExtensions::IsSunOrAshkal` | method | [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FBB60` | `BalootGameModeExtensions::ToClientString` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FBC44` | `BalootGameModeExtensions::ToClientString` | method | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FBCD4` | `BalootGameSoundControls::get_balootGame` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FBE2C` | `BalootGameSoundControls::OnRoundEnd` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FC238` | `CardGameSoundControls::get_MyTeamIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FC308` | `BalootGameSoundControls::OnGameEnd` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FC784` | `BalootHighlights::GetHighlightsName` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FC840` | `BalootPlayer::get_IsRoundDoubler` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FC92C` | `BalootPlayer::get_Game` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FCB10` | `BalootPlayer::UpdatePlayerState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FCD88` | `CardGamePlayer::UpdatePlayerState` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FD444` | `BalootProjectMethods::OrderingValue` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FD4D8` | `BalootProjectMethods::ServerStringValue` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FD544` | `BalootProjectMethods::FromServerValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FD5D4` | `BalootProjectMethods::Requires` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FD650` | `BalootProjectUtility::BestProjectCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FD76C` | `BalootProjectUtility::BestProjectsValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FD84C` | `BalootProjectUtility::ProjectPrecedence` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FDBD8` | `BalootProjectUtility::.ctor` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FDC30` | `BalootProjectUtility::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FE33C` | `BalootProjectUtility.<>c::<.cctor>b__6_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x52FE384` | `BalootScores::SaveRoundScore` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FE624` | `BalootRoundScore::Record` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FEE54` | `CardGameRoundScore::Record` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [طرنيب](tarneeb-spec/04-اللعب-والنقاط.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x52FF008` | `BalootRoundScore.TeamProject::.ctor` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FF0A8` | `BalootStatistics::SetStatistics` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FF2B8` | `CardGameStatistics::SetStatistics` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x52FFA48` | `BalootStatistics::AddStat` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x52FFCF8` | `BalootStatistics::StatisticsInfo` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x52FFE8C` | `BalootStatistics::GetStatisticType` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x52FFF30` | `BalootStatistics::GetStatisticName` | method | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x53003C4` | `Card::ToString` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x5300478` | `Card::Equals` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5300578` | `Card::Equals` | inside (+0x100) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x53005C4` | `Card::Equals` | inside (+0x14C) | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x53005C8` | `Card::GetHashCode` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53006A8` | `CardGame::get_CardsOnFloor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5300888` | `CardGame::GetPlayerTeam` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x53008AC` | `CardGame::get_MyOpponentIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53008F8` | `CardGame::GetNextPlayerIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5300A78` | `CardGame::AssignPlayedCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5300C44` | `CardGame::add_OnStageChanged` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5300CF8` | `CardGame::remove_OnStageChanged` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5300DAC` | `CardGame::SeatPlayer` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5300F8C` | `CardGame::GetRotatedPlayerIndex` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x5300FDC` | `CardGame::OnGameCancelled` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5301320` | `CardGame::SendBidding` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301378` | `CardGame::SendSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53014D4` | `CardGame::SendKasho` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301520` | `CardGame::PlayCard` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53016F0` | `CardGame::CanPlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53017B0` | `CardGame::SpecialPlayAllowed` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53017B8` | `CardGame::SendAcceptNext` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301804` | `CardGame::SendEatCards` | method | [بلوت](baloot-spec/12-بروتوكول-الخادم.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301850` | `CardGame::SendCatch` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53018A8` | `CardGame::SendCatchDetails` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301900` | `CardGame::SendLiveCatch` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301958` | `CardGame::SendCatchClose` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5301B3C` | `CardGameEndScores::get_BonusPoints` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x5301BE4` | `CardGameEndScores::get_Achievements` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5301EC4` | `CardGameEndScores::TestPopulate` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53023DC` | `CardGameEndScores.<>c::<get_Achievements>b__88_0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5302570` | `CardGameHighlights::SetHighlights` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5302940` | `CardGamePlayer::get_PlayedThisTurn` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302950` | `CardGamePlayer::get_IsBidder` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302A20` | `CardGamePlayer::get_IsRoundBidder` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302AB0` | `CardGamePlayer::get_IsDealer` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302B40` | `CardGamePlayer::get_CanPlay` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302B88` | `CardGamePlayer::get_ShouldAcceptNext` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x5302C84` | `CardGamePlayer::get_CanPlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x5302D24` | `CardGameStage::get_IsPlaying` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302D34` | `CardGameStage::get_IsMoveNextRequired` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302D44` | `CardGamePlayer::get_CanEat` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302EF4` | `CardGameStage::get_IsWaitingForEating` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302F04` | `CardGamePlayer::get_IsIdleBlocked` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5302FC4` | `CardGamePlayer::get_CanCardsBeShown` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5303100` | `CardGamePlayer::get_AreCardsShown` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5303154` | `CardGamePlayer::get_Teammate` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530326C` | `CardGamePlayer::AssignSortedCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53034DC` | `CardGamePlayer.<>c::<get_CanCardsBeShown>b__54_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5303614` | `CardGameSoundControls::Init` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53037DC` | `CardGameStage::get_IsCheatCatch` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) |
| `0x53037FC` | `Statistic::BalootMock` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5303C38` | `CardGameVisualControls::Init` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5304288` | `CardGameVisualControls::Update` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53048C4` | `CardGameVisualControls::<Update>g__CanAnimate|68_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5304978` | `CardGameVisualControls::EatCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5304AF4` | `CardGameVisualControls::EatCards` | inside (+0x17C) | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5304B18` | `CardGameVisualControls::<Update>g__ProgressActionsBuffer|68_2` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5304B70` | `CardGameVisualControls.CardAction::get_isReorganizeHand` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5304C64` | `CardGameVisualControls::OnGameStateUpdated` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5304ED4` | `CardGameVisualControls::ResetGameGround` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530528C` | `CardGameVisualControls::IsTooEarlyToPlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53053B4` | `CardGameVisualControls::AddPlayedCardToActionsBuffer` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x53054DC` | `CardGameVisualControls.CardAction::InitCardPlay` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5305604` | `CardGameVisualControls::AddEatingToActionsBuffer` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x53056E8` | `CardGameVisualControls.CardAction::InitEating` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x53057EC` | `CardGameVisualControls::AddReorganizeHandToActionsBuffer` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x53058B4` | `CardGameVisualControls.CardAction::InitReorganizeHand` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x53059A8` | `CardGameVisualControls::PlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5305C50` | `CardGameVisualControls::PlayCard` | inside (+0x2A8) | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5305C7C` | `CardGameVisualControls::<PlayCard>g__DoPlayCard|77_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5305CF8` | `CardGameVisualControls::ShowControls` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5305F0C` | `CardGameVisualControls::HideControls` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530620C` | `CardGameVisualControls::AnimatePlayCard` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5306A10` | `CardGameVisualControls::CardCollisionAnim` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5306C28` | `CardGameVisualControls::GetCardLandingWorldPosition` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5306D40` | `CardGameVisualControls::GetPlayerSlotIndex` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5306E20` | `CardGameVisualControls::FloorCardsNumber` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5306F9C` | `CardGameVisualControls::GetSwayValue` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5307054` | `CardGameVisualControls::GetCollisionValues` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53071EC` | `CardGameVisualControls::ResetEatingCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530747C` | `CardGameVisualControls::ResetPlayedCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53077D0` | `CardGameVisualControls::TweenCardEating` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5307B6C` | `CardGameVisualControls::PrepareEatingCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5307E04` | `CardGameVisualControls::TweenEatingCount` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5308184` | `CardGameVisualControls::<Update>g__AddPauseUntil|68_1` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530818C` | `CardGameVisualControls::<PlayCard>g__CustomPlayCard|77_1` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530831C` | `CardGameVisualControls::<PlayCard>g__CustomPlayCard|77_1` | inside (+0x190) | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x53083DC` | `CardGameVisualControls.CardAction::.ctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53084F8` | `CardGameVisualControls.CardAction::ToString` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53088F0` | `CardGameVisualControls.<>c__DisplayClass85_0::<AnimatePlayCard>b__0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530897C` | `CardGameVisualControls.<>c__DisplayClass93_0::<CardCollisionAnim>b__0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x53090F8` | `CardGameVisualControls.<>c__DisplayClass93_0::<CardCollisionAnim>b__0` | inside (+0x77C) | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x5309684` | `KGameVisualControls::GetActiveUserbox` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5309768` | `CardUtils::FromInt` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5309860` | `CardUtils::FromString` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5309950` | `CardUtils::DecodeCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5309B08` | `CardUtils::ExtractCardData` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5309C7C` | `CardUtils::DecodeCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x5309E48` | `CardUtils::DecodeBinaryLongCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530A740` | `CardUtils::DecodeIntArrayCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530A800` | `CardUtils::EncodeBinaryLongCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x530A94C` | `CardUtils::EncodeBinaryLongCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530AA78` | `CardUtils::DecodeCardNumbers` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530AF08` | `CardUtils::OriginalCardOrder` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530AF94` | `CardUtils::SuitComparison` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B020` | `CardUtils::ValueComparison` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B070` | `CardUtils::SortCards` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B178` | `CardUtils::GetSuitOrder` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B3B4` | `CardUtils::GetValue` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B3D0` | `CardUtils::.cctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B978` | `CardUtils.<>c::<EncodeBinaryLongCards>b__18_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B988` | `CardUtils.<>c::<GetSuitOrder>b__24_0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530B9A0` | `CardUtils.<>c__DisplayClass23_0::<SortCards>g__Comparison|0` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530BAD0` | `CardUtilExtensions::Contains` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530BBC0` | `CardUtilExtensions::Contains` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530BCB0` | `CardUtilExtensions::Contains` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530BDA0` | `CardUtilExtensions::GetCards` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530C0F4` | `CardUtilExtensions::GetCardsWithRanks` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530C448` | `CardUtilExtensions::GetCardsWithSuits` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530C79C` | `CardUtilExtensions::IsBlack` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530C7BC` | `CardUtilExtensions::IsRed` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530C7E0` | `CardUtilExtensions::Clone` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530CCC0` | `CardUtilExtensions.<>c__DisplayClass1_0::<Contains>b__0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530CDD8` | `CardUtilExtensions.<>c__DisplayClass2_0::<Contains>b__0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530D1D8` | `CardGameLastActionInfo::.ctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530D200` | `CardGameLastActionInfo::.ctor` | inside (+0x28) | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x530D438` | `ProjectConditions::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530D590` | `ProjectConditions::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530D60C` | `SuitMethods::GetAll` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530D6D0` | `SuitMethods::GetSuitLocalizationString` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x530D9C8` | `CheatingInfo::get_IsWrongSawa` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530DA20` | `CheatingInfo::get_IsWrongEkka` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530DA78` | `CheatingInfo::get_IsFirstPhase` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x530DA88` | `CheatingInfo::.ctor` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530E270` | `CheatingInfo::CreateCheatingData` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530E4B0` | `CheatingInfo::CreateCheatingData` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x530EADC` | `KGame::get_Room` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x530ECB8` | `KGame::get_Players` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x530ED50` | `KGame::get_IsReplay` | method | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x530ED8C` | `KGame::get_IsVoiceChatEnabled` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x530EDA4` | `KGame::get_IsVoiceChatEnabledForSpectators` | method | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x530EDCC` | `KGame::get_IsSpectator` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5311314` | `KGame::OnExtensionResponse` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x53118AC` | `KGame::OnExtensionResponse` | inside (+0x598) | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x5311AFC` | `KGame::TrySeatPlayer` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x531258C` | `KGame::UpdateGameState` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5313230` | `KGame::SendApproveTeammate` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x53132F8` | `KGame::SendSwitchRequest` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x531342C` | `KGame::SendGameLoaded` | inside (+0x84) | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x5313464` | `KGame::SendResumeLastGame` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x53134B0` | `KGame::RestartGame` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) |
| `0x53134FC` | `KGame::CancelMatchMaking` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) · [ردهة](lobby-spec/README.md) |
| `0x5313500` | `KGame::ExitGame` | method | [ردهة](lobby-spec/02-المطابقة-والمقاعد.md) · [ردهة](lobby-spec/README.md) |
| `0x5313890` | `KGame::NotifyEmoteSent` | method | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x5313FCC` | `KGame::SendForfeitGame` | method | [أنماط](modes-spec/01-كأس-كملنا.md) |
| `0x53147CC` | `KGame::IsGameBalanced` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) · [هوية](identity-spec/01-الرتب-والألقاب.md) |
| `0x5314C4C` | `KGame::<ExitGame>b__215_0` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5314EEC` | `KGame.PlayerSwitchSeatDelegate::.ctor` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5314FA4` | `KGame.PlayerSwitchSeatDelegate::BeginInvoke` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53150D4` | `KPlayer::get_IsHuman` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x5315504` | `KGameExtensions::GetClientContext` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53157E8` | `KGameVisualControls::get_hand` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53159D8` | `KGameVisualControls::get_ActiveUserBoxes` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5315B8C` | `KGameVisualControls::Init` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5315F38` | `KGameVisualControls::GetNextPlayerUserbox` | method | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x53161EC` | `KPlayer::get_NickName` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5316480` | `KPlayer::get_IsRoomOwner` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5316594` | `KPlayer::get_CanPlay` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x5316740` | `KPlayer::remove_OnUserChanged` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5316970` | `KPlayer::UpdateUser` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5316ABC` | `KPlayer::FireEvents` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5316B94` | `KPlayer::UserChanged` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x5316ED8` | `SpecialKingMarbleMove::get_textureRendererCamera` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5316FFC` | `SpecialKingMarbleMove::Start` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5317068` | `SpecialKingMarbleMove::OnGamePerspectiveChanged` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x53171A4` | `SpecialKingMarbleMove::OnEnable` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5317238` | `SpecialKingMarbleMove::OnDisable` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x53172CC` | `SpecialKingMarbleMove::Move` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5317830` | `SpecialKingMarbleMove::OnArrived` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x53179F0` | `SpecialKingMarbleMove::CustomDeath` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x53182F8` | `SpecialKingMarbleMove::.ctor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x531831C` | `ICustomMarbleMove::.ctor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5318324` | `SpecialKingMarbleMove::<OnArrived>b__26_0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x531843C` | `SpecialKingMarbleMove.<>c__DisplayClass25_0::<Move>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x531849C` | `SpecialKingMarbleMove.<>c__DisplayClass25_0::<Move>b__1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x53184C8` | `SpecialKingMarbleMove.<>c__DisplayClass25_0::<Move>b__2` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x53187F4` | `SpecialKingMarbleMove.<>c__DisplayClass25_0::<Move>g__GetAngleToNextNode|4` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) · [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x5318A3C` | `SpecialKingMarbleMove.<>c__DisplayClass25_0::<Move>b__3` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5318A7C` | `SpecialKingMarbleMove.<>c__DisplayClass25_0::<Move>g__OnStepAction|5` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5318AB0` | `SpecialKingMarbleMove.<>c__DisplayClass28_0::<CustomDeath>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5318AD0` | `SpecialKingMarbleMove.<>c__DisplayClass28_0::<CustomDeath>b__1` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5318B64` | `SpecialMarblePlant::Move` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x531914C` | `SpecialMarblePlant::GetAngleByPlayerIndex` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5319164` | `SpecialMarblePlant::.ctor` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x531916C` | `SpecialMarblePlant.<>c__DisplayClass4_0::<Move>b__0` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5319470` | `ICustomMarbleMove::get_GameAction` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5319478` | `ICustomMarbleMove::set_GameAction` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5319480` | `ICustomMarbleMove::get_UseDefaultSound` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x5319488` | `ICustomMarbleMove::set_UseDefaultSound` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x53194D0` | `JackarooEndScores::.ctor` | method | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x5319518` | `JackarooEndScores::SetCardGameEndScores` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x531992C` | `JackarooHighlights::GetHighlightsName` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x53199C0` | `JackarooStatistics::SetStatistics` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5319BD4` | `JackarooStatistics::AddStat` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5319E34` | `JackarooStatistics::StatisticsInfo` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x5319F80` | `JackarooStatistics::GetStatisticType` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x531A000` | `JackarooStatistics::GetStatisticType` | inside (+0x80) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A024` | `JackarooStatistics::GetStatisticName` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x531A09C` | `JackarooHand::get_JackarooGame` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A124` | `JackarooHand::get_JackarooGameVisualControls` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A1AC` | `JackarooHand::get_boardMono` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A22C` | `JackarooHand::get_LastActionInfo` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A2AC` | `JackarooHand::get_SwipeOffset` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A2B4` | `JackarooHand::DoPlayMove` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x531A6A0` | `JackarooHand::GetItemStoreForGameAction` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x531A770` | `JackarooHand::GetItemStoreForAction` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x531A840` | `JackarooHand::TryAffordItem` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A8BC` | `JackarooHand::GetGameActionForAction` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531A9E0` | `JackarooHand::SendToSFS` | method | [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531AC38` | `JackarooHand::DoPlayCard` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B0F4` | `JackarooHand::MoveMarbles` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B194` | `JackarooHand::ResetPlay` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B228` | `JackarooHand::ResetPlay` | inside (+0x94) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B234` | `JackarooHand::ResetPlay` | inside (+0xA0) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B31C` | `JackarooHand::ResetMoves` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B4A8` | `JackarooHand::DisableFireMode` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B4C4` | `JackarooHand::get_playingStage` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B4CC` | `JackarooHand::set_playingStage` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B4D4` | `JackarooHand::get_SqrRadius` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B4E0` | `JackarooHand::RegisterEventListeners` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B62C` | `JackarooHand::UnRegisterEventListeners` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B778` | `JackarooHand::OnDealBatchStarted` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B784` | `JackarooHand::OnDealBatchComplete` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B798` | `JackarooHand::OnGameInitialized` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B8B4` | `JackarooHand::DisableFireModeButton` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B8D0` | `JackarooHand::OnGamePerspectiveChanged` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B97C` | `JackarooHand::Update` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531B9EC` | `JackarooHand::SelectMarble` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531BF9C` | `JackarooHand::SelectMarble` | inside (+0x5B0) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531BFD0` | `JackarooHand::OnMouseButton` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531C170` | `JackarooHand::ShowTipsAndHighlights` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531C750` | `JackarooHand::MoveHandIfRequired` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531C7FC` | `JackarooHand::get_AllowedMoves` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531C850` | `JackarooHand::OnMouseButtonUp` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531C9E8` | `JackarooHand::OnTouchUp` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531C9FC` | `JackarooHand::OnCardClicked` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531CA14` | `JackarooHand::OnCardClicked` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531CA54` | `JackarooHand::OnCardClicked` | inside (+0x40) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531CB84` | `JackarooHand::GetAllowedMovesForCard` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531CC70` | `JackarooHand::GetFireModeGameActionForAction` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531CDB4` | `JackarooHand::GetCardAllowedSpecialMoves` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D178` | `JackarooHand::TryPlayCard` | method | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D3C8` | `JackarooHand::TryPlayCard` | inside (+0x250) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D3DC` | `JackarooHand::TryPlayCard` | inside (+0x264) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D444` | `JackarooHand::TryPlayCard` | inside (+0x2CC) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D4AC` | `JackarooHand::HandleMarblePlay` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D708` | `JackarooHand::HandleMarblePlay` | inside (+0x25C) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D760` | `JackarooHand::HandleMarblePlay` | inside (+0x2B4) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531D830` | `JackarooHand::HandleMarblePlay` | inside (+0x384) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531DCBC` | `JackarooHand::HandleMarblePlay` | inside (+0x810) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531DFAC` | `JackarooHand::ShouldPlayQueenAsTwoStates` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E0C8` | `JackarooHand::ShouldPlayQueenAsTwoStates` | inside (+0x11C) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E1BC` | `JackarooHand::SetCardPreplayAndOthersDimmed` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E2C4` | `JackarooHand::CanAffordSpecialPlay` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x531E384` | `JackarooHand::ShouldPlayOneMove` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E3AC` | `JackarooHand::DoesNextPlayerHasOneCard` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E540` | `JackarooHand::PlayQueenBurnOrSteel` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E610` | `JackarooHand::PlayQueenBurnOrSteel` | inside (+0xD0) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E870` | `JackarooHand::PlayTen` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531E9B0` | `JackarooHand::PlayTen` | inside (+0x140) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531EB88` | `JackarooHand::PlayTen` | inside (+0x318) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531ECE0` | `JackarooHand::PlayTen` | inside (+0x470) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531EE00` | `JackarooHand::PlaySeven` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531EEE4` | `JackarooHand::PlaySeven` | inside (+0xE4) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531F168` | `JackarooHand::PlayAce` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531F340` | `JackarooHand::PlayAce` | inside (+0x1D8) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531F424` | `JackarooHand::PlayAce` | inside (+0x2BC) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531F4D0` | `JackarooHand::PlayAce` | inside (+0x368) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531F760` | `JackarooHand::PlayJack` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531F87C` | `JackarooHand::PlayJack` | inside (+0x11C) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531FE7C` | `JackarooHand::OnGameStatusUpdate` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x531FF90` | `JackarooHand::OnGameStatusUpdate` | inside (+0x114) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53200A0` | `JackarooHand::OnGameStatusUpdate` | inside (+0x224) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5320134` | `JackarooHand::OnGameStatusUpdate` | inside (+0x2B8) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532018C` | `JackarooHand::OnGameStatusUpdate` | inside (+0x310) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53202C4` | `JackarooHand::OnGameStatusUpdate` | inside (+0x448) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5320984` | `JackarooHand::DidHandChanged` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5320D64` | `JackarooHand::WaitForBoard` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5320E10` | `JackarooHand::ShowHandCards` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5320FD4` | `JackarooHand::WaitForBoardIe` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5321078` | `JackarooHand::GetAllowedMoves` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5321180` | `JackarooHand::GetAllowedMoves` | inside (+0x108) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5321744` | `JackarooHand::ShowHandCards` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5321910` | `JackarooHand::ShowActualHandCards` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5321EE0` | `JackarooHand::ShowHandCards` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532223C` | `JackarooHand::ShowHandCardsBacks` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53222F4` | `JackarooHand::ShouldDimCard` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53223B8` | `JackarooHand::DoPendingAction` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53223BC` | `JackarooHand::GameStateHandleFireMode` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x53224A4` | `JackarooHand::EnableFireModeButton` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x53224C0` | `JackarooHand::EnableFireMode` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5322514` | `JackarooHand::OnDeactivateFireMode` | method | [جكارو](jackaroo-spec/16-واجهة-جكارو-مفكوكة.md) |
| `0x532258C` | `JackarooHand::DisablePriceTags` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5322684` | `JackarooHand::FetchSpecialPlayFromStore` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5322758` | `JackarooHand::UpdatePriceTag` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5322C14` | `JackarooHand::ApplyFireMode` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323700` | `JackarooHand::CollectNearbyMarbles` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5323A2C` | `JackarooHand::GroupFireModeLabelForGroup` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) · [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5323CBC` | `JackarooHand::.ctor` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323EF0` | `JackarooHand::<SelectMarble>b__44_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323EF4` | `JackarooHand::<SelectMarble>b__44_0` | inside (+0x4) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323EFC` | `JackarooHand::<OnGameStatusUpdate>b__67_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323F1C` | `JackarooHand::<OnGameStatusUpdate>b__67_0` | inside (+0x20) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323F90` | `JackarooHand::<OnGameStatusUpdate>b__67_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5323FB4` | `JackarooHand::<FetchSpecialPlayFromStore>b__100_0` | method | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x5324374` | `JackarooHand.<>c::<ShowTipsAndHighlights>b__42_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324394` | `JackarooHand.<>c::<ShouldPlayQueenAsTwoStates>b__51_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53243BC` | `JackarooHand.<>c::<HandleMarblePlay>b__56_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53243DC` | `JackarooHand.<>c::<HandleMarblePlay>b__56_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53243FC` | `JackarooHand.<>c::<HandleMarblePlay>b__56_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532441C` | `JackarooHand.<>c::<HandleMarblePlay>b__56_3` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532443C` | `JackarooHand.<>c::<PlayTen>b__60_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532445C` | `JackarooHand.<>c::<PlayTen>b__60_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532447C` | `JackarooHand.<>c::<DidHandChanged>b__68_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53244A8` | `JackarooHand.<>c::<DidHandChanged>b__68_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53244C0` | `JackarooHand.<>c::<DidHandChanged>b__68_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53244CC` | `JackarooHand.<>c::<GetAllowedMoves>b__72_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53244EC` | `JackarooHand.<>c::<GetAllowedMoves>b__72_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324504` | `JackarooHand.<>c::<ShowHandCards>b__79_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532451C` | `JackarooHand.<>c::<ShowActualHandCards>b__81_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324548` | `JackarooHand.<>c::<ShowActualHandCards>b__81_1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324560` | `JackarooHand.<>c::<ShowActualHandCards>b__81_2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53245C0` | `JackarooHand.<>c::<GetCardAllowedSpecialMoves>b__110_0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53249E0` | `JackarooHand.<>c__DisplayClass50_0::<TryPlayCard>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324A30` | `JackarooHand.<>c__DisplayClass52_0::<SetCardPreplayAndOthersDimmed>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324AC8` | `JackarooHand.<>c__DisplayClass59_0::<PlayQueenBurnOrSteel>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324AEC` | `JackarooHand.<>c__DisplayClass59_0::<PlayQueenBurnOrSteel>b__1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324B20` | `JackarooHand.<>c__DisplayClass60_0::<PlayTen>g__SetupMovesMarbles|0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324DC4` | `JackarooHand.<>c__DisplayClass60_1::<PlayTen>b__3` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324F0C` | `JackarooHand.<>c__DisplayClass60_2::<PlayTen>b__4` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324F7C` | `JackarooHand.<>c__DisplayClass61_0::<PlaySeven>b__2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5324FAC` | `JackarooHand.<>c__DisplayClass61_0::<PlaySeven>g__OnOptionSelected|0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53251B8` | `JackarooHand.<>c__DisplayClass61_0::<PlaySeven>g__OnOptionSelected|0` | inside (+0x20C) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53254A4` | `JackarooHand.<>c__DisplayClass61_1::<PlaySeven>g__OnMarbleSelected|1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325848` | `JackarooHand.<>c__DisplayClass61_1::<PlaySeven>g__OnMarbleSelected|1` | inside (+0x3A4) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53259B0` | `JackarooHand.<>c__DisplayClass61_1::<PlaySeven>g__OnMarbleSelected|1` | inside (+0x50C) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325BE8` | `JackarooHand.<>c__DisplayClass61_2::<PlaySeven>b__3` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325C2C` | `JackarooHand.<>c__DisplayClass61_3::<PlaySeven>b__4` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325C80` | `JackarooHand.<>c__DisplayClass61_4::<PlaySeven>b__5` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325CCC` | `JackarooHand.<>c__DisplayClass62_0::<PlayAce>b__2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325CFC` | `JackarooHand.<>c__DisplayClass62_0::<PlayAce>g__OnSelectedAction|0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5325E7C` | `JackarooHand.<>c__DisplayClass62_1::<PlayAce>g__OnSelectAction|1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326098` | `JackarooHand.<>c__DisplayClass62_1::<PlayAce>g__OnSelectAction|1` | inside (+0x21C) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326168` | `JackarooHand.<>c__DisplayClass62_2::<PlayAce>b__3` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53261C4` | `JackarooHand.<>c__DisplayClass63_0::<PlayJack>b__2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53261FC` | `JackarooHand.<>c__DisplayClass63_1::<PlayJack>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326240` | `JackarooHand.<>c__DisplayClass63_2::<PlayJack>b__1` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53265B0` | `JackarooHand.<>c__DisplayClass63_2::<PlayJack>b__1` | inside (+0x370) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326850` | `JackarooHand.<>c__DisplayClass63_3::<PlayJack>b__3` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x53268A4` | `JackarooHand.<>c__DisplayClass67_0::<OnGameStatusUpdate>b__2` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532693C` | `JackarooHand.<>c__DisplayClass67_1::<OnGameStatusUpdate>b__3` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326A5C` | `JackarooHand.<>c__DisplayClass73_0::<GetAllowedMovesForCard>b__0` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326B94` | `JackarooHand.<WaitForBoardIe>d__71::MoveNext` | method | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5326D5C` | `TarneebCardUtils::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x5326DC8` | `TarneebCardUtils::get_AllTarneebCards` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5326FF0` | `TarneebCardUtils::RandomTarneebCard` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5327000` | `TarneebCardUtils::RandomTarneebCard` | inside (+0x10) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x532715C` | `TarneebCardUtils::GetValue` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x5327178` | `TarneebCardUtils::.cctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x5327320` | `TarneebGame::set_EatingCounts` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x532733C` | `TarneebGame::Init` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x53275C0` | `TarneebPlayer::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x53275C8` | `TarneebScores::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x53275D0` | `TarneebGame::EndGame` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5327680` | `TarneebGame::UpdateGameState` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x5327798` | `TarneebGame::GetScores` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x53277A0` | `TarneebGame::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x53277A8` | `TarneebGame::.cctor` | method | [طرنيب](tarneeb-spec/02-تدفق-اللعبة-والحالات.md) · [طرنيب](tarneeb-spec/07-بروتوكول-الخادم.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x532786C` | `TarneebGameSoundControls::get_tarneebGame` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x53278F4` | `TarneebGameSoundControls::OnRoundEnd` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5327B38` | `TarneebGameSoundControls::OnGameEnd` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5327C50` | `TarneebGameSoundControls::.ctor` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x5327C58` | `TarneebPlayer::get_Game` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x5327CE0` | `TarneebPlayer::get_EatingsCount` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5327D90` | `TarneebPlayer::get_TeamEatingsCount` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5327E64` | `TarneebPlayer::get_OpponentTeamEatingsCount` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x532806C` | `TarneebPlayer::get_IsTeamBidder` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x53280BC` | `TarneebScores::SaveRoundScore` | method | [طرنيب](tarneeb-spec/09-الدوال-المفكوكة.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x5328234` | `TarneebRoundScore::get_RoundBid` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x532823C` | `TarneebRoundScore::set_RoundBid` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x5328244` | `TarneebRoundScore::get_BidderWon` | method | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x5328258` | `TarneebRoundScore::Record` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x533DF74` | `NotificationPopUp::Start` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x533E28C` | `NotificationPopUp::OnPopupConfirmed` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x533E520` | `NotificationPopUp::.cctor` | method | [إشعارات](notifications-spec/01-الإشعارات-والإعلانات-والتلميحات.md) |
| `0x5341C58` | `ListView.ListViewControllerBase::add_settlingCompleted` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341DF4` | `ListView.ListViewControllerBase::Awake` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341E20` | `ListView.ListViewControllerBase::Awake` | inside (+0x2C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341EB0` | `ListView.ListViewControllerBase::Update` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341EBC` | `ListView.ListViewControllerBase::UpdateView` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341EF0` | `ListView.ListViewControllerBase::ComputeConditions` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341F44` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0x54) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341F64` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0x74) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341F90` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0xA0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5341FC0` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0xD0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342024` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0x134) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342074` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0x184) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x534207C` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0x18C) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x53420C0` | `ListView.ListViewControllerBase::ComputeConditions` | inside (+0x1D0) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342124` | `ListView.ListViewControllerBase::UpdateItem` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342228` | `ListView.ListViewControllerBase::UpdateItemTransform` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342488` | `ListView.ListViewControllerBase::UpdateItemTransform` | inside (+0x260) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x534249C` | `ListView.ListViewControllerBase::UpdateItemTransform` | inside (+0x274) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x53424A8` | `ListView.ListViewControllerBase::UpdateItemTransform` | inside (+0x280) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x534254C` | `ListView.ListViewControllerBase::UpdateItemTransform` | inside (+0x324) | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x53426A4` | `ListView.ListViewControllerBase::GetObjectSize` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x534286C` | `ListView.ListViewControllerBase::OnScrollEnded` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342918` | `ListView.ListViewControllerBase::SetMaterialClip` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x53429D0` | `ListView.ListViewControllerBase::OnScroll` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342A30` | `ListView.ListViewControllerBase::StartSettling` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342AE0` | `ListView.ListViewControllerBase::EndSettling` | method | [واجهة](ui-spec/01-إطار-القوائم.md) · [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x5342B60` | `ListView.ListViewScroller::OnScrollStarted` | method | [واجهة](ui-spec/05-محرّك-القوائم-مفكوكًا.md) |
| `0x542DB38` | `System.String::Concat` | method | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x543D478` | `System.String::op_Inequality` | method | [بيانات](data-spec/03-إسقاط-المرشِّحات-ونماذج-الخادم.md) |
| `0x543F304` | `System.String::Concat` | method | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x55035EC` | `System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray` | method | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x565C338` | `System.Enum::ToString` | method | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x566D800` | `System.Delegate::Combine` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x566D9F0` | `System.Delegate::Remove` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x56B2AE4` | `System.Threading.Tasks.Task::WhenAll` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x5800000` | `WebSocketSharp.Net.EndPointListener::TrySearchHttpListener` | inside (+0x10) | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x5F5E0FF` | `UnityEngine.U2D.Common.UTess.Tessellator::Triangulate` | inside (+0x433) | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x60334CC` | `UnityEngine.XR.WindowsMR.Input.HololensHand::FinishSetup` | method | [بلوت](baloot-spec/refs/coverage-worklist.md) |
| `0x622A1E0` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x622A2F0` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | inside (+0x110) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x622A400` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | inside (+0x220) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x622A464` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | inside (+0x284) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x622A480` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | inside (+0x2A0) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x622A49C` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | inside (+0x2BC) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x622A4F0` | `Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` | inside (+0x310) | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x624DB34` | `UnityEngine.Purchasing.StoreController::ConfirmPurchase` | method | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x67D3198` | `UnityEngine.AudioListener::set_volume` | method | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x67EEAB4` | `UnityEngine.Debug::LogException` | method | [واجهة](ui-spec/02-ربط-متغيرات-الخادم.md) |
| `0x687B908` | `UnityEngine.Random::Range` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x688AE20` | `UnityEngine.MonoBehaviour::StartCoroutine` | method | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x688C128` | `UnityEngine.MonoBehaviour::.ctor` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x688F94C` | `UnityEngine.Object::op_Implicit` | method | [واجهة](ui-spec/06-دورة-حياة-الربط.md) |
| `0x6891170` | `UnityEngine.Object::Destroy` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x689C734` | `UnityEngine.RectTransform::get_anchoredPosition` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x68A3E58` | `UnityEngine.Transform::TransformPoint` | method | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x68A4890` | `UnityEngine.Transform::get_childCount` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x68A5AA0` | `UnityEngine.Transform::GetChild` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x68AB8E4` | `UnityEngine.Events.UnityEvent::AddListener` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x6C66168` | `UnityEngine.UI.LayoutRebuilder::ForceRebuildLayoutImmediate` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) |
| `0x6C774D4` | `UnityEngine.UI.Selectable::set_interactable` | method | [اجتماعي](social-spec/09-رسم-الشعار-ونموذجه.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x6CA11C0` | `UnityEngine.WWWTranscoder::.cctor` | method | [مصادقة](auth-spec/02-طبقة-الطلبات-مفكوكةً.md) |
| `0x6CACD1C` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x6D00000` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) · [اجتماعي](social-spec/04-نظام-الإحالة.md) · [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x6FBDF80` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x6FBE000` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x6FBE3B0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x7000000` | `—` | data/other | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x7069DA8` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x70E1000` | `—` | data/other | [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x70E1320` | `—` | data/other | [ردهة](lobby-spec/06-واجهة-البطولات.md) · [ردهة](lobby-spec/07-إنشاء-البطولة.md) |
| `0x713BC70` | `—` | data/other | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) · [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/06-النقاط-والنتيجة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) · [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x7175000` | `—` | data/other | [إعدادات](config-spec/01-RemoteConfig.md) |
| `0x7252B10` | `—` | data/other | [ردهة](lobby-spec/06-واجهة-البطولات.md) |
| `0x7252B40` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/colors-palette.md) |
| `0x7252BF0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x7252C60` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x7252CA0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/colors-palette.md) |
| `0x7252CB0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x7253000` | `—` | data/other | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) · [بلوت](baloot-spec/refs/binary-tables.md) · [إعدادات](config-spec/01-RemoteConfig.md) · [إعدادات](config-spec/README.md) · [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x7253130` | `—` | data/other | [تجميليات](cosmetics-spec/01-طبقة-عرض-التجميليات.md) |
| `0x7253200` | `—` | data/other | [إعدادات](config-spec/01-RemoteConfig.md) · [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x7253208` | `—` | data/other | [هوية](identity-spec/04-المسار-السريع-والرتب.md) |
| `0x7253230` | `—` | data/other | [توقّعات](predictions-spec/01-توقع-واربح.md) |
| `0x72532C0` | `—` | data/other | [جكارو](jackaroo-spec/01-اللوح-والهندسة.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) · [جكارو](jackaroo-spec/README.md) |
| `0x72532DC` | `—` | data/other | [جكارو](jackaroo-spec/05-البروتوكول.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x7253328` | `—` | data/other | [جكارو](jackaroo-spec/03-الورق-والأفعال.md) · [جكارو](jackaroo-spec/06-فهرس-العناوين.md) |
| `0x72533A0` | `—` | data/other | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/bidding-states-53.md) |
| `0x7253430` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x7253448` | `—` | data/other | [بلوت](baloot-spec/01-الأوراق-والتعريفات.md) · [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x7253468` | `—` | data/other | [بلوت](baloot-spec/01-الأوراق-والتعريفات.md) · [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x7253488` | `—` | data/other | [بلوت](baloot-spec/01-الأوراق-والتعريفات.md) · [بلوت](baloot-spec/05-اللعب-والأكلات-والقوانين.md) · [بلوت](baloot-spec/06-النقاط-والنتيجة.md) · [بلوت](baloot-spec/13-فهرس-الكود.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/README.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x725349C` | `—` | data/other | [بلوت](baloot-spec/01-الأوراق-والتعريفات.md) · [بلوت](baloot-spec/06-النقاط-والنتيجة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) · [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x72534C0` | `—` | data/other | [بلوت](baloot-spec/11-الذكاء-الاصطناعي-والأوفلاين.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x72534D0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x72534E0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x72534F0` | `—` | data/other | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x7253500` | `—` | data/other | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x7253520` | `—` | data/other | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x72535F8` | `—` | data/other | [اجتماعي](social-spec/07-موجز-العشيرة.md) |
| `0x72536A0` | `—` | data/other | [بلوت](baloot-spec/04-المشاريع.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x72536B0` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x72536C0` | `—` | data/other | [بلوت](baloot-spec/01-الأوراق-والتعريفات.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x72536D4` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) · [بلوت](baloot-spec/refs/address-index.md) · [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x7253728` | `—` | data/other | [هوية](identity-spec/02-الإحصائيات-والملف.md) |
| `0x8000000` | `—` | data/other | [بيانات](data-spec/04-طبقة-التتبّع.md) |
| `0x8430000` | `—` | data/other | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x8558D08` | `—` | data/other | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x8558D20` | `—` | data/other | [بلوت](baloot-spec/03-التوزيع-والمزايدة.md) · [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x8A3C000` | `—` | data/other | [بلوت](baloot-spec/refs/address-index.md) · [بلوت](baloot-spec/refs/binary-tables.md) |
| `0x8C9C3E8` | `—` | data/other | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x8CA5E18` | `—` | data/other | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x8CA7230` | `—` | data/other | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x8CA7290` | `—` | data/other | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x8CA77A8` | `—` | data/other | [بلوت](baloot-spec/16-أعلام-القواعد-والكبوت.md) |
| `0x8CA8148` | `—` | data/other | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x8CB1F00` | `—` | data/other | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x8CB5A70` | `—` | data/other | [بلوت](baloot-spec/18-المشاريع-والنقاط-والنماذج.md) |
| `0x8CB91C0` | `—` | data/other | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x8CE5178` | `—` | data/other | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x8CE6510` | `—` | data/other | [صوتيّة](voice-spec/01-الدردشة-الصوتية.md) |
| `0x8CEA7D0` | `—` | data/other | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x8CEDE78` | `—` | data/other | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x8CF11A0` | `—` | data/other | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x8CFD390` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x8D13760` | `—` | data/other | [طرنيب](tarneeb-spec/11-الدوال-المتبقّية-مفكوكة.md) |
| `0x8D157D0` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x8D1AAC0` | `—` | data/other | [تعريب](l10n-spec/01-التعريب-والعربية.md) |
| `0x8D1EB78` | `—` | data/other | [اجتماعي](social-spec/03-العشائر-والإشراف.md) |
| `0x8D22730` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x8D26BD8` | `—` | data/other | [جكارو](jackaroo-spec/08-الأنيميشن-حركة-الجلول.md) |
| `0x8D26E58` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x8D26E60` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) |
| `0x8D27230` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x8D2A038` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x8D38108` | `—` | data/other | [اقتصاد](economy-spec/05-محرّك-IAP-مفكوكًا.md) |
| `0x8D38A70` | `—` | data/other | [جكارو](jackaroo-spec/09-اليد-والتفاعل.md) |
| `0x8D39000` | `—` | data/other | [طرنيب](tarneeb-spec/07-بروتوكول-الخادم.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x8D39230` | `—` | data/other | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x8D392D0` | `—` | data/other | [هوية](identity-spec/03-شاشة-نهاية-المباراة.md) |
| `0x8D39530` | `—` | data/other | [اقتصاد](economy-spec/04-واجهة-المتجر.md) |
| `0x8D395C0` | `—` | data/other | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x8D3A9C8` | `—` | data/other | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x8D3A9D8` | `—` | data/other | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x8D3ADA0` | `—` | data/other | [تفضيلات](prefs-spec/01-التفضيلات-والإعدادات.md) |
| `0x8D3D000` | `—` | data/other | [طرنيب](tarneeb-spec/07-بروتوكول-الخادم.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x8D3D678` | `—` | data/other | [جكارو](jackaroo-spec/10-نهاية-الشوط-والاحتفال.md) |
| `0x8D3E920` | `—` | data/other | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x8D40000` | `—` | data/other | [طرنيب](tarneeb-spec/07-بروتوكول-الخادم.md) · [طرنيب](tarneeb-spec/TARNEEB-COMPLETE.md) |
| `0x8D41010` | `—` | data/other | [اقتصاد](economy-spec/02-تدقيق-ARM64.md) |
| `0x8D42D68` | `—` | data/other | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x8D43840` | `—` | data/other | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x8D44058` | `—` | data/other | [جكارو](jackaroo-spec/11-وضع-النار.md) |
| `0x8D44138` | `—` | data/other | [بلوت](baloot-spec/15-تدقيق-ARM64.md) · [بلوت](baloot-spec/refs/address-index.md) |
| `0x8D45110` | `—` | data/other | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x8D45700` | `—` | data/other | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x8D45928` | `—` | data/other | [اجتماعي](social-spec/01-المعمارية-والدردشة.md) |
| `0x8D46400` | `—` | data/other | [إعادة](replay-spec/02-محرّك-الإعادة-مفكوكًا.md) |
| `0x8D47CF0` | `—` | data/other | [صوت](sound-spec/01-الصوت-والمعلّقون.md) |
| `0x8D485F0` | `—` | data/other | [جكارو](jackaroo-spec/12-منسّق-أنيميشن-الورق.md) |
| `0x8D4A488` | `—` | data/other | [طرنيب](tarneeb-spec/10-تدقيق-ARM64.md) |
| `0x8D4A4B0` | `—` | data/other | [بلوت](baloot-spec/02-تدفق-اللعبة-والحالات.md) |
| `0x94EB320` | `—` | data/other | [واجهة](ui-spec/04-طبقات-الضباب-والنوافذ.md) |

## الطريقة

```python
# ① امسح كل ملفات .md في كل *-spec عن /0x[0-9A-Fa-f]{6,8}/ ضمن المدى 0x400000..0x9500000
# ② رتّب ScriptMethod من source-code/il2cpp-dump/script.json.gz حسب العنوان
# ③ تطابق تام ⇒ نقطة دخول ؛ وإلا bisect لإيجاد الدالّة الحاوية ⇒ "+0xNN"
# ④ خارج كل الدوالّ ⇒ data/other
```
> `__TEXT` في هذا الثنائي `vmaddr == fileoff == 0`، فالعنوان الافتراضي **هو** إزاحة الملف.
