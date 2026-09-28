# قاموس متغيّرات SFS — الغرفة والمستخدم

> مُستخرَج بالكامل من تفكيك ARM64 لـ`SFSKammelnaRoomExtensions` و`SFSKammelnaUserExtensions`.
> **143 دالة عامة + 24 مولَّدة، كلها مفسَّرة، ولم يبقَ مفتاح واحد غير محلول.**
> ✅ = اسم المفتاح مقروء من مجمّع السلاسل والقيمة الافتراضية من السجلّ.
>
> هذا **مخطّط البيانات الذي يجب أن يبنيه خادمك**.

## آلية الوصول

| العنوان | التوقيع | النوع |
|---|---|---|
| `0x4EC4D3C` | `Get(Variable, string def)` | string |
| `0x4EC5124` | `Get(Variable, bool def)` | bool |
| `0x4EC532C` | `Get(Variable, int def)` | int |
| `0x4EC63B8` | `Get(Variable, long def)` | long |
| `0x4EC55F8` | `Get(Variable, double def)` | double |
| `0x4EC58AC` | `Get(Variable, DateTime? def)` | DateTime? |
| `0x301EA80` | `Get<Int32Enum>(Variable, T def)` | enum |

فتحات واجهة `Room`: `1=Name · 3=GroupId · 6=IsGame · 14=UserCount · 31=GetVariable · 35=ContainsVariable`
فتحات واجهة `User`: `1=Name · 21=GetVariable · 24=ContainsVariable`

---

## ١. متغيّرات الغرفة (Room Variables)

