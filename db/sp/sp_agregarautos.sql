-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [sp_agregarautos](
	@Marca VARCHAR(50) = NULL,
	@Modelo VARCHAR(50) = NULL,
	@Color VARCHAR(50) = NULL,
	@TipoTransmision INT = NULL,
	@Descripcion TEXT = NULL
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @IdAuto INT;

	-- Quitamos los espacios
	SELECT @Marca = [dbo].[cleanTrim](@Marca);
	SELECT @Modelo = [dbo].[cleanTrim](@Modelo);
	SELECT @Color = [dbo].[cleanTrim](@color);
	SELECT @Descripcion = [dbo].[cleanTrim](@Descripcion);

    -- Validaciones
	

	-- Insertamos

	INSERT INTO autos(
		marca,
		modelo,
		color,
		tipo_transmicion,
		descripcion
	) VALUES (
		@Marca,
		@Modelo,
		@Color,
		@TipoTransmision,
		@Descripcion
	)

	SELECT @IdAuto = @@IDENTITY -- Obtenemos el ID del registro insertado

END
GO
