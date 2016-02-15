
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/14/2016 17:20:31
-- Generated from EDMX file: C:\Users\Aaron Campf\Documents\GitHub\Pool\MvcApplication1\Models\Database.edmx
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

IF OBJECT_ID(N'[dbo].[FK_VisitPlace_Places]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitPlace] DROP CONSTRAINT [FK_VisitPlace_Places];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitPlace_Visits]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitPlace] DROP CONSTRAINT [FK_VisitPlace_Visits];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitUser_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitUser] DROP CONSTRAINT [FK_VisitUser_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitUser_Visits]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitUser] DROP CONSTRAINT [FK_VisitUser_Visits];
GO
IF OBJECT_ID(N'[dbo].[FK_UserBadge_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserBadge] DROP CONSTRAINT [FK_UserBadge_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserBadge_Badge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserBadge] DROP CONSTRAINT [FK_UserBadge_Badge];
GO
IF OBJECT_ID(N'[dbo].[FK_UserComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_UserComment];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaceStaticReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StaticReviews] DROP CONSTRAINT [FK_PlaceStaticReview];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaceComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_PlaceComment];
GO
IF OBJECT_ID(N'[dbo].[FK_UserStaticReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StaticReviews] DROP CONSTRAINT [FK_UserStaticReview];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Badges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Badges];
GO
IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[Places]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Places];
GO
IF OBJECT_ID(N'[dbo].[StaticReviews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StaticReviews];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
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
IF OBJECT_ID(N'[dbo].[UserBadge]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserBadge];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Badges'
CREATE TABLE [dbo].[Badges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [image] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [text] nvarchar(max)  NOT NULL,
    [User_Id] int  NULL,
    [Place_Id] int  NOT NULL
);
GO

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

-- Creating table 'Reviews'
CREATE TABLE [dbo].[Reviews] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [review] nvarchar(max)  NOT NULL,
    [rating] smallint  NOT NULL,
    [Place_Id] int  NOT NULL,
    [User_Id] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NULL
);
GO

-- Creating table 'Visits'
CREATE TABLE [dbo].[Visits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'VisitPlace'
CREATE TABLE [dbo].[VisitPlace] (
    [Places_Id] int  NOT NULL,
    [Visits_Id] int  NOT NULL
);
GO

-- Creating table 'VisitUser'
CREATE TABLE [dbo].[VisitUser] (
    [Users_Id] int  NOT NULL,
    [Visits_Id] int  NOT NULL
);
GO

-- Creating table 'UserBadge'
CREATE TABLE [dbo].[UserBadge] (
    [User_Id] int  NOT NULL,
    [Badges_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Badges'
ALTER TABLE [dbo].[Badges]
ADD CONSTRAINT [PK_Badges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Places'
ALTER TABLE [dbo].[Places]
ADD CONSTRAINT [PK_Places]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [PK_Reviews]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [PK_Visits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Places_Id], [Visits_Id] in table 'VisitPlace'
ALTER TABLE [dbo].[VisitPlace]
ADD CONSTRAINT [PK_VisitPlace]
    PRIMARY KEY CLUSTERED ([Places_Id], [Visits_Id] ASC);
GO

-- Creating primary key on [Users_Id], [Visits_Id] in table 'VisitUser'
ALTER TABLE [dbo].[VisitUser]
ADD CONSTRAINT [PK_VisitUser]
    PRIMARY KEY CLUSTERED ([Users_Id], [Visits_Id] ASC);
GO

-- Creating primary key on [User_Id], [Badges_Id] in table 'UserBadge'
ALTER TABLE [dbo].[UserBadge]
ADD CONSTRAINT [PK_UserBadge]
    PRIMARY KEY CLUSTERED ([User_Id], [Badges_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Places_Id] in table 'VisitPlace'
ALTER TABLE [dbo].[VisitPlace]
ADD CONSTRAINT [FK_VisitPlace_Places]
    FOREIGN KEY ([Places_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Visits_Id] in table 'VisitPlace'
ALTER TABLE [dbo].[VisitPlace]
ADD CONSTRAINT [FK_VisitPlace_Visits]
    FOREIGN KEY ([Visits_Id])
    REFERENCES [dbo].[Visits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitPlace_Visits'
CREATE INDEX [IX_FK_VisitPlace_Visits]
ON [dbo].[VisitPlace]
    ([Visits_Id]);
GO

-- Creating foreign key on [Users_Id] in table 'VisitUser'
ALTER TABLE [dbo].[VisitUser]
ADD CONSTRAINT [FK_VisitUser_Users]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Visits_Id] in table 'VisitUser'
ALTER TABLE [dbo].[VisitUser]
ADD CONSTRAINT [FK_VisitUser_Visits]
    FOREIGN KEY ([Visits_Id])
    REFERENCES [dbo].[Visits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitUser_Visits'
CREATE INDEX [IX_FK_VisitUser_Visits]
ON [dbo].[VisitUser]
    ([Visits_Id]);
GO

-- Creating foreign key on [User_Id] in table 'UserBadge'
ALTER TABLE [dbo].[UserBadge]
ADD CONSTRAINT [FK_UserBadge_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Badges_Id] in table 'UserBadge'
ALTER TABLE [dbo].[UserBadge]
ADD CONSTRAINT [FK_UserBadge_Badge]
    FOREIGN KEY ([Badges_Id])
    REFERENCES [dbo].[Badges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBadge_Badge'
CREATE INDEX [IX_FK_UserBadge_Badge]
ON [dbo].[UserBadge]
    ([Badges_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_UserComment]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserComment'
CREATE INDEX [IX_FK_UserComment]
ON [dbo].[Comments]
    ([User_Id]);
GO

-- Creating foreign key on [Place_Id] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [FK_PlaceStaticReview]
    FOREIGN KEY ([Place_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaceStaticReview'
CREATE INDEX [IX_FK_PlaceStaticReview]
ON [dbo].[Reviews]
    ([Place_Id]);
GO

-- Creating foreign key on [Place_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_PlaceComment]
    FOREIGN KEY ([Place_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaceComment'
CREATE INDEX [IX_FK_PlaceComment]
ON [dbo].[Comments]
    ([Place_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [FK_UserStaticReview]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserStaticReview'
CREATE INDEX [IX_FK_UserStaticReview]
ON [dbo].[Reviews]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------