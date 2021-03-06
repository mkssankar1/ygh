USE [v1_groups]
GO
/****** Object:  StoredProcedure [dbo].[spGroupInsert]    Script Date: 01/03/2018 09:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
This procedure creates the user Registration with only basic details  
  
HISTORY:  
02-01-2018 Siva  Created   
*********************************************************/  
  
ALTER PROCEDURE [dbo].[spGroupInsert]  
 @GroupName          VARCHAR(100) = NULL,  
 @GroupShotName          VARCHAR(100) = NULL,  
 @Desc                  VARCHAR(500)    = NULL,  
 @CreatedBy          INT    = NULL,  
 @RETURN_VALUE         INT  OUTPUT    
AS  
BEGIN   
  
SET NOCOUNT ON;  
 /*********************************  
 Step 1:   Insert new group with registration details  
 ********************************/  
 INSERT INTO [dbo].[tblGroupDetails] (  
  [GroupName],  
  [GroupShotName],  
  [Descs],  
  [CreatedDate],  
  [CreatedBy]  
  ) VALUES (  
  @GroupName,  
  @GroupShotName,  
  @Desc,  
  GETUTCDATE(),  
  @CreatedBy)  
    
 /*********************************  
 Step 2:   Get new ID from  table  
 ********************************/  
 Set @RETURN_VALUE =@@IDENTITY   
 
 Insert into [dbo].[tblGroupMember](GroupID,CustomerID,CreatedDate,CreatedBy,Admin) 
							 values(@RETURN_VALUE,@CreatedBy,GETUTCDATE(),@CreatedBy,1)
   select @RETURN_VALUE;
END
