
CREATE PROCEDURE Get_Staffs 

AS
BEGIN

	SELECT [Staff_Id] 'id',[First_Name] 'firstname',[Last_Name] 'lastname',[Bod] 'bod',[Education] 'education ', [Origin] 'soo',[Religion] 'religion'
	FROM [StaffManagement].[dbo].[Staffs]
	
END
