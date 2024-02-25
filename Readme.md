<div class="first-page pattern-dots-lg" style="color: #d3d3d3;">

# <div class="header-page" style="color: black;">A Legbiztonágosabb Közösségi Oldal <br> <small>Adatbázis alapú rendszerek beadandó</small>  </div>

</div>

<div class="page-break"></div>

## Csapat bemutatkozó

- **Csapat neve**: `A Legbiztonságosabb Közösségi Oldal`
- **Csapat tagjai**:
  - **Horváth Gergely Zsolt** (`BYVAM0`)
  - **Stefán Kornél** (`TFRXIL`)
  - **Vass Kinga** (`IZT6ZK`)
- **Gyakorlat**: `Kedd 08:00-10:00`
- **Kurzuskód**: `szte-IB152l`
- **Szemeszter**: `23/24/2`
- **Értékelési mód**: `csapat`

## Bemutató

A Legbiztonságosabb Közösségi Oldal (röviden ALKO, formerly known as Twitter) egy olyan közösségi oldal, ahol a felhasználók adatait csak mi... kezeljük.

<div class="page-break"></div>

## Funkciók

- Regisztráció és bejelentkezés
- Etetés: Az alkalmazásunk mások tartalmát megeteti veled egy összesítő felületen.
- Megosztás: Rövid szöveges üzenetek megosztása maximum 15 szó.
  - A mai fiatalok kb. ennyit tudnak felfogni.
  - Tudományos kutatások kimutatták, hogy a mai ifjúság nem tud ennyinél több szót felfogni (n=0.541 szórással, df=39).
- Kedvelés: A felhasználók jelezhetik másnak a bejegyzésén, hogy nem felel meg a biztonsági alaptételnek.
- Megjegyzés: A felhasználók megjegyzéseket fűzhetnek mások bejegyzéseihez.
  - Megjegyzések karakterszáma oszthatónak kell lennie 3-al.
  - Megjegyzések számának korlátozása 3-ra (per felhasználó). Ez teszi biztonságossá a rendszert, mivel így nem törhetnek ki nagy viták.
- Követés: A felhasználók követhetik egymást.
- Profil: A felhasználók megtekinthetik a saját és mások profilját.
  - Részletes fiók megtekintés: A felhasználók részletesen megtekinthetik a fiókjukat.
  - Részletes pronoun megtekintés
  - Név megtekintése
  - Profilkép integráció (Gravatar)
- Részletes fiók szerkesztés: A felhasználók részletesen szerkeszthetik a fiókjukat.
  - Részletes pronoun beállítás
  - Név megváltoztatása
  - Profilkép integráció (Gravatar)
- ALKO Hol: Tartózkodási hely megosztása ismerősökkel.
- ALKO Tás: Művészi (Haiku) formában oszthatnak meg az emberek itt műveket.
  - A Haiku egy japán költői forma, melynek 5-7-5 szótagú sorai vannak.
  - A Haiku formátumú bejegyzéseknek a szótagszámot ellenőrizzük.
- Biznisz megoldások magas profilú ügyfeleink számára (pl: állambiztonság).

<div class="page-break"></div>

## Képernyő tervek

# Bejelentkezés

![Bejelentkezés](./Screens/login.png)

# Regisztráció

![Regisztráció](./Screens/register.png)

# Főoldal

![Főoldal](./Screens/home.png)

# Profil

![Profil](./Screens/profile.png)

# Idővonal

![Idővonal](./Screens/feed.png)

## EK diagram

![Entity-Relationship Diagram](./Diagrams/ek.svg)

## EK Diagram értelmezés

> Fentről lefele megközelítés

User (<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, Watcher)

- {EmailAddress} -> FirstName, MiddleName, LastName, PasswordHash, Pronouns, Watcher

Following (<u>*UserEmailAddress*</u>, <u>*FollowingUserEmailAddress*</u>)

- 3 NF-ben van, mert mindkét attribútum kulcs.

EmailQueue (<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)

- {EmailId} -> Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*

WatchList (<u>WatchListId</u>, From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*)

- {WatchListId} -> From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*

Poetry (<u>PoetryId</u>, Content, CreationDate, *CreatorUserEmailAddress*)

- {PoetryId} -> Content, CreationDate, *CreatorUserEmailAddress*

Post (<u>PostId</u>, Content, CreationDate, Location, *CreatorUserEmailAddress*)

- {PostId} -> Content, CreationDate, Location, *CreatorUserEmailAddress*