| المفتاح | النوع | الافتراضي | الدالة | المعنى |
|---|---|---|---|---|
| `gt` | enum `GameType` | `0` Friendly | `GetGameType` `0x4EC9B3C` | نوع اللعبة |
| `pr` | bool | `false` | `IsPrivate` `0x4EC9BB0` | غرفة خاصة |
| `password` | string | `null` | `GetPassword` `0x4EC9CA8` | كلمة مرور الغرفة |
| `pmsg` | string | `null` | `GetPinMessage` `0x4EC9DA0` | الرسالة المثبّتة |
| `ce` | bool | **`true`** | `IsChatEnabled` `0x4EC9E98` | الدردشة مفعّلة |
| **`ch`** | bool | `false` | **`IsCheatingAllowed`** `0x4EC9F90` | السماح بالقطع والتقييد |
| `timer` | int | `0` | `GetTimeoutInterval` `0x4ECA088` | مهلة الدور (ثوانٍ) |
| `gid` | **long** | `0` | `GetGameID` `0x4ECA180` | معرّف اللعبة |
| `rTheme` | int | `0` | `GetRoomThemeID` `0x4ECA278` | ثيم الطاولة |
| **`cb`** | int | `0` | **`GetCardbackID`** `0x4ECA370` | ظهر الورق للغرفة |
| **`r`** | int `PlayerRank.Ranks` | `0` AI | `GetRankLimit` `0x4ECA484` | حدّ الرتبة الأدنى |
| `clid` | int | `0` | `GetClanId` `0x4ECB24C` | معرّف عشيرة الغرفة |
| `ORO` | int | `0` | `GetOriginalOwnerId` `0x4ECB730` | المالك الأصلي |
| `pwd` | string | `""` | `GetTournamentPassword` `0x4ECB828` | كلمة مرور البطولة |
| `O` | int | `0` | `GetRoomOwnerId` `0x4ECB920` | مالك الغرفة الحالي |
| `vc` | bool | `false` | `IsVoiceChatEnabled` `0x4ECBBE4` | الصوت مفعّل |
| `vcs` | bool | `false` | `IsVoiceChatEnabledForSpectators` `0x4ECBCDC` | الصوت للمشاهدين |
| **`Tut_type`** | enum `TutorialType` | `0` None | **`GetTutorialType`** `0x4ECBDD4` | نوع الدرس — ⚠️ لاحظ الحرف الكبير والشرطة |
| `i_r` | int | `0` | `GetIsReplay` `0x4ECBE48` | إعادة عرض (يُقارن `== 1`) |
| `pv` | SFSArray→`List<int>` | فارغة | `GetPlayersVoices` `0x4ECBF4C` | أصوات اللاعبين |
| `rm` | string | `""` | `GetRoomMessage` `0x4ECC0DC` | رسالة الغرفة |
| `rst` | int | `0` | `GetRoomSportTeamID` `0x4ECC1D4` | الفريق الرياضي الراعي |
| `rad` | int | `0` | `GetRoomAdCampaignID` `0x4ECC2CC` | حملة إعلانية |
| `ouc` | int? | `null` | `GetOnlineUsersCount` `0x4ECC574` | عدد المتصلين |
| `jcr` | int bitmask | `0` | `GetJackarooCustomRules` `0x4ECC72C` | قواعد جاكارو |
| **`i`** | SFSObject | — | `GetTournamentInfo` `0x4ECC974` | بيانات البطولة |
| `stat` | enum `TournamentStatus` | `0` | `GetTournamentStatus` `0x4ECCB18` | حالة البطولة |
| `crd` | int | `0` | `GetTournamentCurrentRound` `0x4ECCC08` | الجولة الحالية |
| `rt` | DateTime? | `null` | `GetTournamentRoundTimer` `0x4ECCD00` | مؤقّت الجولة |
| `atc` | int | `0` | `GetActiveTournamentsCount` `0x4ECCDFC` | عدد البطولات النشطة |
| `pn` | int | `0` | `GetTournamentParticipantsCount` `0x4ECCEF4` | عدد المشاركين |
| `q` | SFSArray | فارغة | `GetTournamentQueue` `0x4ECCFEC` | طابور الانتظار |
| `apct` | bool | `false` | `CanTournamentParticipantsChooseTeam` `0x4ECD270` | اختيار الفريق |
| `sfl` | bool | `false` | `IsTournamentTeamsShuffled` `0x4ECD368` | خلط الفرق |
| `wsc` | bool | `false` | `IsTournamentWatchersChatEnabled` `0x4ECD460` | دردشة المشاهدين |
| `cx` / `cy` | SFSArray of double | — | `GetCaptchaPath` `0x4ECD62C` | إحداثيات الكابتشا |
| `m` | SFSArray | — | `GetTournamentMatches` `0x4ECD974` | مباريات البطولة |
| `mi` | SFSObject | — | `GetMassTournamentInfo` `0x4ECE2FC` | البطولة الجماهيرية |
| `msd` | int ثوانٍ | `0` | `GetMassMaxStageDelay` `0x4ECE4A0` | أقصى تأخير مرحلة |
| `ast` | int | `0` | `GetMassActiveStage` `0x4ECE5EC` | المرحلة النشطة |
| `apw` | int? | `null` | `GetMassActivePlayWindow` `0x4ECE6E4` | نافذة اللعب |
| `afv` | int | `0` | `GetMassActiveStagePointsToPass` `0x4ECE89C` | نقاط العبور |
| `acst` | DateTime? | `null` | `GetMassActiveClusterStartTime` `0x4ECE994` | بدء العنقود |
| `fclv` | int | `0` | `GetFriendlyChallengeLevel` `0x4ECEA90` | مستوى التحدّي الودّي |
| `ab` | SFSObject | — | `GetActiveBombInfo` `0x4ECEB88` | قنبلة الهدايا |
| **`t1Score`** | int | `0` | `GetTeamScore(room, 1)` `0x4EC9704` | نقاط الفريق 1 |
| **`t2Score`** | int | `0` | `GetTeamScore(room, 2)` | نقاط الفريق 2 |
| **`pinfo`** | SFSArray | — | `GetPlayersInfo` `0x4EC9980` | `PlayerInfo[]` لكل المقاعد |

### ⚠️ دوال غرفة **لا تستعمل متغيّرات**

| الدالة | التنفيذ الفعلي |
|---|---|
| **`IsOffline`** `0x4ECBB20` | `room.GroupId == "Offline Rooms group"` — **اسم مجموعة SFS لا متغيّر** |
| `IsLobby` `0x4ECBA18` | `room.Name == (Config.CurrentGameConfiguration.? ?? "Main Room")` |
| `IsSuppressUserList` `0x4ECC4C4` | `room.UserCount == 0` — الاسم مضلّل |
| `IsTournamentHub` `0x4ECC824` | `!room.IsGame && room.ContainsVariable("i")` |
| `IsMassTournament` `0x4ECE15C` | `!IsGame && ContainsVariable("mi") && GetMassTournamentInfo().FinishTime > Now` |
| `HasTheme` `0x4ECA468` | `GetRoomThemeID(room) > 0` |
| `HasCaptcha` `0x4ECD558` | `room.ContainsVariable("cx")` |
| `QualifyRankLimit` `0x4ECA57C` | `user.GetRank().Rank >= room.GetRankLimit()` |
| `IsClanMember` `0x4ECB1FC` | `room.GetClanId() == user.GetClanId()` |
| `GetPlayerIndexByUser` `0x4ECC3C4` | فهرس **أساسه 1** في `pinfo` حيث `DBID` يطابق، و`0` إن لم يوجد |
| `GetPlayerTeamIndex` `0x4ECC448` | `BalootUtils.GetPlayerTeam(playerIndex)` |
| `GetJoinableSeats` `0x4ECB344` | `seats[i] = !pinfo[i].IsHuman` |
| `GetFirstJoinableSeatIndex` `0x4ECB588` | أول مقعد شاغر **أساسه 1**، أو `-1` |
| `GetFirstJoinableSeatForTeam` `0x4ECB658` | فريق 1 → مقعد 1 ثم 3 · فريق 2 → مقعد 2 ثم 4 · وإلا `-1` |

