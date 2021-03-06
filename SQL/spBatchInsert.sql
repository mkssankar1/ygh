USE [v1_groups]
GO
/****** Object:  StoredProcedure [dbo].[spBatchInsert]    Script Date: 01/06/2018 09:51:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
This procedure creates the user Registration with only basic details  
  
HISTORY:  
06-01-2018 Siva  Created   
*********************************************************/  
  
ALTER PROCEDURE [dbo].[spBatchInsert]  
 @GroupID           INT = NULL,  
 @BatchName         VARCHAR(100) = NULL,  
 @StartDate         DATE   = NULL,  
 @Bi_MonthDate1     INT = NULL,  
 @Bi_MonthDate2     INT = NULL,  
 @MonthDate         INT = NULL,
 @CreatedBy			INT = NULL,
 @Amount            money = null,
 @UserCount			INT = null,
 @RETURN_VALUE         INT  OUTPUT    
  
AS  
BEGIN   
  
SET NOCOUNT ON;  
 /*********************************  
 Step 1:   Insert new menber with registration details  
 ********************************/  
 INSERT INTO [dbo].[tblGroupBatch] (  
  [GroupID],  
  [BatchName],  
  [StartDate],  
  [Bi_MonthDate1],  
  [Bi_MonthDate2],  
  [MonthDate],  
  [CreatedBy],
  [Amount],
  [UserCount]  
  ) VALUES (  
  @GroupID,  
  @BatchName,  
  @StartDate,  
  @Bi_MonthDate1,  
  @Bi_MonthDate2,  
  @MonthDate,  
  @CreatedBy,
  @Amount,
  @UserCount)  
    
 /*********************************  
 Step 2:   Get new ID from tblCust table  
 ********************************/  
 SELECT @RETURN_VALUE =@@IDENTITY   
   
END
