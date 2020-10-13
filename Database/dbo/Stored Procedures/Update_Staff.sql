CREATE PROCEDURE Update_Staff 
@Staff_Id Uniqueidentifier,
@First_Name nvarchar(50),
@Last_Name nvarchar(50),
@Bod nvarchar(20),
@Education nvarchar(20),
@Origin nvarchar (20),
@Religion nvarchar (20)

AS
BEGIN
	Update Staffs
	Set Last_Name = @Last_Name,
	First_Name = @First_Name,
	Bod = @Bod,
	Education = @Education,
	Origin = @Origin,
	Religion = @Religion
	Where Staff_Id = @Staff_Id
END
