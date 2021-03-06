USE [v1_groups]
GO
/****** Object:  StoredProcedure [dbo].[spGroupCheck]    Script Date: 01/03/2018 09:00:39 ******/
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
  
create PROCEDURE [dbo].[spGroupGetList]  
 @CustomerID          int = NULL 
AS  
BEGIN   
  
SET NOCOUNT ON;  
 select  GD.GroupID,GD.GroupName,GD.GroupShotName,GD.Descs,GD.CreatedDate, GD.CreatedBy
 ,GM.STATUS,GM.ADMIN 
 from  tblGroupDetails as GD 
 inner join tblGroupMember AS GM on 
 GD.GroupID = GM.GroupID WHERE GM.CustomerID = @CustomerID  AND
 GD.Status =1 AND GM.STATUS<>7
END