Comment (<u>CommentId</u>, Content, CreationDate, *CreatorUserEmailAddress*, *CommentedOnPostId*, *CommentedOnPoetryId*)

- {CommentId} -> Content, CreationDate, *CreatorUserEmailAddress*, *CommentedOnPostId*, *CommentedOnPoetryId*

Engagement (<u>EngagementId</u>, CreationDate, *CreatorUserEmailAddress*, *EngagedWithPostId*, *EngagedWithPoetryId*)

- {EngagementId} -> CreationDate, *CreatorUserEmailAddress*, *EngagedWithPostId*, *EngagedWithPoetryId*


Minden attribútum atomi -> 1NF-ben vannak a relációsémák.

A sémákban egy kulcs van, kivéve a Following sémában, ahol viszont mindkét attribútum kulcs -> 2NF-ben vannak a relációsémák.

A fentebb felírt funkcionális függőségek alapján nincs tranzitív függés a sémákban -> 3NF-ben vannak a relációsémák.

## Funkcionális függőség elemzés

> Lentről felfele megközelítés

AllDataInDatabase(EmailAddress, UserFirstName, UserMiddleName, UserLastName, UserPasswordHash, UserPronouns, UserWatcher, UserFollowedUserEmailAddress, EmailId, EmailTitle, EmailContent, EmailSentAt, EmailCreatedAt, EmailPriority, EmailRecipientUserEmailAddress, WatchListId, WatchListFrom, WatchListUntil, WatchListStalkedEmailAddress, WatchListStalkerEmailAddress, PoetryId, PoetryContent, PoetryCreationDate, PoetryCreatorUserEmailAddress, PostId, PostContent, PostCreationDate, PostLocation, CommentId, CommentContent, CommentCreationDate, CommentCreatorUserEmailAddress, CommentedOnPostId, CommentedOnPoetryId, EngagementId, EngagementCreatorUserEmailAddress, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

- {EmailAddress} -> UserFirstName, UserMiddleName, UserLastName, UserPasswordHash, UserPronouns, UserWatcher
- {EmailId} -> EmailTitle, EmailContent, EmailSentAt, EmailCreatedAt, EmailPriority, EmailRecipientUserEmailAddress
- {WatchListId} -> WatchListFrom, WatchListUntil, WatchListStalkedEmailAddress, WatchListStalkerEmailAddress
- {PoetryId} -> PoetryContent, PoetryCreationDate, PoetryCreatorUserEmailAddress
- {PostId} -> PostContent, PostCreationDate, PostLocation
- {CommentId} -> CommentContent, CommentCreationDate, CommentCreatorUserEmailAddress, CommentedOnPostId, CommentedOnPoetryId
- {EngagementId} -> EngagementCreatorUserEmailAddress, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId

1. Válasszuk a felhasználó táblát külön az `EmailAddress` mentén

> Vegyük észre, hogy a UserFollowedUserEmailAddress, EmailRecipientUserEmailAddress, WatchListStalkedEmailAddress, WatchListStalkerEmailAddress, PoetryCreatorUserEmailAddress, CommentCreatorUserEmailAddress, EngagementCreatorUserEmailAddress mind UserEmailAddress-re mutatnak.

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)

AllDataInDatabase2(EmailId, EmailTitle, EmailContent, EmailSentAt, EmailCreatedAt, EmailPriority, *EmailRecipientUserEmailAddress*, WatchListId, WatchListFrom, WatchListUntil, *WatchListStalkedEmailAddress*, *WatchListStalkerEmailAddress*, PoetryId, PoetryContent, PoetryCreationDate, *PoetryCreatorUserEmailAddress*, PostId, PostContent, PostCreationDate, PostLocation, CommentId, CommentContent, CommentCreationDate, *CommentCreatorUserEmailAddress*, CommentedOnPostId, CommentedOnPoetryId, EngagementId, *EngagementCreatorUserEmailAddress*, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

2. Válasszuk az EmailQueue táblát külön az `EmailId` mentén

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)
EmailQueue(<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)

AllDataInDatabase3(WatchListId, WatchListFrom, WatchListUntil, *WatchListStalkedEmailAddress*, *WatchListStalkerEmailAddress*, PoetryId, PoetryContent, PoetryCreationDate, *PoetryCreatorUserEmailAddress*, PostId, PostContent, PostCreationDate, PostLocation, CommentId, CommentContent, CommentCreationDate, *CommentCreatorUserEmailAddress*, CommentedOnPostId, CommentedOnPoetryId, EngagementId, *EngagementCreatorUserEmailAddress*, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

3. Válasszuk a WatchList táblát külön a `WatchListId` mentén

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)
EmailQueue(<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)
WatchList(<u>WatchListId</u>, From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*)

