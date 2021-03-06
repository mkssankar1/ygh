USE [v1_groups]
GO
/****** Object:  StoredProcedure [dbo].[spUserLogin]    Script Date: 01/04/2018 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
--- 
  
HISTORY:  
31-12-2017 Siva  Created   
*********************************************************/  
  
ALTER PROCEDURE [dbo].[spUserLogin]  
 @UserName       VARCHAR(50)  = NULL, 
 @Password       VARCHAR(50)  = NULL  
  
AS  
BEGIN   
  
SET NOCOUNT ON;  
If exists(select 1 from tblCustomer where UserName = @UserName and Password =@Password and Status=1 and Lock is null and FirstLogin=0)
	BEGIN
	    SELECT 1 as LOGINSTATUS
	    select * from tblCustomer where UserName = @UserName and Password =@Password;
		UPDATE tblCustomer SET LastLogin=GETUTCDATE() where UserName = @UserName and Password =@Password
		
	End
	ELSE If exists(select 1 from tblCustomer where UserName = @UserName and Password =@Password and FirstLogin=1)
	BEGIN
		SELECT 9 as LOGINSTATUS
	END
	ELSE If exists(select 1 from tblCustomer where UserName = @UserName and Password =@Password and Lock is not null)
	BEGIN
		SELECT 8 as LOGINSTATUS 
	END
	ELSE If exists(select status as LOGINSTATUS from tblCustomer where UserName = @UserName and Password =@Password)
	BEGIN
		select status as LOGINSTATUS from tblCustomer where UserName = @UserName and Password =@Password
	End
	ELSE
	BEGIN
		SELECT -1 as LOGINSTATUS 
	End
   
END
