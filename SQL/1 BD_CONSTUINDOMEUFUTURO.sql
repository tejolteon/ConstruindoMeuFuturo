CREATE DATABASE CONSTRUINDOMEUFUTURO;
GO
USE CONSTRUINDOMEUFUTURO;
GO

CREATE TABLE TB_PROGRAMA (
  Id_Programa INTEGER  NOT NULL   IDENTITY ,
  Nome_Programa VARCHAR(50)  NOT NULL  ,
  Descricao_Programa TEXT      ,
PRIMARY KEY(Id_Programa));
GO




CREATE TABLE TB_ESTADO (
  Id_Estado INTEGER  NOT NULL   IDENTITY ,
  Nome_Estado VARCHAR(30)  NOT NULL  ,
  Sigla_Estado CHAR(2)  NOT NULL    ,
PRIMARY KEY(Id_Estado));
GO




CREATE TABLE TB_QUESTAO (
  Id_Questao INTEGER  NOT NULL   IDENTITY ,
  Texto_Questao VARCHAR(255)      ,
PRIMARY KEY(Id_Questao));
GO




CREATE TABLE TB_RESPOSTA (
  Id_Resposta INTEGER  NOT NULL   IDENTITY ,
  Texto_Resposta VARCHAR(255)      ,
PRIMARY KEY(Id_Resposta));
GO




CREATE TABLE TB_CURSO (
  Id_Curso INTEGER  NOT NULL   IDENTITY ,
  Tipo_Curso VARCHAR(15)  NOT NULL  ,
  Nome_Curso VARCHAR(100)  NOT NULL  ,
  Descricao_Curso TEXT      ,
PRIMARY KEY(Id_Curso));
GO




CREATE TABLE TB_USUARIO (
  Id_Usuario INTEGER  NOT NULL   IDENTITY ,
  Nome_Usuario VARCHAR(50)  NOT NULL  ,
  Email_Usuario VARCHAR(150)  NOT NULL  ,
  Senha_Usuario VARCHAR(16)  NOT NULL  ,
  Tipo_Usuario CHAR  NOT NULL  ,
  Status_Usuario CHAR  NOT NULL  ,
  Data_Cadastro_Usuario DATE  NOT NULL    ,
PRIMARY KEY(Id_Usuario));
GO




CREATE TABLE TB_AREA (
  Id_Area INTEGER  NOT NULL   IDENTITY ,
  Nome_Area VARCHAR(50)  NOT NULL    ,
PRIMARY KEY(Id_Area));
GO




CREATE TABLE TB_CIDADE (
  Id_Cidade INTEGER  NOT NULL   IDENTITY ,
  Nome_Cidade VARCHAR(50)  NOT NULL  ,
  Id_Estado INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Cidade)  ,
  FOREIGN KEY(Id_Estado)
    REFERENCES TB_ESTADO(Id_Estado));
GO


CREATE INDEX TB_CIDADE_FKIndex1 ON TB_CIDADE (Id_Estado);
GO


CREATE INDEX IFK_Rel_23 ON TB_CIDADE (Id_Estado);
GO


CREATE TABLE TB_UNIDADE_DE_ENSINO (
  Id_Unidade_de_Ensino INTEGER  NOT NULL   IDENTITY ,
  Nome_Unidade_de_Ensino VARCHAR(100)  NOT NULL  ,
  Site_Unidade_de_Ensino VARCHAR(255)    ,
  Id_Cidade INTEGER  NOT NULL  ,
  Endereco_Unidade_de_Ensino VARCHAR(150)  NOT NULL  ,
  Descricao_Unidade_de_Ensino TEXT      ,
PRIMARY KEY(Id_Unidade_de_Ensino)  ,
  FOREIGN KEY(Id_Cidade)
    REFERENCES TB_CIDADE(Id_Cidade));
GO


CREATE INDEX TB_UNIDADE_DE_ENSINO_FKIndex1 ON TB_UNIDADE_DE_ENSINO (Id_Cidade);
GO


