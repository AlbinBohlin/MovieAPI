IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    CREATE TABLE [Actor] (
        [Id] int NOT NULL IDENTITY,
        [BirthYear] int NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Actor] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    CREATE TABLE [Movies] (
        [Id] int NOT NULL IDENTITY,
        [Year] int NOT NULL,
        [Title] nvarchar(max) NOT NULL,
        [Genre] nvarchar(max) NOT NULL,
        [Duration] time NOT NULL,
        CONSTRAINT [PK_Movies] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    CREATE TABLE [ActorMovies] (
        [ActorsId] int NOT NULL,
        [MoviesId] int NOT NULL,
        CONSTRAINT [PK_ActorMovies] PRIMARY KEY ([ActorsId], [MoviesId]),
        CONSTRAINT [FK_ActorMovies_Actor_ActorsId] FOREIGN KEY ([ActorsId]) REFERENCES [Actor] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_ActorMovies_Movies_MoviesId] FOREIGN KEY ([MoviesId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    CREATE TABLE [Review] (
        [Id] int NOT NULL IDENTITY,
        [ReviewerName] nvarchar(max) NOT NULL,
        [Rating] int NOT NULL,
        [Comment] nvarchar(max) NOT NULL,
        [MoviesId] int NOT NULL,
        CONSTRAINT [PK_Review] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Review_Movies_MoviesId] FOREIGN KEY ([MoviesId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    CREATE INDEX [IX_ActorMovies_MoviesId] ON [ActorMovies] ([MoviesId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    CREATE INDEX [IX_Review_MoviesId] ON [Review] ([MoviesId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250711163354_init'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250711163354_init', N'9.0.7');
END;

COMMIT;
GO