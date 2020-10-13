
CREATE PROCEDURE Insert_Staff 
@First_Name nvarchar(50),
@Last_Name nvarchar(50),
@Bod nvarchar(20),
@Education nvarchar(20),
@Origin nvarchar (20),
@Religion nvarchar (20)
AS
BEGIN
	INSERT INTO Staffs (First_Name, Last_Name, Bod, Education, Origin, Religion)
	Values (@First_Name, @Last_Name, @Bod, @Education, @Origin, @Religion)
END
