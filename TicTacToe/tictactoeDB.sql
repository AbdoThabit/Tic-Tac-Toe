Create Database TicTacToe ;
use TicTacToe;
Create table Player
(
Id int identity primary key,
Name Nvarchar(50),
Score int,
)
ALTER TABLE Player
ADD CONSTRAINT UQ_Player_Name UNIQUE (Name);

Create table Game
(
GID int identity primary key,
P1Id int ,
P2Id int , 
P1Score int,
P2Score int,
GameDate date,
foreign key (P1Id) references Player(Id),
foreign key (P2Id) references Player(Id),
)


CREATE TRIGGER trg_AddPlayerScores
ON Game
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update Player 1 Score
    UPDATE Player
    SET Score = Score + i.P1Score
    FROM Player p
    JOIN inserted i ON p.Id = i.P1Id;

    -- Update Player 2 Score
    UPDATE Player
    SET Score = Score + i.P2Score
    FROM Player p
    JOIN inserted i ON p.Id = i.P2Id;
END;

CREATE TRIGGER trg_UpdatePlayerScores
ON Game
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Update Player 1 Score (subtract past value)
    UPDATE Player
    SET Score = Score - d.P1Score
    FROM Player p
    JOIN deleted d ON p.Id = d.P1Id;

    -- Update Player 2 Score (subtract past value)
    UPDATE Player
    SET Score = Score - d.P2Score
    FROM Player p
    JOIN deleted d ON p.Id = d.P2Id;

    -- Update Player 1 Score (add new value)
    UPDATE Player
    SET Score = Score + i.P1Score
    FROM Player p
    JOIN inserted i ON p.Id = i.P1Id;

    -- Update Player 2 Score (add new value)
    UPDATE Player
    SET Score = Score + i.P2Score
    FROM Player p
    JOIN inserted i ON p.Id = i.P2Id;
END;


CREATE TRIGGER trg_DeletePlayerScores
ON Game
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Update Player 1 Score (subtract past value)
    UPDATE Player
    SET Score = Score - d.P1Score
    FROM Player p
    JOIN deleted d ON p.Id = d.P1Id;

    -- Update Player 2 Score (subtract past value)
    UPDATE Player
    SET Score = Score - d.P2Score
    FROM Player p
    JOIN deleted d ON p.Id = d.P2Id;
END;


