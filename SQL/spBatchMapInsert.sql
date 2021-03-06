USE [v1_groups]
GO
/****** Object:  StoredProcedure [dbo].[spUserInsert]    Script Date: 01/06/2018 07:16:36 ******/
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
Create PROCEDURE [dbo].[spBatchMapInsert]  
 @BatchId           INT = NULL,  
 @CustomerId        INT = NULL,  
 @PaymentId         INT = NULL,  
 @DawnDate          INT = NULL,  
 @CreatedBy			INT = NULL,
 @RETURN_VALUE         INT  OUTPUT    
  
AS  
BEGIN   
  
SET NOCOUNT ON;  
 /*********************************  
 Step 1:   Insert new menber with registration details  
 ********************************/  
 INSERT INTO [dbo].[tblBatchMapping] (  
  [BatchId],  
  [CustomerId],  
  [PaymentId],  
  [DawnDate],  
  [CreatedBy],
  [CreatedDate] 
  ) VALUES ( 
  @BatchId,  
  @CustomerId,  
  @PaymentId,  
  @DawnDate,  
  @CreatedBy,
  GETUTCDATE())  
    
 /*********************************  
 Step 2:   Get new ID from tblCust table  
 ********************************/  
 SELECT @RETURN_VALUE =@@IDENTITY   
   
END