### ⭐ `IsJoinable` — منطق الانضمام كاملًا ✅

```csharp
// @0x4ECB0B0
if (!room.GetVariable<GameType>("gt", Friendly).IsFriendly()) return false;  // غير ودّية ⇒ لا انضمام
if (user.GetRank().Rank < room.GetRankLimit())                 return false;  // رتبة أقل من الحدّ
if (!room.IsCheatingAllowed())                                 return true;   // "ch" == false ⇒ مفتوحة
if (user.IsSubscribed(includeTempSubscription: true))          return true;   // المشترك يدخل
int clan = room.GetClanId();
if (clan < 1) return false;
return user.GetClanId() == clan;                                              // عضو العشيرة فقط
```

> ⭐ **غرفة «القطع والتقييد» مقيَّدة**: لا يدخلها إلا **مشترك** أو **عضو في عشيرة الغرفة**.
> قاعدة عمل مهمّة لم تكن موثّقة.

---

## ٢. متغيّرات المستخدم (User Variables)

| المفتاح | النوع | الافتراضي | الدالة | المعنى |
|---|---|---|---|---|
| `n` | string | `""` | `GetUserName` `0x4ECF070` | الاسم المعروض |
| `isNew` | bool | `false` | `IsNew` `0x4ECF0E4` | حساب جديد |
| **`st`** | enum `SubscriptionStatus` | `0` None | **`IsSubscribed`** `0x4ECF144` | حالة الاشتراك |
| **`iv`** | bool | `false` | **`IsVerified`** `0x4ECF1F0` | حساب موثّق |
| `sea` | DateTime? | `null` | `IsSubscribedUsingDate` `0x4ECF250` | انتهاء الاشتراك |
| `fsd` / `sd` | int | `0` | `GetFreeSubscriptionDays` / `GetSubscriptionDays` | أيام الاشتراك |
| **`pts`** | int | `0` | **`GetRank`** `0x4ECF734` | نقاط الرتبة |
| **`pe`** | int bitmask | `0` | `Can` `0x4ECF874` | صلاحيات المستخدم |
| `agt` | string | `""` | `GetTitle` `0x4ECF8E4` | اللقب النشط |
| `atl` | int | **`1`** | `GetTitleLevel` `0x4ECF958` | مستوى اللقب |
| `in` | enum `ChatInk` | `0` | `GetChatInk` `0x4ECF9B8` | لون الدردشة |
| `htc` | bool | `false` | `HasTrophyCelebration` `0x4ECFA2C` | احتفال الكأس |
| `ad` | DateTime? | `null` | `HasAvatar` `0x4ECFA8C` | تاريخ الصورة الرمزية |
| `rt` | DateTime? | `null` | `GetRegistrationDate` `0x4ECFBA8` | تاريخ التسجيل |
| `pc` | enum `RankedPlayCondition` | `0` | `GetPlayingCondition` `0x4ECFC0C` | شرط اللعب المصنّف |
| `jp` / `ja` / `mja` | int | `0` | أسعار وعدد الدخولات | مصنّفة |
| `mg_t` | int | `0` | `GetMiniGameTrials` `0x4ECFDA0` | محاولات الألعاب المصغّرة |
| `str` | int | `0` | `GetWinningStreak` `0x4ECFE00` | سلسلة الانتصارات |
| `ms` / `mu` | enum / DateTime? | `0` / `null` | `GetMuteStatus` / `GetMutedUntil` | الكتم |
| `tpts` | int | `0` | `GetTournamentPoints` `0x4ECFFCC` | نقاط البطولات |
| `mte` | enum | `0` | `GetMonthlyTournamentEligibility` `0x4ED002C` | أهلية البطولة الشهرية |
| `td` | int | `0` | `GetTournamentJoiningDiscount` `0x4ED00A0` | خصم الاشتراك |
| `tr` | SFSArray | فارغة | `GetAllTickets` `0x4ED0100` | كل التذاكر |
| `lk` / `achp` | int | `0` | `GetLikes` / `GetAchievementCount` | الإعجابات والإنجازات |
| **`mm`** | bool | `false` | `IsVoiceMuted` `0x4ED0510` | كتم الصوت |
| `cin` | SFSObject | — | `GetClanMembership` `0x4ED0598` | عضوية العشيرة |
| **`aces`** | int | `0` | **`GetAces`** `0x4ED07DC` | عملة «الآص» |
| **`r`** | int | `0` | `GetActiveRoomThemeID` `0x4ED083C` | ثيم الطاولة النشط |
| **`c`** | int | `0` | **`GetActiveCardbackID`** `0x4ED089C` | ظهر الورق النشط |
| `ptn` | int | `0` | `GetActivePatternID` `0x4ED08FC` | نقش البروفايل |
| `fsa` / `fsl` | string / int | `"0"` / `0` | `GetFeaturedSlot` `0x4ED095C` | الخانة المميّزة |
| `ocs` / `ors` / `ops` / `ogs` | `List<StoreOwnedItem>` | — | المملوكات | أوراق · ثيمات · نقوش · هدايا |
| `hprs` | bool | `false` | `HasPaidRoomTheme` `0x4ED0DCC` | يملك ثيمًا مدفوعًا |
| **`ft_lvl`** | int | `0` | **`GetFTLevel`** `0x4ED0E2C` | مستوى Fast Track |
| `ft_s` / `ft_ts` | int | `0` | مرحلة FT وأعلى مرحلة | |
| `ft_rw` / `ft_rl` | int | `0` | جولات FT رابحة/خاسرة — **القلوب = `5 − ft_rl`** | |
| `fts_std` / `fts_w` | int | `0` | عدد FT المبدوءة/المكسوبة | |
| `ft_t` / `ft_nt` / `mt` | int / DateTime? / int | — | تذاكر FT | |
| `e` / `uc` | string | `""` | `GetEmail` / `GetUserCode` | |
| `s_f` `s_t` `s_ti` `s_g` `s_a` | string | `""` | معرّفات التواصل | Facebook · Twitter · TwitterUserID · Google · Apple |

### ⚠️ دوال مستخدم **لا تستعمل متغيّرات**

| الدالة | التنفيذ |
|---|---|
| `GetDbId` `0x4ECF47C` | **`user.Name`** — اسم مستخدم SFS هو مُعرّف قاعدة البيانات |
| `GetIntDbId` `0x4ECF530` | `Convert.ToInt32(user.Name)` |
| `IsTV` `0x4ECF630` | `GetIntDbId(user) < -1` — **المعرّفات ≤ −2 بوتات/شاشات** |
| `GetClanId` `0x4ED0570` | `GetClanMembership()?.ClanId` وإلا **`-1`** |

### المنطق المركّب ✅

```csharp
bool IsSubscribed(User u, bool includeTemp) {
    var st = u.GetVariable<SubscriptionStatus>("st", None);
    if (st == Subscribed /*2*/) return true;
    if (st == Temporary  /*3*/) return includeTemp;
    return false;
}
bool Can(User u, UserPermission p) => (u.GetVariable("pe", 0) & (int)p) == (int)p;
PlayerRank GetRank(User u) => new PlayerRank(u.GetVariable("pts", 0), u.GetVariable("isNew", false));
int GetFTHearts(User u) => 5 - u.GetVariable("ft_rl", 0);

SocialPlatform GetSocialPlatform(User u) {      // الترتيب يحدّد الأولوية
    if (!IsNullOrEmpty(u.GetVariable("s_f",""))) return Facebook; // 0
    if (!IsNullOrEmpty(u.GetVariable("s_t",""))) return Twitter;  // 1
    if (!IsNullOrEmpty(u.GetVariable("s_g",""))) return Google;   // 2
    if (!IsNullOrEmpty(u.GetVariable("s_a",""))) return Apple;    // 3
    return None;                                                  // -1
}
```

---

## ٣. رياضيات الرتب في المطابقة ✅

