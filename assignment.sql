CREATE TABLE Assignment (
	Id int IDENTITY(1, 1) PRIMARY KEY,
	Title nvarchar(50),
	Description nvarchar(250),
	Status nvarchar(20),
	CreatedOn datetime,
	CreatedBy  nvarchar(50),
	ModifiedOn datetime,
	ModifiedBy bit,
);

INSERT INTO Assignment (Title, Description, Status, CreatedOn, CreatedBy, ModifiedOn, ModifiedBy)
VALUES ('AA', 'asdfghjk', 'pending', '2024-01-10', 'Nak', '2024-01-10', 1);

SELECT * FROM Assignment;