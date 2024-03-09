-- Create SQL Technical user

CREATE USER "ALKO" IDENTIFIED BY "s$cretPassw0rd"
    DEFAULT TABLESPACE "USERS";

GRANT ALL PRIVILEGES TO "ALKO";

GRANT UNLIMITED TABLESPACE TO "ALKO";

-- Create base tables for ALKO

BEGIN 
CREATE TABLE "Users" (
    "EmailAddress" NVARCHAR2(255) NOT NULL,
    "FirstName" NVARCHAR2(50) NOT NULL,
    "MiddleName" NVARCHAR2(50) NOT NULL,
    "LastName" NVARCHAR2(50) NOT NULL,
    "PasswordHash" NVARCHAR2(100) NOT NULL,
    "Pronouns" NVARCHAR2(21) NOT NULL,
    "UserWatcher" NUMBER(1) NOT NULL,
    CONSTRAINT "PK_Users" PRIMARY KEY ("EmailAddress")
);
END;
/

BEGIN 
CREATE TABLE "Emails" (
    "Id" NUMBER(10) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
    "Title" NVARCHAR2(100) NOT NULL,
    "Content" NVARCHAR2(1000) NOT NULL,
    "Priority" NUMBER(10) NOT NULL,
    "CreatedAt" TIMESTAMP(7) NOT NULL,
    "SentAt" TIMESTAMP(7),
    "RecipientUserEmailAddress" NVARCHAR2(255) NOT NULL,
    CONSTRAINT "PK_Emails" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Emails_Users_RecipientUserEmailAddress" FOREIGN KEY ("RecipientUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

BEGIN 
CREATE TABLE "Followings" (
    "FollowerUserEmailAddress" NVARCHAR2(255) NOT NULL,
    "FollowedUserEmailAddress" NVARCHAR2(255) NOT NULL,
    CONSTRAINT "PK_Followings" PRIMARY KEY ("FollowedUserEmailAddress", "FollowerUserEmailAddress"),
    CONSTRAINT "FK_Followings_Users_FollowedUserEmailAddress" FOREIGN KEY ("FollowedUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE,
    CONSTRAINT "FK_Followings_Users_FollowerUserEmailAddress" FOREIGN KEY ("FollowerUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

BEGIN 
CREATE TABLE "Poetries" (
    "Id" NUMBER(10) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
    "Content" NVARCHAR2(1000) NOT NULL,
    "CreationDate" TIMESTAMP(7) NOT NULL,
    "CreatorUserEmailAddress" NVARCHAR2(255) NOT NULL,
    CONSTRAINT "PK_Poetries" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Poetries_Users_CreatorUserEmailAddress" FOREIGN KEY ("CreatorUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

BEGIN 
CREATE TABLE "Posts" (
    "Id" NUMBER(10) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
    "Content" NVARCHAR2(1000) NOT NULL,
    "CreationDate" TIMESTAMP(7) NOT NULL,
    "Location" NVARCHAR2(100),
    "CreatorUserEmailAddress" NVARCHAR2(255) NOT NULL,
    CONSTRAINT "PK_Posts" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Posts_Users_CreatorUserEmailAddress" FOREIGN KEY ("CreatorUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

BEGIN 
CREATE TABLE "WatchList" (
    "Id" NUMBER(10) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
    "From" TIMESTAMP(7) NOT NULL,
    "Until" TIMESTAMP(7) NOT NULL,
    "StalkedEmailAddress" NVARCHAR2(255) NOT NULL,
    "StalkerEmailAddress" NVARCHAR2(255) NOT NULL,
    CONSTRAINT "PK_WatchList" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_WatchList_Users_StalkedEmailAddress" FOREIGN KEY ("StalkedEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE,
    CONSTRAINT "FK_WatchList_Users_StalkerEmailAddress" FOREIGN KEY ("StalkerEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

BEGIN 
CREATE TABLE "Comments" (
    "Id" NUMBER(10) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
    "Content" NVARCHAR2(1000) NOT NULL,
    "CreationDate" TIMESTAMP(7) NOT NULL,
    "CreatorUserEmailAddress" NVARCHAR2(255) NOT NULL,
    "CommentedOnPostId" NUMBER(10),
    "CommentedOnPoetryId" NUMBER(10),
    CONSTRAINT "PK_Comments" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Comments_Poetries_CommentedOnPoetryId" FOREIGN KEY ("CommentedOnPoetryId") REFERENCES "Poetries" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Comments_Posts_CommentedOnPoetryId" FOREIGN KEY ("CommentedOnPoetryId") REFERENCES "Posts" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Comments_Users_CreatorUserEmailAddress" FOREIGN KEY ("CreatorUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

BEGIN 
CREATE TABLE "Engagements" (
    "Id" NUMBER(10) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
    "CreationDate" TIMESTAMP(7) NOT NULL,
    "CreatorUserEmailAddress" NVARCHAR2(255) NOT NULL,
    "EngagedWithPostId" NUMBER(10),
    "EngagedWithPoetryId" NUMBER(10),
    CONSTRAINT "PK_Engagements" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Engagements_Poetries_EngagedWithPoetryId" FOREIGN KEY ("EngagedWithPoetryId") REFERENCES "Poetries" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Engagements_Posts_EngagedWithPostId" FOREIGN KEY ("EngagedWithPostId") REFERENCES "Posts" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Engagements_Users_CreatorUserEmailAddress" FOREIGN KEY ("CreatorUserEmailAddress") REFERENCES "Users" ("EmailAddress") ON DELETE CASCADE
);
END;
/

-- Create indexes

CREATE INDEX "IX_Comments_CommentedOnPoetryId" ON "Comments" ("CommentedOnPoetryId")
/

CREATE INDEX "IX_Comments_CreatorUserEmailAddress" ON "Comments" ("CreatorUserEmailAddress")
/

CREATE INDEX "IX_Emails_RecipientUserEmailAddress" ON "Emails" ("RecipientUserEmailAddress")
/

CREATE INDEX "IX_Engagements_CreatorUserEmailAddress" ON "Engagements" ("CreatorUserEmailAddress")
/

CREATE INDEX "IX_Engagements_EngagedWithPoetryId" ON "Engagements" ("EngagedWithPoetryId")
/

CREATE INDEX "IX_Engagements_EngagedWithPostId" ON "Engagements" ("EngagedWithPostId")
/

CREATE INDEX "IX_Followings_FollowerUserEmailAddress" ON "Followings" ("FollowerUserEmailAddress")
/

CREATE INDEX "IX_Poetries_CreatorUserEmailAddress" ON "Poetries" ("CreatorUserEmailAddress")
/

CREATE INDEX "IX_Posts_CreatorUserEmailAddress" ON "Posts" ("CreatorUserEmailAddress")
/

CREATE INDEX "IX_WatchList_StalkedEmailAddress" ON "WatchList" ("StalkedEmailAddress")
/

CREATE INDEX "IX_WatchList_StalkerEmailAddress" ON "WatchList" ("StalkerEmailAddress")
/
