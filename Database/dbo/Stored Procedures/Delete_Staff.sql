
CREATE PROCEDURE Delete_Staff 
@Staff_Id Uniqueidentifier

AS
BEGIN
	Delete from Staffs
	Where Staff_Id = @Staff_Id
	
END
