
CREATE PROCEDURE Get_Staffs 

AS
BEGIN
	SELECT [Staff_Id],[First_Name],[Last_Name],[Bod],[Education],[Religion]
	FROM [StaffManagement].[dbo].[Staffs]
	
END
