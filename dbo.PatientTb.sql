CREATE TABLE [dbo].[PatientTb] (
    [PatCode]  INT           IDENTITY (1, 1) NOT NULL,
    [PatName]  VARCHAR (50)  NOT NULL,
    [PatGen]   VARCHAR (50)  NOT NULL,
    [PatDOB]   DATE          NOT NULL,
    [PatPhone] VARCHAR (50)  NOT NULL,
    [PatAdd]   VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([PatCode] ASC)
);

