
-- User tábla feltöltése (pass: asdasd)
INSERT INTO "Users" VALUES ('example@email.com', 'Béla', 'Kálmán', 'Kiss', 'AQAAAAIAAYagAAAAEHzpJ4rfTf4UvPnqo6XV+V+c2IzsfV3djGgTNOqSWaafzmAFdISh0SVzpn+9TIX2pw==', 'He/Him', 0);
INSERT INTO "Users" VALUES ('ferencjozsi@gmail.com', 'József', 'XVI.', 'Ferenc', 'AQAAAAIAAYagAAAAEHzpJ4rfTf4UvPnqo6XV+V+c2IzsfV3djGgTNOqSWaafzmAFdISh0SVzpn+9TIX2pw==', 'OM/M', 0);
INSERT INTO "Users" VALUES ('krumpli@gmail.com', 'Krump', 'L.', 'Lee', 'AQAAAAIAAYagAAAAEHzpJ4rfTf4UvPnqo6XV+V+c2IzsfV3djGgTNOqSWaafzmAFdISh0SVzpn+9TIX2pw==', 'She/Her', 0);
INSERT INTO "Users" VALUES ('spambot@bots.com', 'Duleep', 'Rishit', 'Ladesh', 'AQAAAAIAAYagAAAAEHzpJ4rfTf4UvPnqo6XV+V+c2IzsfV3djGgTNOqSWaafzmAFdISh0SVzpn+9TIX2pw==', 'BOT/IT', 0);
INSERT INTO "Users" VALUES ('twitter@twitter.com', 'Twitter', 'Formerly Known', 'As X', 'AQAAAAIAAYagAAAAEHzpJ4rfTf4UvPnqo6XV+V+c2IzsfV3djGgTNOqSWaafzmAFdISh0SVzpn+9TIX2pw==', 'He/Him', 1);
INSERT INTO "Users" VALUES ('contact@avh.com', 'Béla', 'K.', 'Kun', 'AQAAAAIAAYagAAAAEHzpJ4rfTf4UvPnqo6XV+V+c2IzsfV3djGgTNOqSWaafzmAFdISh0SVzpn+9TIX2pw==', 'AV/H', 1);

-- Posts tábla feltöltése

INSERT INTO "Posts"	VALUES (1, 'Lorem ipsum dolor', SYSTIMESTAMP, 'Szeged', 'example@email.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (2, 'Next Im buying Coca-Cola to put the cocaine back in', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (3, 'Its a new day in America.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Posts"	VALUES (4, 'Congratulations to the Astronauts that left Earth today. Good choice!', SYSTIMESTAMP, 'ISS', 'example@email.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (5, 'hello literally everyone', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Posts"	VALUES (6, 'this is what happens when you dont recycle your pizza boxes', SYSTIMESTAMP, 'Sweden', 'example@email.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (7, 'Gonna go to pizza hut', SYSTIMESTAMP, 'example@email.com');

INSERT INTO "Posts"	VALUES (8, 'Krumpli', SYSTIMESTAMP, 'Krumpliföldek', 'krumpli@gmail.com');
INSERT INTO "Posts"	VALUES (9, 'Po-ta-toes - boil them , mash them, stick them in a stew', SYSTIMESTAMP, 'Krumpliföldek', 'krumpli@gmail.com');
INSERT INTO "Posts"	VALUES (10, 'Potato', SYSTIMESTAMP, 'Potatoland', 'krumpli@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (11, 'Who is the most powerful potato? Darth Tater.', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (12, 'Why was the potato taken to a psychiatric hospital? It was starch raving mad.', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (13, 'What does a potato say on a sunny morning? What a mashing day!', SYSTIMESTAMP, 'krumpli@gmail.com');

INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (14, 'Twitter, formerly known as X', SYSTIMESTAMP, 'twitter@twitter.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (15, 'Its acquisition time!', SYSTIMESTAMP, 'twitter@twitter.com');
INSERT INTO "Posts"	VALUES (16, 'Twitter servers are down', SYSTIMESTAMP, 'Twitter HQ', 'twitter@twitter.com');
INSERT INTO "Posts"	VALUES (17, 'Twitter servers are on fire', SYSTIMESTAMP, 'Twitter HQ', 'twitter@twitter.com');
INSERT INTO "Posts"	VALUES (18, 'Everything back to normal', SYSTIMESTAMP, 'Twitter HQ', 'twitter@twitter.com');
INSERT INTO "Posts"	VALUES (19, 'Twitter servers are down again', SYSTIMESTAMP, 'Twitter HQ', 'twitter@twitter.com');
INSERT INTO "Posts"	VALUES (20, 'Like if you saw this tweet', SYSTIMESTAMP, 'Twitter HQ', 'twitter@twitter.com');

INSERT INTO "Posts"	VALUES (21, 'Time to reunite Austria-Hungary', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (22, 'Its morbin time', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (23, 'So hard being Emperor', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (24, 'The HRE isnt actually holy', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (25, 'Take the L, HRE', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (26, 'Its morbin time again', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (27, 'Woopsies, just caused a world war', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts"	VALUES (28, 'Nice day for a stroll in the imperial palace', SYSTIMESTAMP, 'Vienna', 'ferencjozsi@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (29, 'Using ChatGPT to manage the empire. lol', SYSTIMESTAMP, 'ferencjozsi@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (30, 'AI driven autocracy is the new fad', SYSTIMESTAMP, 'ferencjozsi@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (31, 'GPT-4 will take our jobs... even the emperors', SYSTIMESTAMP, 'ferencjozsi@gmail.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (32, 'GPT-5 doing a good job governing the empire #ad', SYSTIMESTAMP, 'ferencjozsi@gmail.com');

INSERT INTO "Posts"	VALUES (33, 'If you see any suspicious activity on the platform, contact your friendly neighbourhood ÁVH!', SYSTIMESTAMP, 'Vienna', 'contact@avh.com');

INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (34, 'Hello this is Duleep', SYSTIMESTAMP, 'spambot@bots.com');

INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (35, 'Its spamming time', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (36, 'Spam spam spam', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (37, 'All my bots are farming likes', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (38, 'Check out my posts', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (39, 'Check out my OF page', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts"	VALUES (40, 'Error - bots out of control', SYSTIMESTAMP, 'Old Delhi', 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (41, 'Bots under control', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (42, 'Were going to Bangladesh! Kid named Ladesh:', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (43, 'Hello this is tech Support', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (44, 'How may I help you?', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Posts" ("Id", "Content", "CreationDate", "CreatorUserEmailAddress")
	VALUES (45, 'Duleep here', SYSTIMESTAMP, 'spambot@bots.com');

-- Poetries tábla feltöltése
INSERT INTO "Poetries" VALUES (1, 
'In pale moonlight
the wisteria’s scent
comes from far away.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (2, 
'The earth shakes
just enough
to remind us.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (3, 
'O snail
Climb Mount Fuji,
But slowly, slowly!', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (4, 
'I want to sleep
Swat the flies
Softly, please.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (5, 
'meteor shower
a gentle wave
wets our sandals', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (6, 
'The west wind whispered,
And touched the eyelids of spring:                                                                         
Her eyes, Primroses.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (7, 
'After killing
a spider, how lonely I feel
in the cold of night!', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (8, 
'I kill an ant
and realize my three children
have been watching.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (9, 
'Over the wintry
forest, winds howl in rage
with no leaves to blow.', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (10, 
'cherry blossoms
fall! fall!
enough to fill my belly', SYSTIMESTAMP, 'example@email.com');
INSERT INTO "Poetries" VALUES (11, 
'The lamp once out
Cool stars enter
The window frame.', SYSTIMESTAMP, 'example@email.com');

INSERT INTO "Poetries" VALUES (12, 
'The snow of yesterday
That fell like cherry blossoms
Is water once again', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (13, 
'First autumn morning
the mirror I stare into
shows my fathers face.', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (14, 
'What is it but a dream?
The blooming as well
Lasts only seven cycles', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (15, 
'Even in Kyoto,
Hearing the cuckoos cry,
I long for Kyoto', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (16, 
'The crow has flown away:
Swaying in the evening sun,
A leafless tree', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (17, 
'The neighing horses
are causing echoing neighs
in neighboring barns', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (18, 
'A raindrop from
the roof
Fell in my beer', SYSTIMESTAMP, 'krumpli@gmail.com');
INSERT INTO "Poetries" VALUES (19, 
'Plum flower temple:
Voices rise
From the foothills', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Poetries" VALUES (20, 
'losing its name
a river
enters the sea', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Poetries" VALUES (21, 
'Grasses wilt:
the braking locomotive
grinds to a halt.', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Poetries" VALUES (22, 
'Everything I touch
with tenderness, alas,
pricks like a bramble', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Poetries" VALUES (23, 
'An old silent pond
A frog jumps into the pond—
Splash! Silence again.', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Poetries" VALUES (24, 
'A world of dew,
And within every dewdrop
A world of struggle.', SYSTIMESTAMP, 'spambot@bots.com');
INSERT INTO "Poetries" VALUES (25, 
'I write, erase, rewrite
Erase again, and then
A poppy blooms.', SYSTIMESTAMP, 'spambot@bots.com');

-- WatchList tábla feltöltése
INSERT INTO "WatchList" VALUES (
1, 
TO_TIMESTAMP('2024-03-14 11:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
TO_TIMESTAMP('2024-03-20 11:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
'krumpli@gmail.com', 
'contact@avh.com');
INSERT INTO "WatchList" VALUES (
2, 
TO_TIMESTAMP('2024-03-14 12:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
TO_TIMESTAMP('2024-06-30 12:20:12', 'YYYY-MM-DD HH24:MI:SS'), 
'example@email.com', 
'contact@avh.com');
INSERT INTO "WatchList" VALUES (
3, 
TO_TIMESTAMP('2024-03-10 12:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
TO_TIMESTAMP('2024-04-20 12:04:04', 'YYYY-MM-DD HH24:MI:SS'), 
'example@email.com', 
'twitter@twitter.com');
INSERT INTO "WatchList" VALUES (
4, 
TO_TIMESTAMP('2024-02-01 20:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
TO_TIMESTAMP('2024-04-04 20:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
'ferencjozsi@gmail.com', 
'contact@avh.com');
INSERT INTO "WatchList" VALUES (
5, 
TO_TIMESTAMP('2024-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
TO_TIMESTAMP('2024-04-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), 
'spambot@bots.com', 
'contact@avh.com');

-- Followings tábla feltöltése
INSERT INTO "Followings" VALUES ('krumpli@gmail.com', 'twitter@twitter.com');
INSERT INTO "Followings" VALUES ('krumpli@gmail.com', 'example@email.com');
INSERT INTO "Followings" VALUES ('krumpli@gmail.com', 'ferencjozsi@gmail.com');
INSERT INTO "Followings" VALUES ('krumpli@gmail.com', 'spambot@bots.com');

INSERT INTO "Followings" VALUES ('twitter@twitter.com', 'krumpli@gmail.com');
INSERT INTO "Followings" VALUES ('twitter@twitter.com', 'example@email.com');
INSERT INTO "Followings" VALUES ('twitter@twitter.com', 'ferencjozsi@gmail.com');
INSERT INTO "Followings" VALUES ('twitter@twitter.com', 'spambot@bots.com');

INSERT INTO "Followings" VALUES ('contact@avh.com', 'krumpli@gmail.com');
INSERT INTO "Followings" VALUES ('contact@avh.com', 'example@email.com');
INSERT INTO "Followings" VALUES ('contact@avh.com', 'ferencjozsi@gmail.com');
INSERT INTO "Followings" VALUES ('contact@avh.com', 'twitter@twitter.com');
INSERT INTO "Followings" VALUES ('contact@avh.com', 'spambot@bots.com');

INSERT INTO "Followings" VALUES ('example@email.com', 'krumpli@gmail.com');
INSERT INTO "Followings" VALUES ('example@email.com', 'twitter@twitter.com');

INSERT INTO "Followings" VALUES ('spambot@bots.com', 'twitter@twitter.com');
INSERT INTO "Followings" VALUES ('spambot@bots.com', 'example@email.com');
INSERT INTO "Followings" VALUES ('spambot@bots.com', 'ferencjozsi@gmail.com');

-- Engagements tábla feltöltése
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (1, SYSTIMESTAMP, 'krumpli@gmail.com', 1);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (2, SYSTIMESTAMP, 'krumpli@gmail.com', 33);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (3, SYSTIMESTAMP, 'krumpli@gmail.com', 25);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (4, SYSTIMESTAMP, 'krumpli@gmail.com', 20);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (5, SYSTIMESTAMP, 'krumpli@gmail.com', 42);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (6, SYSTIMESTAMP, 'krumpli@gmail.com', 25);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (7, SYSTIMESTAMP, 'krumpli@gmail.com', 33);

INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (8, SYSTIMESTAMP, 'krumpli@gmail.com', 1);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (9, SYSTIMESTAMP, 'krumpli@gmail.com', 4);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (10, SYSTIMESTAMP, 'krumpli@gmail.com', 8);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (11, SYSTIMESTAMP, 'krumpli@gmail.com', 24);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (12, SYSTIMESTAMP, 'krumpli@gmail.com', 25);

INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (13, SYSTIMESTAMP, 'example@email.com', 30);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (14, SYSTIMESTAMP, 'example@email.com', 34);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (15, SYSTIMESTAMP, 'example@email.com', 25);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (16, SYSTIMESTAMP, 'example@email.com', 21);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (17, SYSTIMESTAMP, 'example@email.com', 42);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (18, SYSTIMESTAMP, 'example@email.com', 25);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (19, SYSTIMESTAMP, 'example@email.com', 33);

INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (20, SYSTIMESTAMP, 'example@email.com', 12);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (21, SYSTIMESTAMP, 'example@email.com', 16);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (22, SYSTIMESTAMP, 'example@email.com', 17);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (23, SYSTIMESTAMP, 'example@email.com', 24);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (24, SYSTIMESTAMP, 'example@email.com', 25);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (25, SYSTIMESTAMP, 'example@email.com', 20);

INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (26, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 1);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (27, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 10);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (28, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 3);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (29, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 43);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (30, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 44);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (31, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 2);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPostId") 
VALUES (32, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 9);

INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (33, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 12);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (34, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 6);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (35, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 17);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (36, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 24);
INSERT INTO "Engagements" ("Id", "CreationDate", "CreatorUserEmailAddress", "EngagedWithPoetryId") 
VALUES (37, SYSTIMESTAMP, 'ferencjozsi@gmail.com', 25);

-- Emails tábla feltöltése
INSERT INTO "Emails" VALUES
(1, 'Warning', 'User has posted', 1, SYSTIMESTAMP, SYSTIMESTAMP, 'contact@avh.com');
INSERT INTO "Emails" VALUES
(2, 'Giga Warning', 'Another user has posted', 1, SYSTIMESTAMP, SYSTIMESTAMP, 'contact@avh.com');
INSERT INTO "Emails" VALUES
(3, 'Mega Warning', 'Problematic user has posted', 1, SYSTIMESTAMP, SYSTIMESTAMP, 'contact@avh.com');
INSERT INTO "Emails" VALUES
(4, 'Mega Warning', 'Problematic user has posted', 1, SYSTIMESTAMP, SYSTIMESTAMP, 'twitter@twitter.com');
INSERT INTO "Emails" VALUES
(5, 'Warning', 'Problematic user has posted', 2, SYSTIMESTAMP, SYSTIMESTAMP, 'twitter@twitter.com');

-- Comments tábla feltöltése
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (1, 'Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 1);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (2, 'Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 10);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (3, 'Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 2);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (4, 'Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 3);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (5, 'Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 4);

INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (6, 'Nice Haiku, Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 1);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (7, 'Nice Haiku, Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 3);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (8, 'Nice Haiku, Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 5);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (9, 'Nice Haiku, Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 7);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (10, 'Nice Haiku, Check out my page~', SYSTIMESTAMP, 'spambot@bots.com', 9);

INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (11, 'lol', SYSTIMESTAMP, 'example@email.com', 14);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (12, 'love it', SYSTIMESTAMP, 'example@email.com', 22);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (13, 'laughed out loud', SYSTIMESTAMP, 'example@email.com', 33);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (14, 'i have seen enough internet for today', SYSTIMESTAMP, 'example@email.com', 25);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPostId")
VALUES (15, 'Xd', SYSTIMESTAMP, 'example@email.com', 17);

INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (16, 'beautiful', SYSTIMESTAMP, 'ferencjozsi@gmail.com', 24);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (17, 'danke', SYSTIMESTAMP, 'ferencjozsi@gmail.com', 1);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (18, 'Nice haiku to conquer the world to', SYSTIMESTAMP, 'ferencjozsi@gmail.com', 25);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (19, 'Was this generated by AI?', SYSTIMESTAMP, 'ferencjozsi@gmail.com', 7);
INSERT INTO "Comments" 
("Id", "Content", "CreationDate", "CreatorUserEmailAddress", "CommentedOnPoetryId")
VALUES (20, 'GPT-4 going hard', SYSTIMESTAMP, 'ferencjozsi@gmail.com', 3);