CREATE INDEX IFK_Rel_20 ON TB_UNIDADE_DE_ENSINO (Id_Cidade);
GO


CREATE TABLE TB_PERFIL (
  Id_Perfil INTEGER  NOT NULL   IDENTITY ,
  Id_Usuario INTEGER  NOT NULL  ,
  Data_Nascimento_Perfil DATE    ,
  Escolaridade_Perfil VARCHAR(50)      ,
PRIMARY KEY(Id_Perfil)  ,
  FOREIGN KEY(Id_Usuario)
    REFERENCES TB_USUARIO(Id_Usuario));
GO


CREATE INDEX TB_PERFIL_FKIndex1 ON TB_PERFIL (Id_Usuario);
GO


CREATE INDEX IFK_Rel_08 ON TB_PERFIL (Id_Usuario);
GO


CREATE TABLE TB_UNIDADE_DE_ENSINO_has_TB_CURSO (
  Id_Unidade_de_Ensino INTEGER  NOT NULL  ,
  Id_Curso INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Unidade_de_Ensino, Id_Curso)    ,
  FOREIGN KEY(Id_Unidade_de_Ensino)
    REFERENCES TB_UNIDADE_DE_ENSINO(Id_Unidade_de_Ensino),
  FOREIGN KEY(Id_Curso)
    REFERENCES TB_CURSO(Id_Curso));
GO


CREATE INDEX TB_UNIDADE_DE_ENSINO_has_TB_CURSO_FKIndex1 ON TB_UNIDADE_DE_ENSINO_has_TB_CURSO (Id_Unidade_de_Ensino);
GO
CREATE INDEX TB_UNIDADE_DE_ENSINO_has_TB_CURSO_FKIndex2 ON TB_UNIDADE_DE_ENSINO_has_TB_CURSO (Id_Curso);
GO


CREATE INDEX IFK_Rel_21 ON TB_UNIDADE_DE_ENSINO_has_TB_CURSO (Id_Unidade_de_Ensino);
GO
CREATE INDEX IFK_Rel_22 ON TB_UNIDADE_DE_ENSINO_has_TB_CURSO (Id_Curso);
GO


CREATE TABLE TB_QUESTIONARIO (
  Id_Questao INTEGER  NOT NULL  ,
  Id_Resposta INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Questao, Id_Resposta)    ,
  FOREIGN KEY(Id_Questao)
    REFERENCES TB_QUESTAO(Id_Questao),
  FOREIGN KEY(Id_Resposta)
    REFERENCES TB_RESPOSTA(Id_Resposta));
GO


CREATE INDEX TB_QUESTIONARIO_FKIndex1 ON TB_QUESTIONARIO (Id_Questao);
GO
CREATE INDEX TB_QUESTIONARIO_FKIndex2 ON TB_QUESTIONARIO (Id_Resposta);
GO


CREATE INDEX IFK_Rel_49 ON TB_QUESTIONARIO (Id_Questao);
GO
CREATE INDEX IFK_Rel_50 ON TB_QUESTIONARIO (Id_Resposta);
GO


CREATE TABLE TB_CURSO_INDICADO (
  Id_Curso INTEGER  NOT NULL  ,
  Id_Perfil INTEGER  NOT NULL  ,
  Status_Curso_Indicado CHAR      ,
  Pontuacao_Teste_Curso_Indicado INTEGER,
PRIMARY KEY(Id_Curso, Id_Perfil)    ,
  FOREIGN KEY(Id_Curso)
    REFERENCES TB_CURSO(Id_Curso),
  FOREIGN KEY(Id_Perfil)
    REFERENCES TB_PERFIL(Id_Perfil));
GO


CREATE INDEX TB_CURSO_INDICADO_FKIndex1 ON TB_CURSO_INDICADO (Id_Curso);
GO
CREATE INDEX TB_CURSO_INDICADO_FKIndex2 ON TB_CURSO_INDICADO (Id_Perfil);
GO