AllDataInDatabase4(PoetryId, PoetryContent, PoetryCreationDate, *PoetryCreatorUserEmailAddress*, PostId, PostContent, PostCreationDate, PostLocation, CommentId, CommentContent, CommentCreationDate, *CommentCreatorUserEmailAddress*, CommentedOnPostId, CommentedOnPoetryId, EngagementId, *EngagementCreatorUserEmailAddress*, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

4. Válasszuk a Poetry táblát külön a `PoetryId` mentén

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)
EmailQueue(<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)
WatchList(<u>WatchListId</u>, From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*)
Poetry(<u>PoetryId</u>, Content, CreationDate, *CreatorUserEmailAddress*)

AllDataInDatabase5(PostId, PostContent, PostCreationDate, PostLocation, CommentId, CommentContent, CommentCreationDate, *CommentCreatorUserEmailAddress*, CommentedOnPostId, CommentedOnPoetryId, EngagementId, *EngagementCreatorUserEmailAddress*, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

5. Válasszuk a Post táblát külön a `PostId` mentén

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)
EmailQueue(<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)
WatchList(<u>WatchListId</u>, From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*)
Poetry(<u>PoetryId</u>, Content, CreationDate, *CreatorUserEmailAddress*)
Post(<u>PostId</u>, Content, CreationDate, Location, *CreatorUserEmailAddress*)

AllDataInDatabase6(CommentId, CommentContent, CommentCreationDate, *CommentCreatorUserEmailAddress*, CommentedOnPostId, CommentedOnPoetryId, EngagementId, *EngagementCreatorUserEmailAddress*, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

6. Válasszuk a Comment táblát külön a `CommentId` mentén

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)
EmailQueue(<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)
WatchList(<u>WatchListId</u>, From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*)
Poetry(<u>PoetryId</u>, Content, CreationDate, *CreatorUserEmailAddress*)
Post(<u>PostId</u>, Content, CreationDate, Location, *CreatorUserEmailAddress*)
Comment(<u>CommentId</u>, Content, CreationDate, *CreatorUserEmailAddress*, *CommentedOnPostId*, *CommentedOnPoetryId*)

AllDataInDatabase7(EngagementId, *EngagementCreatorUserEmailAddress*, EngagementCreationDate, EngagedWithPostId, EngagedWithPoetryId)

7. Lássuk be, hogy a maradt tulajdonságok az Engagement tábla

User(<u>EmailAddress</u>, FirstName, MiddleName, LastName, PasswordHash, Pronouns, UserWatcher)
EmailQueue(<u>EmailId</u>, Title, Content, SentAt, CreatedAt, Priority, *RecipientUserEmailAddress*)
WatchList(<u>WatchListId</u>, From, Until, *StalkedEmailAddress*, *StalkerEmailAddress*)
Poetry(<u>PoetryId</u>, Content, CreationDate, *CreatorUserEmailAddress*)
Post(<u>PostId</u>, Content, CreationDate, Location, *CreatorUserEmailAddress*)
Comment(<u>CommentId</u>, Content, CreationDate, *CreatorUserEmailAddress*, *CommentedOnPostId*, *CommentedOnPoetryId*)
Engagement(<u>EngagementId</u>, *CreatorUserEmailAddress*, CreationDate, EngagedWithPostId, EngagedWithPoetryId)

## EK Diagram elemzések egyesítése, értékelés

Az EK elemzések során megállapítottuk, hogy az azonosítók mentén azonos táblastruktúrára jutunk a két módszerrel. Ez nem feltétlen jelenti az optimális megoldást, de biztosak lehetünk abban, hogy az adatbázisunk 3NF-ben van.

## Egyed Modell

![Entity Model Diagram](./Diagrams/em.svg)

<div class="page-break"></div>

## Fizikai adatfolyam

![Physical Data Flow](./Diagrams/adatfolyam-fizikai.svg)

<div class="page-break"></div>

## Logikai adatfolyam

![Logical Data Flow](./Diagrams/adatfolyam-logikai.svg)

<div class="page-break"></div>

## Szerep-funkció mátrix

![Role-Function Matrix](./Diagrams/matrix-szerep.svg)

## Egyed-esemény mátrix
![Entity-Event Matrix](./Diagrams/matrix-esemeny.svg)

