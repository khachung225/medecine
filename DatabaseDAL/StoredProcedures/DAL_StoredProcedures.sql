SET NOCOUNT ON
GO
USE [medecine]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_Insert]
GO
CREATE PROCEDURE [dbo].[Unit_Insert]
	@UnitId bigint ,
	@UnitShortName nvarchar(100) = null ,
	@UnitName nvarchar(500) = null ,
	@ActorChanged bigint ,
	@TimeChanged datetime 

AS

INSERT [dbo].[Unit]
(
	[UnitId],
	[UnitShortName],
	[UnitName],
	[ActorChanged],
	[TimeChanged]

)
VALUES
(
	@UnitId,
	@UnitShortName,
	@UnitName,
	@ActorChanged,
	@TimeChanged

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_Update]
GO
CREATE PROCEDURE [dbo].[Unit_Update]
	@UnitId bigint,
	@UnitShortName nvarchar(100) = null,
	@UnitName nvarchar(500) = null,
	@ActorChanged bigint,
	@TimeChanged datetime

AS

UPDATE [dbo].[Unit]
SET
	[UnitId] = @UnitId,
	[UnitShortName] = @UnitShortName,
	[UnitName] = @UnitName,
	[ActorChanged] = @ActorChanged,
	[TimeChanged] = @TimeChanged
 WHERE 
	[UnitId] = @UnitId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[Unit_SelectByPrimaryKey]
	@UnitId bigint
AS

	SELECT 
		[UnitId], [UnitShortName], [UnitName], [ActorChanged], [TimeChanged]
	FROM [dbo].[Unit]
	WHERE 
			[UnitId] = @UnitId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_SelectAll]
GO
CREATE PROCEDURE [dbo].[Unit_SelectAll]
AS

	SELECT 
		[UnitId], [UnitShortName], [UnitName], [ActorChanged], [TimeChanged]
	FROM [dbo].[Unit]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_SelectByField]
GO
CREATE PROCEDURE [dbo].[Unit_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [UnitId], [UnitShortName], [UnitName], [ActorChanged], [TimeChanged] FROM [dbo].[Unit] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[Unit_DeleteByPrimaryKey]
	@UnitId bigint
AS

DELETE FROM [dbo].[Unit]
 WHERE 
	[UnitId] = @UnitId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Unit_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Unit_DeleteByField]
GO
CREATE PROCEDURE [dbo].[Unit_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Unit] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_Insert]
GO
CREATE PROCEDURE [dbo].[Medecine_Insert]
	@MedecineId bigint ,
	@Medecine_ShorName nvarchar(100) = null ,
	@Medecine_Name nvarchar(500) = null ,
	@Contain nvarchar(500) = null ,
	@Used nvarchar(500) = null ,
	@Dosage_Children nvarchar(500) = null ,
	@Dosage_Adult nchar(10) = null ,
	@IsBaby bit = null ,
	@Present_Id bigint = null ,
	@ActorChanged bigint = null ,
	@TimeChanged datetime = null 

AS

INSERT [dbo].[Medecine]
(
	[MedecineId],
	[Medecine_ShorName],
	[Medecine_Name],
	[Contain],
	[Used],
	[Dosage_Children],
	[Dosage_Adult],
	[IsBaby],
	[Present_Id],
	[ActorChanged],
	[TimeChanged]

)
VALUES
(
	@MedecineId,
	@Medecine_ShorName,
	@Medecine_Name,
	@Contain,
	@Used,
	@Dosage_Children,
	@Dosage_Adult,
	@IsBaby,
	@Present_Id,
	@ActorChanged,
	@TimeChanged

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_Update]
GO
CREATE PROCEDURE [dbo].[Medecine_Update]
	@MedecineId bigint,
	@Medecine_ShorName nvarchar(100) = null,
	@Medecine_Name nvarchar(500) = null,
	@Contain nvarchar(500) = null,
	@Used nvarchar(500) = null,
	@Dosage_Children nvarchar(500) = null,
	@Dosage_Adult nchar(10) = null,
	@IsBaby bit = null,
	@Present_Id bigint = null,
	@ActorChanged bigint = null,
	@TimeChanged datetime = null

AS