CREATE INDEX IFK_Rel_36 ON TB_CURSO_INDICADO (Id_Curso);
GO
CREATE INDEX IFK_Rel_44 ON TB_CURSO_INDICADO (Id_Perfil);
GO


CREATE TABLE TB_CURSO_CONCLUIDO (
  Id_Curso_Concluido INTEGER  NOT NULL   IDENTITY ,
  Id_Perfil INTEGER  NOT NULL  ,
  Id_Curso INTEGER  NOT NULL  ,
  Data_Curso_Concluido DATE      ,
PRIMARY KEY(Id_Curso_Concluido, Id_Perfil, Id_Curso)    ,
  FOREIGN KEY(Id_Perfil)
    REFERENCES TB_PERFIL(Id_Perfil),
  FOREIGN KEY(Id_Curso)
    REFERENCES TB_CURSO(Id_Curso));
GO


CREATE INDEX TB_CURSO_CONCLUIDO_FKIndex1 ON TB_CURSO_CONCLUIDO (Id_Perfil);
GO
CREATE INDEX TB_CURSO_CONCLUIDO_FKIndex2 ON TB_CURSO_CONCLUIDO (Id_Curso);
GO


CREATE INDEX IFK_Rel_16 ON TB_CURSO_CONCLUIDO (Id_Perfil);
GO
CREATE INDEX IFK_Rel_17 ON TB_CURSO_CONCLUIDO (Id_Curso);
GO


CREATE TABLE TB_AREA_has_TB_CURSO (
  Id_Area INTEGER  NOT NULL  ,
  Id_Curso INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Area, Id_Curso)    ,
  FOREIGN KEY(Id_Area)
    REFERENCES TB_AREA(Id_Area),
  FOREIGN KEY(Id_Curso)
    REFERENCES TB_CURSO(Id_Curso));
GO


CREATE INDEX TB_AREA_has_TB_CURSO_FKIndex1 ON TB_AREA_has_TB_CURSO (Id_Area);
GO
CREATE INDEX TB_AREA_has_TB_CURSO_FKIndex2 ON TB_AREA_has_TB_CURSO (Id_Curso);
GO


CREATE INDEX IFK_Rel_19 ON TB_AREA_has_TB_CURSO (Id_Area);
GO
CREATE INDEX IFK_Rel_20 ON TB_AREA_has_TB_CURSO (Id_Curso);
GO


CREATE TABLE TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO (
  Id_Programa INTEGER  NOT NULL  ,
  Id_Unidade_de_Ensino INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Programa, Id_Unidade_de_Ensino)    ,
  FOREIGN KEY(Id_Programa)
    REFERENCES TB_PROGRAMA(Id_Programa),
  FOREIGN KEY(Id_Unidade_de_Ensino)
    REFERENCES TB_UNIDADE_DE_ENSINO(Id_Unidade_de_Ensino));
GO


CREATE INDEX TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO_FKIndex1 ON TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO (Id_Programa);
GO
CREATE INDEX TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO_FKIndex2 ON TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO (Id_Unidade_de_Ensino);
GO


CREATE INDEX IFK_Rel_20 ON TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO (Id_Programa);
GO
CREATE INDEX IFK_Rel_21 ON TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO (Id_Unidade_de_Ensino);
GO


CREATE TABLE TB_PERFIL_has_TB_QUESTIONARIO (
  Id_Perfil INTEGER  NOT NULL  ,
  Id_Questao INTEGER  NOT NULL  ,
  Id_Resposta INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Perfil, Id_Questao,Id_Resposta)  ,
  FOREIGN KEY(Id_Perfil)
    REFERENCES TB_PERFIL(Id_Perfil),
  FOREIGN KEY(Id_Questao, Id_Resposta)
    REFERENCES TB_QUESTIONARIO(Id_Questao, Id_Resposta));