```csharp
GetHighestRankInRoom(room) =>
    room.GetPlayersInfo().Select(p => p.PlayerRank.Rank)
        .Where(r => r != Ranks.AI)                 // يستبعد البوتات فقط
        .OrderByDescending(r => (int)r).FirstOrDefault();

GetLowestRankInRoom(room)  => … .OrderBy(r => (int)r).FirstOrDefault();

float GetAverageRank(room) {
    var ranks = room.GetPlayersInfo().Select(p => p.PlayerRank.Rank).Where(r => r != Ranks.AI);
    return (float)ranks.Sum(r => (int)r) / (float)ranks.Count();
}
```
> ⚠️ `GetAverageRank` تقسم على `Count()` **بلا حماية** — غرفة بلا بشر تُنتج `NaN`. لا تنسخ هذا.

---

## ٤. جداول التعدادات ✅

**`GameType`**: `Friendly=0 · Ranked=1 · Tournament=2 · FastTrack=3 · Challenge=4`

**`TutorialType`**: `None=0 · Hokom=1 · Sun=2 · Catch=3 · AdvancedHokom=4 · AdvancedSun=5 ·
CatchSun=6 · CatchClosedDbl=7 · CatchHokomCut=8 · CatchHokomUp=9 · CatchHokomHKMCut=10 ·
CatchWrongSawa=11 · CatchWrongEkka=12`

**`PlayerRank.Ranks`**: `AI=0 · Beginner=1 · Intermediate=2 · Advanced=3 · Professional=4 ·
Expert=5 · Master=6 · Elite=7 · King=8`

**`SubscriptionStatus`**: `None=0 · Expired=1 · Subscribed=2 · Temporary=3`
**`SocialPlatform`**: `None=-1 · Facebook=0 · Twitter=1 · Google=2 · Apple=3`
**`TicketType`**: `PublicTournament=0 · OfficialTournament=1`
**`TournamentType`**: `Public=0 · Private=1 · Mass=2 · Official=3 · OfficialMonthly=4`
**`TournamentStatus`**: `Scheduled=0 · Running=1 · Cancelled=2 · Refunded=3 · Finished=4 · FinalCountdown=5`
**`MuteStatus`**: `None=0 · MutedByAdmin=1`
**`ChatInk`**: `Clean=0 · Admin=1 · Moderator=2 · MonthlyWinner=3 · Bomber=4 · BomberWeeklyTop1=5 · Top2=6 · Top3=7`
**`RankedPlayCondition`**: `CanPlay=0 · ShouldWatchAds=1 · ShouldPay=2 · MustPay=3`
**`MonthlyTournamentEligibilityType`**: `NotEligible=0 · Platinum=1 · Gold=2 · Silver=3 · Bronze=4`
**`ClanSubscriptionStatus`**: `Active=0 · Grace=1 · Inactive=2 · Archived=3 · Deleted=4`
**`TournamentPrizeType`**: `NotDetermined=0 · NoPrize=1 · Aces=2 · MassEventPoints=3 ·
MassStageAdvance=4 · TournamentPoints=9 · MonthlyPrize=10`

**`UserPermission`** (bitmask للمفتاح `pe`):
`AccessSwagger=1 · RunServerCommands=2 · ManageTournaments=4 · ResetBeggarCurrency=8 ·
AccessPrivateInfo=16 · HaveChatColor=32 · KickAndMutePlayers=64 · EditPlayerInfo=128 ·
ManageGameRooms=256 · AccessHiddenTournaments=512 · SeeBroadcasterView=1024 ·
IgnoreGameInvites=2048 · CreateTournamentsWithNoPrize=4096 ·
CreateVisiblePrivateTournaments=8192 · ForceFriend=16384 · PinMessage=32768 ·
EnterLockedServers=65536 · ManageMassTournament=131072`

---

## ٥. تنبيهات

1. **تصادم مفاتيح بين النطاقين — مقصود**: `"r"` في الغرفة = حدّ الرتبة، وفي المستخدم = ثيم
   الطاولة. و`"rt"` في الغرفة = مؤقّت جولة البطولة، وفي المستخدم = تاريخ التسجيل.
   النطاقان مستقلّان تمامًا.
2. **`IsOffline` ليست متغيّرًا** — تقارن `GroupId` بالنصّ `"Offline Rooms group"`.
   **اسم المجموعة هذا جزء من البروتوكول.**
3. **`ce` هي البوليان الوحيد الافتراضي `true`**، و`atl` هو العدد الوحيد الافتراضي `1`.
4. **`GetTutorialType` مفتاحها `Tut_type`** — بخلاف كل المفاتيح القصيرة. **لا تُخمّن `tt`.**
5. `GetUserById` ليست من امتدادات كملنا — هي من واجهة `Sfs2X.Entities.Room` (فتحة 27).
