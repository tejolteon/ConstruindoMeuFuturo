CREATE DATABASE construindomeufuturo;

use construindomeufuturo;
GO

CREATE TABLE TB_CURSO (
  Id_Curso INTEGER  NOT NULL  IDENTITY  ,
  Tipo_Curso VARCHAR(10)  NOT NULL  ,
  Nome_Curso VARCHAR(50)  NOT NULL  ,
  Descrição_Curso TEXT,
PRIMARY KEY(Id_Curso));
GO




CREATE TABLE TB_PROGRAMA (
  Id_Programa INTEGER  NOT NULL   IDENTITY ,
  Nome_Programa VARCHAR(50)  NOT NULL  ,
  Descrição_Programa TEXT,
PRIMARY KEY(Id_Programa));
GO




CREATE TABLE TB_ESTADO (
  Id_Estado INTEGER  NOT NULL   IDENTITY ,
  Nome_Estado VARCHAR(30)  NOT NULL  ,
  Sigla_Estado CHAR(2)  NOT NULL    ,
PRIMARY KEY(Id_Estado));
GO




CREATE TABLE TB_AREA (
  Id_Area INTEGER  NOT NULL   IDENTITY ,
  Nome_Area VARCHAR(30)  NOT NULL    ,
PRIMARY KEY(Id_Area));
GO




CREATE TABLE TB_USUARIO (
  Id_Usuario INTEGER  NOT NULL   IDENTITY ,
  Email_Usuario VARCHAR(50)  NOT NULL  ,
  Senha_Usuario VARCHAR(16)  NOT NULL    ,
PRIMARY KEY(Id_Usuario));
GO




CREATE TABLE TB_PERFIL (
  Id_Perfil INTEGER  NOT NULL   IDENTITY ,
  Id_Usuario INTEGER  NOT NULL  ,
  Nome_Perfil VARCHAR(40) NOT NULL,
  Data_Nascimento_Perfil DATE,
  Escolaridade_Perfil VARCHAR(20)      ,
PRIMARY KEY(Id_Perfil)  ,
  FOREIGN KEY(Id_Usuario)
    REFERENCES TB_USUARIO(Id_Usuario));
GO


CREATE INDEX TB_PERFIL_FKIndex1 ON TB_PERFIL (Id_Usuario);
GO


CREATE INDEX IFK_Rel_08 ON TB_PERFIL (Id_Usuario);
GO


CREATE TABLE TB_CIDADE (
  Id_Cidade INTEGER  NOT NULL   IDENTITY ,
  Nome_Cidade VARCHAR(30)  NOT NULL  ,
  Id_Estado INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Cidade)  ,
  FOREIGN KEY(Id_Estado)
    REFERENCES TB_ESTADO(Id_Estado));
GO


CREATE INDEX TB_CIDADE_FKIndex1 ON TB_CIDADE (Id_Estado);
GO


CREATE INDEX IFK_Rel_23 ON TB_CIDADE (Id_Estado);
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


CREATE INDEX IFK_Rel_18 ON TB_PERFIL_has_TB_AREA (Id_Perfil);
GO
CREATE INDEX IFK_Rel_19 ON TB_PERFIL_has_TB_AREA (Id_Area);
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


CREATE TABLE TB_CURSO_has_TB_PROGRAMA (
  Id_Curso INTEGER  NOT NULL  ,
  Id_Programa INTEGER  NOT NULL    ,
PRIMARY KEY(Id_Curso, Id_Programa)    ,
  FOREIGN KEY(Id_Curso)
    REFERENCES TB_CURSO(Id_Curso),
  FOREIGN KEY(Id_Programa)
    REFERENCES TB_PROGRAMA(Id_Programa));
GO


CREATE INDEX TB_CURSO_has_TB_PROGRAMA_FKIndex1 ON TB_CURSO_has_TB_PROGRAMA (Id_Curso);
GO
CREATE INDEX TB_CURSO_has_TB_PROGRAMA_FKIndex2 ON TB_CURSO_has_TB_PROGRAMA (Id_Programa);
GO


CREATE INDEX IFK_Rel_11 ON TB_CURSO_has_TB_PROGRAMA (Id_Curso);
GO
CREATE INDEX IFK_Rel_12 ON TB_CURSO_has_TB_PROGRAMA (Id_Programa);
GO


CREATE TABLE TB_UNIDADE_DE_ENSINO (
  Id_Unidade_de_Ensino INTEGER  NOT NULL   IDENTITY ,
  Nome_Unidade_de_Ensino VARCHAR(50)  NOT NULL  ,
  Site_Unidade_de_Ensino VARCHAR(100)    ,
  Id_Cidade INTEGER  NOT NULL  ,
  Endereco_Unidade_de_Ensino VARCHAR(150)    ,
  Descrição_Unidade_de_Ensino TEXT      ,
PRIMARY KEY(Id_Unidade_de_Ensino)  ,
  FOREIGN KEY(Id_Cidade)
    REFERENCES TB_CIDADE(Id_Cidade));
GO


CREATE INDEX TB_UNIDADE_DE_ENSINO_FKIndex1 ON TB_UNIDADE_DE_ENSINO (Id_Cidade);
GO


CREATE INDEX IFK_Rel_20 ON TB_UNIDADE_DE_ENSINO (Id_Cidade);
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


Insert into TB_USUARIO(Email_Usuario,Senha_Usuario) VALUES('g@g.com','123456');
GO
select * from TB_USUARIO;