UPDATE [dbo].[Medecine]
SET
	[MedecineId] = @MedecineId,
	[Medecine_ShorName] = @Medecine_ShorName,
	[Medecine_Name] = @Medecine_Name,
	[Contain] = @Contain,
	[Used] = @Used,
	[Dosage_Children] = @Dosage_Children,
	[Dosage_Adult] = @Dosage_Adult,
	[IsBaby] = @IsBaby,
	[Present_Id] = @Present_Id,
	[ActorChanged] = @ActorChanged,
	[TimeChanged] = @TimeChanged
 WHERE 
	[MedecineId] = @MedecineId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[Medecine_SelectByPrimaryKey]
	@MedecineId bigint
AS

	SELECT 
		[MedecineId], [Medecine_ShorName], [Medecine_Name], [Contain], [Used], [Dosage_Children], [Dosage_Adult], [IsBaby], [Present_Id], [ActorChanged], [TimeChanged]
	FROM [dbo].[Medecine]
	WHERE 
			[MedecineId] = @MedecineId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_SelectAll]
GO
CREATE PROCEDURE [dbo].[Medecine_SelectAll]
AS

	SELECT 
		[MedecineId], [Medecine_ShorName], [Medecine_Name], [Contain], [Used], [Dosage_Children], [Dosage_Adult], [IsBaby], [Present_Id], [ActorChanged], [TimeChanged]
	FROM [dbo].[Medecine]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_SelectByField]
GO
CREATE PROCEDURE [dbo].[Medecine_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [MedecineId], [Medecine_ShorName], [Medecine_Name], [Contain], [Used], [Dosage_Children], [Dosage_Adult], [IsBaby], [Present_Id], [ActorChanged], [TimeChanged] FROM [dbo].[Medecine] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[Medecine_DeleteByPrimaryKey]
	@MedecineId bigint
AS

DELETE FROM [dbo].[Medecine]
 WHERE 
	[MedecineId] = @MedecineId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Medecine_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Medecine_DeleteByField]
GO
CREATE PROCEDURE [dbo].[Medecine_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Medecine] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_Insert]
GO
CREATE PROCEDURE [dbo].[Presentation_Insert]
	@PresentId bigint ,
	@UnitL1 bigint = null ,
	@UnitL2 bigint = null ,
	@UnitL3 bigint = null ,
	@UnitL4 nchar(10) = null ,
	@ActorChanged bigint = null ,
	@TimeChanged datetime = null 

AS

INSERT [dbo].[Presentation]
(
	[PresentId],
	[UnitL1],
	[UnitL2],
	[UnitL3],
	[UnitL4],
	[ActorChanged],
	[TimeChanged]

)
VALUES
(
	@PresentId,
	@UnitL1,
	@UnitL2,
	@UnitL3,
	@UnitL4,
	@ActorChanged,
	@TimeChanged

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_Update]
GO
CREATE PROCEDURE [dbo].[Presentation_Update]
	@PresentId bigint,
	@UnitL1 bigint = null,
	@UnitL2 bigint = null,
	@UnitL3 bigint = null,
	@UnitL4 nchar(10) = null,
	@ActorChanged bigint = null,
	@TimeChanged datetime = null

AS

UPDATE [dbo].[Presentation]
SET
	[PresentId] = @PresentId,
	[UnitL1] = @UnitL1,
	[UnitL2] = @UnitL2,
	[UnitL3] = @UnitL3,
	[UnitL4] = @UnitL4,
	[ActorChanged] = @ActorChanged,
	[TimeChanged] = @TimeChanged
 WHERE 
	[PresentId] = @PresentId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[Presentation_SelectByPrimaryKey]
	@PresentId bigint
AS

	SELECT 
		[PresentId], [UnitL1], [UnitL2], [UnitL3], [UnitL4], [ActorChanged], [TimeChanged]
	FROM [dbo].[Presentation]
	WHERE 
			[PresentId] = @PresentId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_SelectAll]
GO
CREATE PROCEDURE [dbo].[Presentation_SelectAll]
AS

	SELECT 
		[PresentId], [UnitL1], [UnitL2], [UnitL3], [UnitL4], [ActorChanged], [TimeChanged]
	FROM [dbo].[Presentation]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_SelectByField]
GO
CREATE PROCEDURE [dbo].[Presentation_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [PresentId], [UnitL1], [UnitL2], [UnitL3], [UnitL4], [ActorChanged], [TimeChanged] FROM [dbo].[Presentation] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[Presentation_DeleteByPrimaryKey]
	@PresentId bigint
AS

DELETE FROM [dbo].[Presentation]
 WHERE 
	[PresentId] = @PresentId

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Presentation_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[Presentation_DeleteByField]
GO
CREATE PROCEDURE [dbo].[Presentation_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Presentation] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO
