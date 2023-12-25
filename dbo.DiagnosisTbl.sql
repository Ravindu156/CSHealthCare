CREATE TABLE [dbo].[DiagnosisTbl] (
    [Id]       INT          NOT NULL,
    [DiagCode] INT          NULL,
    [DiagDate] DATE         NULL,
    [Patient]  INT          NULL,
    [Test]     INT          NULL,
    [Cost]     INT          NULL,
    [Result]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK1] FOREIGN KEY ([Patient]) REFERENCES [dbo].[PatientTb] ([PatCode]),
    CONSTRAINT [FK2] FOREIGN KEY ([Test]) REFERENCES [dbo].[TestTbl] ([TestCode])
);

