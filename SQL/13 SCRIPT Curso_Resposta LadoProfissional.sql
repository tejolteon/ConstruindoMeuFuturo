CREATE
PROCEDURE pcd_profissional 
@idcurso INT
AS
DECLARE @r INT
DECLARE @q INT
BEGIN
	SET @r = 1
	SET @q = 1

	WHILE(@q<=12)
	BEGIN
			INSERT INTO TB_QUESTIONARIO_has_TB_CURSO(Id_Curso, Id_Questao, Id_Resposta) VALUES(@idcurso, @q, @r);
			SET @q = @q + 1;
		SET @r = @r + 5;
	END
END

GO

CREATE
PROCEDURE pcd_ascensao
@idcurso INT
AS
DECLARE @r INT
DECLARE @q INT
BEGIN
	SET @r = 2
	SET @q = 1

	WHILE(@q<=12)
	BEGIN
			INSERT INTO TB_QUESTIONARIO_has_TB_CURSO(Id_Curso, Id_Questao, Id_Resposta) VALUES(@idcurso, @q, @r);
			SET @q = @q + 1;
		SET @r = @r + 5;
	END
END
GO

CREATE
PROCEDURE pcd_seguranca 
@idcurso INT
AS
DECLARE @r INT
DECLARE @q INT
BEGIN
	SET @r = 3
	SET @q = 1

	WHILE(@q<=12)
	BEGIN
			INSERT INTO TB_QUESTIONARIO_has_TB_CURSO(Id_Curso, Id_Questao, Id_Resposta) VALUES(@idcurso, @q, @r);
			SET @q = @q + 1;
		SET @r = @r + 5;
	END
END

GO

CREATE
PROCEDURE pcd_qualidade
@idcurso INT
AS
DECLARE @r INT
DECLARE @q INT
BEGIN
	SET @r = 4
	SET @q = 1

	WHILE(@q<=12)
	BEGIN
			INSERT INTO TB_QUESTIONARIO_has_TB_CURSO(Id_Curso, Id_Questao, Id_Resposta) VALUES(@idcurso, @q, @r);
			SET @q = @q + 1;
		SET @r = @r + 5;
	END
END

GO

CREATE 
PROCEDURE pcd_solidariedade
@idcurso INT
AS
DECLARE @r INT
DECLARE @q INT
BEGIN
	SET @r = 5
	SET @q = 1

	WHILE(@q<=12)
	BEGIN
			INSERT INTO TB_QUESTIONARIO_has_TB_CURSO(Id_Curso, Id_Questao, Id_Resposta) VALUES(@idcurso, @q, @r);
			SET @q = @q + 1;
		SET @r = @r + 5;
	END
END