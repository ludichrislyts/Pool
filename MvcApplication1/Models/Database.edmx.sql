
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/13/2015 23:38:15
-- Generated from EDMX file: C:\Users\ludichrislyts\Documents\Visual Studio 2012\Projects\MvcApplication1\MvcApplication1\Models\Database.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PlaceUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_PlaceUser];
GO
IF OBJECT_ID(N'[dbo].[FK_AvatarUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_AvatarUser];
GO
IF OBJECT_ID(N'[dbo].[FK_BadgeUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_BadgeUser];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaceStaticReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StaticReviews] DROP CONSTRAINT [FK_PlaceStaticReview];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentPlace]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_CommentPlace];
GO
IF OBJECT_ID(N'[dbo].[FK_UserComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_UserComment];
GO
IF OBJECT_ID(N'[dbo].[FK_UserStaticReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StaticReviews] DROP CONSTRAINT [FK_UserStaticReview];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitPlace_Visit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitPlace] DROP CONSTRAINT [FK_VisitPlace_Visit];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitPlace_Place]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitPlace] DROP CONSTRAINT [FK_VisitPlace_Place];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitUser_Visit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitUser] DROP CONSTRAINT [FK_VisitUser_Visit];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitUser] DROP CONSTRAINT [FK_VisitUser_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Places]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Places];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[StaticReviews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StaticReviews];
GO
IF OBJECT_ID(N'[dbo].[Badges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Badges];
GO
IF OBJECT_ID(N'[dbo].[Avatars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Avatars];
GO
IF OBJECT_ID(N'[dbo].[Visits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visits];
GO
IF OBJECT_ID(N'[dbo].[VisitPlace]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitPlace];
GO
IF OBJECT_ID(N'[dbo].[VisitUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Places'
CREATE TABLE [dbo].[Places] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL,
    [city] nvarchar(max)  NOT NULL,
    [state] nvarchar(max)  NOT NULL,
    [zip] int  NOT NULL,
    [phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [PlaceId] int  NOT NULL,
    [AvatarId] int  NOT NULL,
    [BadgeId] int  NOT NULL,
    [Comment_Id] int  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [text] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [PlaceId] int  NOT NULL
);
GO

-- Creating table 'StaticReviews'
CREATE TABLE [dbo].[StaticReviews] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [review] nvarchar(max)  NOT NULL,
    [PlaceId] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Badges'
CREATE TABLE [dbo].[Badges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [image] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Avatars'
CREATE TABLE [dbo].[Avatars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [image] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Visits'
CREATE TABLE [dbo].[Visits] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'VisitPlace'
CREATE TABLE [dbo].[VisitPlace] (
    [Visits_Id] int  NOT NULL,
    [Places_Id] int  NOT NULL
);
GO

-- Creating table 'VisitUser'
CREATE TABLE [dbo].[VisitUser] (
    [Visits_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Places'
ALTER TABLE [dbo].[Places]
ADD CONSTRAINT [PK_Places]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StaticReviews'
ALTER TABLE [dbo].[StaticReviews]
ADD CONSTRAINT [PK_StaticReviews]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Badges'
ALTER TABLE [dbo].[Badges]
ADD CONSTRAINT [PK_Badges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Avatars'
ALTER TABLE [dbo].[Avatars]
ADD CONSTRAINT [PK_Avatars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [PK_Visits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Visits_Id], [Places_Id] in table 'VisitPlace'
ALTER TABLE [dbo].[VisitPlace]
ADD CONSTRAINT [PK_VisitPlace]
    PRIMARY KEY NONCLUSTERED ([Visits_Id], [Places_Id] ASC);
GO

-- Creating primary key on [Visits_Id], [Users_Id] in table 'VisitUser'
ALTER TABLE [dbo].[VisitUser]
ADD CONSTRAINT [PK_VisitUser]
    PRIMARY KEY NONCLUSTERED ([Visits_Id], [Users_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PlaceId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_PlaceUser]
    FOREIGN KEY ([PlaceId])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaceUser'
CREATE INDEX [IX_FK_PlaceUser]
ON [dbo].[Users]
    ([PlaceId]);
GO

-- Creating foreign key on [AvatarId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_AvatarUser]
    FOREIGN KEY ([AvatarId])
    REFERENCES [dbo].[Avatars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AvatarUser'
CREATE INDEX [IX_FK_AvatarUser]
ON [dbo].[Users]
    ([AvatarId]);
GO

-- Creating foreign key on [BadgeId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_BadgeUser]
    FOREIGN KEY ([BadgeId])
    REFERENCES [dbo].[Badges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BadgeUser'
CREATE INDEX [IX_FK_BadgeUser]
ON [dbo].[Users]
    ([BadgeId]);
GO

-- Creating foreign key on [PlaceId] in table 'StaticReviews'
ALTER TABLE [dbo].[StaticReviews]
ADD CONSTRAINT [FK_PlaceStaticReview]
    FOREIGN KEY ([PlaceId])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaceStaticReview'
CREATE INDEX [IX_FK_PlaceStaticReview]
ON [dbo].[StaticReviews]
    ([PlaceId]);
GO

-- Creating foreign key on [PlaceId] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_CommentPlace]
    FOREIGN KEY ([PlaceId])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentPlace'
CREATE INDEX [IX_FK_CommentPlace]
ON [dbo].[Comments]
    ([PlaceId]);
GO

-- Creating foreign key on [Comment_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_UserComment]
    FOREIGN KEY ([Comment_Id])
    REFERENCES [dbo].[Comments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserComment'
CREATE INDEX [IX_FK_UserComment]
ON [dbo].[Users]
    ([Comment_Id]);
GO

-- Creating foreign key on [UserId] in table 'StaticReviews'
ALTER TABLE [dbo].[StaticReviews]
ADD CONSTRAINT [FK_UserStaticReview]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserStaticReview'
CREATE INDEX [IX_FK_UserStaticReview]
ON [dbo].[StaticReviews]
    ([UserId]);
GO

-- Creating foreign key on [Visits_Id] in table 'VisitPlace'
ALTER TABLE [dbo].[VisitPlace]
ADD CONSTRAINT [FK_VisitPlace_Visit]
    FOREIGN KEY ([Visits_Id])
    REFERENCES [dbo].[Visits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Places_Id] in table 'VisitPlace'
ALTER TABLE [dbo].[VisitPlace]
ADD CONSTRAINT [FK_VisitPlace_Place]
    FOREIGN KEY ([Places_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitPlace_Place'
CREATE INDEX [IX_FK_VisitPlace_Place]
ON [dbo].[VisitPlace]
    ([Places_Id]);
GO

-- Creating foreign key on [Visits_Id] in table 'VisitUser'
ALTER TABLE [dbo].[VisitUser]
ADD CONSTRAINT [FK_VisitUser_Visit]
    FOREIGN KEY ([Visits_Id])
    REFERENCES [dbo].[Visits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'VisitUser'
ALTER TABLE [dbo].[VisitUser]
ADD CONSTRAINT [FK_VisitUser_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitUser_User'
CREATE INDEX [IX_FK_VisitUser_User]
ON [dbo].[VisitUser]
    ([Users_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------