GO


CREATE INDEX Table_18_FKIndex1 ON TB_PERFIL_has_TB_QUESTIONARIO (Id_Perfil);
GO


CREATE INDEX IFK_Rel_27 ON TB_PERFIL_has_TB_QUESTIONARIO (Id_Perfil);
GO
CREATE INDEX IFK_Rel_34 ON TB_PERFIL_has_TB_QUESTIONARIO (Id_Questao, Id_Resposta);
GO


CREATE TABLE TB_PERFIL_has_TB_CIDADE (
  Id_Perfil INTEGER  NOT NULL  ,
  Id_Cidade INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Perfil, Id_Cidade)    ,
  FOREIGN KEY(Id_Perfil)
    REFERENCES TB_PERFIL(Id_Perfil),
  FOREIGN KEY(Id_Cidade)
    REFERENCES TB_CIDADE(Id_Cidade));
GO


CREATE INDEX TB_PERFIL_has_TB_CIDADE_FKIndex1 ON TB_PERFIL_has_TB_CIDADE (Id_Perfil);
GO
CREATE INDEX TB_PERFIL_has_TB_CIDADE_FKIndex2 ON TB_PERFIL_has_TB_CIDADE (Id_Cidade);
GO


CREATE INDEX IFK_Rel_04 ON TB_PERFIL_has_TB_CIDADE (Id_Perfil);
GO
CREATE INDEX IFK_Rel_05 ON TB_PERFIL_has_TB_CIDADE (Id_Cidade);
GO


CREATE TABLE TB_QUESTIONARIO_has_TB_CURSO (
  Id_Curso INTEGER  NOT NULL  ,
  Id_Questao INTEGER  NOT NULL  ,
  Id_Resposta INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Curso, Id_Questao,Id_Resposta)  ,
  FOREIGN KEY(Id_Questao, Id_Resposta)
    REFERENCES TB_QUESTIONARIO(Id_Questao, Id_Resposta),
  FOREIGN KEY(Id_Curso)
    REFERENCES TB_CURSO(Id_Curso));
GO


CREATE INDEX TB_QUESTIONARIO_has_TB_CURSO_FKIndex2 ON TB_QUESTIONARIO_has_TB_CURSO (Id_Curso);
GO


CREATE INDEX IFK_Rel_47 ON TB_QUESTIONARIO_has_TB_CURSO (Id_Questao, Id_Resposta);
GO
CREATE INDEX IFK_Rel_48 ON TB_QUESTIONARIO_has_TB_CURSO (Id_Curso);
GO


CREATE TABLE TB_PERFIL_has_TB_AREA (
  Id_Perfil INTEGER  NOT NULL  ,
  Id_Area INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Perfil, Id_Area)    ,
  FOREIGN KEY(Id_Perfil)
    REFERENCES TB_PERFIL(Id_Perfil),
  FOREIGN KEY(Id_Area)
    REFERENCES TB_AREA(Id_Area));
GO


CREATE INDEX TB_PERFIL_has_TB_AREA_FKIndex1 ON TB_PERFIL_has_TB_AREA (Id_Perfil);
GO
CREATE INDEX TB_PERFIL_has_TB_AREA_FKIndex2 ON TB_PERFIL_has_TB_AREA (Id_Area);
GO


CREATE INDEX IFK_Rel_16 ON TB_PERFIL_has_TB_AREA (Id_Perfil);
GO
CREATE INDEX IFK_Rel_17 ON TB_PERFIL_has_TB_AREA (Id_Area);
GO





-- os tipos sao: A=Administrador | B=Colaborador | C=Consultador--
Insert into TB_USUARIO(Nome_Usuario, Email_Usuario, Senha_Usuario,Tipo_Usuario,Status_Usuario,Data_Cadastro_Usuario) 
VALUES('Tiago', 't@t.com','123','A','A',GETDATE());

GO
