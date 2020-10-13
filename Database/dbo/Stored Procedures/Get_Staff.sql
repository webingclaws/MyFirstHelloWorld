CREATE PROCEDURE Get_Staff 
@Staff_Id Uniqueidentifier

AS
BEGIN
	SELECT [Staff_Id],[First_Name],[Last_Name],[Bod],[Education],[Religion]
	FROM [StaffManagement].[dbo].[Staffs]
	WHERE Staff_Id = @Staff_Id
END