<div class="page-break"></div>

## Funkció meghatározás

![Function definition](./Diagrams/funkcio-1121.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-3.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-41.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-51.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-52.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-6.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-71.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-8.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-9.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-10.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-11.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-121.svg)

<div class="page-break"></div>

![Function definition](./Diagrams/funkcio-123.svg)

<div class="page-break"></div>

## Menütervek

### Felhasználó

```mermaid
stateDiagram-v2

state "Nem bejelentkezett főoldal" as notloggedin
state "MEN0" as notloggedin
notloggedin --> login
notloggedin --> register

#Login
state "Login" as login
state "Men1" as login

#Register
state "Register" as register
state "Men2" as register

login --> loggedin
register --> loggedin

state "Bejelentkezett főoldal" as loggedin
state "MEN3" as loggedin
loggedin --> profile
loggedin --> timeline
loggedin --> viewprofile

#Profil kezelés
state "Profil kezelés" as profile
state "Men4" as profile

#Idővonal megtekintése
state "Idővonal megtekintése" as timeline
state "Men5" as timeline
timeline --> like
timeline --> createpost
timeline --> sharepoetry
timeline --> addcomment

#Bejegyzés létrehozás
state "Bejegyzés létrehozás" as createpost
state "Men6" as createpost
createpost --> sharelocation

#Tartózkodási hely megosztása
state "Tartózkodási hely megosztása" as sharelocation
state "Men7" as sharelocation

#Művészi alkotás megosztása
state "Művészi alkotás megosztása" as sharepoetry
state "Men8" as sharepoetry

#Kedvelés
state "Kedvelés" as like
state "Men9" as like

#Megjegyzés hozzáadása
state "Megjegyzés hozzáadása" as addcomment
state "Men10" as addcomment

#Profil megtekintés
state "Profil megtekintés" as viewprofile
state "Men11" as viewprofile
viewprofile --> follow

# Követés
state "Követés" as follow
state "Men12" as follow

#state "Bejelentkezett főoldal" as avh
#state "MEN3" as avh
#avh --> watchuser

```

<div class="page-break"></div>

### ÁVH Felhasználó

```mermaid
stateDiagram-v2

state "Nem bejelentkezett főoldal" as notloggedin
state "MEN0" as notloggedin
notloggedin --> login
notloggedin --> register

#Login
state "Login" as login
state "Men1" as login

#Register
state "Register" as register
state "Men2" as register

login --> loggedin
register --> loggedin

state "Bejelentkezett főoldal" as loggedin
state "MEN3" as loggedin
loggedin --> profile
loggedin --> timeline
loggedin --> viewprofile

#Profil kezelés
state "Profil kezelés" as profile
state "Men4" as profile

#Idővonal megtekintése
state "Idővonal megtekintése" as timeline
state "Men5" as timeline
timeline --> like
timeline --> createpost
timeline --> sharepoetry
timeline --> addcomment

#Bejegyzés létrehozás
state "Bejegyzés létrehozás" as createpost
state "Men6" as createpost
createpost --> sharelocation

#Tartózkodási hely megosztása
state "Tartózkodási hely megosztása" as sharelocation
state "Men7" as sharelocation

#Művészi alkotás megosztása
state "Művészi alkotás megosztása" as sharepoetry
state "Men8" as sharepoetry

#Kedvelés
state "Kedvelés" as like
state "Men9" as like

#Megjegyzés hozzáadása
state "Megjegyzés hozzáadása" as addcomment
state "Men10" as addcomment

#Profil megtekintés
state "Profil megtekintés" as viewprofile
state "Men11" as viewprofile
viewprofile --> follow
viewprofile --> watchuser

# Követés
state "Követés" as follow
state "Men12" as follow

#state "Bejelentkezett főoldal" as avh
#state "MEN3" as avh
#avh --> watchuser

#Felhasználó megfigyelés
state "Felhasználó megfigyelés" as watchuser
state "Men3" as watchuser

```

<div class="page-break"></div>

## Munkafelosztás

### 1. mérföldkő

<div style="width: 400px;">

![Munkafelosztás 1. mérföldkő](./Diagrams/workitems-1.png)

</div>

### 2. mérföldkő

<div style="width: 400px;">

![Munkafelosztás 2. mérföldkő](./Diagrams/workitems-2.png)

</div>

<div class="page-break"></div>

### 3-4. mérföldkő

<div style="width: 400px;">

![Munkafelosztás 3-4. mérföldkő](./Diagrams/workitems-34.png)

</div>
